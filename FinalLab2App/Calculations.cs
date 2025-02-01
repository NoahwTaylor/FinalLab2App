using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public static class Calculations
    {

        public static void CalculateAveragePay() // Calculate the average weekly pay for all employees
        {
            double totalPay = 0; // Initialize the total pay to 0
            double averagePay;

            foreach (Employee employee in Lists.employees) // Loop through all employees in master list
            {
                totalPay += employee.CalculateWeeklyPay(); // Add the weekly pay of each employee to the total pay
            }
            averagePay = totalPay / Lists.employees.Count;
            Console.WriteLine($"The average weekly pay among all employees is {averagePay.ToString("c")}");

        }

        public static void CalculateHighestWage() // Find the wages employee with the highest weekly pay
        {
            double highestWage = Int32.MinValue; // Initialize the highest wage to the lowest possible value
            string highestPaid = "";

            foreach (Wages employee in Lists.wages) // Loop through all wages employees
            {
                if (employee.CalculateWeeklyPay() > highestWage) // If the employee's weekly pay is higher than the current highest wage
                {
                    highestWage = employee.CalculateWeeklyPay(); // Set the highest wage to the employee's weekly pay
                    highestPaid = employee.Name;
                }
            }
            Console.WriteLine($"The highest paid wage employee is {highestPaid} at {highestWage.ToString("c")} per week!");
        }

        public static void CalculateLowestSalary() // Find the salaried employee with the lowest yearly salary
        {
            double lowestSalary = Int32.MaxValue; // Initialize the lowest salary to the highest possible value
            string lowestPaid = "";

            foreach (Salaried employee in Lists.salarieds) // Loop through all salaried employees
            {
                if (employee.Salary < lowestSalary) // If the employee's salary is lower than the current lowest salary
                {
                    lowestSalary = employee.Salary; // Set the lowest salary to the employee's salary
                    lowestPaid = employee.Name;
                }

            }
            Console.WriteLine($"The lowest paid salary worker is {lowestPaid} at {lowestSalary.ToString("c")} per year!");
        }

        public static void PercentPerCategory()// Calculate what percentage of the company’s employees fall into each employee category
        {
            decimal wagePercentage = Convert.ToDecimal(Lists.wages.Count) / Convert.ToDecimal(Lists.employees.Count); // Divide the number of wage employees by the total number of employees
            decimal salariedPercentage = Convert.ToDecimal(Lists.salarieds.Count) / Convert.ToDecimal(Lists.employees.Count); // Divide the number of salaried employees by the total number of employees
            decimal partTimePercentage = Convert.ToDecimal(Lists.partTimes.Count) / Convert.ToDecimal(Lists.employees.Count); // Divide the number of part time employees by the total number of employees

            Console.WriteLine($"The percentage of employees in the wage category is {wagePercentage.ToString("p")}");
            Console.WriteLine($"The percentage of employees in the salaried category is {salariedPercentage.ToString("p")}");
            Console.WriteLine($"The percentage of employees in the part time category {partTimePercentage.ToString("p")}");
        }
    }
}
