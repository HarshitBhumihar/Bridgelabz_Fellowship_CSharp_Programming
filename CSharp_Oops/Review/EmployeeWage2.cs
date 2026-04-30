using System;

namespace Review
{
    internal class EmployeeWage2
    {
        
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        const int EMP_RATE_PER_HOUR = 20;
        const int MAX_WORKING_DAYS = 20;
        const int MAX_WORKING_HOURS = 100;

        
        private int totalEmpHrs = 0;
        private int totalWorkingDays = 0;
        private int totalSalary = 0;

        Random random = new Random();

        public void CalculateWage()
        {
            while (totalEmpHrs < MAX_WORKING_HOURS && totalWorkingDays < MAX_WORKING_DAYS)
            {
                totalWorkingDays++;

                int empCheck = random.Next(0, 3); 
                int empHrs = 0;

                
                if (empCheck == IS_FULL_TIME)
                {
                    empHrs = 8;
                    Console.WriteLine($"Day {totalWorkingDays}: Full Time");
                }
                else if (empCheck == IS_PART_TIME)
                {
                    empHrs = 4;
                    Console.WriteLine($"Day {totalWorkingDays}: Part Time");
                }
                else
                {
                    empHrs = 0;
                    Console.WriteLine($"Day {totalWorkingDays}: Absent");
                }

                totalEmpHrs += empHrs;

                int dailyWage = empHrs * EMP_RATE_PER_HOUR;
                totalSalary += dailyWage;

                Console.WriteLine($"Hours: {empHrs}, Daily Wage: {dailyWage}");
                Console.WriteLine("--------------------------------");
            }

            Console.WriteLine($"Total Working Days: {totalWorkingDays}");
            Console.WriteLine($"Total Hours Worked: {totalEmpHrs}");
            Console.WriteLine($"Total Salary: {totalSalary}");
        }
    }
}