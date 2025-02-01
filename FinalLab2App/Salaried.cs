using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Salaried : Employee // Salaried inherits from Employee
    {

        public double Salary { get; set; } // creating accessor for salary
        public Salaried(string id, string name, string address, string phoneNumber, long sin, string birthday, string department, double salary) : base(id, name, address, phoneNumber, sin, birthday, department)
        {
            Id = id;
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            Sin = sin;
            Birthday = birthday;
            Department = department;
            Salary = salary;
        }

        double weeklyPay; // variable to store weekly pay
        public override double CalculateWeeklyPay() // method to calculate weekly pay of salaried employee
        {
            weeklyPay = Salary / 52; // calculate weekly pay for salaried employee
            return weeklyPay;
        }

    }
}
