using System;
using System.Collections.Generic;

namespace CatalogWebApi.Models;

public partial class QuotationItem
{
    public int Id { get; set; }

    public int? QuotationId { get; set; }

    public int? EndowmentId { get; set; }

    public int? SizeId { get; set; }

    public int? ColorId { get; set; }

    public int Quantity { get; set; }

    public string? ImageItemName { get; set; }

    public virtual Color? Color { get; set; }

    public virtual Endowment? Endowment { get; set; }

    public virtual Quotation? Quotation { get; set; }

    public virtual Size? Size { get; set; }
}
