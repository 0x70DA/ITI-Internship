using System;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array of 3 Employess.
            Employee[] employees = new Employee[3];

            // Read all the data from the user.
            EnterData(employees);

            // Sort employees based on hire date.
            Array.Sort(employees);

            // Print the array.
            Console.WriteLine("---------------------------");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
                Console.WriteLine();
            }

        }
        static void EnterData(Employee[] employees)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                // Call the constructor for every element in the array.
                employees[i] = new Employee();

                Console.WriteLine($"Enter data for employee number {i + 1} >>");
                Console.Write("Enter ID: ");
                employees[i].ID = int.Parse(Console.ReadLine());
                // employees[i].SetID(int.Parse(Console.ReadLine()));
                
                Console.Write("Enter Salray: ");
                employees[i].Salary = int.Parse(Console.ReadLine());
                //employees[i].SetSalary(int.Parse(Console.ReadLine()));

                employees[i].HD = EnterDate();
                //employees[i].SetHireDate(EnterDate());

                Console.Write("Enter Gender(M/F): ");
                employees[i].Gender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine(), true);
                //employees[i].SetGender((Gender)Enum.Parse(typeof(Gender), Console.ReadLine(), true));
            }
        }
        static HireDate EnterDate()
        {
            Console.WriteLine("Enter the Hire date>>");
            HireDate hire = new HireDate();
            Console.Write("Day: ");
            hire.Day = byte.Parse(Console.ReadLine());
            //hire.SetDay(byte.Parse(Console.ReadLine()));

            Console.Write("Month: ");
            hire.Month = byte.Parse(Console.ReadLine());
            //hire.SetMonth(byte.Parse(Console.ReadLine()));

            Console.Write("Year: ");
            hire.Year = short.Parse(Console.ReadLine());
            //hire.SetYear(short.Parse(Console.ReadLine()));
            return hire;
        }
    }
}
