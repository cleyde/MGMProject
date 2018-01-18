Imports AutoMapper
Public Class AutoMapperConfig

    Public Sub RegisterMapping()
        Dim config As New Configuration.MapperConfigurationExpression : With config
            .AddProfile(Of DomainToViewModelMappingProfile)()
            .AddProfile(Of ViewModelToDomainMappingProfile)()
        End With
        Mapper.Initialize(config)

    End Sub

End Class
