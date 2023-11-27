Namespace TaskManager.Repository.Contracts
    Public Interface IRepository(Of T As Class)
        Function GetAll(userId As Integer) As IEnumerable(Of T)
        Function GetById(id As Integer) As T
        Sub Add(entity As T)
        Function Update(entity As T) As Integer
        Function Delete(id As Integer) As Boolean
    End Interface


End Namespace

