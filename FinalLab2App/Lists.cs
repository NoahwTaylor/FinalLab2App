using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public static class Lists
    {

        public static List<Employee> employees = new List<Employee>(); // Master list of all employees
        public static List<Wages> wages = new List<Wages>(); // List of all wage employees
        public static List<Salaried> salarieds = new List<Salaried>(); // List of all salaried employees
        public static List<PartTime> partTimes = new List<PartTime>(); // List of all part time employees
        public static void PopulateList(string filePath) // Populate the lists with employees from the data file
        {
            StreamReader data = new StreamReader(filePath); // Open the data file
            while (!data.EndOfStream) // Loop through the file until the end
            {
                string[] rawData = data.ReadLine().Split(':'); // Split the line into an array of strings

                for (int i = 0; i < 5; i++) // If employee ID is between 0-4 inclusive, they are Salaried
                {
                    if (rawData[0].StartsWith(i.ToString())) // If the employee ID starts with the current number, create a Salaried object
                    {
                        Salaried employee = new Salaried(rawData[0], rawData[1], rawData[2], rawData[3], long.Parse(rawData[4]), rawData[5], rawData[6], double.Parse(rawData[7]));
                        employees.Add(employee);
                        salarieds.Add(employee);
                    }
                }

                for (int i = 5; i < 8; i++) // If employee ID is between 5-7 inclusive, they are Wages
                {
                    if (rawData[0].StartsWith(i.ToString())) // If the employee ID starts with the current number, create a Wages object
                    {
                        Wages employee = new Wages(rawData[0], rawData[1], rawData[2], rawData[3], long.Parse(rawData[4]), rawData[5], rawData[6], double.Parse(rawData[7]), double.Parse(rawData[8]));
                        employees.Add(employee); // Add the employee to the master list
                        wages.Add(employee); // Add the employee to the wages list
                    }
                }

                for (int i = 8; i < 10; i++) // If employee ID is 8 or 9, they are Part Time
                {
                    if (rawData[0].StartsWith(i.ToString())) // If the employee ID starts with the current number, create a PartTime object
                    {
                        PartTime employee = new PartTime(rawData[0], rawData[1], rawData[2], rawData[3], long.Parse(rawData[4]), rawData[5], rawData[6], double.Parse(rawData[7]), double.Parse(rawData[8]));
                        employees.Add(employee); // Add the employee to the master list
                        partTimes.Add(employee); // Add the employee to the part time list
                    }
                }
            }
            data.Close();
        }
    }
}
