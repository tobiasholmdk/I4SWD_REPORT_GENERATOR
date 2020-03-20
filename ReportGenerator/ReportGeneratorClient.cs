using System;

namespace ReportGenerator
{
    internal class ReportGeneratorClient
    {
        private static void Main()
        {
            var db = new EmployeeDB();

            // Add some employees
            db.AddEmployee(new Employee("Anne", 3000));
            db.AddEmployee(new Employee("Berit", 2000));
            db.AddEmployee(new Employee("Christel", 1000));

            var reportGenerator = new ReportGenerator(db);

            // Create a default (name-first) report
            IPrinter nameprinter = new NameFirst();
            reportGenerator.CompileReport(nameprinter);

            Console.WriteLine("");
            Console.WriteLine("");
            
            // Create a salary-first report
            IPrinter salprinter = new SalaryFirst();
            reportGenerator.CompileReport(salprinter);
        }
    }
}