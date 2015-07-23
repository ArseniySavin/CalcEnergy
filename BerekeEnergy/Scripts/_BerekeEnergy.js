var editor;

$(document).ready(function () {

    editor = new $.fn.dataTable.Editor({
        ajax: {
            url: "TypeDeviceAjaxHandler",
            method: "POST"
        },
        table: "#TypeDevice",
        idSrc: "Id",
        fields: [
            {
                name: "Id",
                type: "hidden"
            }, {
                label: "Код:",
                name: "code"
            }, {
                label: "Наименование:",
                name: "name"
            }
        ],
        i18n: {
            edit: {
                title: "Изменить"
            },
            create: {
                title: "Добавить"
            },
            remove: {
                title: "Удалить"
            }
        }
    });

    $('#TypeDevice').dataTable({
        processing: true,
        serverSide: false,
        ajax: {
            url: "TypeDeviceAjaxHandler"
        },
        dom: 'Tfrtip',
        columns: [
                        {
                            data: "Id",
                            "visible": false
                            //searchable : false,
                            //sortable : false,
                            // render : function (oObj) {
                            //return "<input type=\"checkbox\" id=\"" + oObj[0] + "\" />"
                            //}
                        },
                        { data: "code" },
                        { data: "name" },
        ],
        tableTools: {
            sRowSelect: "os",
            aButtons: [
                { sExtends: "editor_create", editor: editor, sButtonText: "Добавить" },
                { sExtends: "editor_edit", editor: editor, sButtonText: "Изменит" },
                { sExtends: "editor_remove", editor: editor, sButtonText: "Удалить" }
            ]
        }
    });

    // Tariff

    editor = new $.fn.dataTable.Editor({
        ajax: {
            url: "TariffAjaxHandler",
            method: "POST"
        },
        table: "#Tariff",
        idSrc: "Id",
        fields: [
            {
                name: "Id",
                type: "hidden"
            }, {
                label: "Код:",
                name: "code"
            }, {
                label: "Наименование:",
                name: "name"
            }, {
                label: "Тариф 1:",
                name: "tariff_1"
            }, {
                label: "Тариф 2:",
                name: "tariff_2"
            }, {
                label: "Тариф 3:",
                name: "tariff_3"
            }, {
                label: "Тариф 4:",
                name: "tariff_4"
            }
        ],
        i18n: {
            edit: {
                title: "Изменить"
            },
            create: {
                title: "Добавить"
            },
            remove: {
                title: "Удалить"
            }
        }
    });

    $('#Tariff').dataTable({
        processing: true,
        serverSide: false,
        ajax: {
            url: "TariffAjaxHandler"
        },
        dom: 'Tfrtip',
        columns: [
                        {
                            data: "Id",
                            "visible": false
                        },
                        { data: "code" },
                        { data: "name" },
                        { data: "tariff_1" },
                        { data: "tariff_2" },
                        { data: "tariff_3" },
                        { data: "tariff_4" },
        ],
        tableTools: {
            sRowSelect: "os",
            aButtons: [
                { sExtends: "editor_create", editor: editor, sButtonText: "Добавить" },
                { sExtends: "editor_edit", editor: editor, sButtonText: "Изменит" },
                { sExtends: "editor_remove", editor: editor, sButtonText: "Удалить" }
            ]
        }
    });

    // Device

    editor = new $.fn.dataTable.Editor({
        ajax: {
            url: "DeviceAjaxHandler",
            method: "POST"
        },
        table: "#Device",
        idSrc: "Id",
        fields: [
            {
                name: "Id",
                type: "hidden"
            }, {
                label: "Код:",
                name: "code"
            }, {
                label: "Наименование:",
                name: "name"
            }, {
                label: "Коофициент:",
                name: "coefficient"
            }, {
                label: "Тип:",
                name: "TypeDevice.Id",
                type:  "select",
                options: loaderTypeDevice()
            }, {
                name: "TypeDevice.code",
                type: "hidden"
            }, {
                name: "TypeDevice.name",
                type: "hidden"
            }, {
                label: "Тариф:",
                name: "Tariff.Id",
                type: "select",
                options: loaderTariff()
            }
        ],
        i18n: {
            edit: {
                title: "Изменить"
            },
            create: {
                title: "Добавить"
            },
            remove: {
                title: "Удалить"
            }
        }
    });

    $('#Device').dataTable({
        processing: true,
        serverSide: false,
        ajax: {
            url: "DeviceAjaxHandler"
        },
        dom: 'Tfrtip',
        columns: [
                        {
                            data: "Id",
                            "visible": false
                        },
                        { data: "code" },
                        { data: "name" },
                        { data: "coefficient" },
                        { data: "TypeDevice.name" },
                        { data: "TypeDevice.code", visible: false },
                        { data: "TypeDevice.Id", visible: false },
        ],
        tableTools: {
            sRowSelect: "os",
            aButtons: [
                { sExtends: "editor_create", editor: editor, sButtonText: "Добавить" },
                { sExtends: "editor_edit", editor: editor, sButtonText: "Изменит" },
                { sExtends: "editor_remove", editor: editor, sButtonText: "Удалить" }
            ]
        }
    });
});

function loaderTypeDevice() {
    var test = new Array({ "label": "Test1", "value": "1" });
    //test.splice(0, 1);
    $.ajax({
        type: 'GET',
        url: "GetTypeDeviceAjaxHandler",
        async: false,
        dataType: 'json',
        success: function (json) {
            for (var a = 0; a < json.length; a++) {
                obj = { "label": json[a]["label"], "value": json[a]["value"] };
                test.push(obj);
            }
        }
    });
    return test;
}
function loaderTariff() {
    var test = new Array({ "label": "Test1", "value": "1" });
    //test.splice(0, 1);
    $.ajax({
        type: 'GET',
        url: "GetTariffAjaxHandler",
        async: false,
        dataType: 'json',
        success: function (json) {
            for (var a = 0; a < json.length; a++) {
                obj = { "label": json[a]["label"], "value": json[a]["value"] };
                test.push(obj);
            }
        }
    });
    return test;
}
