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

### Cars

|Name | Data Type|
|-----|-----------|
|Id|int|
|BrandId|int|
|ColorId|int|
|ModelYear|int|
|DailyPrice|int|
|Description|nchar(100)|

### Brands

|Name | Data Type|
|-----|-----------|
|BrandId|int|
|BrandName|nchar(100)|

### Colors
|Name | Data Type|
|-----|-----------|
|ColorId|int|
|ColorName|nchar(100)|

### Customers

|Name | Data Type|
|-----|-----------|
|UserId|int|
|CompanyName|nchar(100)|
|CustomerId|int|

### Users
|Name | Data Type|
|-----|-----------|
|Id|int|
|FirstName|nchar(100)|
|LastName|int|
|EMail|nchar(100)|
|Password|int|

### Rentals

|Name | Data Type|
|-----|-----------|
|CarId|int|
|RentDate|nchar(100)|
|CustomerId|int|
|ReturnDate|nchar(100)|

<br/>

### All Of The Project

![ReCapProject - Microsoft Visual Studio 18 02 2021 21_36_02](https://user-images.githubusercontent.com/77458312/108405126-c3ddf780-7231-11eb-8b83-96be31ec72ce.png)
![ReCapProject - Microsoft Visual Studio 18 02 2021 21_39_55](https://user-images.githubusercontent.com/77458312/108405262-ec65f180-7231-11eb-9763-5d6793c9fede.png)
![ReCapProject - Microsoft Visual Studio 18 02 2021 21_40_54](https://user-images.githubusercontent.com/77458312/108405333-04d60c00-7232-11eb-8d20-e91584c9a190.png)
![ReCapProject - Microsoft Visual Studio 18 02 2021 21_41_32](https://user-images.githubusercontent.com/77458312/108405456-259e6180-7232-11eb-9999-989e00b7d866.png)
![ReCapProject - Microsoft Visual Studio 18 02 2021 21_42_28](https://user-images.githubusercontent.com/77458312/108405552-41a20300-7232-11eb-842c-7a498e037e40.png)
