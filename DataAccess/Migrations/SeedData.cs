using DataAccess.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace DataAccess.Migrations
{
	public static class SeedData
	{
		public static void DoSeed(IApplicationBuilder app)
		{
			using (var serviceScope = app.ApplicationServices.CreateScope())
			{
				var context = serviceScope.ServiceProvider.GetService<AtmoContext>();

				context.Database.Migrate();
				if (!context.Tickets.Any())
				{
					for (var i = 0; i < 15; i++)
					{
						context.Tickets.Add(
							new Models.Ticket
							{
								CreationDate = DateTime.Now.AddDays(-i),
								Content = $"Test Ticket number {i + 1}"
							});

						context.Tickets.Add(
							new Models.Ticket
							{
								CreationDate = DateTime.Now.AddMonths(-i),
								Content = $"Test archived Ticket number {i + 1}",
								Archived = true,
							});
					}
					context.SaveChanges();
				}
			}
		}
	}
}
