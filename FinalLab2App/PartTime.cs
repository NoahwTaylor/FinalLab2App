using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class PartTime : Employee
    {
        public double Rate { get; set; } // creating accessor for rate
        public double Hours { get; set; } // creating accessor for hours
        public PartTime(string id, string name, string address, string phoneNumber, long sin, string birthday, string department, double rate, double hours) : base(id, name, address, phoneNumber, sin, birthday, department)
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
            if (Hours > 40)
            {
                weeklyPay = Rate * 40 + ((Hours - 40) * (Rate * 1.5)); // calculate weekly pay for part time employee in overtime
            }
            else
            {
                weeklyPay = Rate * Hours; // calculate weekly pay for part time employee
            }
            return weeklyPay;
        }
    }
}
