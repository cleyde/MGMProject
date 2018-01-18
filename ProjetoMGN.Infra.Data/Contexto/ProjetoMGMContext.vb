
Imports System.Data.Entity
Imports ProjetoMGN.Domain

Public Class ProjetoMGMContext
    Inherits DbContext


    Public Sub New()
        MyBase.New("name=ProjetoMGMDb")
    End Sub

    Public Property Clientes() As DbSet(Of Cliente)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Conventions.Remove(Of System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention)()
        modelBuilder.Conventions.Remove(Of System.Data.Entity.ModelConfiguration.Conventions.OneToManyCascadeDeleteConvention)()
        modelBuilder.Conventions.Remove(Of System.Data.Entity.ModelConfiguration.Conventions.ManyToManyCascadeDeleteConvention)()
        modelBuilder.Entity(Of Cliente)().HasKey(Function(c) c.CPF)
        modelBuilder.Entity(Of Cliente)().Property(Function(t) t.Logradouro).HasColumnType(“varchar”)
        modelBuilder.Entity(Of Cliente)().Property(Function(t) t.Municipio).HasColumnType(“varchar”)
        modelBuilder.Entity(Of Cliente)().Property(Function(t) t.Nome).HasColumnType(“varchar”)
        modelBuilder.Entity(Of Cliente)().Property(Function(t) t.TipoTelefone).HasColumnType(“varchar”)
        modelBuilder.Entity(Of Cliente)().Property(Function(t) t.UF).HasColumnType(“varchar”)


    End Sub
    Public Overrides Function SaveChanges() As Integer

        For Each dbEntityEntry In ChangeTracker.Entries(Of Cliente).Where(Function(t) t.GetType().GetProperty("DataCadastro") IsNot Nothing)
            If dbEntityEntry.State = EntityState.Added Then
                dbEntityEntry.Property("DataCadastro").CurrentValue = Now
            End If

            If dbEntityEntry.State = EntityState.Modified Then
                dbEntityEntry.Property("DataCadastro").IsModified = False
            End If
        Next
        Return MyBase.SaveChanges()
    End Function
End Class

