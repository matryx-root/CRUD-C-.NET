using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD.WEB
{
    public partial class MPSitio : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de búsqueda
            string nombre = txtBusquedaNombre.Text;
            string rut = txtBusquedaRut.Text;

            // Redireccionar a la página de listado de tickets con los parámetros de búsqueda
            Response.Redirect($"~/ListarTickets.aspx?nombre={nombre}&rut={rut}");
        }







    }
}