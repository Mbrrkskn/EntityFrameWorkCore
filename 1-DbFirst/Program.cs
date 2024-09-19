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
         *  Ayrica projemize EntityFrameWorkCore paketini ve hangi database ile calisacak isek 
         *  Mesela EntityFrameWorkCore.SqlServer ilgili paketini ve EntityFrameWorkCore.Design paketini kurmak gereklidir.
         *  Bu paketleri nuget uzerinden indirebiliriz
         * 
         * Halihazırdaki bir database'in DbContext'ini cikartmak için asagıdaki komut kullanılabilir
         * Burada Connection string ve hangi database paketini kullanacağımız değiştirmek yeterli olacaktır.
         * 
         * 
         */
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
