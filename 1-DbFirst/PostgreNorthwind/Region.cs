using System;
using System.Collections.Generic;

namespace _1_DbFirst.PostgreNorthwind;

public partial class Region
{
    public short RegionId { get; set; }

    public string RegionDescription { get; set; } = null!;

    public virtual ICollection<Territory> Territories { get; set; } = new List<Territory>();
}
