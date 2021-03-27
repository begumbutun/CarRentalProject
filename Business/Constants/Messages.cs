using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string RentsAdded = "Araba kiralama işlemi başarılı.";
        public static string NameInvalid = "Araba teslim edilmedi.Kiralama işlemi başarısız.";
        internal static string BrandAdded = "Marka Eklendi";
        internal static string BrandDeleted="Marka Silindi";
        internal static string BrandUpdated="Marka Güncellendi";
        internal static string CarAdded="Araba Eklendi";
        internal static string CarDeleted="Araba Silindi";
        internal static string CarUpdated="Araba Güncellendi";
        internal static string ColorAdded="Renk Eklendi";
        internal static string ColorDeleted="Renk Silindi";
        internal static string ColorUpdated="Renk Güncellendi";
        internal static string CarImagesAdded="Resim Eklendi";
        internal static string CarImagesUpdated="Yeni Resim Güncellendi";
        internal static String  AuthorizationDenied = "Yetkiniz Yok.";
        internal static string UserRegistered="Kullanıcı Kayıtlı";
        internal static String UserNotFound="Kullanıcı Bulunamadı";
        internal static String PasswordError="Şifre Hatalı";
        internal static string SuccessfulLogin="Giriş Başarılı";
        internal static string UserAlreadyExists="Kullanıcı Mevcut";
        internal static string AccessTokenCreated="Token Oluşturuldu";
    }
}

