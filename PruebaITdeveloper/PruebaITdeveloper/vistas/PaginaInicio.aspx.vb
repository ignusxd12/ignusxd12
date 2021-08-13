Public Class PaginaInicio
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim codEir As String = TextEir.Text
        'Dim ArregloTabla As SqlDataReader = datos.GetDatosEir(codEir)
        'Dim Cod As String ='001'

        Dim url As String = "detallesEir.aspx?ID=" + codEir

        Response.Redirect(url)
        'Dim arrListEir As New ArrayList
        'Do While ArregloTabla.Read
        '    classEir.eir =
        '    classEir.contenedor = ArregloTabla("contenedor")
        '    classEir.sello = ArregloTabla("sello")
        '    classEir.responsable_nombre = ArregloTabla("responsable_nombre")
        '    classEir.empresa_nombre = ArregloTabla("empresa_nombre")
        '    arrListEir.Add(classEir)
        'Loop
    End Sub

End Class