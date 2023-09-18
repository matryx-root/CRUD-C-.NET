using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD.WEB
{
    public partial class BusquedaAvanzada : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Configura los controles DropDownList
                ddlFiltros.SelectedValue = ""; // Seleccionar la opción por defecto
            }

            // Comprueba si hay un filtro en la URL y aplica la búsqueda
            string filtro = Request.QueryString["filtro"];
            if (!string.IsNullOrEmpty(filtro))
            {
                // Aplica el filtro en la búsqueda
                AplicarFiltro(filtro);
            }
        }

        protected void btnBuscarAvanzada_Click(object sender, EventArgs e)
        {
            // Obtiene el filtro seleccionado y el valor de búsqueda
            string filtro = ddlFiltros.SelectedValue;
            string busqueda = txtBusquedaAvanzada.Text.Trim();

            // Redirige a la página de ListarTickets.aspx con el filtro en la URL
            Response.Redirect($"~/ListarTickets.aspx?filtro={HttpUtility.UrlEncode(filtro)}&busqueda={HttpUtility.UrlEncode(busqueda)}");
        }

        private void AplicarFiltro(string filtro)
        {
            // Aquí puedes implementar la lógica para aplicar el filtro y cargar los resultados en gvResultados
            // Por ejemplo, puedes llamar a una función que filtre los datos en base al filtro y luego enlazar los resultados al GridView.
            // Asegúrate de manejar casos donde no se encuentren resultados.
            // Puedes mostrar un mensaje de error en lblMensajeError si no se encuentran resultados.
        }
    }
}