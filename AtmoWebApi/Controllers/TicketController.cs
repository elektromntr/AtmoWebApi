using System.Threading.Tasks;
using DataAccess.Models;
using Logic.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AtmoWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
		private readonly ITicketService _ticketService;

		public TicketController(ITicketService ticketService)
		{
			_ticketService = ticketService;
		}

		[HttpGet("Tickets")]
		public async Task<IActionResult> GetTickets()
		{
			var result = await _ticketService.GetAll();
			return Ok(result);
		}

		[HttpPost("Create")]
		public async Task<IActionResult> Create([FromBody] Ticket ticket)
		{
			var result = await _ticketService.Create(ticket);
			return Ok(result);
		}
    }
}