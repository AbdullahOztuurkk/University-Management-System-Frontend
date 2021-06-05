using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using UniOtomasyonUI.Manager;
using UniOtomasyonUI.Models.UserLesson;
using WinFormUI.Layout;

namespace UniOtomasyonUI.Pages.User
{
    public partial class Lessons_Form : MasterForm
    {
        RestManager restManager;
        Models.User CurrentUser = Program.CURRENT_USER;
        public Lessons_Form()
        {
            InitializeComponent();
            restManager = new RestManager();
        }

        private void Lessons_Form_Load(object sender, EventArgs e)
        {
            Lbl_Ad.Text = CurrentUser.FirstName;
            Lbl_Soyad.Text = CurrentUser.LastName;
            //PB_User_Image.Image = CurrentUser.Image;
            GetLessons();
        }
        
        private void GetLessons()
        {
            restManager.AddCookie("token", Program.ACCESS_TOKEN);
            RestResponse responseObject = (RestResponse)restManager.CreateHttpRequest("/v1/users/lessons", Method.GET);
            if (restManager.IsOperationSuccessful(responseObject))
            {
                List<UserLesson> UserLessonList = JsonConvert.DeserializeObject<List<UserLesson>>(restManager.ReadResponseField(responseObject, "data"));
                if (UserLessonList.Count > 0)
                {
                    foreach (var userLesson in UserLessonList)
                    {
                        DG_UserLesson.Rows.Add(
                            userLesson.Lesson.Code,
                            userLesson.Lesson.Name,
                            GetSeasonDescription(userLesson.Season),
                            userLesson.Lesson.Credit,
                            GetAverageDescription(userLesson.Average));
                    }
                }
            }
        }

        /// <summary>
        /// Get average description if average is 0
        /// </summary>
        private string GetAverageDescription(int average)
        {
            return average == 0 ? "Açıklanmadı" : average.ToString();
        }

        /// <summary>
        /// Get average description if average is 0
        /// </summary>
        private string GetSeasonDescription(string season)
        {
            switch (season)
            {
                case "SPRING": season = "Güz Dönemi"; break;
                case "WINTER": season = "Kış Dönemi"; break;
                case "SUMMER": season = "Yaz Dönemi"; break;
            }
            return season;
        }
    }
}
