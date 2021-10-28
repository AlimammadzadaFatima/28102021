using System;

namespace _28102021
{
    class Program
    {
        static void Main(string[] args)
        {
            Product mehsul1 = new Product();
            Product mehsul2 = new Product();
            Product mehsul3 = new Product();
            Product mehsul4 = new Product();
            Product mehsul5 = new Product();
            mehsul1.Name = "Ayaqqabi;";
            mehsul1.BrandName = "Nike;";
            mehsul1.Price = 79.50;
            ///
            mehsul2.Name = "Koynek;";
            mehsul2.BrandName = "Lc-Waikiki;";
            mehsul2.Price = 60;
            ///
            mehsul3.Name = "Salvar;";
            mehsul3.BrandName = "Mango;";
            mehsul3.Price = 99.99;
            ///
            mehsul4.Name = "Canta;";
            mehsul4.BrandName = "Bershka;";
            mehsul4.Price = 49;
            ///
            mehsul5.Name = "Kurtka;";
            mehsul5.BrandName = "DeFacto;";
            mehsul5.Price = 119.90;
            double minPrice = 50;
            double maxPrice = 100;
            Product[] mehsullar = new Product[] { mehsul1, mehsul2, mehsul3, mehsul4, mehsul5 };
            Metod(mehsullar,minPrice,maxPrice);
            foreach (var item in Metod(mehsullar,minPrice,maxPrice))
            {
                Console.WriteLine($"Adi : {item.Name} Brendi : {item.BrandName} Qiymeti : {item.Price} azn");
            }
            Char miras = new Char();
            miras.Color = "Bunu Vehicleden miras aldi ";
            miras.Name = "Bu da mirasdi ";
            miras.Brand = "Bunu elave etdim ";
            miras.Model = "Elave xususiyyetidi ";
            Vehicle ata = new Vehicle();
            ata.Name = "Bu miras veren oldugu ucun ";
            ata.Color = "Ancag oz xususiyyetleri var ";
            //Console.WriteLine(miras.Color+miras.Name+miras.Brand+miras.Model);
            //Console.WriteLine(ata.Name+ata.Color);

        }
        static Product [] Metod(Product[] mehsullar, double minPrice, double maxPrice)
        {
            int count = 0;
            for (int i = 0; i < mehsullar.Length; i++)
            {
                if (mehsullar[i].Price > minPrice && mehsullar[i].Price < maxPrice)
                    count++;
            }
            Product[] arr = new Product[count];
            int j = 0;
            for (int i = 0; i < mehsullar.Length; i++)
            {
                if (mehsullar[i].Price > minPrice && mehsullar[i].Price < maxPrice)
                {
                    arr[j] = mehsullar[i];
                    j++;
                }
            }
            return arr;
        }
    }
    
    
}
