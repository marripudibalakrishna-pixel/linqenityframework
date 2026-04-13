using System;
using System.Collections.Generic;

namespace linqenityframework.NorthWind_Connect;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
