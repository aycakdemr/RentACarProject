
# ReCapProject

![rental-car-insurance](https://user-images.githubusercontent.com/77458312/108398371-fb48a600-7229-11eb-8366-96c0e4c6f1fb.png)

## Getting Started

Çok katlı mimari örneği olan bu proje başlıca Business,DataAccess,Core,Entities ve WebAPI katmanlarından oluşmaktadır.
## Packages

### Business
-Autofac(6.1.0)<br/>
-Autofac.Extras.DynamicProxy(6.0.0)<br/>
-Autofac.Extensions.DependencyInjection(7.1.0)<br/>
-FluentValidation(9.5.1)<br/>
-Microsoft.AspNetCore.Http.Abstractions(2.2.0)<br/>
-Microsoft.Extensions.DependencyInjection(5.0.1)<br/>
-NETStandard.Library(2.0.3)<br/>

### Core
-Autofac(6.1.0)<br/>
-Autofac.Extensions.DependencyInjection(7.1.0)<br/>
-Autofac.Extras.DynamicProxy(6.0.0)<br/>
-FluentValidation(9.5.1)<br/>
-Microsoft.EntityFrameworkCore.SqlServer(3.1.11)<br/>
-Microsoft.AspNetCore.Http(2.2.2)<br/>
-Microsoft.AspNetCore.Http.Abstractions(2.2.0)<br/>
-Microsoft.AspNetCore.Http.Features(5.0.3)<br/>
-Microsoft.Extensions.Configuration(5.0.0)<br/>
-Microsoft.IdentityModel.Tokens(6.8.0)<br/>
-NETStandard.Library(2.0.3)<br/>
-Newtonsoft.Json(12.0.3)<br/>
-System.IdentityModel.Tokens.Jwt(6.8.0)<br/>

### DataAccess
-Microsoft.EntityFrameworkCore.SqlServer(3.1.11)<br/>
-NETStandard.Library(2.0.3)<br/>

### WebAPI
-Autofac.Extensions.DependencyInjection(7.1.0)<br/>
-Microsoft.AspNetCore.Authentication.JwtBearer(3.1.11)<br/>

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

### 7.Gün
-Api üzerinden arabaya resim ekleyecek sistemi yazıldı.
-Resim silme, güncelleme yetenekleri eklendi.

### 8.Gün
-Projeye JWT entegrasyonu yapıldı.

### 9.Gün
-Cache, Transaction ve Performance aspectlerini eklendi.



## Database Tables

![Kitap1 - Excel 16 04 2021 21_14_47](https://user-images.githubusercontent.com/77458312/115067197-3baa6480-9ef9-11eb-9298-0485b6d6ce19.png)



<br/>

**T_SQL kodlarına [buradan](tables.sql) ulaşabilirsiniz.**

