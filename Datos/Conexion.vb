Imports System.Data.SqlClient

Public Class Conexion
    Dim ccadena As New SqlConnection

    Public Function SQL_Conexion() As SqlConnection
        ccadena.ConnectionString = "Data Source=educem.cloudapp.net;Initial Catalog=Matriculado;User ID=server;Password=T1.3Ducem.2019"
        Return ccadena
    End Function

    Public Function SQL_Sedes() As SqlConnection
        ccadena.ConnectionString = "Data Source=educem.cloudapp.net;Initial Catalog=Directorio;User ID=server;Password=T1.3Ducem.2019"
        Return ccadena
    End Function

    Public Function SQL_Corporativo() As SqlConnection
        ccadena.ConnectionString = "Data Source=educem.cloudapp.net;Initial Catalog=Corporativo;User ID=server;Password=T1.3Ducem.2019"
        Return ccadena
    End Function

End Class