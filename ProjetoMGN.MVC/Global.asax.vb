Imports System.Web.Optimization

Public Class MvcApplication
    Inherits System.Web.HttpApplication
    Private ReadOnly _automappingconfig = New AutoMapperConfig()
    Sub Application_Start()
        AreaRegistration.RegisterAllAreas()
        FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)
        _automappingconfig.RegisterMapping()
    End Sub
End Class
