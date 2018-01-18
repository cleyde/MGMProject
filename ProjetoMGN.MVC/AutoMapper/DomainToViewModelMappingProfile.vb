Imports AutoMapper
Imports ProjetoMGN.Domain

Public Class DomainToViewModelMappingProfile
    Inherits Profile


    Private ReadOnly _profilename As String

    Public Overrides ReadOnly Property ProfileName() As String
        Get
            Return ("ViewModelToDomainMappings")
        End Get
    End Property

    Public Sub New()
        CreateMap(Of ClienteViewModel, Cliente)()

    End Sub
End Class
