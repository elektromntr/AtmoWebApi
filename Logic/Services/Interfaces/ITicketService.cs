using DataAccess.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Services.Interfaces
{
    public interface ITicketService
    {
		/// <summary>
		/// Get all not archived Tickets from database
		/// </summary>
		/// <returns>List of not archived tickets</returns>
		Task<IList<Ticket>> GetAll();
		/// <summary>
		/// Create Ticket in database
		/// </summary>
		/// <param name="ticket">Entity of Ticket to create</param>
		/// <returns>Created Ticket</returns>
		Task<Ticket> Create(Ticket ticket);
		/// <summary>
		/// Update Ticket in database
		/// </summary>
		/// <param name="ticket">Ticket to update</param>
		/// <returns>Updated Ticket</returns>
		Task<Ticket> Update(Ticket ticket);
    }
}
