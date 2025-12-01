using System;
using System.Collections.Generic;

namespace CatalogWebApi.Models;

public partial class Endowment
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int EndowmentTypeId { get; set; }

    public int EndowmentCategoryId { get; set; }

    public virtual Category EndowmentCategory { get; set; } = null!;

    public virtual EndowmentType EndowmentType { get; set; } = null!;

    public virtual ICollection<QuotationItem> QuotationItems { get; set; } = new List<QuotationItem>();

    public virtual ICollection<Image> Images { get; set; } = new List<Image>();
}
