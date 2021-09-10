using System;

namespace ConsoleSampleproject
{
    public struct Employee
    {
        public int age;
        public String name;
        public bool isEmployee;

    }
    class Program
    {
        static void Main(string[] args)
        {
            //int age = 27;
            //String name = "Dipti";
            //bool isEmployee = true;
            
            Employee emp;

            emp.age = 27;
            emp.name = "Dipti Mohanty";
            emp.isEmployee = false;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(emp.name + " is " + emp.age + " years old");
            Console.WriteLine("Is she an employee of Dell?" + (emp.isEmployee ? "Yes" : "No"));
        }
    }
}
