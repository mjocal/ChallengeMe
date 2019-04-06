
function BuildCtrlTable(encodedModel) {

    //debugger;

    var model = jQuery.parseJSON($.base64.decode(encodedModel));

    var id = model.Id;
    var tblBodyId = 'tblBody_' + id;
    var htmlTable = GetHtmlTable(model.ColumHeaders, model.RowList, tblBodyId);
    var htmlText = '<br/><div class="panel panel-primary" id="' + id + '">' +
        '<div class="panel-heading">' + '<h3 class="panel-title">' + model.Title + '</h3>' + '</div>' +
        '<div class="panel-body">' + htmlTable + '</div>' + '</div>';

    $('#' + model.ContainerId).html(htmlText);

    //Evento de seleccion de una fila
    var table = $('#' + tblBodyId).DataTable({
        "language" : {
            "lengthMenu": "Mostrar _MENU_ por página",
            "zeroRecords": "No se han encontrado registros",
            "info": "Mostrar página _PAGE_ de _PAGES_",
            "infoEmpty": "No hay registros disponibles",
            "search" : "Buscar",
            "paginate": {
                "first": "Primero",
                "last": "Ultimo",
                "next": "Siguiente",
                "previous" : "Anterior"
            },
            "infoFiltered": "(filtrado de _MAX_ registros totales)"
        }
    });
    var selectedRowIndex = -1;
    var selectedClass = "info";

    $('#' + tblBodyId + ' tbody').on('click', 'tr', function () {
        //debugger;
        //Deseleccion.
        if ($(this).hasClass(selectedClass)) {
            $(this).removeClass(selectedClass);
            selectedRowIndex = -1;
        }
        else {
            //Seleccion
            table.$('tr.' + selectedClass).removeClass(selectedClass);
            $(this).addClass(selectedClass);
            selectedRowIndex = table.row(this).index();
        }

        //Guarda el indice seleccionado como parte del modelo           
        SetAttributteValue(id, "SelectedRowIndex", selectedRowIndex);

        //Verifica si existe un evento asociado a la seleccion y lo ejecuta en caso de que el indice sea mayor que -1
        if (selectedRowIndex > -1 && (!(!model.OnSelect) && model.OnSelect.trim())) {
            //Ejecuta el evento
            eval(model.OnSelect);
        }
    });


    //Setea los atributos custom postPintado
    SetAttributteValue(id, "ColumHeaders", model.ColumHeaders);
    SetAttributteValue(id, "Title", model.Title);
    SetAttributteValue(id, "RowList", model.RowList);
    SetAttributteValue(id, "ContainerId", model.ContainerId);
    SetAttributteValue(id, "JsFunctionName", model.JsFunctionName);
    SetAttributteValue(id, "OnSelect", model.OnSelect);
    SetAttributteValue(id, "SelectedRowIndex", selectedRowIndex);
}

function GetHtmlTable(columnHeaders, rowList, tblBodyId) {

    var html = "No se encontraron registros";

    //Solo genera la tabla si hay al menos un registro
    if (rowList.length > 0) {
        var columns = columnHeaders.split(",");
        var header = "<thead><tr>";

        $.each(columns, function (columnId, columnName) {
            header += '<th>' + columnName + '</th>';
        });

        header += '</tr>' + '</thead>';

        var body = '<tbody>';

        if (rowList.length === 0) {

        }

        $.each(rowList, function (rowId, row) {
            body += '<tr>';
            //debugger;
            $.each(row, function (columnId, columnValue) {
                body += '<td>' + columnValue + '</td>';
            });

            body += '</tr>';
        });

        body += '</tbody>';

        html = '<table id="' + tblBodyId + '" class="table table-striped table-hover">' +
            header +
            body +
            '</table> ';
    }

    return html;
}

function CtrlTableModel(id) {
    this.Id = id;
    this.ColumHeaders = GetAttributteValue(id, "ColumHeaders");
    this.Title = GetAttributteValue(id, "Title");
    this.RowList = GetAttributteValue(id, "RowList");
    this.ContainerId = GetAttributteValue(id, "ContainerId");
    this.JsFunctionName = GetAttributteValue(id, "JsFunctionName");
    this.OnSelect = GetAttributteValue(id, "OnSelect");
    this.SelectedRowIndex = GetAttributteValue(id, "SelectedRowIndex");
}