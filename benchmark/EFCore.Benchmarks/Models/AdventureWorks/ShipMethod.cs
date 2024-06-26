// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;

namespace Microsoft.EntityFrameworkCore.Benchmarks.Models.AdventureWorks;

public class ShipMethod
{
    public ShipMethod()
    {
        PurchaseOrderHeader = new HashSet<PurchaseOrderHeader>();
        SalesOrderHeader = new HashSet<SalesOrderHeader>();
    }

    public int ShipMethodID { get; set; }
    public DateTime ModifiedDate { get; set; }
    public string Name { get; set; }
#pragma warning disable IDE1006 // Naming Styles
    public Guid rowguid { get; set; }
#pragma warning restore IDE1006 // Naming Styles
    public decimal ShipBase { get; set; }
    public decimal ShipRate { get; set; }

    public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeader { get; set; }
    public virtual ICollection<SalesOrderHeader> SalesOrderHeader { get; set; }
}
