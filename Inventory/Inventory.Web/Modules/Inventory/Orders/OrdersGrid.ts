
namespace Inventory.Inventory {

    import fld = OrdersRow.Fields;

    @Serenity.Decorators.registerClass()
    export class OrdersGrid extends Serenity.EntityGrid<OrdersRow, any> {
        protected getColumnsKey() { return 'Inventory.Orders'; }
        protected getDialogType() { return <any>OrdersDialog; }
        protected getIdProperty() { return OrdersRow.idProperty; }
        protected getInsertPermission() { return OrdersRow.insertPermission; }
        protected getLocalTextPrefix() { return OrdersRow.localTextPrefix; }
        protected getService() { return OrdersService.baseUrl; }
        public dragValue = "";
        private pendingChanges: Q.Dictionary<any> = {};

        constructor(container: JQuery) {
            super(container);
            this.slickContainer.on('change', '.edit:input', (e) => this.inputsChange(e)); 
            //this.slickContainer.on('dragenter', (e) => this.inputsChange(e)); 

        }

         
        protected getButtons() {
            var buttons = super.getButtons();

            //buttons.push(Common.ExcelExportHelper.createToolButton({
            //    grid: this,
            //    service: ProductService.baseUrl + '/ListExcel',
            //    onViewSubmit: () => this.onViewSubmit(),
            //    separator: true
            //}));

            buttons.push(Common.PdfExportHelper.createToolButton({
                grid: this,
                onViewSubmit: () => this.onViewSubmit(),
                reportTitle: 'Product List',
                columnTitles: {
                    'Discontinued': 'Dis.',
                },
                tableOptions: {
                    columnStyles: {
                        ProductID: {
                            columnWidth: 25,
                            halign: 'right'
                        },
                        Discountinued: {
                            columnWidth: 25
                        }
                    }
                }
            }));

            buttons.push({
                title: 'Save Changes',
                cssClass: 'apply-changes-button disabled',
                onClick: e => this.saveClick(),
                separator: true
            });

            return buttons;
        }

       

        private saveClick() {
            if (Object.keys(this.pendingChanges).length === 0) {
                return;
            }

            // this calls save service for all modified rows, one by one
            // you could write a batch update service
            var keys = Object.keys(this.pendingChanges);
            var current = -1;
            var self = this;

            (function saveNext() {
                if (++current >= keys.length) {
                    self.refresh();
                    return;
                }

                var key = keys[current];
                var entity = Q.deepClone(self.pendingChanges[key]);
                entity.OrderId = key;
                Q.serviceRequest('Inventory/Orders/Update', {
                    EntityId: key,
                    Entity: entity
                }, (response) => {
                    delete self.pendingChanges[key];
                    saveNext();
                });
            })();
        }

        
        protected getColumns() {
            var columns = super.getColumns();
            var num = ctx => this.numericInputFormatter(ctx);
            var str = ctx => this.stringInputFormatter(ctx);


            Q.first(columns, x => x.field === fld.StatusFailedDescription).format = str; 
          /*  Q.first(columns, x => x.field === 'StatusFailedDescription').visible = false;*/

            var status = Q.first(columns, x => x.field === fld.StatusName);
            status.referencedFields = [fld.Status];
            status.format = ctx => this.selectFormatter(ctx, fld.Status, FulfillmentStatusRow.getLookup()); 
  
            return columns;
        }

        private numericInputFormatter(ctx) {
            var klass = 'edit numeric';
            var item = ctx.item as OrdersRow;
            var pending = this.pendingChanges[item.OrderId];

            if (pending && pending[ctx.column.field] !== undefined) {
                klass += ' dirty';
            }

            var value = this.getEffectiveValue(item, ctx.column.field) as number;

            return "<input type='text' class='" + klass +
                "' data-field='" + ctx.column.field +
                "' value='" + Q.formatNumber(value, '0.##') + "'/>";
        }

        private stringInputFormatter(ctx) { 
            var klass = 'edit string ';//drag-fill
            var isDraggable = true;
            var item = ctx.item as OrdersRow;
            var pending = this.pendingChanges[item.OrderId];
            var column = ctx.column as Slick.Column;

            if (pending && pending[column.field] !== undefined) {
                klass += ' dirty';
            }

            var value = this.getEffectiveValue(item, column.field) as string;

            if (column.field == fld.StatusFailedDescription && item.Status != 3) {
                return "<div> </div>";
            }

            return "<input type='text' draggable='" + isDraggable +"'  class='" + klass +
                "' data-field='" + column.field +
                "' value='" + Q.attrEncode(value) +
                "' maxlength='" + column.sourceItem.maxLength + "'/>";
        }
         
        protected viewDataChanged(e: any, rows: OrdersRow[]) {
            super.viewDataChanged(e, rows);
            //Spreadsheet.DragAndDrop(this.inputsChange);

            Spreadsheet.DragAndDrop((e) => {
                this.inputsChange(e);
            })
        }
        
       
        private getEffectiveValue(item, field): any {
            var pending = this.pendingChanges[item.OrderId];
            if (pending && pending[field] !== undefined) {
                return pending[field];
            } 
            return item[field];
        }

        private inputsChange(e: JQueryEventObject) {

            var cell = this.slickGrid.getCellFromEvent(e);
            
            if (cell != undefined) { 
                var item = this.itemAt(cell.row);
                var input = $(e.target);
                var field = input.data('field');
                var text = Q.coalesce(Q.trimToNull(input.val()), '0');
                var pending = this.pendingChanges[item.OrderId];

                var effective = this.getEffectiveValue(item, field);
                var oldText: string;
                if (input.hasClass("numeric"))
                    oldText = Q.formatNumber(effective, '0.##');
                else
                    oldText = effective as string;

                var value;
                if (input.hasClass("numeric")) {
                    var i = Q.parseInteger(text);
                    if (isNaN(i) || i > 32767 || i < 0) {
                        Q.notifyError(Q.text('Validation.Integer'), '', null);
                        input.val(oldText);
                        input.focus();
                        return;
                    }
                    value = i;
                }
                else {
                    if (text == "0")
                        return;
                    value = text;
                }
                    
                if (!pending) {
                    this.pendingChanges[item.OrderId] = pending = {};
                }

                pending[field] = value;
                item[field] = value;
                this.view.refresh();

                if (input.hasClass("numeric"))
                    value = Q.formatNumber(value, '0.##');

                input.val(value).addClass('dirty');

                //this.view.refresh();
                //if (value == 3) {
                //    this.stringInputFormatter(str);
                //}
                //this.setSaveButtonState(); 
                if (field != undefined)
                    this.saveClick();
                console.log("Saved");
            }
        }
         
        private setSaveButtonState() {
            this.toolbar.findButton('apply-changes-button').toggleClass('disabled',
                Object.keys(this.pendingChanges).length === 0);
        }

        private selectFormatter(ctx: Slick.FormatterContext, idField: string, lookup: Q.Lookup<any>) {

            var isDraggable = true;
            var klass = 'edit drag-fill';
            var item = ctx.item as OrdersRow;
            var pending = this.pendingChanges[item.OrderId];
            var column = ctx.column as Slick.Column;

            if (pending && pending[idField] !== undefined) {
                klass += ' dirty';
            }

            var value = this.getEffectiveValue(item, idField);
            var markup = "<select draggable='" + isDraggable +"' class='" + klass +
                "' data-field='" + idField +
                
                "' style='width: 100%; max-width: 100%'>";
            for (var c of lookup.items) {
                let id = c[lookup.idField];
                markup += "<option value='" + Q.attrEncode(id) + "'"
                if (id == value) {
                    markup += " selected";
                }
                markup += ">" + Q.htmlEncode(c[lookup.textField]) + "</option>";
            }
            return markup + "</select>";
        } 
    }
}