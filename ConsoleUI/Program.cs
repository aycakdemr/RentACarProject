using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string islemler = "1. Araba Ekle \n" +
                "2. Tüm arabaları getir \n" +
                "3. Seçilen arabayı brand id'ye göre getir \n" +
                "4. Seçilen arabayı color id'ye göre getir \n" +
                "5. Brand ekle \n" +
                "6. Tüm brandleri getir \n" +
                "7. Seçilen brand'i id'ye göre getir \n" +
                "8. Seçilen brand'i name'e göre getir \n" +
                "9. Color ekle \n" +
                "10. Tüm Colorları getir \n" +
                "11. Seçilen color'ı id'ye göre getir \n" +
                "12. Seçilen color'ı name'e göre getir \n";
            
            while (true)
            {   
                Console.WriteLine(islemler);
                String secim = Console.ReadLine();
                if (secim.Equals("1"))
                {
                    CarManager carManager = new CarManager(new EfCarDal());
                    carManager.Add(new Car() { ColorId=2,BrandId=3,DailyPrice=150,ModelYear=2000,Description="abcx"}) ;

                }
                else if (secim.Equals("2"))
                {
                    CarManager carManager = new CarManager(new EfCarDal());
                    foreach (var car in carManager.GetAll())
                    {
                       Console.WriteLine(car.Description);
                    }

                }
                else if (secim.Equals("3"))
                {
                    CarManager carManager = new CarManager(new EfCarDal());
                    foreach (var car in carManager.GetCarsByBrandId(2))
                    {
                        Console.WriteLine(car.Description);
                    }
                }
                else if (secim.Equals("4"))
                {
                    CarManager carManager = new CarManager(new EfCarDal());
                    foreach (var car in carManager.GetCarsByColorId(2))
                    {
                        Console.WriteLine(car.Description);
                    }
                }

                else if (secim.Equals("5"))
                {
                    BrandManager brandManager = new BrandManager(new EfBrandDal());
                    brandManager.Add(new Brand() {BrandId = 2,BrandName="abc"
                    }
                        );
                }
                else if (secim.Equals("6"))
                {
                    BrandManager brandManager = new BrandManager(new EfBrandDal());
                    foreach (var brand in brandManager.GetAll())
                    {
                        Console.WriteLine(brand.BrandName);
                    }
                }
                else if (secim.Equals("7"))
                {
                    BrandManager brandManager = new BrandManager(new EfBrandDal());
                    foreach (var brand in brandManager.GetBrandsById(2))
                    {
                        Console.WriteLine(brand.BrandName);
                    }
                }
                else if (secim.Equals("8"))
                {
                    BrandManager brandManager = new BrandManager(new EfBrandDal());
                    foreach (var brand in brandManager.GetBrandsByName("aa"))
                    {
                        Console.WriteLine(brand.BrandName);
                    }
                }
                else if (secim.Equals("9"))
                {
                    ColorManager colorManager = new ColorManager(new EfColorDal());
                    colorManager.Add(new Color() { ColorName = "beyaz",
                        ColorId=2
                    }
                    ) ;

                }
                else if (secim.Equals("10"))
                {
                    ColorManager colorManager = new ColorManager(new EfColorDal());
                    foreach (var color in colorManager.GetAll())
                    {
                        Console.WriteLine(color.ColorName);
                    }
                }
                else if (secim.Equals("11"))
                {
                    ColorManager colorManager = new ColorManager(new EfColorDal());
                    foreach (var color in colorManager.GetColorsById(2))
                    {
                        Console.WriteLine(color.ColorName);
                    }

                }
                else if (secim.Equals("12"))
                {
                    ColorManager colorManager = new ColorManager(new EfColorDal());
                    foreach (var color in colorManager.GetColorsByName("aa "))
                    {
                        Console.WriteLine(color.ColorName);
                    }
                }
            }



        }
    }
}
