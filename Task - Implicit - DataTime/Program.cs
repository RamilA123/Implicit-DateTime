using System;
using Task___Implicit___DataTime.Models;
using Task___Implicit___DataTime.Models.Temperatures;

namespace Task___Implicit___DataTime
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Task 1 - Convert Temperatures

            //Console.Write("Celcius degree = ");

            //double degreeC = double.Parse(Console.ReadLine());

            //Celcius celcius1 = new Celcius(degreeC);

            //Kelvin kelvin1 = celcius1;

            //Console.WriteLine("Kelvin degree = " + kelvin1.Degree_K);

            #endregion

            EmployeeList employees = new EmployeeList();

            employees.AddBirthday(new Employee { Birthday = "09/04/2022"});
            employees.AddBirthday(new Employee { Birthday = "02/04/2022"});
            employees.AddBirthday(new Employee { Birthday = "08/04/2022"});
            employees.AddBirthday(new Employee { Birthday = "01/04/2023"});
            employees.AddBirthday(new Employee { Birthday = "05/04/2022"});
            employees.AddBirthday(new Employee { Birthday = "06/04/2023"});
            
            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now.AddMonths(2);
            double salary = 2500;
            
            employees.CountOfEmployees(start, end, salary);
        }
    }

    public class EmployeeList
    {
        private Employee[] _employees;

        public EmployeeList()
        {
            _employees = new Employee[0];
        }

        public void AddBirthday(Employee date)
        {
            Array.Resize(ref _employees, _employees.Length + 1);
            _employees[_employees.Length - 1] = date;
        }

        public int CountOfEmployees(DateTime start, DateTime end, double salary)
        {
            int count = 0;

            for (int i = 0; i < _employees.Length; i++)
            {
                if ((employees[_employees - 1] > start && _employees[_employees - 1]) && salary > 2000)
                    count++;
            }
            return count;


        }
    }
}
