﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DSS_SWP.Models;

public partial class WarrantyCertificate
{
    public long Id { get; set; }

    public long ProductId { get; set; }

    public string IssueDate { get; set; }

    public string ExpiryDate { get; set; }

    public int Status { get; set; }

    public virtual Product Product { get; set; }
}