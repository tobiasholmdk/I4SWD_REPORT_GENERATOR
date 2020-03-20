using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ReportGenerator
{
    public interface IPrinter
    {
        public void Print(List<Employee> employees);
    }
}