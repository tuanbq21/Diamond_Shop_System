﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DSS_SWP.Models;

public partial class Payment
{
    public long Id { get; set; }

    public string PaymentMethod { get; set; }

    public string DateTime { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}