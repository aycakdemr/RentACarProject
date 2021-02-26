# ReCapProject

![rental-car-insurance](https://user-images.githubusercontent.com/77458312/108398371-fb48a600-7229-11eb-8366-96c0e4c6f1fb.png)

## Getting Started

Çok katlı mimari örneği olan bu proje başlıca Business,DataAccess,Core,Entities ve WebAPI katmanlarından oluşmaktadır.Henüz tamamlanmış olmayıp geliştirme aşamasındadır.

## Packages

### Business
-Autofac(6.1.0)<br/>
-Autofac.Extras.DynamicProxy(6.0.0)<br/>
-FluentValidation(9.5.1)<br/>

### Core
-Autofac(6.1.0)<br/>
-Autofac.Extensions.DependencyInjection(7.1.0)<br/>
-Autofac.Extras.DynamicProxy(6.0.0)<br/>
-FluentValidation(9.5.1)<br/>
-Microsoft.EntityFrameworkCore.SqlServer(3.1.11)<br/>

### DataAccess
-Microsoft.EntityFrameworkCore.SqlServer(3.1.11)<br/>

### WebAPI
-Autofac.Extensions.DependencyInjection(7.1.0)<br/>

## Updates

### 1.Gün
-Entities, DataAccess, Business ve Console katmanlarını oluşturuldu. <br/>
-Bir *Car* nesnesi oluşturulup,Id, BrandId, ColorId, ModelYear, DailyPrice, Description alanları eklendi <br/>
-InMemory formatta GetById, GetAll, Add, Update, Delete oprasyonları yazıldı. <br/>

### 2.Gün
-Brand ve Color nesneleri eklendi,her iki nesneye de Id ve name özellikleri eklendi.<br/>
-Sql Server tarafında yeni bir veritabanı kuruldu,Adı Recap olarak belirlendi ve Cars,Brands,Colors tabloları eklendi.<br/>
-Sisteme Generic IEntityRepository altyapısı yazıldı<br/>
-Car, Brand ve Color nesneleri için Entity Framework altyapısı yazıldı.<br/>

### 3.Gün
-Core katmanı oluşturuldu.<br/>
-Tüm sınıflar için crud operasyonları yazıldı.<br/>
-IDto oluşturulup gerekli tablolar join edildi.<br/>

### 4.Gün
-Core katmanına Result yapılandırması yapıldı.<br/> 
-Customers ve Users tabloları da oluşturulup birbirleriyle ilişkilendirildi.<br/> 
-Araba kiralanma bilgilerini tutan Rental tablosu da sisteme eklendi.<br/> 

### 5.Gün 
-Web API katmanı kuruldu.

### 6.Gün
-Projeye Autofac ve FluentValidation desteği eklendi.<br/> 
-Projeye AOP desteği eklendi.<br/> 


## Database Tables

![Kitap1 - Excel 18 02 2021 23_15_04](https://user-images.githubusercontent.com/77458312/108416501-d4956a00-723f-11eb-9c13-e70aed5cab40.png)


<br/>

**Database tables kodlarına [buradan](tables.sql) ulaşabilirsiniz.**
