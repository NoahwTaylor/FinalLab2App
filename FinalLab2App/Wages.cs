using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Wages : Employee
    {
        public double Rate { get; set; } // creating accessor for rate
        public double Hours { get; set; } // creating accessor for hours
        public Wages(string id, string name, string address, string phoneNumber, long sin, string birthday, string department, double rate, double hours) : base(id, name, address, phoneNumber, sin, birthday, department)
        {
            Id = id;
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            Sin = sin;
            Birthday = birthday;
            Department = department;
            Rate = rate;
            Hours = hours;
        }

        double weeklyPay; // variable to store weekly pay
        public override double CalculateWeeklyPay() // method to calculate weekly pay of part time employee
        {
            weeklyPay = Rate * Hours; // calculate weekly pay for part time employee
            return weeklyPay;
        }
    }
}
