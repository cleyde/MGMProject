Imports System.Web.Mvc
Imports ProjetoMGN.Domain
Imports ProjetoMGN.Infra.Data

Namespace Controllers
    Public Class ClientesController
        Inherits Controller
        Private ReadOnly _clientRepository As ClienteRepository

        Public Sub New()
            Me.New(New ClienteRepository())
        End Sub


        Sub New(ByVal cliRep As ClienteRepository)
            _clientRepository = cliRep
        End Sub
        ' GET: Clientes
        Function Index() As ActionResult
            Dim clientViewModel = AutoMapper.Mapper.Map(Of IEnumerable(Of Cliente), IEnumerable(Of ClienteViewModel))(_clientRepository.GetAll)
            Return View(clientViewModel)
        End Function

        ' GET: Clientes/Details/5
        Function Details(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' GET: Clientes/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Clientes/Create
        <HttpPost()>
        <ValidateAntiForgeryToken>
        Function Create(ByVal cliente As ClienteViewModel) As ActionResult
            Dim clientDomain
            If (ModelState.IsValid) Then
                clientDomain = AutoMapper.Mapper.Map(Of ClienteViewModel, Cliente)(cliente)
                _clientRepository.Add(clientDomain)
                Return RedirectToAction("Index")
            End If
            Return View(cliente)
        End Function

        ' GET: Clientes/Edit/5
        Function Edit(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' POST: Clientes/Edit/5
        <HttpPost()>
        Function Edit(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add update logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        ' GET: Clientes/Delete/5
        Function Delete(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' POST: Clientes/Delete/5
        <HttpPost()>
        Function Delete(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add delete logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function
    End Class
End Namespace