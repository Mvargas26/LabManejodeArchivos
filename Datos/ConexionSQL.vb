Imports System.Data.SqlClient
Imports System.Configuration

Public Class ConexionSQL
    Dim sqlConectar As SqlConnection 'variable q me permite conectarme
    Public Sub New() 'constructor
        Try
            Dim strConector As New System.Text.StringBuilder 'objeto almacena string de conexion

            With strConector
                .Append("Data Source=")
                .Append(ConfigurationManager.AppSettings("ServerName"))
                .Append(";Initial Catalog=")
                .Append(ConfigurationManager.AppSettings("DBName"))
                '.Append(";Integrated Security=True;Trusted_Connection=true")
                .Append(";User=")
                .Append(ConfigurationManager.AppSettings("User"))
                .Append(";Password=")
                .Append(ConfigurationManager.AppSettings("Pass"))
            End With

            Me.sqlConectar = New SqlConnection(strConector.ToString) 'convertimos la variable en un objeto

        Catch sql As SqlException
            Throw sql
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Public Sub ProbarConexion()
        Try
            Me.sqlConectar.Open()

            Me.sqlConectar.Close()


        Catch sql As SqlException
            Throw sql
        Catch ex As Exception
            Throw ex
        Finally
            If Me.sqlConectar.State = ConnectionState.Open Then ' si la conexion esta abierta, cierrela
                Me.sqlConectar.Close()
            End If
        End Try
    End Sub

End Class
