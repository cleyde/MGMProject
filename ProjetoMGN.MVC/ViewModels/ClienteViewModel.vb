Imports System.ComponentModel.DataAnnotations
Public Class ClienteViewModel
    <Required(ErrorMessage:="Preencha o campo Nome")>
    <MaxLength(150, ErrorMessage:="Máximo {0} caractere")>
    <MinLength(2, ErrorMessage:="Mínimo {0} caractere")>
    Public Property Nome As String
    <Key>
    Public Property CPF As Integer
    Public Property TipoTelefone As String
    <Required>
    <DataType(DataType.PhoneNumber)>
    Public Property Telefone As Integer
    <Required>
    <DataType(DataType.PostalCode)>
    Public Property CEP As Integer
    <Required(ErrorMessage:="Preencher o campo Logradouro")>
    <MaxLength(500, ErrorMessage:="Máximo {0} caracteres")>
    <MinLength(2, ErrorMessage:="Mínimo {0} caracteres")>
    Public Property Logradouro As String
    <Required(ErrorMessage:="Preencher o campo Numero")>
    Public Property Numero As Integer
    <Required(ErrorMessage:="Preencher o campo Bairro")>
    <MaxLength(100, ErrorMessage:="Máximo {0} caracteres")>
    <MinLength(2, ErrorMessage:="Mínimo {0} caracteres")>
    Public Property Bairro As String
    <Required(ErrorMessage:="Preencher o campo Municipio")>
    <MaxLength(100, ErrorMessage:="Máximo {0} caracteres")>
    <MinLength(2, ErrorMessage:="Mínimo {0} caracteres")>
    Public Property Municipio As String
    <Required(ErrorMessage:="Preencher o campo UF")>
    Public Property UF As String
    <ScaffoldColumn(False)>
    Public Property DataCadastro As Date
End Class
