<%@ Page Title="" Language="C#" MasterPageFile="~/MPSitio.Master" AutoEventWireup="true" CodeBehind="ListarTickets.aspx.cs" Inherits="CRUD.WEB.ListarTickets" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



<div class="table-responsive">
    
   
    
        <div class="col-md-4 offset-md-4 text-center">

             <h1>Listar Tickets</h1>


            <div class="form-group">
                <asp:DropDownList ID="ddlFiltroEstado" runat="server" CssClass="form-control">
                    <asp:ListItem Text="Todos" Value="" />
                    <asp:ListItem Text="Habilitados" Value="Habilitados" />
                    <asp:ListItem Text="Inhabilitados" Value="Inhabilitados" />
                </asp:DropDownList>
            </div>
                <div>
                     <asp:Button ID="Button1" runat="server" Text="Filtrar" OnClick="BtnFiltrar_Click" CssClass="btn btn-primary" />
            </div>
        </div>
   
    
</div>
    <br />


   








     <br />

<div class="table-responsive">
    <asp:Repeater runat="server" ID="Repeater1">
        <HeaderTemplate>
            <table class="table table-striped">
                <thead>
                    <tr>
                        <th>ID TICKET</th>
                        <th>Nombre del Cliente</th>
                        <th>RUT del Cliente</th>
                        <th>Número Telefónico</th>
                        <th>Email del Cliente</th>
                        <th>Nombre del Producto</th>
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
                <td><%# Eval("Producto") %></td>
                <td><%# Eval("Descripcion") %></td>
                <td><asp:Label runat="server" ID="lblEstado" Text='<%# Eval("Estado") %>' /></td>
                <td><asp:Label runat="server" ID="lblTicketId" Text='<%# Eval("Id") %>' Visible="false" /></td>
                <td>
                <div class="btn-group btn-group-horizontal">
    <asp:Button runat="server" Text="Detalle Ticket" OnClick="BtnDetalleTicket_Click" CommandArgument='<%# Eval("Id") %>' CssClass="btn btn-info" />
    <asp:Button runat="server" Text="Actualizar" OnClick="Actualizar_Click" CommandArgument='<%# Eval("Id") %>' CssClass="btn btn-warning" />
    <asp:Button runat="server" Text="Eliminar" OnClick="Eliminar_Click" CommandArgument='<%# Eval("Id") %>' CssClass="btn btn-danger" />
    <asp:Button runat="server" Text="Cambiar Estado" OnClick="CambiarEstado_Click" CommandArgument='<%# Eval("Id") %>' CssClass="btn btn-success" />
</div>
                    </td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </tbody>
            </table>
        </FooterTemplate>
    </asp:Repeater>
</div>
    <script src="Scripts/crear-ticket-modal.js"></script>
    <script src="Scripts/zoom.js"></script>
    <script src="Scripts/zoom-manager.js"></script>
</asp:Content>







