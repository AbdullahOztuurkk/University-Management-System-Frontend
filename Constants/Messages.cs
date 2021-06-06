using System;
using System.Collections.Generic;
using System.Text;

namespace UniOtomasyonUI.Constants
{
    public static class Messages
    {
        //Validation Messages
        public static string Invalid_Email = "Geçersiz bir mail girdiniz!";
        public static string Not_Empty_Credentials = "Email ve şifre boş girilemez.";
        public static string Invalid_Security_Code = "Güvenlik kodu hatalı !";
        public static string Invalid_Lesson_Identity = "Ders oluştururken isim ve ders kodu girmek zorundasınız!";
        public static string Invalid_Lesson_Values = "Ders oluştururken kredi ve sınıfı 0'dan büyük girmek zorundasınız!";
        public static string Not_Empty_Department_Or_Faculty = "Ders oluştururken fakülte yada bölüm adını girmek zorundasınız!";
        public static string Lesson_Delete_But_Unselected = "Ders silmek için öncelikle silmek istediğiniz dersi seçin!";

        //Information Messages
        public static string Lesson_Added = "Ders başarıyla eklendi.";
        public static string Lesson_Deleted = "Ders başarıyla silindi.";
    }
}
