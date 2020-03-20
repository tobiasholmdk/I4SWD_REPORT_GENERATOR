using System;
using System.Collections.Generic;

namespace ReportGenerator
{
    public class NameFirst : IPrinter
    {
        public void Print(List<Employee> employees)
        {
            Console.WriteLine("Name-first report");
            foreach (var e in employees)
            {
                Console.WriteLine("------------------");
                Console.WriteLine("Name: {0}", e.Name);
                Console.WriteLine("Salary: {0}", e.Salary);
                Console.WriteLine("------------------");
            }
        }
    }
}