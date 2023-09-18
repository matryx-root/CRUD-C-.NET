using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CRUD.BUSINESS
{
    public class Ticket
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public string Producto { get; set; }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        // private DateTime CreatedAt { get; set; } = DateTime.Now;


        // Constructor que acepta los argumentos necesarios
        public Ticket(Cliente cliente, string producto, string descripcion, string estado)
        {
            this.Cliente = cliente;
            this.Producto = producto;
            this.Descripcion = descripcion;
            this.Estado = estado;
        }
    }
}
