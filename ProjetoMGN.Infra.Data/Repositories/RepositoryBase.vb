Imports ProjetoMGN.Domain


Public Class RepositoryBase(Of TEntity As Class)
    Implements IDisposable, IRepositoryBase(Of TEntity)

    Dim Db As New ProjetoMGMContext()

    Sub New()
        Dim ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance

    End Sub



    Public Sub Add(entity As TEntity) Implements IRepositoryBase(Of TEntity).Add
        Db.Set(Of TEntity).Add(entity)
        Db.SaveChanges()
    End Sub

    Public Sub Dispose() Implements IRepositoryBase(Of TEntity).Dispose
        Db.Dispose()
    End Sub

    Public Sub Remove(entity As TEntity) Implements IRepositoryBase(Of TEntity).Remove
        Db.Set(Of TEntity)().Remove(entity)
        Db.SaveChanges()
    End Sub

    Public Sub Update(entity As TEntity) Implements IRepositoryBase(Of TEntity).Update
        Db.Entry(entity).State = System.Data.Entity.EntityState.Modified
        Db.SaveChanges()
    End Sub

    Private Sub IDisposable_Dispose() Implements IDisposable.Dispose
        Throw New NotImplementedException()
    End Sub

    Public Function GetAll() As IEnumerable(Of TEntity) Implements IRepositoryBase(Of TEntity).GetAll
        Return Db.Set(Of TEntity).ToList
    End Function

    Public Function GetById(Id As Guid) As TEntity Implements IRepositoryBase(Of TEntity).GetById
        Return Db.Set(Of TEntity).Find(Id)
    End Function
End Class
