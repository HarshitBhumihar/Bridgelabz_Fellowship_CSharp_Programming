using System;

namespace EmployeeWageApp
{
    public class EmployeeWage1
    {
        private double basicSalary;
        private double allowance;

        public EmployeeWage1(double basic, double allow)
        {
            basicSalary = basic;
            allowance = allow;
        }

        public double CalculatePF()
        {
            return basicSalary * 0.12;
        }

        public double CalculateGross()
        {
            return basicSalary + allowance;
        }

        public double CalculateNet()
        {
            double pf = CalculatePF();
            double gross = CalculateGross();
            return gross - pf;
        }

        public void DisplaySalary()
        {
            Console.WriteLine("\n--- Salary Details ---");
            Console.WriteLine("Basic Salary: " + basicSalary);
            Console.WriteLine("Allowance: " + allowance);
            Console.WriteLine("PF: " + CalculatePF());
            Console.WriteLine("Gross Salary: " + CalculateGross());
            Console.WriteLine("Net Salary: " + CalculateNet());
        }
    }
}