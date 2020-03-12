﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Testability
{
    class ShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f;

            return 0;
        }
    }
}
