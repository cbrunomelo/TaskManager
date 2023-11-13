Imports System.Configuration
Imports System.IO
Imports System.Reflection
Imports System.Runtime.InteropServices

Namespace TaskManager.Repository.DALFactory
    Public Class ConexaoDB

        Shared _connectionString As String
        Shared _providerName As String

        Public Shared Sub getAcesso(ByVal tipoAcesso As ETipoAcesso)

            Try
                Select Case tipoAcesso
                    Case ETipoAcesso.SQLite
                        Dim diretorioSolucao As String = Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath))
                        _connectionString = ConnectionStringSQLite()
                        _providerName = ConfigurationManager.ConnectionStrings("SQLiteConnectionString").ProviderName
                    Case ETipoAcesso.MySQL
                        _connectionString = ConfigurationManager.ConnectionStrings("MySQLConnectionString").ConnectionString
                        _providerName = ConfigurationManager.ConnectionStrings("MySQLConnectionString").ProviderName
                    Case "SQLServer"
                        _connectionString = ConfigurationManager.ConnectionStrings("SQLServerConnectionString").ConnectionString
                        _providerName = ConfigurationManager.ConnectionStrings("SQLServerConnectionString").ProviderName
                End Select
            Catch ex As Exception
                Throw New Exception("Erro ao acessar a string de conexão")
            End Try
        End Sub

        Public Shared Function ConnectiontString() As String
            Return _connectionString
        End Function
        Public Shared Function ProviderName() As String
            Return _providerName
        End Function


        Private Shared Function ConnectionStringSQLite() As String
            Dim diretorioSolucao As String = Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath))
            Dim diretorioDoSQlite As String = "\Repository"
            Return "Data Source=" & diretorioSolucao & diretorioDoSQlite & "\app.db;Version=3;"
        End Function





    End Class


End Namespace



