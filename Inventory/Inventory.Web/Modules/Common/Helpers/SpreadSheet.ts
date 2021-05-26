namespace Inventory {

    export class Spreadsheet {

        static dragValue : string;
        static DragAndDrop(inputChange: Function) {
            var containers = document.querySelectorAll('.slick-cell input, .slick-cell select');

            containers.forEach(x => {
                $(x).draggable();
                $(x).css('cursor', 'cell');
                $(x).css('background', 'transparent');
                x.addEventListener('dragstart', (e) => {
                    Spreadsheet.dragValue = (<HTMLInputElement>e.target).value;
                    const cell = $(e.target).parent('.slick-cell');
                    if (cell[0] && !$(cell[0]).hasClass('highlight')) {
                        $(cell[0]).addClass(' hold')
                    }
                });
                x.addEventListener('dragenter', (e: JQueryEventObject) => {
                    const value = (<HTMLInputElement>e.target).value;

                    if (value == this.dragValue) {
                        return;
                    }
                    if ($(e.target).is("select") && !parseInt(value)) {
                        return;
                    }

                    const cell = $(e.target).parent('.slick-cell');
                    if (cell[0] && !$(cell[0]).hasClass('highlight')) {
                        $(cell[0]).addClass(' hovered highlight')
                    }

                    (<HTMLInputElement>e.target).value = this.dragValue;
                    inputChange(e);

                });
                x.addEventListener('dragover', function (e: JQueryEventObject) {
                    e.preventDefault();

                    const cell = $(e.target).parent('.slick-cell');
                    if (cell[0] && !$(cell[0]).hasClass('highlight')) {
                        $(cell[0]).addClass(' highlight')
                    }
                });
                x.addEventListener('dragend', function (e: JQueryEventObject) {
                    e.preventDefault();
                    //const highlighted = $('.highlight');
                    //for (let item in highlighted) {
                    //    highlighted.removeClass('highlight');
                    //}
                    const cell = $(e.target).parent('.slick-cell');
                    $(cell[0]).addClass('  hovered highlight')
                });
            });
        }
    }
     
}