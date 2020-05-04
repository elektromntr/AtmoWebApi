using DataAccess.Migrations;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Configuration
{
	public class AtmoContext : DbContext
	{
		public AtmoContext(DbContextOptions<AtmoContext> options) : base(options) { }
		
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.DoSeed();
		}

		public DbSet<Ticket> Tickets { get; set; }
		public DbSet<TicketLog> TicketLogs { get; set; }
	}
}
