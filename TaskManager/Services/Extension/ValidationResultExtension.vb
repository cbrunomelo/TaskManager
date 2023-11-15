Imports FluentValidation.Results
Imports System.Runtime.CompilerServices

Module ValidationResultExtension

    <Extension()>
    Public Function ToListErros(Of T)(validationResult As ValidationResult) As List(Of String)

        Dim list As List(Of String) = New List(Of String)()

        For Each erro As ValidationFailure In validationResult.Errors
            list.Add(erro.ErrorMessage)
        Next
        Return list

    End Function





End Module
