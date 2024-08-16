﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace eBikeSystemDB.Entities;

public partial class PurchaseOrder
{
    [Key]
    [Column("PurchaseOrderID")]
    public int PurchaseOrderId { get; set; }

    public int PurchaseOrderNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OrderDate { get; set; }

    [Column(TypeName = "money")]
    public decimal TaxAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal SubTotal { get; set; }

    public bool Closed { get; set; }

    [StringLength(100)]
    public string Notes { get; set; }

    [Column("EmployeeID")]
    public int EmployeeId { get; set; }

    [Column("VendorID")]
    public int VendorId { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("PurchaseOrders")]
    public virtual Employee Employee { get; set; }

    [InverseProperty("PurchaseOrder")]
    public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; } = new List<PurchaseOrderDetail>();

    [InverseProperty("PurchaseOrder")]
    public virtual ICollection<ReceiveOrder> ReceiveOrders { get; set; } = new List<ReceiveOrder>();

    [ForeignKey("VendorId")]
    [InverseProperty("PurchaseOrders")]
    public virtual Vendor Vendor { get; set; }
}