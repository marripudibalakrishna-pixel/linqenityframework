using System;
using System.Collections.Generic;

namespace linqenityframework.NorthWindDb_Connect;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
