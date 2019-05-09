using System;

namespace AccountingMVC.Models
{
    public class TimeLog
    {
		public int Id { get; set; }
		public DateTime DateTime { get; set; }
        public int Hours { get; set; }
		public int? EmployeeBaseId { get; set; }
	}
}
