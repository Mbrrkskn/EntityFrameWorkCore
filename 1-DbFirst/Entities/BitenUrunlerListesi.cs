using System;
using System.Collections.Generic;

namespace _1_DbFirst.Entities;

public partial class BitenUrunlerListesi
{
    public int UrunId { get; set; }

    public string UrunAdi { get; set; } = null!;
}
