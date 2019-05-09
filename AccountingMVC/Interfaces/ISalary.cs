using System;

namespace AccountingMVC.Interfaces
{
	public interface ISalary
    {
        decimal CalculateSalary(DateTime startDateTime, DateTime endDateTime);
    }
}
