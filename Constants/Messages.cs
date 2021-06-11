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
        public static string Not_Empty_Department_Or_Faculty = "Fakülte yada bölüm adını girmek zorundasınız!";
        public static string Lesson_Delete_But_Unselected = "Ders silmek için öncelikle silmek istediğiniz dersi seçin!";
        public static string Lesson_Update_But_Unselected = "Ders güncellemek için öncelikle herhangi bir dersi seçin!";
        public static string Invalid_Exam_Lesson = "Sınav eklemek için ilgili öğrencinin eklemek istediğiniz dersini seçin!";
        public static string Exam_Delete_But_Unselected = "Sınav silmek için öncelikle sınavı seçin!";
        public static string Exam_Update_But_Unselected = "Sınav güncellemek için öncelikle sınav seçin!";
        public static string User_Delete_But_Unselected = "Kullanıcı güncellemek için öncelikle herhangi bir kullanıcı seçin!";
        public static string Not_Empty_User_Properties = "KUllanıcı güncellerken yada eklerken lütfen gerekli bilgileri giriniz!";
        public static string Doesnt_Match_Password = "Şifreler Uyuşmuyor";

        //Information Messages
        public static string Lesson_Added = "Ders başarıyla eklendi.";
        public static string Lesson_Updated = "Ders başarıyla silindi.";
        public static string Lesson_Deleted = "Ders başarıyla silindi.";
        public static string Exam_Added = "Sınav başarıyla eklendi.";
        public static string Exam_Deleted = "Sınav başarıyla silindi.";
        public static string Exam_Updated = "Sınav başarıyla güncellendi.";
        public static string User_Deleted = "Kullanıcı başarıyla silindi.";
        public static string User_Added = "Kullanıcı başarıyla eklendi.";
        public static string User_Updated = "Kullanıcı başarıyla güncellendi.";

    }
}
