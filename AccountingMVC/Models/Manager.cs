using AccountingMVC.Interfaces;
using AccountingMVC.Models;
using System.Collections.Generic;

namespace AccountingMVC.Models
{
	public class Manager : EmployeeBase, IManager
    {
		public ICollection<IEmployee> EmployeeList { get; }

		public Manager()
		{
			EmployeeList = new List<IEmployee>();
		}
	}
}
