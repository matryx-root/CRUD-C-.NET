<%@ Page Title="" Language="C#" MasterPageFile="~/MPSitio.Master" AutoEventWireup="true" CodeBehind="ActualizarTicket.aspx.cs" Inherits="CRUD.WEB.ActualizarTicket" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="container mt-5">
        <div class="row justify-content-center">
            <div class="col-md-6">
                <h1>Actualizar Ticket</h1>
                <asp:Label runat="server" ID="lblMensaje" CssClass="message" Visible="false"></asp:Label>

                <!-- Agrega los controles para editar los campos del ticket existente -->
                <div class="form-group">
                    <asp:Label runat="server" Text="Nombre del Cliente:" AssociatedControlID="txtNombreCliente" />
                    <asp:TextBox runat="server" ID="txtNombreCliente" CssClass="form-control" />
                </div>

                <div class="form-group">
                    <asp:Label runat="server" Text="RUT del Cliente:" AssociatedControlID="txtRutCliente" />
                    <asp:TextBox runat="server" ID="txtRutCliente" CssClass="form-control" />
                </div>

                <div class="form-group">
                    <asp:Label runat="server" Text="Número Telefónico:" AssociatedControlID="txtTelefono" />
                    <asp:TextBox runat="server" ID="txtTelefono" CssClass="form-control" />
                </div>

                <div class="form-group">
                    <asp:Label runat="server" Text="Email del Cliente:" AssociatedControlID="txtEmail" />
                    <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" />
                </div>

                <div class="form-group">
                    <asp:Label runat="server" Text="Nombre del Producto:" AssociatedControlID="txtNombreProducto" />
                    <asp:TextBox runat="server" ID="txtNombreProducto" CssClass="form-control" />
                </div>

                <div class="form-group">
                    <asp:Label runat="server" Text="Descripción del Ticket:" AssociatedControlID="txtDescripcion" />
                    <asp:TextBox runat="server" ID="txtDescripcion" TextMode="MultiLine" Rows="4" CssClass="form-control" />
                </div>

                <div class="form-group">
                    <asp:Label runat="server" Text="Tipo de Cliente:" AssociatedControlID="ddlTipoCliente" />
                    <asp:DropDownList runat="server" ID="ddlTipoCliente" CssClass="form-control">
                        <asp:ListItem Text="Seleccionar" Value="" Disabled="true"></asp:ListItem>
                        <asp:ListItem Text="Persona Natural" Value="PersonaNatural"></asp:ListItem>
                        <asp:ListItem Text="Empresa" Value="Empresa"></asp:ListItem>
                    </asp:DropDownList>
                </div>

                <asp:ValidationSummary runat="server" ID="vsActualizarTicket" ForeColor="Red" ValidationGroup="vgActualizarTicket" />

                <asp:Button runat="server" ID="btnActualizarTicket" Text="Actualizar Ticket" OnClick="BtnActualizarTicket_Click" CssClass="btn btn-primary" ValidationGroup="vgActualizarTicket" />
            </div>
        </div>
    </div>
</asp:Content>
