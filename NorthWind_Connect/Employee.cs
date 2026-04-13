using System;
using System.Collections.Generic;

namespace linqenityframework.NorthWindDb_Connect;

public partial class Employee
{
    public int EmpId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string City { get; set; } = null!;
}
