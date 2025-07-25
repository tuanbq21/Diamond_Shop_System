﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DSS_SWP.Models;

public partial class Order
{
    public long Id { get; set; }

    public long CustomerId { get; set; }

    public string OrderDate { get; set; }

    public double TotalPrice { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    public string Address { get; set; }

    public string Phone { get; set; }

    public int Status { get; set; }

    public long? PaymentId { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual Payment Payment { get; set; }
}