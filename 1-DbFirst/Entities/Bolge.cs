using System;
using System.Collections.Generic;

namespace _1_DbFirst.Entities;

public partial class Bolge
{
    public int BolgeId { get; set; }

    public string BolgeTanimi { get; set; } = null!;

    public virtual ICollection<Bolgeler> Bolgelers { get; set; } = new List<Bolgeler>();
}
