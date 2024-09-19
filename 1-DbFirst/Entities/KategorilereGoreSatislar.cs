using System;
using System.Collections.Generic;

namespace _1_DbFirst.Entities;

public partial class KategorilereGoreSatislar
{
    public int KategoriId { get; set; }

    public string KategoriAdi { get; set; } = null!;

    public string UrunAdi { get; set; } = null!;

    public decimal? Urunlerales { get; set; }
}
