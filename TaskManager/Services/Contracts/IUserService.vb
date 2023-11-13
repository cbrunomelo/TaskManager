Imports TaskManager.TaskManager.Services.Entitys

Namespace TaskManager.Services.Contracts
    Public Interface IUserService

        Sub CreateUser(name As String, password As String)

        Sub UpdateUser(id As Integer, name As String, password As String)

        Sub DeleteUser(id As Integer)
        Function GetUser(id As Integer) As User

        Function GetUsers() As IEnumerable

    End Interface


End Namespace



