using System;
using System.Collections.Generic;

namespace CatalogWebApi.Models;

public partial class Color
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<QuotationItem> QuotationItems { get; set; } = new List<QuotationItem>();
}
