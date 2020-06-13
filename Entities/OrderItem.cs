using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExercicio9.Entities
{
    class OrderItem
    {
        public int Quantity { get; private set; }
        public double Price { get; private set; }
        public Product Product { get; private set; }


        public double SubTotal()
        {
            return Quantity * Price;
        }


        public override string ToString()
        {
            return $"{Product.Name}, ${Price}, Quantity: {Quantity}, Subtotal: ${SubTotal()}";
        }
    }
}
