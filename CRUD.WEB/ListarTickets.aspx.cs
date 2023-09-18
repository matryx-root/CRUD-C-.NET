using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using CRUD.BUSINESS;

namespace CRUD.WEB
{
    public partial class ListarTickets : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarTickets();

                // Verifica si hay parámetros de búsqueda en la URL
                if (!string.IsNullOrEmpty(Request.QueryString["nombre"]) || !string.IsNullOrEmpty(Request.QueryString["rut"]))
                {
                    string nombre = Request.QueryString["nombre"];
                    string rut = Request.QueryString["rut"];

                    // Aplica los filtros de búsqueda
                    FiltrarTickets(nombre, rut);
                }
            }
        }

        protected void BtnDetalleTicket_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int ticketId = Convert.ToInt32(btn.CommandArgument);
            Response.Redirect($"DetalleTicket.aspx?ticketId={ticketId}");
        }

        protected void RbFiltroEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estadoSeleccionado = ddlFiltroEstado.SelectedValue;
            CargarTickets(estadoSeleccionado);
        }

        private void CargarTickets(string estadoSeleccionado = "")
        {
            var listaTickets = TicketControlador.ObtenerTodosLosTickets();

            if (!string.IsNullOrEmpty(estadoSeleccionado))
            {
                listaTickets = listaTickets.Where(t => t.Estado == estadoSeleccionado).ToList();
            }

            Repeater1.DataSource = listaTickets;
            Repeater1.DataBind();
        }

        protected void CambiarEstado_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            RepeaterItem item = (RepeaterItem)btn.NamingContainer;
            int ticketId = Convert.ToInt32(((Label)item.FindControl("lblTicketId")).Text);
            string estadoActual = ((Label)item.FindControl("lblEstado")).Text;

            // Cambia el estado al opuesto del estado actual
            string nuevoEstado = (estadoActual == "Habilitados") ? "Inhabilitados" : "Habilitados";
            TicketControlador.CambiarEstadoTicket(ticketId, nuevoEstado);

            CargarTickets();
        }










        protected void Actualizar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int ticketId = Convert.ToInt32(btn.CommandArgument);
            Response.Redirect($"ActualizarTicket.aspx?ticketId={ticketId}");
        }

        protected void Eliminar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int ticketId = Convert.ToInt32(btn.CommandArgument);
            TicketControlador.EliminarTicket(ticketId);
            CargarTickets();
        }

        protected void BtnFiltrar_Click(object sender, EventArgs e)
        {
            // Obtén el valor seleccionado del DropDownList
            string estadoSeleccionado = ddlFiltroEstado.SelectedValue;

            // Llama al método para cargar los tickets con el filtro aplicado
            CargarTickets(estadoSeleccionado);
        }

        private void FiltrarTickets(string nombre, string rut)
        {
            var listaTickets = TicketControlador.ObtenerTodosLosTickets();

            // Aplica los filtros si se proporcionan valores no nulos o vacíos
            if (!string.IsNullOrEmpty(nombre))
            {
                listaTickets = listaTickets.Where(t => t.Cliente.Nombre.Contains(nombre)).ToList();
            }

            if (!string.IsNullOrEmpty(rut))
            {
                listaTickets = listaTickets.Where(t => t.Cliente.Rut.Contains(rut)).ToList();
            }

            Repeater1.DataSource = listaTickets;
            Repeater1.DataBind();
        }
    }
}
