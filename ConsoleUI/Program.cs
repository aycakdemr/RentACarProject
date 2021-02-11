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
            string islemler = "1. Araba İşlemleri \n" +
                "2. Brand İşlemleri\n" +
                "3. Color İşlemleri\n" +
                "4. Birleştirilmiş Tabloyu Getir\n"+
                "*******************************\n";

                
            
            while (true)
            {   
                Console.WriteLine(islemler);
                String secim = Console.ReadLine();
                if (secim.Equals("1"))
                {
                    string islemler2 = "a. Araba Ekleme\n" +
                        "b. Araba Silme\n" +
                        "c. Araba Güncelleme\n" +
                        "d. Tüm Arabaları Getir";
                    Console.WriteLine(islemler2);
                    String secim2 = Console.ReadLine();
                    if (secim2.Equals("a"))
                    {
                        CarManager carManager = new CarManager(new EfCarDal());
                        carManager.Add(new Car() { ColorId = 2, BrandId = 3, DailyPrice = 150, ModelYear = 2000, Description = "abcx" });
                    }
                    else if (secim2.Equals("b"))
                    {
                        CarManager carManager = new CarManager(new EfCarDal());
                        carManager.Delete(2);
                    }
                    else if (secim2.Equals("c"))
                    {
                        CarManager carManager = new CarManager(new EfCarDal());
                        carManager.Update(1, new Car()
                        {
                            Id = 2,
                            BrandId = 3,
                            ColorId = 4,
                            DailyPrice = 150,
                            ModelYear = 2000,
                            Description = "honda"
                        });
                    }
                    else if (secim2.Equals("d"))
                    {
                        CarManager carManager = new CarManager(new EfCarDal());
                        foreach (var car in carManager.GetAll().Data)
                        {
                            Console.WriteLine(car.Description);
                        }
                    }


                }
                else if (secim.Equals("2"))
                {
                    string islemler3 = "a. Brand Ekleme\n" +
                        "b. Brand Silme\n" +
                        "c. Brand Güncelleme\n" +
                        "d. Tüm Brandleri Getir";
                    Console.WriteLine(islemler3);
                    String secim3 = Console.ReadLine();

                    if (secim3.Equals("a"))
                    {
                        BrandManager brandManager = new BrandManager(new EfBrandDal());
                        brandManager.Add(new Brand() { BrandId = 1, BrandName = "xyz" });
                    }
                    else if (secim3.Equals("b"))
                    {
                        BrandManager brandManager = new BrandManager(new EfBrandDal());
                        brandManager.Delete(2);
                    }
                    else if (secim3.Equals("c"))
                    {
                        BrandManager brandManager = new BrandManager(new EfBrandDal());
                        brandManager.Update(1, new Brand() { BrandId = 3, BrandName = "abc" });
                    }
                    else if (secim3.Equals("d"))
                    {
                        BrandManager brandManager = new BrandManager(new EfBrandDal());
                        foreach (var brand in brandManager.GetAll().Data)
                        {
                            Console.WriteLine(brand.BrandName);
                        }
                    }
                }
                else if (secim.Equals("3"))
                {
                    string islemler3 = "a. Color Ekleme\n" +
                        "b. Color Silme\n" +
                        "c. Color Güncelleme\n" +
                        "d. Tüm Colorları Getir";
                    Console.WriteLine(islemler3);
                    String secim3 = Console.ReadLine();

                    if (secim3.Equals("a"))
                    {
                        ColorManager colorManager = new ColorManager(new EfColorDal());
                        colorManager.Add(new Color() { ColorId = 8, ColorName = "eflatun" });
                    }
                    else if (secim3.Equals("b"))
                    {
                        ColorManager colorManager = new ColorManager(new EfColorDal());
                        colorManager.Delete(3);
                    }
                    else if (secim3.Equals("c"))
                    {
                        ColorManager colorManager = new ColorManager(new EfColorDal());
                        colorManager.Update(4, new Color() { ColorId = 1, ColorName = "sarı" });
                    }
                    else if (secim3.Equals("d"))
                    {
                        ColorManager colorManager = new ColorManager(new EfColorDal());
                        foreach (var color in colorManager.GetAll().Data)
                        {
                            Console.WriteLine(color.ColorName);
                        }
                    }


                }
                else if (secim.Equals("4"))
                {
                    CarManager carManager = new CarManager(new EfCarDal());
                    foreach (var car in carManager.GetCarDetails().Data)
                    {
                        Console.WriteLine(car.Description + " --> " + car.ColorName + " --> " + car.BrandName + " --> " + car.DailyPrice);
                    }
                }
                


            }



        }
    }
}
