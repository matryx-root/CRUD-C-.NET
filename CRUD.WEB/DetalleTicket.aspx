<%@ Page Title="" Language="C#" MasterPageFile="~/MPSitio.Master" AutoEventWireup="true" CodeBehind="DetalleTicket.aspx.cs" Inherits="CRUD.WEB.DetalleTicket" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div class="container mt-5">
        <div class="row justify-content-center">
            <div class="col-md-6">
                <h1>Detalle de Ticket</h1>
                <asp:Label runat="server" ID="lblMensaje" CssClass="message" Visible="false"></asp:Label>
                <div class="form-group">
                    <label for="lblNombreCliente">Nombre del Cliente:</label>
                    <asp:Label runat="server" ID="lblNombreCliente" CssClass="form-control" Text=""></asp:Label>
                </div>
                <div class="form-group">
                    <label for="lblRutCliente">RUT del Cliente:</label>
                    <asp:Label runat="server" ID="lblRutCliente" CssClass="form-control" Text=""></asp:Label>
                </div>
                <div class="form-group">
                    <label for="lblTelefono">Número Telefónico:</label>
                    <asp:Label runat="server" ID="lblTelefono" CssClass="form-control" Text=""></asp:Label>
                </div>
                <div class="form-group">
                    <label for="lblEmail">Email del Cliente:</label>
                    <asp:Label runat="server" ID="lblEmail" CssClass="form-control" Text=""></asp:Label>
                </div>
                <div class="form-group">
                    <label for="lblNombreProducto">Nombre del Producto:</label>
                    <asp:Label runat="server" ID="lblNombreProducto" CssClass="form-control" Text=""></asp:Label>
                </div>
                <div class="form-group">
                    <label for="lblDescripcion">Descripción del Ticket:</label>
                    <asp:Label runat="server" ID="lblDescripcion" TextMode="MultiLine" Rows="4" CssClass="form-control" Text=""></asp:Label>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" Text="Tipo de Cliente:" AssociatedControlID="ddlTipoCliente" />
                    <asp:DropDownList runat="server" ID="ddlTipoCliente" CssClass="form-control">
                        <asp:ListItem Text="Seleccionar" Value="" Disabled="true"></asp:ListItem>
                        <asp:ListItem Text="Persona Natural" Value="PersonaNatural"></asp:ListItem>
                        <asp:ListItem Text="Empresa" Value="Empresa"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="row mt-4">
                    <div class="col-md-12">
                        <asp:Button runat="server" ID="btnVolver" Text="Volver al Listado de Tickets" OnClick="btnVolver_Click" CssClass="btn btn-primary" />
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script src="Scripts/zoom.js"></script>
    <script src="Scripts/zoom-manager.js"></script>
</asp:Content>


