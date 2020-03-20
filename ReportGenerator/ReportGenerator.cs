using System;
using System.Collections.Generic;

namespace ReportGenerator
{
    internal class ReportGenerator
    {
        private readonly EmployeeDB _employeeDb;

        private IPrinter p = new SalaryFirst();
        
        public ReportGenerator(EmployeeDB employeeDb)
        {
            if (employeeDb == null) throw new ArgumentNullException("employeeDb");
            _employeeDb = employeeDb;
        }


        public void CompileReport(IPrinter printer)
        {
            var employees = new List<Employee>();
            Employee employee;
            
            _employeeDb.Reset();

            // Get all employees
            while ((employee = _employeeDb.GetNextEmployee()) != null)
            {
                employees.Add(employee);
            }
            printer.Print(employees);
        }
    }
}