using Business.Concrete;
using Core.Entities.Concrete;
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
            //    string islemler = "1. Araba İşlemleri \n" +
            //        "2. Brand İşlemleri\n" +
            //        "3. Color İşlemleri\n" +
            //        "4. Birleştirilmiş Tabloyu Getir\n"+
            //        "5. User İşlemleri\n" +
            //        "6. Customer İşlemleri\n" +
            //        "7. Rental İşlemleri\n" +
            //        "*******************************\n";



            //    while (true)
            //    {   
            //        Console.WriteLine(islemler);
            //        String secim = Console.ReadLine();
            //        if (secim.Equals("1"))
            //        {
            //            string islemler2 = "a. Araba Ekleme\n" +
            //                "b. Araba Silme\n" +
            //                "c. Araba Güncelleme\n" +
            //                "d. Tüm Arabaları Getir\n";
            //            Console.WriteLine(islemler2);
            //            String secim2 = Console.ReadLine();
            //            if (secim2.Equals("a"))
            //            {
            //                CarManager carManager = new CarManager(new EfCarDal());
            //                Console.WriteLine(carManager.Add(new Car() { ColorId = 2, BrandId = 3, DailyPrice = 150, ModelYear = 2000, Description = "abcx" }).Message);
            //            }
            //            else if (secim2.Equals("b"))
            //            {
            //                CarManager carManager = new CarManager(new EfCarDal());
            //                Console.WriteLine(carManager.Delete(2).Message);
            //            }
            //            else if (secim2.Equals("c"))
            //            {
            //                CarManager carManager = new CarManager(new EfCarDal());
            //                Console.WriteLine(carManager.Update(1, new Car()
            //                {
            //                    BrandId = 3,
            //                    ColorId = 4,
            //                    DailyPrice = 150,
            //                    ModelYear = 2000,
            //                    Description = "honda"
            //                }).Message);
            //            }
            //            else if (secim2.Equals("d"))
            //            {
            //                CarManager carManager = new CarManager(new EfCarDal());
            //                foreach (var car in carManager.GetAll().Data)
            //                {
            //                    Console.WriteLine(car.Description);
            //                }
            //            }


            //        }
            //        else if (secim.Equals("2"))
            //        {
            //            string islemler3 = "a. Brand Ekleme\n" +
            //                "b. Brand Silme\n" +
            //                "c. Brand Güncelleme\n" +
            //                "d. Tüm Brandleri Getir\n";
            //            Console.WriteLine(islemler3);
            //            String secim3 = Console.ReadLine();

            //            if (secim3.Equals("a"))
            //            {
            //                BrandManager brandManager = new BrandManager(new EfBrandDal());
            //                Console.WriteLine(brandManager.Add(new Brand() { BrandName = "xyz" }).Message);
            //            }
            //            else if (secim3.Equals("b"))
            //            {
            //                BrandManager brandManager = new BrandManager(new EfBrandDal());
            //                Console.WriteLine(brandManager.Delete(2).Message);
            //            }
            //            else if (secim3.Equals("c"))
            //            {
            //                BrandManager brandManager = new BrandManager(new EfBrandDal());
            //                Console.WriteLine(brandManager.Update(1, new Brand() {  BrandName = "abc" }).Message);
            //            }
            //            else if (secim3.Equals("d"))
            //            {
            //                BrandManager brandManager = new BrandManager(new EfBrandDal());
            //                foreach (var brand in brandManager.GetAll().Data)
            //                {
            //                    Console.WriteLine(brand.BrandName);
            //                }
            //            }
            //        }
            //        else if (secim.Equals("3"))
            //        {
            //            string islemler3 = "a. Color Ekleme\n" +
            //                "b. Color Silme\n" +
            //                "c. Color Güncelleme\n" +
            //                "d. Tüm Colorları Getir\n";
            //            Console.WriteLine(islemler3);
            //            String secim3 = Console.ReadLine();

            //            if (secim3.Equals("a"))
            //            {
            //                ColorManager colorManager = new ColorManager(new EfColorDal());
            //                Console.WriteLine(colorManager.Add(new Color() {  ColorName = "eflatun" }).Message);
            //            }
            //            else if (secim3.Equals("b"))
            //            {
            //                ColorManager colorManager = new ColorManager(new EfColorDal());
            //                Console.WriteLine(colorManager.Delete(3).Message);
            //            }
            //            else if (secim3.Equals("c"))
            //            {
            //                ColorManager colorManager = new ColorManager(new EfColorDal());
            //                Console.WriteLine(colorManager.Update(4, new Color() {  ColorName = "sarı" }).Message);
            //            }
            //            else if (secim3.Equals("d"))
            //            {
            //                ColorManager colorManager = new ColorManager(new EfColorDal());
            //                foreach (var color in colorManager.GetAll().Data)
            //                {
            //                    Console.WriteLine(color.ColorName);
            //                }
            //            }


            //        }


            //        else if (secim.Equals("6"))
            //        {
            //            string islemler6 = "a. Customer Ekleme\n" +
            //                "b. Customer Silme\n" +
            //                "c. Customer Güncelleme\n" +
            //                "d. Tüm Customerları Getir\n" +
            //                "e. Get by id\n";
            //            Console.WriteLine(islemler6);
            //            String secim4 = Console.ReadLine();

            //            if (secim4.Equals("a"))
            //            {
            //                CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //                Console.WriteLine(customerManager.Add(new Customer { CompanyName = "abc" }).Message);
            //            }
            //            else if (secim4.Equals("b"))
            //            {
            //                CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            //                Console.WriteLine(customerManager.Delete(1).Message);
            //            }
            //            else if (secim4.Equals("c"))
            //            {
            //                CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //                Console.WriteLine(customerManager.Update(1, new Customer { CompanyName = "abc" }).Message);
            //            }
            //            else if (secim4.Equals("d"))
            //            {
            //                CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //                foreach (var user in customerManager.GetAll().Data)
            //                {
            //                    Console.WriteLine(user.CompanyName);
            //                }
            //            }
            //            else if (secim4.Equals("e"))
            //            {
            //                CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //                Console.WriteLine(customerManager.GetById(2).Message);
            //            }
            //        }
            //        else if (secim.Equals("7"))
            //        {
            //            string islemler7 = "a. Araba Kiralama";
            //            Console.WriteLine(islemler7);
            //            String secim4 = Console.ReadLine();


            //        }


            //    }



            //}
        }
    }
}
