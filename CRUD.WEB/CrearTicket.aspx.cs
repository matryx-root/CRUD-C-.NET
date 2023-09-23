using System;
using System.Drawing;
using System.Net.Sockets;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using CRUD.BUSINESS;


namespace CRUD.WEB
{
    public partial class CrearTicket : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LimpiarControles();
            }
        }

        protected void ValidateNombreCliente(object source, ServerValidateEventArgs args)
        {
            // Realiza la validación del largo del nombre del cliente
            string nombreCliente = txtNombreCliente.Text;
            args.IsValid = !string.IsNullOrEmpty(nombreCliente) && nombreCliente.Length >= 5;
        }

        protected void ValidateNombreProducto(object source, ServerValidateEventArgs args)
        {
            // Realiza la validación del largo del nombre del producto
            string nombreProducto = txtNombreProducto.Text;
            args.IsValid = !string.IsNullOrEmpty(nombreProducto) && nombreProducto.Length >= 10;
        }

        protected void ValidateDescripcionProducto(object source, ServerValidateEventArgs args)
        {
            // Realiza la validación del largo de la descripción del producto
            string descripcionProducto = txtDescripcion.Text;
            args.IsValid = !string.IsNullOrEmpty(descripcionProducto) && descripcionProducto.Length >= 10;
        }

        protected void BtnCrearTicket_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string nombreCliente = txtNombreCliente.Text;
                string rutCliente = txtRutCliente.Text;
                string telefono = txtTelefono.Text;
                string email = txtEmail.Text;
                string descripcion = txtDescripcion.Text;
                string tipoCliente = ddlTipoCliente.SelectedValue;

                if (string.IsNullOrEmpty(nombreCliente) || string.IsNullOrEmpty(descripcion) || string.IsNullOrEmpty(tipoCliente))
                {
                    lblMensaje.Text = "Por favor, complete todos los campos obligatorios.";
                    lblMensaje.CssClass = "error-message";
                    lblMensaje.Visible = true;
                }
                else
                {
                    Cliente cliente = null;

                    if (tipoCliente == "PersonaNatural")
                    {
                        cliente = new PersonaNatural
                        {
                            Nombre = nombreCliente,
                            Rut = rutCliente,
                            Telefono = telefono,
                            Email = email
                        };
                    }
                    else if (tipoCliente == "Empresa")
                    {
                        cliente = new Empresa
                        {
                            Nombre = nombreCliente,
                            Rut = rutCliente,
                            Telefono = telefono,
                            Email = email,
                            RazonSocial = "Razón Social de la Empresa"
                        };
                    }

                    Ticket ticket = new Ticket(cliente, txtNombreProducto.Text, descripcion, "Abierto");
                    // Grabar el ticket actual
                    TicketControlador.AgregarTicket(ticket);

                    Response.Redirect("ListarTickets.aspx");
                    LimpiarControles();
                }
            }
        }

        private void LimpiarControles()
        {
            txtNombreCliente.Text = string.Empty;
            txtRutCliente.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtNombreProducto.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            ddlTipoCliente.SelectedIndex = 0;
        }
    }
}

