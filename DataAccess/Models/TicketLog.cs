using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
	/// <summary>
	/// Record of history of Ticket lifecycle
	/// </summary>
	public class TicketLog : BaseClass
	{
		/// <summary>
		/// Action that been made on Ticket
		/// </summary>
		public string Action { get; set; }
		/// <summary>
		/// Content that goes with the action
		/// </summary>
		public string Content { get; set; }
		public Ticket Ticket { get; set; }
		/// <summary>
		/// Id of the parent Ticket 
		/// </summary>
		public int TicketId { get; set; }
	}
}
