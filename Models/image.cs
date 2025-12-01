using System;
using System.Collections.Generic;

namespace CatalogWebApi.Models;

public partial class Image
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Url { get; set; } = null!;

    public virtual ICollection<Endowment> Endowments { get; set; } = new List<Endowment>();
}
