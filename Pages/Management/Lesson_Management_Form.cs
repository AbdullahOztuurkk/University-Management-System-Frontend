using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UniOtomasyonUI.Constants;
using UniOtomasyonUI.Manager;
using UniOtomasyonUI.Models.Department;
using UniOtomasyonUI.Models.Faculty;
using UniOtomasyonUI.Models.Lesson;
using WinFormUI.Layout;

namespace UniOtomasyonUI.Pages.Administration
{
    public partial class Lesson_Management_Form : MasterForm
    {
        static RestManager restManager;
        static List<Faculty> faculties;
        static List<Department> departments;
        static List<Lesson> lessons;
        string errorMessage;
        public Lesson_Management_Form()
        {
            InitializeComponent();
            restManager = new RestManager();
            faculties = new List<Faculty>();
            departments = new List<Department>();
            lessons = new List<Lesson>();
        }
        private void Lesson_Management_Form_Load(object sender, EventArgs e)
        {
            GetFaculties(restManager, CB_Faculty);
            GetFaculties(restManager, CB_Faculty_Input);
        }

        private void CB_Faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDepartments(restManager, CB_Department, CB_Faculty);
        }
        private void CB_Faculty_Input_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDepartments(restManager, CB_Department_Input, CB_Faculty_Input);
        }

        /// <summary>
        /// Get faculties in system
        /// </summary>
        public static void GetFaculties(RestManager restManager,ComboBox CBEntity)
        {
            restManager.AddCookie("token", Program.ACCESS_TOKEN);
            RestResponse responseObject = (RestResponse)restManager.CreateHttpRequest("/v1/faculties", Method.GET);
            if (restManager.IsOperationSuccessful(responseObject))
            {
                faculties = JsonConvert.DeserializeObject<List<Faculty>>(restManager.ReadResponseField(responseObject, "datas").ToString());
                CBEntity.DataSource = faculties;
                CBEntity.DisplayMember = "name";
            }
        }

        /// <summary>
        /// Get departments in system by facultyId
        /// </summary>
        public static void GetDepartments(RestManager restManager,ComboBox CBEntity, ComboBox CBTarget)
        {
            restManager.AddCookie("token", Program.ACCESS_TOKEN);
            RestResponse responseObject = (RestResponse)restManager.CreateHttpRequest("/v1/faculties/" + (CBTarget.SelectedIndex + 1) + "/departments", Method.GET);
            if (restManager.IsOperationSuccessful(responseObject))
            {
                departments = JsonConvert.DeserializeObject<List<Department>>(restManager.ReadResponseField(responseObject, "datas").ToString());
                CBEntity.DataSource = departments;
                CBEntity.DisplayMember = "Name";
            }
        }


        /// <summary>
        /// Get lessons by department Id
        /// </summary>
        /// <param name="id">Department Id</param>
        private void GetLessons(int id)
        {
            DG_Lesson.Rows.Clear();
            restManager.AddCookie("token", Program.ACCESS_TOKEN);
            RestResponse responseObject = (RestResponse)restManager.CreateHttpRequest("/v1/lessons/?departmentId=" + id, Method.GET);
            if (restManager.IsOperationSuccessful(responseObject))
            {
                lessons = JsonConvert.DeserializeObject<List<Lesson>>(restManager.ReadResponseField(responseObject, "data"));
                foreach (var lesson in lessons)
                {
                    DG_Lesson.Rows.Add(lesson.Id,
                                        lesson.Code,
                                        lesson.Name,
                                        lesson.Credit);
                }
            }
        }

        private void Btn_List_Click(object sender, EventArgs e)
        {
            DG_Lesson.Rows.Clear();
            GetLessons(CB_Department.SelectedIndex + 1);
        }

        /// <summary>
        /// Check form controls for security
        /// </summary>
        /// <returns>Validity</returns>
        private bool CheckValidation()
        {
            errorMessage = null;
            if (string.IsNullOrEmpty(Txt_Name.Text) ||
                string.IsNullOrEmpty(Txt_Code.Text)) { errorMessage = Messages.Invalid_Lesson_Identity; }
            else if (Txt_Credit.Value == 0 ||
                     NUD_Class.Value == 0) { errorMessage = Messages.Invalid_Lesson_Values; }
            else if (CB_Faculty_Input.DataSource == null ||
                     CB_Department_Input.DataSource == null) { errorMessage = Messages.Not_Empty_Department_Or_Faculty; }

            return errorMessage == null ? true : false;
        }

        /// <summary>
        /// Add lesson 
        /// </summary>
        private void Btn_Lesson_Add_Click(object sender, EventArgs e)
        {
            if (CheckValidation())
            {
                restManager.AddCookie("token", Program.ACCESS_TOKEN);
                CreateLessonDto createLessonDto = new CreateLessonDto
                {
                    Code = Txt_Code.Text,
                    Credit = (int)Txt_Credit.Value,
                    Name = Txt_Name.Text,
                    Grade = (int)NUD_Class.Value,
                    Status = "OPEN",
                };
                RestResponse responseObject = (RestResponse)restManager.CreateHttpRequest(
                    String.Concat("/v1/lessons/?departmentId=", CB_Department_Input.SelectedIndex + 1), Method.POST, createLessonDto);
                if (restManager.IsOperationSuccessful(responseObject))
                {
                    MessageBox.Show(Messages.Lesson_Added, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// Delete the lesson if a cell clicked in datagridview exam
        /// </summary>
        private void Btn_Lesson_Delete_Click(object sender, EventArgs e)
        {
            if(DG_Lesson.SelectedRows.Count == 0)
            {
                MessageBox.Show(Messages.Lesson_Delete_But_Unselected, "Hata", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                restManager.AddCookie("token", Program.ACCESS_TOKEN);
                RestResponse responseObject = (RestResponse)restManager.CreateHttpRequest(
                    String.Concat("/v1/lessons/", DG_Lesson.SelectedRows[0].Cells[0].Value), Method.DELETE);
                if(restManager.IsOperationSuccessful(responseObject))
                {
                    MessageBox.Show(Messages.Lesson_Deleted, "Bilgilendirme", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// Update the lesson if a cell clicked in datagridview exam
        /// </summary>
        private void Btn_Lesson_Update_Click(object sender, EventArgs e)
        {
            if (DG_Lesson.SelectedRows.Count == 0)
            {
                MessageBox.Show(Messages.Lesson_Update_But_Unselected, "Hata", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                CreateLessonDto createLessonDto = new CreateLessonDto
                {
                    Code = Txt_Code.Text,
                    Credit = (int)Txt_Credit.Value,
                    Name = Txt_Name.Text,
                    Grade = (int)NUD_Class.Value,
                    Status = "OPEN",
                };
                RestResponse responseObject = (RestResponse)restManager.CreateHttpRequest(
                    String.Concat("/v1/lessons/", CB_Department_Input.SelectedIndex + 1), Method.PATCH, createLessonDto);
                if (restManager.IsOperationSuccessful(responseObject))
                {
                    MessageBox.Show(Messages.Lesson_Updated, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
