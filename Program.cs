using CSharpExercicio9.Entities;
using System;

namespace CSharpExercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter customer data:");
            
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("E-mail: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Customer customer = new Customer(name, email, birthDate);

            Console.WriteLine(customer.ToString());
        }
    }
}
