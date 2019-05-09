using System.Collections.Generic;

namespace AccountingMVC.Interfaces
{
	public interface IEmployeeBase
    {
		string Name { get; set; }
        decimal SalaryPerHour { get; set; }

		ICollection<ITimeLog> TimeLogList { get; }
    }
}
