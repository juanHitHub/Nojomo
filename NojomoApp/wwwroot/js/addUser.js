function saveMessage(nombre){

       document.getElementById('divServerValidations').innerHTML = nombre + " guardado correctamente!";
}

function setFocusOnElement(element) {
    element.focus();
}

function getTipo() {
    var Tipo = ["--Seleccione--","Cliente","Agente","Administrador"];
    return Tipo;
}

//$('#checkall').change(function () {
//    $('.checkitem').prop("checked",$(this).prop("checked"))
//})