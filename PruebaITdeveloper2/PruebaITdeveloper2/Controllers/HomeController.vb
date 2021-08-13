Imports System.Data.SqlClient

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Dim datos As New DatosEir
    Dim classEir As New EIR
    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function


    Function DatosEir(eir_code As String) As ActionResult
        Dim ArregloTabla As SqlDataReader = datos.GetDatosEir(eir_code)

        Dim arrListEir As New ArrayList
        Do While ArregloTabla.Read
            classEir.eir = ArregloTabla("eir")
            classEir.contenedor = ArregloTabla("contenedor")
            classEir.sello = ArregloTabla("sello")
            classEir.responsable_nombre = ArregloTabla("responsable_nombre")
            classEir.empresa_nombre = ArregloTabla("empresa_nombre")
            arrListEir.Add(classEir)
        Loop
        ArregloTabla.Close()




        Return View(arrListEir)
    End Function
End Class
