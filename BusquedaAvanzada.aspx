<%@ Page Title="" Language="C#" MasterPageFile="~/MPSitio.Master" AutoEventWireup="true" CodeBehind="BusquedaAvanzada.aspx.cs" Inherits="CRUD.WEB.BusquedaAvanzada" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Contenido de la página de búsqueda avanzada -->
    <h1>Búsqueda Avanzada</h1>
    <div>
        <asp:Label ID="lblFiltro" runat="server" Text="Criterio de Búsqueda Avanzada:" AssociatedControlID="ddlFiltros" />
        <asp:DropDownList ID="ddlFiltros" runat="server">
            <asp:ListItem Text="Seleccionar" Value="" />
            <asp:ListItem Text="Opción 1" Value="Opcion1" />
            <asp:ListItem Text="Opción 2" Value="Opcion2" />
            <!-- Agrega más opciones según tus necesidades -->
        </asp:DropDownList>
        <asp:TextBox ID="txtBusquedaAvanzada" runat="server" />
        <asp:Button ID="btnBuscarAvanzada" runat="server" Text="Buscar" OnClick="btnBuscarAvanzada_Click" />
    </div>

    <asp:GridView ID="gvResultados" runat="server" AutoGenerateColumns="true">
        <!-- Define las columnas que deseas mostrar en la grilla -->
    </asp:GridView>

    <asp:Label ID="lblMensajeError" runat="server" ForeColor="Red" Visible="false"></asp:Label>
</asp:Content>
