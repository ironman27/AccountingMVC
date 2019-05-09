using System;
using System.Collections.Generic;
using AccountingMVC.Interfaces;

namespace AccountingMVC.Models
{
	public abstract class EmployeeBase: IEmployeeBase
    {
		public int Id { get; set; }
		public string Name { get; set; }
		public decimal SalaryPerHour { get; set; }
		public ICollection<ITimeLog> TimeLogList { get; }

		public EmployeeBase()
		{
			TimeLogList = new List<ITimeLog>();
		}
	}
}
