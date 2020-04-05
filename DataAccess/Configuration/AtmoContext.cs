using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Configuration
{
	public class AtmoContext : DbContext
	{
		public AtmoContext(DbContextOptions<AtmoContext> options) : base(options) { }

		public DbSet<Ticket> Tickets { get; set; }
	}
}
