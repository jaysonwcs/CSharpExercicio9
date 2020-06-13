using CSharpExercicio9.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExercicio9.Entities
{
    class Order
    {
        public DateTime Time { get; private set; }
        public OrderStatus Status { get; private set; }
        public List<OrderItem> Items { get; private set; } = new List<OrderItem>();
        public Customer Customer { get; private set; }


        public Order(OrderStatus status, Customer customer)
        {
            Status = status;
            Customer = customer;
            Time = DateTime.Now;
        }


        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0.0;

            foreach (OrderItem item in Items)
            {
                total += item.SubTotal();
            }

            return total;
        }


        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("ORDER SUMMARY:");
            builder.AppendLine($"Order time: {Time.ToString("dd/MM/yyyy HH:mm:ss")}");
            builder.AppendLine($"Order status: {Status.ToString()}");
            builder.AppendLine(Customer.ToString());
            builder.AppendLine("Order items:");

            foreach (OrderItem item in Items)
            {
                builder.AppendLine(item.ToString());
            }

            builder.AppendLine($"Total price: ${Total()}");

            return builder.ToString();
        }
    }
}
