using ClassAndObject.Kendaraan;
using ClassAndObject.OperasiMatematika;
using ClassAndObject.Perpustakaan;
using ClassAndObject.TokoLaptop;
using ClassAndObject.TokoSepeda;

namespace ClassAndObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Buku
            Buku buku = new Buku("Armada", "Ernest Cline", 2015);
            buku.TampilkanInfo();

            // Kendaraan
            Mobil mobil = new Mobil("Toyota", "RAV4", 2001);
            mobil.TampilkanSpesifikasi();

            // Laptop
            Laptop laptop = new Laptop("Asus", "Intel Core i5", 16, 526);
            laptop.TampilkanSpesifikasi();

            // Sepeda
            Sepeda sepeda = new Sepeda("Polygon", "PATH", 14.5);
            sepeda.TampilkanInformasi();

            // Kalkulator
            Kalkulator kalkulator = new Kalkulator();
            Console.WriteLine(kalkulator.Tambah(2, 5));
            Console.WriteLine(kalkulator.Kurang(7, 3));
            Console.WriteLine(kalkulator.Kali(1, 8));
            Console.WriteLine(kalkulator.Bagi(6, 2));
        }
    }
}
