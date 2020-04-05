using DataAccess.Models;
using DataAccess.Repository;
using Logic.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logic.Services
{
	public class TicketService : ITicketService
	{
		private readonly IRepository<Ticket> _ticketRepository;

		public TicketService(IRepository<Ticket> ticketRepository)
		{
			_ticketRepository = ticketRepository;
		}

		public async Task<IList<Ticket>> GetAll() => await _ticketRepository.GetAll().Where(t => !t.Archived).ToListAsync();

		public async Task<Ticket> Create(Ticket ticket) => await _ticketRepository.Add(ticket);

		public async Task<Ticket> Update(Ticket ticket) => await _ticketRepository.Update(ticket);
	}
}
