@ModelType IEnumerable(Of ProjetoMGN.MVC.ClienteViewModel)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Nome)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.TipoTelefone)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Telefone)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.CEP)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Logradouro)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Numero)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Bairro)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Municipio)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.UF)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Nome)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TipoTelefone)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Telefone)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CEP)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Logradouro)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Numero)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Bairro)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Municipio)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.UF)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.CPF }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.CPF }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.CPF })
        </td>
    </tr>
Next

</table>
