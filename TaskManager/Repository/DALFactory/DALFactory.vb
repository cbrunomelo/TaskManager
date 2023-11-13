Imports System.Data.Common

Namespace TaskManager.Repository.DALFactory
    Public Class DALFactory

        Public Shared Function CriarComando(comandoTexto As String, comandoTipo As CommandType, listaParametros As List(Of DbParameter)) As DbCommand

            Try
                Dim oFactory = DbProviderFactories.GetFactory(ConexaoDB.ProviderName)
                Dim oConn = oFactory.CreateConnection

                oConn.ConnectionString = ConexaoDB.ConnectiontString
                Dim oCmd = oConn.CreateCommand

                oCmd.CommandText = comandoTexto
                oCmd.CommandType = comandoTipo

                If Not IsNothing(listaParametros) Then
                    For Each oParam In listaParametros
                        oCmd.Parameters.Add(oParam)
                    Next
                End If

                Return oCmd

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Shared Function CriarParametro(nomeParametro As String, tipoParametro As DbType, valorParametro As Object) As DbParameter
            Try
                Dim oFactory = DbProviderFactories.GetFactory(ConexaoDB.ProviderName)
                Dim oParam = oFactory.CreateParameter

                If Not IsNothing(oParam) Then
                    oParam.ParameterName = nomeParametro
                    oParam.DbType = tipoParametro
                    oParam.Value = valorParametro
                End If
                Return oParam
            Catch ex As Exception
                Throw
            End Try
        End Function


        Public Shared Function ExecutarComando(comandoTexto As String, comandoTipo As CommandType, listaParametros As List(Of DbParameter), tipoComando As TipoDeComando) As Object

            Dim command = CriarComando(comandoTexto, comandoTipo, listaParametros)
            Dim retorno As Object = Nothing

            Try
                command.Connection.Open()

                Select Case tipoComando
                    Case TipoDeComando.ExecuteNonQuery
                        retorno = command.ExecuteNonQuery
                    Case TipoDeComando.ExecuteReader
                        retorno = command.ExecuteReader
                    Case TipoDeComando.ExecuteScalar
                        retorno = command.ExecuteScalar
                    Case TipoDeComando.ExecuteDataTable
                        Dim table = New DataTable
                        Dim reader = command.ExecuteReader
                        table.Load(reader)
                        reader.Close()
                        retorno = table
                    Case TipoDeComando.ExecuteDataSet
                        Dim oFactory = DbProviderFactories.GetFactory(ConexaoDB.ProviderName)
                        Dim da As DbDataAdapter = oFactory.CreateDataAdapter
                        command.CommandText = comandoTexto
                        command.CommandType = comandoTipo
                        da.SelectCommand = command
                        Dim ds As New DataSet
                        da.Fill(ds)
                        retorno = ds
                End Select
            Catch ex As Exception
                Throw ex
            Finally
                If Not tipoComando = TipoDeComando.ExecuteReader Then
                    If command.Connection.State = ConnectionState.Open Then
                        command.Connection.Close()
                    End If
                    command.Connection.Dispose()
                End If
            End Try
            Return retorno
        End Function






    End Class


End Namespace
