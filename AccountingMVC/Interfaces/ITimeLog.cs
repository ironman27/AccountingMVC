using System;

namespace AccountingMVC.Interfaces
{
	public interface ITimeLog
    {
        DateTime DateTime { get; set; }
        int Hours { get; set; }
    }
}
