using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace _1_DbFirst.Entities;

public partial class NorthwindContext : DbContext
{
    public NorthwindContext()
    {
    }

    public NorthwindContext(DbContextOptions<NorthwindContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AlfabetikSiraliUrunlerListesi> AlfabetikSiraliUrunlerListesis { get; set; }

    public virtual DbSet<AlphabeticalListOfProduct> AlphabeticalListOfProducts { get; set; }

    public virtual DbSet<AyrintiliSatisDetaylari> AyrintiliSatisDetaylaris { get; set; }

    public virtual DbSet<BitenUrunlerListesi> BitenUrunlerListesis { get; set; }

    public virtual DbSet<Bolge> Bolges { get; set; }

    public virtual DbSet<Bolgeler> Bolgelers { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<CurrentProductList> CurrentProductLists { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerAndSuppliersByCity> CustomerAndSuppliersByCities { get; set; }

    public virtual DbSet<CustomerDemographic> CustomerDemographics { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Faturalar> Faturalars { get; set; }

    public virtual DbSet<HerUcAylikSatislar> HerUcAylikSatislars { get; set; }

    public virtual DbSet<Kategoriler> Kategorilers { get; set; }

    public virtual DbSet<KategorilereGore1997YiliSatislari> KategorilereGore1997YiliSatislaris { get; set; }

    public virtual DbSet<KategorilereGoreSatislar> KategorilereGoreSatislars { get; set; }

    public virtual DbSet<KategorilereGoreUrunler> KategorilereGoreUrunlers { get; set; }

    public virtual DbSet<Menuler> Menulers { get; set; }

    public virtual DbSet<MusteriDemographic> MusteriDemographics { get; set; }

    public virtual DbSet<Musteriler> Musterilers { get; set; }

    public virtual DbSet<Nakliyeciler> Nakliyecilers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrdersQry> OrdersQries { get; set; }

    public virtual DbSet<OrtalamaMaliyetinUzerindekiUrunler> OrtalamaMaliyetinUzerindekiUrunlers { get; set; }

    public virtual DbSet<OzetCeyrekSatislar> OzetCeyrekSatislars { get; set; }

    public virtual DbSet<OzetYillikSatislar> OzetYillikSatislars { get; set; }

    public virtual DbSet<Personeller> Personellers { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductsAboveAveragePrice> ProductsAboveAveragePrices { get; set; }

    public virtual DbSet<ProductsByCategory> ProductsByCategories { get; set; }

    public virtual DbSet<QuarterlyOrder> QuarterlyOrders { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<SatisAltToplamlari> SatisAltToplamlaris { get; set; }

    public virtual DbSet<SatisDetaylari> SatisDetaylaris { get; set; }

    public virtual DbSet<Satislar> Satislars { get; set; }

    public virtual DbSet<SatislarSorgusu> SatislarSorgusus { get; set; }

    public virtual DbSet<SatislarinToplamMiktari> SatislarinToplamMiktaris { get; set; }

    public virtual DbSet<SehirlereGoreMusteriVeTedarikciler> SehirlereGoreMusteriVeTedarikcilers { get; set; }

    public virtual DbSet<Shipper> Shippers { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<Tedarikciler> Tedarikcilers { get; set; }

    public virtual DbSet<Territory> Territories { get; set; }

    public virtual DbSet<Urunler> Urunlers { get; set; }

    public virtual DbSet<_1997YiliUrunSatislari> _1997YiliUrunSatislaris { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=.;Database=Northwind;Trusted_Connection=true;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AlfabetikSiraliUrunlerListesi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Alfabetik Sirali Urunler Listesi");

            entity.Property(e => e.BirimFiyati).HasColumnType("money");
            entity.Property(e => e.BirimdekiMiktar).HasMaxLength(20);
            entity.Property(e => e.KategoriAdi).HasMaxLength(15);
            entity.Property(e => e.KategoriId).HasColumnName("KategoriID");
            entity.Property(e => e.TedarikciId).HasColumnName("TedarikciID");
            entity.Property(e => e.UrunAdi).HasMaxLength(40);
            entity.Property(e => e.UrunId).HasColumnName("UrunID");
        });

        modelBuilder.Entity<AlphabeticalListOfProduct>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Alphabetical list of products");

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CategoryName).HasMaxLength(15);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ProductName).HasMaxLength(40);
            entity.Property(e => e.QuantityPerUnit).HasMaxLength(20);
            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            entity.Property(e => e.UnitPrice).HasColumnType("money");
        });

        modelBuilder.Entity<AyrintiliSatisDetaylari>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Ayrintili Satis Detaylari");

            entity.Property(e => e.BirimFiyati).HasColumnType("money");
            entity.Property(e => e.ExtendedPrice).HasColumnType("money");
            entity.Property(e => e.SatisId).HasColumnName("SatisID");
            entity.Property(e => e.UrunAdi).HasMaxLength(40);
            entity.Property(e => e.UrunId).HasColumnName("UrunID");
        });

        modelBuilder.Entity<BitenUrunlerListesi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Biten Urunler Listesi");

            entity.Property(e => e.UrunAdi).HasMaxLength(40);
            entity.Property(e => e.UrunId)
                .ValueGeneratedOnAdd()
                .HasColumnName("UrunID");
        });

        modelBuilder.Entity<Bolge>(entity =>
        {
            entity.HasKey(e => e.BolgeId).IsClustered(false);

            entity.ToTable("Bolge");

            entity.Property(e => e.BolgeId)
                .ValueGeneratedNever()
                .HasColumnName("BolgeID");
            entity.Property(e => e.BolgeTanimi)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<Bolgeler>(entity =>
        {
            entity.HasKey(e => e.TerritoryId).IsClustered(false);

            entity.ToTable("Bolgeler");

            entity.Property(e => e.TerritoryId)
                .HasMaxLength(20)
                .HasColumnName("TerritoryID");
            entity.Property(e => e.BolgeId).HasColumnName("BolgeID");
            entity.Property(e => e.TerritoryTanimi)
                .HasMaxLength(50)
                .IsFixedLength();

            entity.HasOne(d => d.Bolge).WithMany(p => p.Bolgelers)
                .HasForeignKey(d => d.BolgeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Bolgeler_Bolge");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasIndex(e => e.CategoryName, "CategoryName");

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CategoryName).HasMaxLength(15);
            entity.Property(e => e.Description).HasColumnType("ntext");
            entity.Property(e => e.Picture).HasColumnType("image");
        });

        modelBuilder.Entity<CurrentProductList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Current Product List");

            entity.Property(e => e.ProductId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ProductID");
            entity.Property(e => e.ProductName).HasMaxLength(40);
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasIndex(e => e.City, "City");

            entity.HasIndex(e => e.CompanyName, "CompanyName");

            entity.HasIndex(e => e.PostalCode, "PostalCode");

            entity.HasIndex(e => e.Region, "Region");

            entity.Property(e => e.CustomerId)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("CustomerID");
            entity.Property(e => e.Address).HasMaxLength(60);
            entity.Property(e => e.City).HasMaxLength(15);
            entity.Property(e => e.CompanyName).HasMaxLength(40);
            entity.Property(e => e.ContactName).HasMaxLength(30);
            entity.Property(e => e.ContactTitle).HasMaxLength(30);
            entity.Property(e => e.Country).HasMaxLength(15);
            entity.Property(e => e.Fax).HasMaxLength(24);
            entity.Property(e => e.Phone).HasMaxLength(24);
            entity.Property(e => e.PostalCode).HasMaxLength(10);
            entity.Property(e => e.Region).HasMaxLength(15);

            entity.HasMany(d => d.CustomerTypes).WithMany(p => p.Customers)
                .UsingEntity<Dictionary<string, object>>(
                    "CustomerCustomerDemo",
                    r => r.HasOne<CustomerDemographic>().WithMany()
                        .HasForeignKey("CustomerTypeId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_CustomerCustomerDemo"),
                    l => l.HasOne<Customer>().WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_CustomerCustomerDemo_Customers"),
                    j =>
                    {
                        j.HasKey("CustomerId", "CustomerTypeId").IsClustered(false);
                        j.ToTable("CustomerCustomerDemo");
                        j.IndexerProperty<string>("CustomerId")
                            .HasMaxLength(5)
                            .IsFixedLength()
                            .HasColumnName("CustomerID");
                        j.IndexerProperty<string>("CustomerTypeId")
                            .HasMaxLength(10)
                            .IsFixedLength()
                            .HasColumnName("CustomerTypeID");
                    });
        });

        modelBuilder.Entity<CustomerAndSuppliersByCity>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Customer and Suppliers by City");

            entity.Property(e => e.City).HasMaxLength(15);
            entity.Property(e => e.CompanyName).HasMaxLength(40);
            entity.Property(e => e.ContactName).HasMaxLength(30);
            entity.Property(e => e.Relationship)
                .HasMaxLength(9)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CustomerDemographic>(entity =>
        {
            entity.HasKey(e => e.CustomerTypeId).IsClustered(false);

            entity.Property(e => e.CustomerTypeId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("CustomerTypeID");
            entity.Property(e => e.CustomerDesc).HasColumnType("ntext");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasIndex(e => e.LastName, "LastName");

            entity.HasIndex(e => e.PostalCode, "PostalCode");

            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.Address).HasMaxLength(60);
            entity.Property(e => e.BirthDate).HasColumnType("datetime");
            entity.Property(e => e.City).HasMaxLength(15);
            entity.Property(e => e.Country).HasMaxLength(15);
            entity.Property(e => e.Extension).HasMaxLength(4);
            entity.Property(e => e.FirstName).HasMaxLength(10);
            entity.Property(e => e.HireDate).HasColumnType("datetime");
            entity.Property(e => e.HomePhone).HasMaxLength(24);
            entity.Property(e => e.LastName).HasMaxLength(20);
            entity.Property(e => e.Notes).HasColumnType("ntext");
            entity.Property(e => e.Photo).HasColumnType("image");
            entity.Property(e => e.PhotoPath).HasMaxLength(255);
            entity.Property(e => e.PostalCode).HasMaxLength(10);
            entity.Property(e => e.Region).HasMaxLength(15);
            entity.Property(e => e.Title).HasMaxLength(30);
            entity.Property(e => e.TitleOfCourtesy).HasMaxLength(25);

            entity.HasOne(d => d.ReportsToNavigation).WithMany(p => p.InverseReportsToNavigation)
                .HasForeignKey(d => d.ReportsTo)
                .HasConstraintName("FK_Employees_Employees");

            entity.HasMany(d => d.Territories).WithMany(p => p.Employees)
                .UsingEntity<Dictionary<string, object>>(
                    "EmployeeTerritory",
                    r => r.HasOne<Territory>().WithMany()
                        .HasForeignKey("TerritoryId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_EmployeeTerritories_Territories"),
                    l => l.HasOne<Employee>().WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_EmployeeTerritories_Employees"),
                    j =>
                    {
                        j.HasKey("EmployeeId", "TerritoryId").IsClustered(false);
                        j.ToTable("EmployeeTerritories");
                        j.IndexerProperty<int>("EmployeeId").HasColumnName("EmployeeID");
                        j.IndexerProperty<string>("TerritoryId")
                            .HasMaxLength(20)
                            .HasColumnName("TerritoryID");
                    });
        });

        modelBuilder.Entity<Faturalar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Faturalar");

            entity.Property(e => e.Adres).HasMaxLength(60);
            entity.Property(e => e.BirimFiyati).HasColumnType("money");
            entity.Property(e => e.Bolge).HasMaxLength(15);
            entity.Property(e => e.ExtendedPrice).HasColumnType("money");
            entity.Property(e => e.MusteriId)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("MusteriID");
            entity.Property(e => e.MusteriName).HasMaxLength(40);
            entity.Property(e => e.NakliyeUcreti).HasColumnType("money");
            entity.Property(e => e.NakliyeciName).HasMaxLength(40);
            entity.Property(e => e.OdemeTarihi).HasColumnType("datetime");
            entity.Property(e => e.PersonelSatislari).HasMaxLength(31);
            entity.Property(e => e.PostaKodu).HasMaxLength(10);
            entity.Property(e => e.SatisId).HasColumnName("SatisID");
            entity.Property(e => e.SatisTarihi).HasColumnType("datetime");
            entity.Property(e => e.Sehir).HasMaxLength(15);
            entity.Property(e => e.SevkAdi).HasMaxLength(40);
            entity.Property(e => e.SevkAdresi).HasMaxLength(60);
            entity.Property(e => e.SevkBolgesi).HasMaxLength(15);
            entity.Property(e => e.SevkPostaKodu).HasMaxLength(10);
            entity.Property(e => e.SevkSehri).HasMaxLength(15);
            entity.Property(e => e.SevkTarihi).HasColumnType("datetime");
            entity.Property(e => e.SevkUlkesi).HasMaxLength(15);
            entity.Property(e => e.Ulke).HasMaxLength(15);
            entity.Property(e => e.UrunAdi).HasMaxLength(40);
            entity.Property(e => e.UrunId).HasColumnName("UrunID");
        });

        modelBuilder.Entity<HerUcAylikSatislar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Her Uc Aylik Satislar");

            entity.Property(e => e.MusteriId)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("MusteriID");
            entity.Property(e => e.Sehir).HasMaxLength(15);
            entity.Property(e => e.SirketAdi).HasMaxLength(40);
            entity.Property(e => e.Ulke).HasMaxLength(15);
        });

        modelBuilder.Entity<Kategoriler>(entity =>
        {
            entity.HasKey(e => e.KategoriId);

            entity.ToTable("Kategoriler");

            entity.HasIndex(e => e.KategoriAdi, "KategoriAdi");

            entity.Property(e => e.KategoriId).HasColumnName("KategoriID");
            entity.Property(e => e.KategoriAdi).HasMaxLength(15);
            entity.Property(e => e.Resim).HasColumnType("image");
            entity.Property(e => e.Tanimi).HasColumnType("ntext");
        });

        modelBuilder.Entity<KategorilereGore1997YiliSatislari>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Kategorilere Gore 1997 Yili Satislari");

            entity.Property(e => e.KategoriAdi).HasMaxLength(15);
            entity.Property(e => e.KategoriSales).HasColumnType("money");
        });

        modelBuilder.Entity<KategorilereGoreSatislar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Kategorilere Gore Satislar");

            entity.Property(e => e.KategoriAdi).HasMaxLength(15);
            entity.Property(e => e.KategoriId).HasColumnName("KategoriID");
            entity.Property(e => e.UrunAdi).HasMaxLength(40);
            entity.Property(e => e.Urunlerales).HasColumnType("money");
        });

        modelBuilder.Entity<KategorilereGoreUrunler>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Kategorilere Gore Urunler");

            entity.Property(e => e.BirimdekiMiktar).HasMaxLength(20);
            entity.Property(e => e.KategoriAdi).HasMaxLength(15);
            entity.Property(e => e.UrunAdi).HasMaxLength(40);
        });

        modelBuilder.Entity<Menuler>(entity =>
        {
            entity.ToTable("Menuler");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MenuAdi)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MusteriDemographic>(entity =>
        {
            entity.HasKey(e => e.MusteriTypeId).IsClustered(false);

            entity.Property(e => e.MusteriTypeId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("MusteriTypeID");
            entity.Property(e => e.MusteriDesc).HasColumnType("ntext");
        });

        modelBuilder.Entity<Musteriler>(entity =>
        {
            entity.HasKey(e => e.MusteriId);

            entity.ToTable("Musteriler");

            entity.HasIndex(e => e.Bolge, "Bolge");

            entity.HasIndex(e => e.PostaKodu, "PostaKodu");

            entity.HasIndex(e => e.Sehir, "Sehir");

            entity.HasIndex(e => e.SirketAdi, "SirketAdi");

            entity.Property(e => e.MusteriId)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("MusteriID");
            entity.Property(e => e.Adres).HasMaxLength(60);
            entity.Property(e => e.Bolge).HasMaxLength(15);
            entity.Property(e => e.Faks).HasMaxLength(24);
            entity.Property(e => e.MusteriAdi).HasMaxLength(30);
            entity.Property(e => e.MusteriUnvani).HasMaxLength(30);
            entity.Property(e => e.PostaKodu).HasMaxLength(10);
            entity.Property(e => e.Sehir).HasMaxLength(15);
            entity.Property(e => e.SirketAdi).HasMaxLength(40);
            entity.Property(e => e.Telefon).HasMaxLength(24);
            entity.Property(e => e.Ulke).HasMaxLength(15);

            entity.HasMany(d => d.MusteriTypes).WithMany(p => p.Musteris)
                .UsingEntity<Dictionary<string, object>>(
                    "MusteriMusteriDemo",
                    r => r.HasOne<MusteriDemographic>().WithMany()
                        .HasForeignKey("MusteriTypeId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_MusteriMusteriDemo"),
                    l => l.HasOne<Musteriler>().WithMany()
                        .HasForeignKey("MusteriId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_MusteriMusteriDemo_Musteriler"),
                    j =>
                    {
                        j.HasKey("MusteriId", "MusteriTypeId").IsClustered(false);
                        j.ToTable("MusteriMusteriDemo");
                        j.IndexerProperty<string>("MusteriId")
                            .HasMaxLength(5)
                            .IsFixedLength()
                            .HasColumnName("MusteriID");
                        j.IndexerProperty<string>("MusteriTypeId")
                            .HasMaxLength(10)
                            .IsFixedLength()
                            .HasColumnName("MusteriTypeID");
                    });
        });

        modelBuilder.Entity<Nakliyeciler>(entity =>
        {
            entity.HasKey(e => e.NakliyeciId);

            entity.ToTable("Nakliyeciler");

            entity.Property(e => e.NakliyeciId).HasColumnName("NakliyeciID");
            entity.Property(e => e.SirketAdi).HasMaxLength(40);
            entity.Property(e => e.Telefon).HasMaxLength(24);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasIndex(e => e.CustomerId, "CustomerID");

            entity.HasIndex(e => e.CustomerId, "CustomersOrders");

            entity.HasIndex(e => e.EmployeeId, "EmployeeID");

            entity.HasIndex(e => e.EmployeeId, "EmployeesOrders");

            entity.HasIndex(e => e.OrderDate, "OrderDate");

            entity.HasIndex(e => e.ShipPostalCode, "ShipPostalCode");

            entity.HasIndex(e => e.ShippedDate, "ShippedDate");

            entity.HasIndex(e => e.ShipVia, "ShippersOrders");

            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("CustomerID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.Freight)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.RequiredDate).HasColumnType("datetime");
            entity.Property(e => e.ShipAddress).HasMaxLength(60);
            entity.Property(e => e.ShipCity).HasMaxLength(15);
            entity.Property(e => e.ShipCountry).HasMaxLength(15);
            entity.Property(e => e.ShipName).HasMaxLength(40);
            entity.Property(e => e.ShipPostalCode).HasMaxLength(10);
            entity.Property(e => e.ShipRegion).HasMaxLength(15);
            entity.Property(e => e.ShippedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_Orders_Customers");

            entity.HasOne(d => d.Employee).WithMany(p => p.Orders)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_Orders_Employees");

            entity.HasOne(d => d.ShipViaNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.ShipVia)
                .HasConstraintName("FK_Orders_Shippers");
        });

        modelBuilder.Entity<OrdersQry>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Orders Qry");

            entity.Property(e => e.Address).HasMaxLength(60);
            entity.Property(e => e.City).HasMaxLength(15);
            entity.Property(e => e.CompanyName).HasMaxLength(40);
            entity.Property(e => e.Country).HasMaxLength(15);
            entity.Property(e => e.CustomerId)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("CustomerID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.Freight).HasColumnType("money");
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.PostalCode).HasMaxLength(10);
            entity.Property(e => e.Region).HasMaxLength(15);
            entity.Property(e => e.RequiredDate).HasColumnType("datetime");
            entity.Property(e => e.ShipAddress).HasMaxLength(60);
            entity.Property(e => e.ShipCity).HasMaxLength(15);
            entity.Property(e => e.ShipCountry).HasMaxLength(15);
            entity.Property(e => e.ShipName).HasMaxLength(40);
            entity.Property(e => e.ShipPostalCode).HasMaxLength(10);
            entity.Property(e => e.ShipRegion).HasMaxLength(15);
            entity.Property(e => e.ShippedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<OrtalamaMaliyetinUzerindekiUrunler>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Ortalama Maliyetin Uzerindeki Urunler");

            entity.Property(e => e.BirimFiyati).HasColumnType("money");
            entity.Property(e => e.UrunAdi).HasMaxLength(40);
        });

        modelBuilder.Entity<OzetCeyrekSatislar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Ozet Ceyrek Satislar");

            entity.Property(e => e.SatisId).HasColumnName("SatisID");
            entity.Property(e => e.SevkTarihi).HasColumnType("datetime");
            entity.Property(e => e.Subtotal).HasColumnType("money");
        });

        modelBuilder.Entity<OzetYillikSatislar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Ozet Yillik Satislar");

            entity.Property(e => e.SatisId).HasColumnName("SatisID");
            entity.Property(e => e.SevkTarihi).HasColumnType("datetime");
            entity.Property(e => e.Subtotal).HasColumnType("money");
        });

        modelBuilder.Entity<Personeller>(entity =>
        {
            entity.HasKey(e => e.PersonelId);

            entity.ToTable("Personeller");

            entity.HasIndex(e => e.PostaKodu, "PostaKodu");

            entity.HasIndex(e => e.SoyAdi, "SoyAdi");

            entity.Property(e => e.PersonelId).HasColumnName("PersonelID");
            entity.Property(e => e.Adi).HasMaxLength(10);
            entity.Property(e => e.Adres).HasMaxLength(60);
            entity.Property(e => e.Bolge).HasMaxLength(15);
            entity.Property(e => e.DogumTarihi).HasColumnType("datetime");
            entity.Property(e => e.EvTelefonu).HasMaxLength(24);
            entity.Property(e => e.Extension).HasMaxLength(4);
            entity.Property(e => e.Fotograf).HasColumnType("image");
            entity.Property(e => e.FotografPath).HasMaxLength(255);
            entity.Property(e => e.IseBaslamaTarihi).HasColumnType("datetime");
            entity.Property(e => e.Notlar).HasColumnType("ntext");
            entity.Property(e => e.PostaKodu).HasMaxLength(10);
            entity.Property(e => e.Sehir).HasMaxLength(15);
            entity.Property(e => e.SoyAdi).HasMaxLength(20);
            entity.Property(e => e.Ulke).HasMaxLength(15);
            entity.Property(e => e.Unvan).HasMaxLength(30);
            entity.Property(e => e.UnvanEki).HasMaxLength(25);

            entity.HasOne(d => d.BagliCalistigiKisiNavigation).WithMany(p => p.InverseBagliCalistigiKisiNavigation)
                .HasForeignKey(d => d.BagliCalistigiKisi)
                .HasConstraintName("FK_Personeller_Personeller");

            entity.HasMany(d => d.Territories).WithMany(p => p.Personels)
                .UsingEntity<Dictionary<string, object>>(
                    "PersonelBolgeler",
                    r => r.HasOne<Bolgeler>().WithMany()
                        .HasForeignKey("TerritoryId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PersonelBolgeler_Bolgeler"),
                    l => l.HasOne<Personeller>().WithMany()
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PersonelBolgeler_Personeller"),
                    j =>
                    {
                        j.HasKey("PersonelId", "TerritoryId").IsClustered(false);
                        j.ToTable("PersonelBolgeler");
                        j.IndexerProperty<int>("PersonelId").HasColumnName("PersonelID");
                        j.IndexerProperty<string>("TerritoryId")
                            .HasMaxLength(20)
                            .HasColumnName("TerritoryID");
                    });
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasIndex(e => e.CategoryId, "CategoriesProducts");

            entity.HasIndex(e => e.CategoryId, "CategoryID");

            entity.HasIndex(e => e.ProductName, "ProductName");

            entity.HasIndex(e => e.SupplierId, "SupplierID");

            entity.HasIndex(e => e.SupplierId, "SuppliersProducts");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.ProductName).HasMaxLength(40);
            entity.Property(e => e.QuantityPerUnit).HasMaxLength(20);
            entity.Property(e => e.ReorderLevel).HasDefaultValue((short)0);
            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            entity.Property(e => e.UnitPrice)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.UnitsInStock).HasDefaultValue((short)0);
            entity.Property(e => e.UnitsOnOrder).HasDefaultValue((short)0);

            entity.HasOne(d => d.Category).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_Products_Categories");

            entity.HasOne(d => d.Supplier).WithMany(p => p.Products)
                .HasForeignKey(d => d.SupplierId)
                .HasConstraintName("FK_Products_Suppliers");
        });

        modelBuilder.Entity<ProductsAboveAveragePrice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Products Above Average Price");

            entity.Property(e => e.ProductName).HasMaxLength(40);
            entity.Property(e => e.UnitPrice).HasColumnType("money");
        });

        modelBuilder.Entity<ProductsByCategory>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Products by Category");

            entity.Property(e => e.CategoryName).HasMaxLength(15);
            entity.Property(e => e.ProductName).HasMaxLength(40);
            entity.Property(e => e.QuantityPerUnit).HasMaxLength(20);
        });

        modelBuilder.Entity<QuarterlyOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Quarterly Orders");

            entity.Property(e => e.City).HasMaxLength(15);
            entity.Property(e => e.CompanyName).HasMaxLength(40);
            entity.Property(e => e.Country).HasMaxLength(15);
            entity.Property(e => e.CustomerId)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("CustomerID");
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e => e.RegionId).IsClustered(false);

            entity.ToTable("Region");

            entity.Property(e => e.RegionId)
                .ValueGeneratedNever()
                .HasColumnName("RegionID");
            entity.Property(e => e.RegionDescription)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<SatisAltToplamlari>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Satis Alt Toplamlari");

            entity.Property(e => e.SatisId).HasColumnName("SatisID");
            entity.Property(e => e.Subtotal).HasColumnType("money");
        });

        modelBuilder.Entity<SatisDetaylari>(entity =>
        {
            entity.HasKey(e => new { e.SatisId, e.UrunId }).HasName("PK_Order_Details");

            entity.ToTable("Satis Detaylari");

            entity.HasIndex(e => e.SatisId, "SatisID");

            entity.HasIndex(e => e.SatisId, "SatislarOrder_Details");

            entity.HasIndex(e => e.UrunId, "UrunID");

            entity.HasIndex(e => e.UrunId, "UrunlerOrder_Details");

            entity.Property(e => e.SatisId).HasColumnName("SatisID");
            entity.Property(e => e.UrunId).HasColumnName("UrunID");
            entity.Property(e => e.BirimFiyati).HasColumnType("money");
            entity.Property(e => e.Miktar).HasDefaultValue((short)1);

            entity.HasOne(d => d.Satis).WithMany(p => p.SatisDetaylaris)
                .HasForeignKey(d => d.SatisId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_Details_Satislar");

            entity.HasOne(d => d.Urun).WithMany(p => p.SatisDetaylaris)
                .HasForeignKey(d => d.UrunId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_Details_Urunler");
        });

        modelBuilder.Entity<Satislar>(entity =>
        {
            entity.HasKey(e => e.SatisId);

            entity.ToTable("Satislar");

            entity.HasIndex(e => e.MusteriId, "MusteriID");

            entity.HasIndex(e => e.MusteriId, "MusterilerSatislar");

            entity.HasIndex(e => e.ShipVia, "NakliyecilerSatislar");

            entity.HasIndex(e => e.PersonelId, "PersonelID");

            entity.HasIndex(e => e.PersonelId, "PersonellerSatislar");

            entity.HasIndex(e => e.SatisTarihi, "SatisTarihi");

            entity.HasIndex(e => e.SevkPostaKodu, "SevkPostaKodu");

            entity.HasIndex(e => e.SevkTarihi, "SevkTarihi");

            entity.Property(e => e.SatisId).HasColumnName("SatisID");
            entity.Property(e => e.MusteriId)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("MusteriID");
            entity.Property(e => e.NakliyeUcreti)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.OdemeTarihi).HasColumnType("datetime");
            entity.Property(e => e.PersonelId).HasColumnName("PersonelID");
            entity.Property(e => e.SatisTarihi).HasColumnType("datetime");
            entity.Property(e => e.SevkAdi).HasMaxLength(40);
            entity.Property(e => e.SevkAdresi).HasMaxLength(60);
            entity.Property(e => e.SevkBolgesi).HasMaxLength(15);
            entity.Property(e => e.SevkPostaKodu).HasMaxLength(10);
            entity.Property(e => e.SevkSehri).HasMaxLength(15);
            entity.Property(e => e.SevkTarihi).HasColumnType("datetime");
            entity.Property(e => e.SevkUlkesi).HasMaxLength(15);

            entity.HasOne(d => d.Musteri).WithMany(p => p.Satislars)
                .HasForeignKey(d => d.MusteriId)
                .HasConstraintName("FK_Satislar_Musteriler");

            entity.HasOne(d => d.Personel).WithMany(p => p.Satislars)
                .HasForeignKey(d => d.PersonelId)
                .HasConstraintName("FK_Satislar_Personeller");

            entity.HasOne(d => d.ShipViaNavigation).WithMany(p => p.Satislars)
                .HasForeignKey(d => d.ShipVia)
                .HasConstraintName("FK_Satislar_Nakliyeciler");
        });

        modelBuilder.Entity<SatislarSorgusu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Satislar Sorgusu");

            entity.Property(e => e.Adres).HasMaxLength(60);
            entity.Property(e => e.Bolge).HasMaxLength(15);
            entity.Property(e => e.MusteriId)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("MusteriID");
            entity.Property(e => e.NakliyeUcreti).HasColumnType("money");
            entity.Property(e => e.OdemeTarihi).HasColumnType("datetime");
            entity.Property(e => e.PersonelId).HasColumnName("PersonelID");
            entity.Property(e => e.PostaKodu).HasMaxLength(10);
            entity.Property(e => e.SatisId).HasColumnName("SatisID");
            entity.Property(e => e.SatisTarihi).HasColumnType("datetime");
            entity.Property(e => e.Sehir).HasMaxLength(15);
            entity.Property(e => e.SevkAdi).HasMaxLength(40);
            entity.Property(e => e.SevkAdresi).HasMaxLength(60);
            entity.Property(e => e.SevkBolgesi).HasMaxLength(15);
            entity.Property(e => e.SevkPostaKodu).HasMaxLength(10);
            entity.Property(e => e.SevkSehri).HasMaxLength(15);
            entity.Property(e => e.SevkTarihi).HasColumnType("datetime");
            entity.Property(e => e.SevkUlkesi).HasMaxLength(15);
            entity.Property(e => e.SirketAdi).HasMaxLength(40);
            entity.Property(e => e.Ulke).HasMaxLength(15);
        });

        modelBuilder.Entity<SatislarinToplamMiktari>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Satislarin Toplam Miktari");

            entity.Property(e => e.SaleAmount).HasColumnType("money");
            entity.Property(e => e.SatisId).HasColumnName("SatisID");
            entity.Property(e => e.SevkTarihi).HasColumnType("datetime");
            entity.Property(e => e.SirketAdi).HasMaxLength(40);
        });

        modelBuilder.Entity<SehirlereGoreMusteriVeTedarikciler>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Sehirlere Gore Musteri ve Tedarikciler");

            entity.Property(e => e.MusteriAdi).HasMaxLength(30);
            entity.Property(e => e.Relationship)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Sehir).HasMaxLength(15);
            entity.Property(e => e.SirketAdi).HasMaxLength(40);
        });

        modelBuilder.Entity<Shipper>(entity =>
        {
            entity.Property(e => e.ShipperId).HasColumnName("ShipperID");
            entity.Property(e => e.CompanyName).HasMaxLength(40);
            entity.Property(e => e.Phone).HasMaxLength(24);
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasIndex(e => e.CompanyName, "CompanyName");

            entity.HasIndex(e => e.PostalCode, "PostalCode");

            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            entity.Property(e => e.Address).HasMaxLength(60);
            entity.Property(e => e.City).HasMaxLength(15);
            entity.Property(e => e.CompanyName).HasMaxLength(40);
            entity.Property(e => e.ContactName).HasMaxLength(30);
            entity.Property(e => e.ContactTitle).HasMaxLength(30);
            entity.Property(e => e.Country).HasMaxLength(15);
            entity.Property(e => e.Fax).HasMaxLength(24);
            entity.Property(e => e.HomePage).HasColumnType("ntext");
            entity.Property(e => e.Phone).HasMaxLength(24);
            entity.Property(e => e.PostalCode).HasMaxLength(10);
            entity.Property(e => e.Region).HasMaxLength(15);
        });

        modelBuilder.Entity<Tedarikciler>(entity =>
        {
            entity.HasKey(e => e.TedarikciId);

            entity.ToTable("Tedarikciler");

            entity.HasIndex(e => e.PostaKodu, "PostaKodu");

            entity.HasIndex(e => e.SirketAdi, "SirketAdi");

            entity.Property(e => e.TedarikciId).HasColumnName("TedarikciID");
            entity.Property(e => e.Adres).HasMaxLength(60);
            entity.Property(e => e.Bolge).HasMaxLength(15);
            entity.Property(e => e.Faks).HasMaxLength(24);
            entity.Property(e => e.MusteriAdi).HasMaxLength(30);
            entity.Property(e => e.MusteriUnvani).HasMaxLength(30);
            entity.Property(e => e.PostaKodu).HasMaxLength(10);
            entity.Property(e => e.Sehir).HasMaxLength(15);
            entity.Property(e => e.SirketAdi).HasMaxLength(40);
            entity.Property(e => e.Telefon).HasMaxLength(24);
            entity.Property(e => e.Ulke).HasMaxLength(15);
            entity.Property(e => e.WebSayfasi).HasColumnType("ntext");
        });

        modelBuilder.Entity<Territory>(entity =>
        {
            entity.HasKey(e => e.TerritoryId).IsClustered(false);

            entity.Property(e => e.TerritoryId)
                .HasMaxLength(20)
                .HasColumnName("TerritoryID");
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.TerritoryDescription)
                .HasMaxLength(50)
                .IsFixedLength();

            entity.HasOne(d => d.Region).WithMany(p => p.Territories)
                .HasForeignKey(d => d.RegionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Territories_Region");
        });

        modelBuilder.Entity<Urunler>(entity =>
        {
            entity.HasKey(e => e.UrunId);

            entity.ToTable("Urunler");

            entity.HasIndex(e => e.KategoriId, "KategoriID");

            entity.HasIndex(e => e.KategoriId, "KategorilerUrunler");

            entity.HasIndex(e => e.TedarikciId, "TedarikciID");

            entity.HasIndex(e => e.TedarikciId, "TedarikcilerUrunler");

            entity.HasIndex(e => e.UrunAdi, "UrunAdi");

            entity.Property(e => e.UrunId).HasColumnName("UrunID");
            entity.Property(e => e.BirimFiyati)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.BirimdekiMiktar).HasMaxLength(20);
            entity.Property(e => e.EnAzYenidenSatisMikatari).HasDefaultValue((short)0);
            entity.Property(e => e.HedefStokDuzeyi).HasDefaultValue((short)0);
            entity.Property(e => e.KategoriId).HasColumnName("KategoriID");
            entity.Property(e => e.TedarikciId).HasColumnName("TedarikciID");
            entity.Property(e => e.UrunAdi).HasMaxLength(40);
            entity.Property(e => e.YeniSatis).HasDefaultValue((short)0);

            entity.HasOne(d => d.Kategori).WithMany(p => p.Urunlers)
                .HasForeignKey(d => d.KategoriId)
                .HasConstraintName("FK_Urunler_Kategoriler");

            entity.HasOne(d => d.Tedarikci).WithMany(p => p.Urunlers)
                .HasForeignKey(d => d.TedarikciId)
                .HasConstraintName("FK_Urunler_Tedarikciler");
        });

        modelBuilder.Entity<_1997YiliUrunSatislari>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("1997 Yili Urun Satislari");

            entity.Property(e => e.KategoriAdi).HasMaxLength(15);
            entity.Property(e => e.UrunAdi).HasMaxLength(40);
            entity.Property(e => e.Urunlerales).HasColumnType("money");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
