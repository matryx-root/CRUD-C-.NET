<%@ Page Title="" Language="C#" MasterPageFile="~/MPSitio.Master" AutoEventWireup="true" CodeBehind="ActualizarTicket.aspx.cs" Inherits="CRUD.WEB.ActualizarTicket" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="container mt-5">
        <div class="row justify-content-center">
            <div class="col-md-6">
                <h1>Actualizar Ticket</h1>
                <asp:Label runat="server" ID="lblMensaje" CssClass="message" Visible="false"></asp:Label>


                <asp:Label runat="server" ID="Label1" CssClass="message" Visible="false"></asp:Label>

                <!-- Agrega los controles para editar los campos del ticket existente -->
                <div class="form-group">
                    <asp:Label runat="server" Text="Nombre del Cliente:" AssociatedControlID="txtNombreCliente" />
                    <asp:TextBox runat="server" ID="txtNombreCliente" CssClass="form-control" />
                    <asp:RequiredFieldValidator runat="server" ID="rfvNombreCliente" ControlToValidate="txtNombreCliente"
                        InitialValue="" ErrorMessage="El nombre es obligatorio" Display="Dynamic" ForeColor="Red" ValidationGroup="vgActualizarTicket" />
                </div>

                <div class="form-group">
                    <asp:Label runat="server" Text="RUT del Cliente:" AssociatedControlID="txtRutCliente" />
                    <asp:TextBox runat="server" ID="txtRutCliente" CssClass="form-control" />
                    <asp:RequiredFieldValidator runat="server" ID="rfvRutCliente" ControlToValidate="txtRutCliente"
                        InitialValue="" ErrorMessage="El RUT es obligatorio" Display="Dynamic" ForeColor="Red" ValidationGroup="vgActualizarTicket" />
                    <asp:RegularExpressionValidator runat="server" ID="revRutCliente" ControlToValidate="txtRutCliente"
                        ValidationExpression="^(\d{8,9}-[\dkK])$" ErrorMessage="Formato de RUT inválido" Display="Dynamic"
                        ForeColor="Red" ValidationGroup="vgActualizarTicket" />
                </div>






                
                <div class="form-group">
                    <asp:Label runat="server" Text="Número Telefónico:" AssociatedControlID="txtTelefono" />
                    <asp:TextBox runat="server" ID="txtTelefono" CssClass="form-control" />
                    <asp:RequiredFieldValidator runat="server" ID="rfvTelefono" ControlToValidate="txtTelefono"
                        InitialValue="" ErrorMessage="El número telefónico es obligatorio" Display="Dynamic" ForeColor="Red"
                        ValidationGroup="vgActualizarTicket" />
                </div>

                <div class="form-group">
                    <asp:Label runat="server" Text="Email del Cliente:" AssociatedControlID="txtEmail" />
                    <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" />
                    <asp:RequiredFieldValidator runat="server" ID="rfvEmail" ControlToValidate="txtEmail"
                        InitialValue="" ErrorMessage="El email es obligatorio" Display="Dynamic" ForeColor="Red" ValidationGroup="vgActualizarTicket" />
                    <asp:RegularExpressionValidator runat="server" ID="revEmail" ControlToValidate="txtEmail"
                        ValidationExpression="^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$" ErrorMessage="Formato de email inválido" Display="Dynamic"
                        ForeColor="Red" ValidationGroup="vgActualizarTicket" />
                </div>

                <div class="form-group">
                    <asp:Label runat="server" Text="Nombre del Producto:" AssociatedControlID="txtNombreProducto" />
                    <asp:TextBox runat="server" ID="txtNombreProducto" CssClass="form-control" />
                    <asp:RequiredFieldValidator runat="server" ID="rfvNombreProducto" ControlToValidate="txtNombreProducto"
                        InitialValue="" ErrorMessage="El nombre del producto es obligatorio" Display="Dynamic" ForeColor="Red"
                        ValidationGroup="vgActualizarTicket" />
                    <asp:RegularExpressionValidator runat="server" ID="revNombreProducto" ControlToValidate="txtNombreProducto"
                        ValidationExpression="^.{10,}$" ErrorMessage="El nombre del producto debe tener al menos 10 caracteres de largo" Display="Dynamic"
                        ForeColor="Red" ValidationGroup="vgActualizarTicket" />
                </div>

                <div class="form-group">
                    <asp:Label runat="server" Text="Descripción del Ticket:" AssociatedControlID="txtDescripcion" />
                    <asp:TextBox runat="server" ID="txtDescripcion" TextMode="MultiLine" Rows="4" CssClass="form-control" />
                    <asp:RequiredFieldValidator runat="server" ID="rfvDescripcion" ControlToValidate="txtDescripcion"
                        InitialValue="" ErrorMessage="La descripción es obligatoria" Display="Dynamic" ForeColor="Red" ValidationGroup="vgActualizarTicket" />
                    <asp:RegularExpressionValidator runat="server" ID="revDescripcion" ControlToValidate="txtDescripcion"
                        ValidationExpression="^.{10,}$" ErrorMessage="La descripción debe tener al menos 10 caracteres de largo" Display="Dynamic"
                        ForeColor="Red" ValidationGroup="vgActualizarTicket" />
                </div>

                <div class="form-group">
                    <asp:Label runat="server" Text="Tipo de Cliente:" AssociatedControlID="ddlTipoCliente" />
                    <asp:DropDownList runat="server" ID="ddlTipoCliente" CssClass="form-control">
                        <asp:ListItem Text="Seleccionar" Value="" Disabled="true"></asp:ListItem>
                        <asp:ListItem Text="Persona Natural" Value="PersonaNatural"></asp:ListItem>
                        <asp:ListItem Text="Empresa" Value="Empresa"></asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator runat="server" ID="rfvTipoCliente" ControlToValidate="ddlTipoCliente"
                        InitialValue="" ErrorMessage="Seleccione un tipo de cliente" Display="Dynamic" ForeColor="Red"
                        ValidationGroup="vgActualizarTicket" />
                </div>

                <asp:ValidationSummary runat="server" ID="vsActualizarTicket" ForeColor="Red" ValidationGroup="vgActualizarTicket" />

                <asp:Button runat="server" ID="btnActualizarTicket" Text="Actualizar Ticket" OnClick="BtnActualizarTicket_Click"
                    CssClass="btn btn-primary" ValidationGroup="vgActualizarTicket" />
            </div>
        </div>
    </div>

    <script src="Scripts/zoom.js"></script>
    <script src="Scripts/zoom-manager.js"></script>
</asp:Content>
