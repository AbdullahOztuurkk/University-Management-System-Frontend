using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UniOtomasyonUI.Constants;
using UniOtomasyonUI.Manager;
using UniOtomasyonUI.Models.Exam;
using UniOtomasyonUI.Models.UserLesson;
using UniOtomasyonUI.Pages.User;
using WinFormUI.Layout;

namespace UniOtomasyonUI.Pages.Management
{
    public partial class Exam_Management_Form : MasterForm
    {
        RestManager restManager;
        List<UserLesson> userLessonList;
        string errorMessage;
        public Exam_Management_Form()
        {
            InitializeComponent();
            restManager = new RestManager();
            userLessonList = new List<UserLesson>();
        }

        private void Exam_Management_System_Load(object sender, System.EventArgs e)
        {
            GetExams();
        }

        /// <summary>
        /// Check user input for security
        /// </summary>
        /// <returns>Validity</returns>
        private bool CheckValidation()
        {
            errorMessage = null;
            if( CB_Name.DataSource == null || String.IsNullOrEmpty(CB_Name.SelectedItem.ToString())) { errorMessage = Messages.Invalid_Exam_Lesson; }   

            return errorMessage == null ? true : false;
        }

        /// <summary>
        /// Get User Lessons for exam
        /// </summary>
        /// <param name="UserId">User id</param>
        private void GetUserLesson(int UserId)
        {
            restManager.AddCookie("token", Program.ACCESS_TOKEN);
            RestResponse responseObject = (RestResponse)restManager.CreateHttpRequest("/v1/users/lessons/"+UserId, Method.GET);
                if (restManager.IsOperationSuccessful(responseObject))
            {
                userLessonList = JsonConvert.DeserializeObject<List<UserLesson>>(restManager.ReadResponseField(responseObject, "data"));
                CB_Name.DataSource = userLessonList;
                CB_Name.DisplayMember = "LessonName";
            }
        }


        /// <summary>
        /// Get All Exams with user informations
        /// </summary>
        private void GetExams()
        {
            DG_Exam.Rows.Clear();
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
                            exam.UserLesson.lesson.Code,
                            exam.UserLesson.lesson.Name,
                            exam.UserLesson.lesson.Credit,
                            Exams_Form.GetExamTypeDescription(exam.Type),
                            exam.Score,
                            exam.announcementDate.ToShortDateString());
                        new User_Management_Form().GetUsers(DG_User);
                    }
                }
            }
        }

        private void Exam_Management_System_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            FormManager.OpenHiddenForm(new Administrator_Form().Name);
            Console.WriteLine("");
        }

        /// <summary>
        /// Add Exam by user lesson id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Lesson_Add_Click(object sender, EventArgs e)
        {
            if (CheckValidation())
            {
                CreateExamDto createExamDto = new CreateExamDto
                {
                    Score = (int)NUD_Score.Value,
                    announcementDate = DateTime.UtcNow,
                    Type = GetExamType(CB_Type.Text),
                    UserLessonId = Convert.ToInt32(DG_User.SelectedRows[0].Cells[0].Value)
                };
                RestResponse responseObject = (RestResponse)restManager.CreateHttpRequest("/v1/exams/",Method.POST,createExamDto);
                if (restManager.IsOperationSuccessful(responseObject))
                {
                    MessageBox.Show(Messages.Exam_Added, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetExams();
                }
            }
        }

        /// <summary>
        /// Get exam type for insert exam
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private string GetExamType(string text)
        {
            switch (CB_Type.SelectedIndex)
            {
                case 0: text = "MIDTERM"; break;
                case 1: text = "PROJECT"; break;
                case 2: text = "FINAL";break;
                case 3: text = "MAKEUP"; break;
            }
            return text;
        }

        /// <summary>
        /// Get user lessons when a cell clicked in dg_user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DG_User_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            GetUserLesson(Convert.ToInt32(DG_User.Rows[e.RowIndex].Cells[0].Value));
        }

        private void Btn_Lesson_Delete_Click(object sender, EventArgs e)
        {
            if(DG_User.SelectedRows.Count>0)
            {
                DeleteExamDto deleteExamDto = new DeleteExamDto { Id = Convert.ToInt32(DG_User.SelectedRows[0].Cells[0].Value) };
                RestResponse responseObject = (RestResponse)restManager.CreateHttpRequest(
                    String.Concat("/v1/exams/",deleteExamDto.Id),Method.DELETE);
                if(restManager.IsOperationSuccessful(responseObject))
                {
                    MessageBox.Show(Messages.Exam_Deleted, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetExams();
                }
            }
            else
            {
                MessageBox.Show(Messages.Exam_Delete_But_Unselected, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
