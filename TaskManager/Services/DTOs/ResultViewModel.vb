Namespace TaskManager.Services.DTOs
    Public Class ResultViewModel(Of T)

        Property Success As Boolean

        Property Erros As List(Of String) = New List(Of String)()

        Property Data As T

        Sub New(errorList As List(Of String))
            Erros = errorList
            Success = False
        End Sub

        Sub New(data As T)
            Success = True
            Me.Data = data
        End Sub

        Sub New(erro As String)
            Success = False
            Erros.Add(erro)
        End Sub
    End Class

End Namespace
