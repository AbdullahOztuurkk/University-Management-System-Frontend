using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UniOtomasyonUI.Manager;
using UniOtomasyonUI.Models;
using UniOtomasyonUI.Models.Dto;
using UniOtomasyonUI.Models.Exam;
using WinFormUI.Layout;

namespace UniOtomasyonUI.Pages.User
{
    public partial class Exams_Form : MasterForm
    {
        RestManager restManager;
        Models.User CurrentUser = Program.CURRENT_USER;
        public Exams_Form()
        {
            InitializeComponent();
            restManager = new RestManager();
        }

        private void Exams_Form_Load(object sender, EventArgs e)
        {
            Lbl_Ad.Text = CurrentUser.FirstName;
            Lbl_Soyad.Text = CurrentUser.LastName;
            //PB_User_Image.Image = CurrentUser.Image;
            GetExams();
        }

        private void Exams_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.OpenHiddenForm(new Student_Form().Name);
        }

        /// <summary>
        /// Get Exams by current user id and deploy the datagridview
        /// </summary>
        private void GetExams()
        {
            GetExamsDto examsDto = new GetExamsDto { Id = CurrentUser.Id };
            restManager.AddCookie("token", Program.ACCESS_TOKEN);
            RestResponse responseObject = (RestResponse)restManager.CreateHttpRequest("v1/exam/", Method.GET, examsDto);
            if (restManager.ReadResponseField(responseObject, "success") == false.ToString())
            {
                MessageBox.Show(restManager.ReadResponseField(responseObject, "message"), "Bilgilendirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (restManager.ReadResponseField(responseObject, "success") == true.ToString())
            {
                List<Exam> Exams = JsonConvert.DeserializeObject<List<Exam>>(restManager.ReadResponseField(responseObject, "data"));
                if (Exams.Count > 0)
                {
                    foreach (var exam in Exams)
                    {
                        DG_Exam.Rows.Add(
                            exam.UserLesson.lesson.code,
                            exam.UserLesson.lesson.name,
                            exam.UserLesson.lesson.credit,
                            GetExamTypeDescription(exam.Type),
                            exam.Score,
                            exam.announcementDate.ToShortDateString());
                    }
                }
            }
        }


        /// <summary>
        /// Get type Turkish description by exam type
        /// </summary>
        private string GetExamTypeDescription(string examType)
        {
            switch (examType)
            {
                case "MID": examType = "Vize"; break;
                case "PROJECT": examType = "Proje"; break;
                case "FINAL": examType = "Final"; break;
                case "MAKEUP": examType = "Büt"; break;
            }
            return examType;
        }
    }
}
