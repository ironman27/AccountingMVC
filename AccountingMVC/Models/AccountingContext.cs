using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AccountingMVC.Models
{
	public class AccountingDBContext:DbContext
	{
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Manager> Managers { get; set; }
		public DbSet<TimeLog> TimeLogs { get; set; }
	}
}