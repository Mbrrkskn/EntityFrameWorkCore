﻿using System;
using System.Collections.Generic;

namespace _1_DbFirst.Entities;

public partial class OzetCeyrekSatislar
{
    public DateTime? SevkTarihi { get; set; }

    public int SatisId { get; set; }

    public decimal? Subtotal { get; set; }
}