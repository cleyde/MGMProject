Public Interface IRepositoryBase(Of TEntity As Class)

    Sub Add(ByVal entity As TEntity)
    Sub Remove(ByVal entity As TEntity)
    Sub Update(ByVal entity As TEntity)
    Function GetById(ByVal Id As Guid) As TEntity
    Function GetAll() As IEnumerable(Of TEntity)
    Sub Dispose()
End Interface
