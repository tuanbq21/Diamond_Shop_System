﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using DSS_SWP.Repositories;
using System;
using System.Collections.Generic;

namespace DSS_SWP.Models;

public partial class Product
{
    public long Id { get; set; }

    public string ProductCode { get; set; }

    public string ProductName { get; set; }

    public long MainDiamondId { get; set; }

    public string Image { get; set; }

    public long? ExtraDiamondId { get; set; }

    public long? NumberExDiamond { get; set; }

    public long? DiamondShellId { get; set; }

    public double? Size { get; set; }

    public double PriceRate { get; set; }

    public int Quantity { get; set; }

    public int Status { get; set; }

    public virtual DiamondShell DiamondShell { get; set; }

    public virtual ExtraDiamond ExtraDiamond { get; set; }

    public virtual MainDiamond MainDiamond { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual ICollection<WarrantyCertificate> WarrantyCertificates { get; set; } = new List<WarrantyCertificate>();

    public double TotalPrice
    {
        get
        {
            double? exDiamondPrice = ExtraDiamondId.HasValue ? GetExDiamondPrice(ExtraDiamondId.Value) * (NumberExDiamond ?? 0) : 0;
            double mainDiamondPrice = GetMainDiamondPrice(MainDiamondId);
            double? shellPrice = DiamondShellId.HasValue ? GetShellPrice(DiamondShellId.Value) : 0;
            return exDiamondPrice.GetValueOrDefault() + mainDiamondPrice + shellPrice.GetValueOrDefault();
        }
    }

    private double? GetExDiamondPrice(long id)
    {
        using var context = new DSS_CustomerContext();
        var extraDiamondRepo = new ExtraDiamondRepo();
        return extraDiamondRepo.GetByIdLong(id)?.Price;
    }

    private double GetMainDiamondPrice(long id)
    {
        using var context = new DSS_CustomerContext();
        var mainDiamondRepo = new MainDiamondRepo();
        var mainDiamond = mainDiamondRepo.GetByIdLong(id);
        return GetDiamondPrice(mainDiamond.Origin, mainDiamond.Cut, mainDiamond.CaraWeight, mainDiamond.Color) ?? 0;
    }

    private double? GetShellPrice(long id)
    {
        using var context = new DSS_CustomerContext();
        var diamondShellRepo = new DiamondShellRepo();
        var materialRepo = new MaterialRepo();
        var shell = diamondShellRepo.GetByIdLong(id);
        var materialPrice = materialRepo.GetByIdInt(shell.MaterialId ?? 1)?.Price ?? 0;
        return materialPrice * shell.Weight ?? 0;
    }

    private double? GetDiamondPrice(string origin, string cut, string caraWeight, string color)
    {
        using var context = new DSS_CustomerContext();
        var diamondPriceList = context.DiamondPriceLists
                                      .FirstOrDefault(d => d.Origin == origin
                                                        && d.Cut == cut
                                                        && d.CaraWeight == caraWeight
                                                        && d.Color == color);
        return diamondPriceList?.Price;
    }
}
