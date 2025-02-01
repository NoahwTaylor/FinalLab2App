using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Employee
    {
        public string Id { get; set; } // creating accessor for ID
        public string Name { get; set; } // creating accessor for name
        public string Address { get; set; } // creating accessor for address
        public string PhoneNumber { get; set; } // creating accessor for phone number
        public long Sin { get; set; } // creating accessor for SIN
        public string Birthday { get; set; } // creating accessor for birthday
        public string Department { get; set; } // creating accessor for employee category

        public Employee(string id, string name, string address, string phoneNumber, long sin, string birthday, string department)
        {
            Id = id;
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            Sin = sin;
            Birthday = birthday;
            Department = department;
        }
        public virtual double CalculateWeeklyPay()
        {
            return 0;
        }
    }
}
