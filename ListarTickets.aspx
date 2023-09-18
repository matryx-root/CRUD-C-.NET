<%@ Page Title="" Language="C#" MasterPageFile="~/MPSitio.Master" AutoEventWireup="true" CodeBehind="ListarTickets.aspx.cs" Inherits="CRUD.WEB.ListarTickets" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<h1>Listar Tickets</h1>

<div class="row mt-3">
    <div class="col-md-3">
        <asp:Label runat="server" ID="lblMensaje" CssClass="message" Visible="false"></asp:Label>
    </div>
    <div class="col-md-3">
        <asp:Label runat="server" ID="Label1" CssClass="message" Visible="false"></asp:Label>
    </div>

    <div class="col-sm-3 ml-auto">
        <div class="form-group">
            <asp:RadioButtonList ID="rbFiltroEstado" runat="server" AutoPostBack="True" CssClass="form-control">
                <asp:ListItem Text="Todos" Value="" />
                <asp:ListItem Text="Habilitados" Value="Habilitados" />
                <asp:ListItem Text="Inhabilitados" Value="Inhabilitados" />
            </asp:RadioButtonList>
        </div>
    </div>
    <div>
        <asp:Button ID="Button1" runat="server" Text="Filtrar" OnClick="BtnFiltrar_Click" CssClass="btn btn-primary" />
    </div>
</div>

<div class="table-responsive">
    <asp:Repeater runat="server" ID="Repeater1">
        <HeaderTemplate>
            <table class="table table-striped">
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Nombre del Cliente</th>
                        <th>RUT del Cliente</th>
                        <th>Número Telefónico</th>
                        <th>Email del Cliente</th>
                        <th>Descripción</th>
                        <th>Estado</th>
                        <th>Acciones</th>
                    </tr>
                </thead>
                <tbody>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td><%# Eval("Id") %></td>
                <td><%# Eval("Cliente.Nombre") %></td>
                <td><%# Eval("Cliente.Rut") %></td>
                <td><%# Eval("Cliente.Telefono") %></td>
                <td><%# Eval("Cliente.Email") %></td>
                <td><%# Eval("Descripcion") %></td>
                <td><%# Eval("Estado") %></td>
                <td>
                    <asp:Button runat="server" Text="Detalle Ticket" OnClick="BtnDetalleTicket_Click" CommandArgument='<%# Eval("Id") %>' CssClass="btn btn-info" />
                    <asp:Button runat="server" Text="Actualizar" OnClick="Actualizar_Click" CommandArgument='<%# Eval("Id") %>' CssClass="btn btn-warning" />
                    <asp:Button runat="server" Text="Eliminar" OnClick="Eliminar_Click" CommandArgument='<%# Eval("Id") %>' CssClass="btn btn-danger" />
                    <asp:Button runat="server" Text="Cambiar Estado" OnClick="CambiarEstado_Click" CommandArgument='<%# Eval("Id") %>' CssClass="btn btn-success" />
                </td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </tbody>
            </table>
        </FooterTemplate>
    </asp:Repeater>
</div>
</asp:Content>







