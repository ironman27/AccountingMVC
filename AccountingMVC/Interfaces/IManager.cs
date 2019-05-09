using System.Collections.Generic;

namespace AccountingMVC.Interfaces
{
	public interface IManager:IEmployeeBase
    {
		ICollection<IEmployee> EmployeeList { get; }
    }
}
