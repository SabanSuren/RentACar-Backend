using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public class Messages
    {
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola Hatalı";
        public static string SuccessfulLogin = "Başarılı Giriş";
        public static string UserAlreadyExists = "Kullanıcı sistemde mevcut";
        public static string AccessTokenCreated = "Accces Token Oluşturuldu";

        public static string Addet = "Veri eklendi";

        public static string Delete = "Veri Silindi";

        public static string Update = "Veri Güncellendi";


        public static string CarNameInvalid = "Araç Adı Geçersiz";


        public static string MaintenanceTime = "Sistem Bakım Saati";

        public static string CarsListed = "Arabalar Listelendi";
        public static string AddRentalErrorRentedCar = "Araba Teslim edilmemiş";
        public static string PhotoAdded = "Fotoğraf Eklendi:";
        public static string PhotoDeleted = "Fotoğraf Silindi";
        public static string DataListed = "Veriler Listelendi:";
        public static string PhotoUpdate = "fotoğraf Güncellendi:";
        public static string PhotoLimitExceded = "Bir aracın max 5 Fotoğrafı bulunmalıdır:";
        public static string EmailErroro = "Bu Email Sistemde Mevcut:";

        public static string AuthorizationDenied = "Bu işlem için yetkiniz bulunmamaktadır";
        public static string UserRegistered = "Kullanıcı Başarılı bir şekilde kayıt edildi";
        internal static string RentalEndDateNotEntered;
        internal static string BrandIdListed;
        internal static string ColorIdListed;
    }
}
