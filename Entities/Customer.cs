using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExercicio9.Entities
{
    class Customer
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }


        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append(Name);
            builder.Append(" (" + BirthDate.ToString("dd/MM/yyyy") + ") - ");
            builder.Append(Email);

            return builder.ToString();
        }
    }
}
