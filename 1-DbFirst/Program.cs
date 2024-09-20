using _1_DbFirst.Entities;

namespace _1_DbFirst
{
    internal class Program
    {
        #region Gerekli oramin hazilanmasi
        /*
         * 1- EntityFramework tool 'unu kurmak
         * Bunu komut satiri uzerinden yapacagiz
         * 
         *  dotnet tool install --global dotnet-ef komutu ef tool paketini kurar
         *  
         *  Ayrica projemize hangi database ile calisacak isek 
         *  Mesela EntityFrameWorkCore.SqlServer ilgili paketini ve EntityFrameWorkCore.Design paketini kurmak gereklidir.
         *  Bu paketleri nuget uzerinden indirebiliriz
         *  
         *  Halihazirdaki bir database'in DbContext'ini cikartmak icin aşagidaki komut kullanilabilir.
         *  Burada Connection string ve Hangi database paketi ni kullanacagimiz degistirmek yeterli olacaktir.
         *  
         *  dotnet ef dbcontext scaffold 
         *  "server=.;Database=Northwind;Trusted_Connection=true;TrustServerCertificate=true"  //Burasi Connection string bolumu
         *  Microsoft.EntityFrameWorkCore.SqlServer    // Hangi databasea ile calisacagi bilgisi
         *  -o Entities  // output olarak hangi Klasore cikti verecegi
         */
        #endregion
        static void Main(string[] args)
        {
            Shipper shipper = new Shipper()
            {
                ShipperId = 11,
                CompanyName = null,
                Phone = "123123"
            };
            NorthwindContext context = new NorthwindContext();

            // context.Customers.Where(p => p.Country == "UK").ToList().ForEach(p => Console.WriteLine(p.CompanyName + " " + p.Country));

            //Update
            //var shipper11 = context.Find<Shipper>(11);
            //shipper11.CompanyName = "Deneme";
            //context.Shippers.Update(shipper11);
            //Insert
            //context.Shippers.Add(shipper);

            context.Shippers.Update(shipper);

            context.SaveChanges();
            Console.WriteLine("Hello, World!");
        }
    }
}
