using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DataAccess.Migrations
{
	public static class ModelBuilderExtensions
	{
		public static void DoSeed(this ModelBuilder modelBuilder)
		{
			var tickets = new List<Ticket>();

			for (var i = 1; i < 15; i++)
			{
				tickets.Add(
					new Models.Ticket
					{
						Id = i,
						CreationDate = DateTime.Now.AddDays(-i),
						Content = $"Test Ticket number {i}",
						Archived = false,
						EditDate = null,
					});

				var z = 15+i;
				tickets.Add(
					new Models.Ticket
					{
						Id = z,
						CreationDate = DateTime.Now.AddMonths(-i),
						Content = $"Test archived Ticket number {i}",
						Archived = true,
						EditDate = null,
					});
			}
			modelBuilder.Entity<Ticket>().HasData(new Ticket
			{
				Id = 69,
				Archived = false,
				Content = "69",
				CreationDate = DateTime.Now,
				EditDate = null,
			});
			modelBuilder.Entity<Ticket>().HasData(tickets);
		}
	}
}
