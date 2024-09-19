using System;
using System.Collections.Generic;

namespace _1_DbFirst.Entities;

public partial class OrtalamaMaliyetinUzerindekiUrunler
{
    public string UrunAdi { get; set; } = null!;

    public decimal? BirimFiyati { get; set; }
}
