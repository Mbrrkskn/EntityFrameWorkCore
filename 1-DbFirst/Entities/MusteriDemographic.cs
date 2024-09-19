using System;
using System.Collections.Generic;

namespace _1_DbFirst.Entities;

public partial class MusteriDemographic
{
    public string MusteriTypeId { get; set; } = null!;

    public string? MusteriDesc { get; set; }

    public virtual ICollection<Musteriler> Musteris { get; set; } = new List<Musteriler>();
}
