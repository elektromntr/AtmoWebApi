using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
	public class Ticket : BaseClass
	{
		/// <summary>
		/// Content of the Ticket
		/// </summary>
		public string Content { get; set; }
		/// <summary>
		/// Describes if Ticket is archived
		/// </summary>
		public bool Archived { get; set; }
		/// <summary>
		/// History of the Ticket in logs
		/// </summary>
		public virtual IList<TicketLog> TicketLogs { get; set; }
	}
}
