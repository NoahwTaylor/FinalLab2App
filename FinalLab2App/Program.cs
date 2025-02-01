﻿// Fill a list with objects based on the supplied data file
using Lab2;

Lists.PopulateList(@"employees.txt");

// Calculate the average weekly pay for all employees
Calculations.CalculateAveragePay();

//Calculate the highest wrrkly pay for the wage employees, including the name of the employee
Calculations.CalculateHighestWage();

//Calculate the lowest salary for the salaried employees, including the name of the employee
Calculations.CalculateLowestSalary();

//Calculate the percentage of employees in each category
Calculations.PercentPerCategory();