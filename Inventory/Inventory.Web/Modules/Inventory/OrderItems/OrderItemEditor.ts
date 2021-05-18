/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace Inventory.Inventory { 
        @Serenity.Decorators.registerEditor()
        export class OrderItemEditor extends Common.GridEditorBase<OrderItemsRow> {
            
            protected getColumnsKey() { return "Inventory.OrderItems"; }

            protected getDialogType() { return OrderItemEditorDialog; }

            protected getLocalTextPrefix() { return OrderItemsRow.localTextPrefix; }

            constructor(container: JQuery) {
                super(container); 
            }

            protected getAddButtonCaption() {
                return "Add Items to order";
            }

             

            protected validateEntity(row: OrderItemsRow, id: number) {
                if (!super.validateEntity(row, id))
                    return false;

                let date: Date = new Date(); 

                row.OrderDate = date.toLocaleDateString();
                row.SubTotal = row.Qty * row.UnitPrice;
                row.ProductName = ProductRow.getLookup().itemById[row.ProductId].Name; 

                return true;
            }
             

        }

    } 