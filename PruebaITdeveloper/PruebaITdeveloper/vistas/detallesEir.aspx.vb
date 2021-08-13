Imports System.Data.SqlClient

Public Class detallesEir
    Inherits System.Web.UI.Page
    Dim datos As New DataEir
    Dim classEir As New EIR
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim codEir = Request.QueryString("ID")
        Dim ArregloTabla As SqlDataReader = datos.GetDatosEir(codEir)

        Do While ArregloTabla.Read
            TextEir.Text = ArregloTabla("eir")
            TextContenedor.Text = ArregloTabla("contenedor")
            TextSello.Text = ArregloTabla("sello")
            TextResponsable.Text = ArregloTabla("responsable_nombre")
            TextEmpresa.Text = ArregloTabla("empresa_nombre")

        Loop
    End Sub

End Class