$(function () {
    $('#btnBuscar').click(function () {
        var baseUrl =@Url.Action("DatosEir", "Home");
        var codEir = $("#txtEir").val();
        var url = baseUrl + "/" + codEir;
        window.location(url);


    });
});
  