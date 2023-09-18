using System;
using System.Collections.Generic;
using System.Linq;

namespace CRUD.BUSINESS
{
    public static class TicketControlador
    {
        private static List<Ticket> Tickets { get; set; }
        private static int LastTicketId { get; set; } = 0;

        // Constructor estático para inicializar la lista en el arranque de la aplicación
        static TicketControlador()
        {
            Tickets = new List<Ticket>();
        }

        public static List<Ticket> ObtenerTodosLosTickets()
        {
            // Retorna la lista de todos los tickets
            return Tickets;
        }

        public static List<Ticket> ObtenerTicketsPorEstado(string estado)
        {
            // Filtra la lista de tickets por estado y devuelve los que coinciden
            return Tickets.Where(t => t.Estado == estado).ToList();
        }

        public static Ticket ObtenerTicketPorId(int ticketId)
        {
            // Buscar un ticket por su ID
            return Tickets.FirstOrDefault(t => t.Id == ticketId);
        }

        public static List<Ticket> BuscarTicketsPorCriterio(string criterio)
        {
            // Filtra la lista de tickets según el criterio (aquí debes implementar tu lógica real)
            criterio = criterio.ToLower();
            return Tickets
                .Where(ticket =>
                    ticket.Cliente.Nombre.ToLower().Contains(criterio) ||
                    ticket.Descripcion.ToLower().Contains(criterio))
                .ToList();
        }

        public static void AgregarTicket(Ticket ticket)
        {
            // Asignar un nuevo ID único al ticket
            ticket.Id = ++LastTicketId;

            // Agregar el ticket a la lista
            Tickets.Add(ticket);
        }

        public static void ActualizarTicket(Ticket ticket)
        {
            // Actualizar un ticket existente
            var ticketExistente = Tickets.FirstOrDefault(t => t.Id == ticket.Id);
            if (ticketExistente != null)
            {
                // Actualiza los valores del ticket existente con los del nuevo ticket
                ticketExistente.Cliente = ticket.Cliente;
                ticketExistente.Producto = ticket.Producto;
                ticketExistente.Descripcion = ticket.Descripcion;
                ticketExistente.Estado = ticket.Estado;
            }
        }

        public static void EliminarTicket(int ticketId)
        {
            // Elimina un ticket por su ID
            var ticketExistente = Tickets.FirstOrDefault(t => t.Id == ticketId);
            if (ticketExistente != null)
            {
                Tickets.Remove(ticketExistente);
            }
        }

        public static bool InhabilitarTicket(int ticketId)
        {
            // Encuentra el ticket por su ID
            Ticket ticketExistente = Tickets.FirstOrDefault(t => t.Id == ticketId);

            if (ticketExistente != null)
            {
                // Verifica si el ticket ya está inhabilitado para evitar cambios innecesarios
                if (ticketExistente.Estado != "Inhabilitado")
                {
                    ticketExistente.Estado = "Inhabilitado";
                    return true; // Devuelve true cuando se inhabilita el ticket con éxito
                }
                else
                {
                    return false; // Devuelve false si el ticket ya estaba inhabilitado
                }
            }
            else
            {
                return false; // Devuelve false si no se encontró el ticket por ID
            }
        }

        public static void CambiarEstadoTicket(int ticketId, string nuevoEstado)
        {
            // Encuentra el ticket por su ID
            Ticket ticketExistente = Tickets.FirstOrDefault(t => t.Id == ticketId);

            if (ticketExistente != null)
            {
                ticketExistente.Estado = nuevoEstado;
            }
        }
    }
}


