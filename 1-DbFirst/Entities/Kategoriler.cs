using System;
using System.Collections.Generic;

namespace _1_DbFirst.Entities;

public partial class Kategoriler
{
    public int KategoriId { get; set; }

    public string KategoriAdi { get; set; } = null!;

    public string? Tanimi { get; set; }

    public byte[]? Resim { get; set; }

    public virtual ICollection<Urunler> Urunlers { get; set; } = new List<Urunler>();
}
