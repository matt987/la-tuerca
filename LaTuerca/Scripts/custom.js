function Add() {
    $("#tblData tbody").append(
        "<tr>" +
            "<td><input type='text'/></td>" +
            "<td><input type='text'/></td>" +
            "<td><input class='typeahead' type='text'/> <input class='typeahead-value' type='hidden'/></td>" +
            "<td><a class='btnSave'><i class='glyphicon glyphicon-ok'></i></a>" +
                "<a class='btnDelete'><i class='glyphicon glyphicon-remove'></i></a>" +
            "</td>" +
        "</tr>");
    $('#tblData .typeahead').typeahead({
        hint: true,
        highlight: true,
        displayKey: 'name',
        minLength: 1
    },
    {
        name: 'states',
        source: substringMatcher(states)
    }).on('typeahead:selected', function (event, data) {
        $('.typeahead-value').val(data.id);
    });

    $(".btnSave").bind("click", Save); $(".btnDelete").bind("click", Delete);
};

function Save() { 
    var par = $(this).parent().parent(); //tr 
    var tdCantidad = par.children("td:nth-child(1)");
    var tdPrecio = par.children("td:nth-child(2)");
    var tdRepuesto = par.children("td:nth-child(3)");
    console.log(tdRepuesto.children());
    var tdButtons = par.children("td:nth-child(4)");
    tdCantidad.html(tdCantidad.children("input[type=text]").val());
    tdPrecio.html(tdPrecio.children("input[type=text]").val());
    tdRepuesto.html("holaaa");
    tdButtons.html("<a class='btnDelete'><i class='glyphicon glyphicon-remove'></i></a><a class='btnEdit'><i class='glyphicon glyphicon-pencil'></i></a>");
    $(".btnEdit").bind("click", Edit); $(".btnDelete").bind("click", Delete);
};

function Edit() { 
    var par = $(this).parent().parent(); //tr 
    var tdCantidad = par.children("td:nth-child(1)");
    var tdPrecio = par.children("td:nth-child(2)");
    var tdRepuesto = par.children("td:nth-child(3)");
    var tdButtons = par.children("td:nth-child(4)");
    tdCantidad.html("<input type='text' id='txtCantidad' value='" + tdCantidad.html() + "'/>");
    tdPrecio.html("<input type='text' id='txtPrecio' value='" + tdPrecio.html() + "'/>");
    tdRepuesto.html("<input type='text' id='txtRepuesto' value='" + tdRepuesto.html() + "'/>");
    tdButtons.html("<a class='btnSave'><i class='glyphicon glyphicon-ok'></i></a>");
    $(".btnSave").bind("click", Save);
    $(".btnEdit").bind("click", Edit);
    $(".btnDelete").bind("click", Delete);
};

function Delete() { 
    var par = $(this).parent().parent(); //tr 
    par.remove();
};

$(function () {
    //Add, Save, Edit and Delete functions code 
    $(".btnEdit").bind("click", Edit);
    $(".btnDelete").bind("click", Delete);
    $("#btnAdd").on("click", Add);
});




//Typehead
var substringMatcher = function (strs) {
    var resultados = function findMatches(q, cb) {
        var matches, substringRegex;

        // an array that will be populated with substring matches
        matches = [];

        // regex used to determine if a string contains the substring `q`
        substrRegex = new RegExp(q, 'i');

        // iterate through the pool of strings and for any string that
        // contains the substring `q`, add it to the `matches` array
        $.each(strs, function (i, str) {
            if (substrRegex.test(str.name)) {
                matches.push(str);
            }
        });
        cb(matches);
    };
    
    return resultados;
};

var states = [{ "id": 1, "name": 'Alabama' }, { "id": 2, "name": 'Alaska' }
];

$('#tblData .typeahead').typeahead({
    hint: true,
    highlight: true,
    minLength: 1
},
{
    name: 'states',
    source: substringMatcher(states)
});