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
        public List<OrderItem> Items { get; private set; }
        public Customer Customer { get; private set; }


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
    }
}
