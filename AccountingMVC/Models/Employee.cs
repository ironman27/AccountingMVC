using AccountingMVC.Interfaces;

namespace AccountingMVC.Models
{
    public class Employee : EmployeeBase, IEmployee
    {
		public int? ManagerId { get; set; }
		public Manager Manager { get; set; }
	}
}