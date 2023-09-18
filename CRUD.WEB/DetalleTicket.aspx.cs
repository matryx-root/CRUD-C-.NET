using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CRUD.BUSINESS;

namespace CRUD.WEB
{
    public partial class DetalleTicket : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["ticketId"] != null)
                {
                    int ticketId = Convert.ToInt32(Request.QueryString["ticketId"]);
                    Ticket ticket = TicketControlador.ObtenerTicketPorId(ticketId);

                    if (ticket != null && ticket.Cliente != null)
                    {
                        // Mostrar los controles si el ticket y ticket.Cliente son válidos
                        lblNombreCliente.Text = ticket.Cliente.Nombre;
                        lblRutCliente.Text = ticket.Cliente.Rut;
                        lblTelefono.Text = ticket.Cliente.Telefono;
                        lblEmail.Text = ticket.Cliente.Email;
                        lblNombreProducto.Text = ticket.Producto;
                        lblDescripcion.Text = ticket.Descripcion;
                    }
                    else
                    {
                        // Ocultar los controles si el ticket o ticket.Cliente son nulos
                        OcultarControles();
                    }
                }
                else
                {
                    // Ocultar los controles si no se proporciona un "ticketId" en la URL
                    OcultarControles();
                }
            }
        }

        private void OcultarControles()
        {
            // Este método oculta los controles cuando no se cumplen las condiciones.
            lblNombreCliente.Visible = false;
            lblRutCliente.Visible = false;
            lblTelefono.Visible = false;
            lblEmail.Visible = false;
            lblNombreProducto.Visible = false;
            lblDescripcion.Visible = false;
            // Puedes continuar ocultando otros controles según sea necesario.
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListarTickets.aspx");
        }
    }
}