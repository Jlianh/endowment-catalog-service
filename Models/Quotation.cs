using System;
using System.Collections.Generic;

namespace CatalogWebApi.Models;

public partial class Quotation
{
    public int Id { get; set; }

    public string ClientName { get; set; } = null!;

    public string? ClientCompany { get; set; }

    public string ClientEmail { get; set; } = null!;

    public string ClientAddress { get; set; } = null!;

    public string ClientPhone { get; set; } = null!;

    public DateOnly CreatedAt { get; set; }

    public virtual ICollection<QuotationItem> QuotationItems { get; set; } = new List<QuotationItem>();
}
