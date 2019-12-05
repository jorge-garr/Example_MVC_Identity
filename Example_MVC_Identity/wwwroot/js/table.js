$(document).ready(function () {
    let values = window.listaEmpleados ? window.listaEmpleados : null;

    if (values != null) {
        addTable(values);
    }
});

function addTable(values) {

    let table = ``;

    for (let i in values) {
        table += `
            <tr>
                <td>${values[i].Name}</td>
                <td>${values[i].LastName}</td>
                <td>${values[i].Department}</td>
                <td>${values[i].Position}</td>
            </tr>
        `
    }

    $('#tbodytable').append(table);
}