using System;
using System.Collections.Generic;

namespace CourseraWEB3.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string CutomerName { get; set; } = null!;

    public double? CutomerAmount { get; set; }

    public string? City { get; set; }
}
