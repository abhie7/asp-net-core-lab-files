using System;
using System.Collections.Generic;

namespace DatabaseFirstApproach.Models;

public partial class Emp
{
    public int EmpId { get; set; }

    public string EmpName { get; set; } = null!;

    public int EmpSal { get; set; }
}
