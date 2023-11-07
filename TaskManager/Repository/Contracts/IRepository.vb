Namespace TaskManager.Repository.Contracts
    Public Interface IRepository(Of T As Class)
        Function GetAll() As IEnumerable(Of T)
        Function GetById(id As Integer) As T
        Sub Add(entity As T)
        Sub Update(entity As T)
        Sub Delete(entity As T)
    End Interface


End Namespace

