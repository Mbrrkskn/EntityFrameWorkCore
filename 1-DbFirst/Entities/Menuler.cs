using System;
using System.Collections.Generic;

namespace _1_DbFirst.Entities;

public partial class Menuler
{
    public int Id { get; set; }

    public string? MenuAdi { get; set; }

    public short? SiraNo { get; set; }

    public int? UstMenuId { get; set; }
}
