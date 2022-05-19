using System;

namespace ConsoleApp2
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
            }
        }
        static void EnterData(Employee[] employees)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"Enter data for employee number {i + 1} >>");
                Console.Write("Enter ID: ");
                employees[i].SetID(int.Parse(Console.ReadLine()));
                Console.Write("Enter Salray: ");
                employees[i].SetSalary(int.Parse(Console.ReadLine()));

                employees[i].SetHireDate(EnterDate());

                Console.Write("Enter Gender(M/F): ");
                //employees[i].SetGender((Gender)Convert.ToChar(Console.ReadLine()));
                employees[i].SetGender((Gender)Enum.Parse(typeof(Gender), Console.ReadLine(), true));
            }
        }
        static HireDate EnterDate()
        {
            Console.WriteLine("Enter the Hire date>>");
            HireDate hire = new HireDate();
            Console.Write("Day: ");
            hire.SetDay(byte.Parse(Console.ReadLine()));
            Console.Write("Month: ");
            hire.SetMonth(byte.Parse(Console.ReadLine()));
            Console.Write("Year: ");
            hire.SetYear(short.Parse(Console.ReadLine()));
            return hire;
        }
    }
}
