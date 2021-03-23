using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constans
{
    public class Messages
    {
        public static string added = "eklendi";
        public static string deleted = "silindi";
        public static string updated = "güncellendi";
        public static string error = "hata";
        public static string listed = "listelendi";
        public static string succeed = "başarılı";

        public static string CarImagesCountExceded= "Daha fazla resim eklenemez.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "kayıt oldu";
        public static string UserNotFound = "kullanıcı bulunamadı";
        public static string PasswordError = "parola hatası";
        public static string SuccessfulLogin = "başarılı giriş";
        public static string UserAlreadyExists = "kullanıcı zaten var";
        public static string AccessTokenCreated;

        public static string RentalNotAvailable = "Kiralanabilir Değil";
    }
}
