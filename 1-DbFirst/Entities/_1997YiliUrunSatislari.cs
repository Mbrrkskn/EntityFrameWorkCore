﻿using System;
using System.Collections.Generic;

namespace _1_DbFirst.Entities;

public partial class _1997YiliUrunSatislari
{
    public string KategoriAdi { get; set; } = null!;

    public string UrunAdi { get; set; } = null!;

    public decimal? Urunlerales { get; set; }
}
