using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using UniOtomasyonUI.Manager;
using UniOtomasyonUI.Models.Exam;
using UniOtomasyonUI.Pages.User;
using WinFormUI.Layout;

namespace UniOtomasyonUI.Pages.Management
{
    public partial class Exam_Management_System : MasterForm
    {
        RestManager restManager;
        public Exam_Management_System()
        {
            InitializeComponent();
            restManager = new RestManager();
        }

        private void Exam_Management_System_Load(object sender, System.EventArgs e)
        {
            GetExams();
        }

        private void GetExams()
        {
            restManager.AddCookie("token", Program.ACCESS_TOKEN);
            RestResponse responseObject = (RestResponse)restManager.CreateHttpRequest("v1/exams/", Method.GET);
            if (restManager.IsOperationSuccessful(responseObject))
            {
                List<Exam> Exams = JsonConvert.DeserializeObject<List<Exam>>(restManager.ReadResponseField(responseObject, "data"));
                if (Exams.Count > 0)
                {
                    foreach (var exam in Exams)
                    {
                        DG_Exam.Rows.Add(
                            exam.UserLesson.user.FirstName,
                            exam.UserLesson.user.LastName,
                            exam.UserLesson.lesson.code,
                            exam.UserLesson.lesson.name,
                            exam.UserLesson.lesson.credit,
                            Exams_Form.GetExamTypeDescription(exam.Type),
                            exam.Score,
                            exam.announcementDate.ToShortDateString());
                    }
                }
            }
        }
    }
}
