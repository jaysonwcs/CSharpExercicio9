using CSharpExercicio9.Entities;
using CSharpExercicio9.Entities.Enums;
using System;
using System.Runtime.InteropServices;

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

            
            
            Console.WriteLine("Enter order data:");

            Console.WriteLine("Enter a status number:");
            Console.WriteLine("0 for PENDING_PAYMENT");
            Console.WriteLine("1 for PROCESSING");
            Console.WriteLine("2 for SHIPPED");
            Console.WriteLine("3 for DELIVERED");

            OrderStatus status = (OrderStatus)int.Parse(Console.ReadLine());


            Console.Write("How many items to this order? ");
            int itemsAmount = int.Parse(Console.ReadLine());


            Order order = new Order(status, customer);

            for (int i = 1; i <= itemsAmount; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");

                Console.Write("Product name: ");
                string productName = Console.ReadLine();

                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());


                Product product = new Product(productName, price);

                OrderItem item = new OrderItem(quantity, product);

                order.AddItem(item);
            }

            Console.WriteLine();


            Console.WriteLine(order.ToString());
        }
    }
}
