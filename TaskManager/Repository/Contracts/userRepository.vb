Imports TaskManager.TaskManager.Repository.Contracts
Imports TaskManager.TaskManager.Services.Entitys
Namespace TaskManager.TaskManager.Repository.Contracts
    Public Interface IUserrepository
        Inherits IRepository(Of User)
        Function GetByName(name As String) As Integer?

    End Interface

End Namespace