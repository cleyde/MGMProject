Imports AutoMapper
Imports ProjetoMGN.Domain

Public Class ViewModelToDomainMappingProfile
    Inherits Profile


    Private ReadOnly _profilename As String

    Public Overrides ReadOnly Property ProfileName() As String
        Get
            Return ("DomainToViewModelMappings")
        End Get
    End Property

    Public Sub New()
        CreateMap(Of Cliente, ClienteViewModel)()

    End Sub

End Class
