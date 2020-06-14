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
            Customer customer = GetCustomerData();

            OrderStatus status = GetStatus();

            Order order = GetOrder(status, customer);

            Console.WriteLine();
            Console.WriteLine(order.ToString());
        }

        private static Order GetOrder(OrderStatus status, Customer customer)
        {
            Console.Write("How many items to this order? ");
            int itemsAmount = int.Parse(Console.ReadLine());


            Order order = new Order(status, customer);

            for (int i = 1; i <= itemsAmount; i++)
            {
                order.AddItem(GetItem(i));
            }

            return order;
        }

        private static OrderItem GetItem(int i)
        {
            Console.WriteLine($"Enter #{i} item data:");

            Console.Write("Product name: ");
            string productName = Console.ReadLine();

            Console.Write("Product price: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());


            Product product = new Product(productName, price);

            return new OrderItem(quantity, product);
        }

        private static OrderStatus GetStatus()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Enter order data:");
            Console.WriteLine();
            Console.WriteLine("Enter a status:");
            Console.WriteLine("0 for PENDING_PAYMENT");
            Console.WriteLine("1 for PROCESSING");
            Console.WriteLine("2 for SHIPPED");
            Console.WriteLine("3 for DELIVERED");
            Console.Write("Type the status number here: ");

            return (OrderStatus)int.Parse(Console.ReadLine());
        }

        static Customer GetCustomerData()
        {
            Console.WriteLine("Enter customer data:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("E-mail: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            return new Customer(name, email, birthDate);
        }

    }
}
