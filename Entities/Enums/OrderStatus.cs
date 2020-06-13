using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExercicio9.Entities.Enums
{
    enum OrderStatus : int
    {
        PENDING_PAYMENT,
        PROCESSING,
        SHIPPED,
        DELIVERED,
    }
}
