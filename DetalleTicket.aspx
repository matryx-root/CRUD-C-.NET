<%@ Page Title="" Language="C#" MasterPageFile="~/MPSitio.Master" AutoEventWireup="true" CodeBehind="DetalleTicket.aspx.cs" Inherits="CRUD.WEB.DetalleTicket" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="container">
        <h1 class="mt-4">Detalle de Ticket</h1>

        <div class="row mt-4">
            <div class="col-md-6">
                <div class="form-group">
                    <label for="lblNombreCliente">Nombre del Cliente:</label>
                    <asp:Label runat="server" ID="lblNombreCliente" CssClass="form-control" Text=""></asp:Label>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <label for="lblDescripcion">Descripción:</label>
                    <asp:Label runat="server" ID="lblDescripcion" CssClass="form-control" Text=""></asp:Label>
                </div>
            </div>
        </div>

        <!-- Agrega más detalles del ticket aquí usando el mismo formato -->

        <div class="row mt-4">
            <div class="col-md-12">
                <asp:Button runat="server" ID="btnVolver" Text="Volver al Listado de Tickets" OnClick="btnVolver_Click" CssClass="btn btn-primary" />
            </div>
        </div>
    </div>
</asp:Content>


