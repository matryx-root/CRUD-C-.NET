using CRUD.BUSINESS;
using System;
using System.Web.UI;

namespace CRUD.WEB
{
    public partial class ActualizarTicket : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["ticketId"] != null)
                {
                    // Obtén el ID del ticket que deseas actualizar desde la URL
                    int ticketId;
                    if (int.TryParse(Request.QueryString["ticketId"], out ticketId))
                    {
                        try
                        {
                            // Lógica para cargar los detalles del ticket a actualizar
                            Ticket ticket = TicketControlador.ObtenerTicketPorId(ticketId);

                            if (ticket != null)
                            {
                                // Llena los controles con los detalles del ticket
                                txtNombreCliente.Text = ticket.Cliente.Nombre;
                                txtRutCliente.Text = ticket.Cliente.Rut;
                                txtTelefono.Text = ticket.Cliente.Telefono;
                                txtEmail.Text = ticket.Cliente.Email;

                                // Asigna el valor del campo "Nombre del Producto"
                                txtNombreProducto.Text = ticket.Producto;

                                txtDescripcion.Text = ticket.Descripcion;
                                ddlTipoCliente.SelectedValue = ticket.Cliente is PersonaNatural ? "PersonaNatural" : "Empresa";
                            }
                            else
                            {
                                // Maneja el caso en el que el ticket no se encuentra
                                lblMensaje.Text = "El ticket no se encontró. Puede que haya sido eliminado.";
                                lblMensaje.CssClass = "message-error";
                                lblMensaje.Visible = true;
                            }
                        }
                        catch (Exception ex)
                        {
                            // Maneja errores de obtención de datos
                            lblMensaje.Text = "Error al cargar los detalles del ticket: " + ex.Message;
                            lblMensaje.CssClass = "message-error";
                            lblMensaje.Visible = true;
                        }
                    }
                    else
                    {
                        // Maneja el caso en el que el ID de ticket no es válido
                        lblMensaje.Text = "El ID del ticket no es válido.";
                        lblMensaje.CssClass = "message-error";
                        lblMensaje.Visible = true;
                    }
                }
                else
                {
                    // Maneja el caso en el que no se proporciona un ID de ticket
                    lblMensaje.Text = "No se proporcionó un ID de ticket válido.";
                    lblMensaje.CssClass = "message-error";
                    lblMensaje.Visible = true;
                }
            }
        }

        protected void BtnActualizarTicket_Click(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString["ticketId"] != null)
                {
                    // Obtén el ID del ticket que deseas actualizar desde la URL
                    int ticketId;
                    if (int.TryParse(Request.QueryString["ticketId"], out ticketId))
                    {
                        // Lógica para actualizar el ticket
                        Ticket ticket = TicketControlador.ObtenerTicketPorId(ticketId);

                        if (ticket != null)
                        {
                            // Actualiza los valores del ticket con los datos del formulario
                            ticket.Cliente.Nombre = txtNombreCliente.Text;
                            ticket.Cliente.Rut = txtRutCliente.Text;
                            ticket.Cliente.Telefono = txtTelefono.Text;
                            ticket.Cliente.Email = txtEmail.Text;

                            // Asigna el valor del campo "Nombre del Producto"
                            ticket.Producto = txtNombreProducto.Text;

                            ticket.Descripcion = txtDescripcion.Text;
                            string tipoCliente = ddlTipoCliente.SelectedValue;

                            // Actualiza el tipo de cliente según la selección
                            if (tipoCliente == "PersonaNatural")
                            {
                                if (!(ticket.Cliente is PersonaNatural))
                                {
                                    // Si el cliente anteriormente no era una persona natural, crea una nueva instancia
                                    ticket.Cliente = new PersonaNatural();
                                }
                            }
                            else if (tipoCliente == "Empresa")
                            {
                                if (!(ticket.Cliente is Empresa))
                                {
                                    // Si el cliente anteriormente no era una empresa, crea una nueva instancia
                                    ticket.Cliente = new Empresa();
                                }
                            }

                            try
                            {
                                // Lógica para guardar el ticket actualizado en TicketControlador
                                TicketControlador.ActualizarTicket(ticket);

                                // Redirige a la página de listar tickets o muestra un mensaje de éxito
                                Response.Redirect("ListarTickets.aspx?mensaje=El+ticket+fue+actualizado+con+éxito");
                            }
                            catch (Exception ex)
                            {
                                // Maneja errores al actualizar el ticket
                                lblMensaje.Text = "Error al actualizar el ticket: " + ex.Message;
                                lblMensaje.CssClass = "message-error";
                                lblMensaje.Visible = true;
                            }
                        }
                        else
                        {
                            // Maneja el caso en el que el ticket no se encuentra
                            lblMensaje.Text = "El ticket no se encontró. Puede que haya sido eliminado.";
                            lblMensaje.CssClass = "message-error";
                            lblMensaje.Visible = true;
                        }
                    }
                    else
                    {
                        // Maneja el caso en el que el ID de ticket no es válido
                        lblMensaje.Text = "El ID del ticket no es válido.";
                        lblMensaje.CssClass = "message-error";
                        lblMensaje.Visible = true;
                    }
                }
                else
                {
                    // Maneja el caso en el que no se proporciona un ID de ticket
                    lblMensaje.Text = "No se proporcionó un ID de ticket válido.";
                    lblMensaje.CssClass = "message-error";
                    lblMensaje.Visible = true;
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores generales
                lblMensaje.Text = "Error general al actualizar el ticket: " + ex.Message;
                lblMensaje.CssClass = "message-error";
                lblMensaje.Visible = true;
            }
        }
    }
}
