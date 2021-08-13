@ModelType IEnumerable(Of Prueba360Movil.EIR)
@Code
ViewData("Title") = "DatosEir"
End Code

<h2>DatosEir</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.eir)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.contenedor)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.sello)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.responsable_nombre)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.empresa_nombre)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.eir)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.contenedor)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.sello)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.responsable_nombre)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.empresa_nombre)
        </td>
        <td>
            @*@Html.ActionLink("Edit", "Edit", New With {.id = item.PrimaryKey}) |
            @Html.ActionLink("Details", "Details", New With {.id = item.PrimaryKey}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.PrimaryKey})*@
        </td>
    </tr>
Next

</table>
