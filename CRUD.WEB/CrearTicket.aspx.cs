using System;
using System.Drawing;
using System.Net.Sockets;
using System.Web.Services.Description;
using System.Web.UI;
using CRUD.BUSINESS;

namespace CRUD.WEB
{
    public partial class CrearTicket : Page
    {
        // Declara una variable de clase para mantener el ticket actual
        private Ticket ticketActual;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LimpiarControles();
            }
        }



        protected void BtnCrearTicket_Click(object sender, EventArgs e)
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
