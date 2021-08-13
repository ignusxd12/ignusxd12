﻿Imports System.Data.SqlClient

Public Class DataEir
    Function GetDatosEir(ByVal EIR_ID As String) As SqlDataReader
        Dim MyCommand As New SqlCommand
        Try
            MyCommand.Connection = New SqlConnection("Data Source=localhost;Initial Catalog=360Movil;User ID=sa;Password=linux")
            MyCommand.CommandText = "sp_get_eir_datos"
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 5000
            MyCommand.Parameters.AddWithValue("@EIR", EIR_ID)

            Dim ArregloTabla As SqlDataReader
            MyCommand.Connection.Open()
            ArregloTabla = MyCommand.ExecuteReader(CommandBehavior.CloseConnection)
            Return ArregloTabla
        Catch ex As Exception

        End Try

    End Function
End Class
