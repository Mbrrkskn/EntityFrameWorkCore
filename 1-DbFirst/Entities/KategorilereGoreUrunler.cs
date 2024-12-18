﻿using System;
using System.Collections.Generic;

namespace _1_DbFirst.Entities;

public partial class KategorilereGoreUrunler
{
    public string KategoriAdi { get; set; } = null!;

    public string UrunAdi { get; set; } = null!;

    public string? BirimdekiMiktar { get; set; }

    public short? HedefStokDuzeyi { get; set; }

    public bool Sonlandi { get; set; }
}
