using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
	public class Ticket : BaseClass
	{
		public string Content { get; set; }
		public bool Archived { get; set; }
	}
}
