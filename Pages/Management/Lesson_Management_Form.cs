using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UniOtomasyonUI.Manager;
using UniOtomasyonUI.Models.Department;
using UniOtomasyonUI.Models.Faculty;
using UniOtomasyonUI.Models.Lesson;
using WinFormUI.Layout;

namespace UniOtomasyonUI.Pages.Administration
{
    public partial class Lesson_Management_Form : MasterForm
    {
        RestManager restManager;
        List<Faculty> faculties;
        List<Department> departments;
        List<Lesson> lessons;
        public Lesson_Management_Form()
        {
            InitializeComponent();
            restManager = new RestManager();
            faculties = new List<Faculty>();
            departments = new List<Department>();
            lessons = new List<Lesson>();
        }

        /// <summary>
        /// Get faculties in system
        /// </summary>
        private void GetFaculties()
        {
            restManager.AddCookie("token", Program.ACCESS_TOKEN);
            RestResponse responseObject = (RestResponse)restManager.CreateHttpRequest("/v1/faculties", Method.GET);
            if (restManager.IsOperationSuccessful(responseObject))
            {
                faculties = JsonConvert.DeserializeObject<List<Faculty>>(restManager.ReadResponseField(responseObject, "datas").ToString());
                CB_Faculty.DataSource = faculties;
                CB_Faculty.DisplayMember = "name";
            }
        }

        /// <summary>
        /// Get departments when the faculty index has been changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CB_Faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            restManager.AddCookie("token", Program.ACCESS_TOKEN);
            RestResponse responseObject = (RestResponse)restManager.CreateHttpRequest("/v1/faculties/" + (CB_Faculty.SelectedIndex + 1) + "/departments", Method.GET);
            if (restManager.IsOperationSuccessful(responseObject))
            {
                departments = JsonConvert.DeserializeObject<List<Department>>(restManager.ReadResponseField(responseObject, "datas").ToString());
                CB_Department.DataSource = departments;
                CB_Department.DisplayMember = "Name";
            }
        }

        private void Lesson_Management_Form_Load(object sender, EventArgs e)
        {
            GetFaculties();
        }

        /// <summary>
        /// Get lessons by department Id
        /// </summary>
        /// <param name="id">Department Id</param>
        private void GetLessons(int id)
        {
            restManager.AddCookie("token", Program.ACCESS_TOKEN);
            RestResponse responseObject = (RestResponse)restManager.CreateHttpRequest("/v1/lessons/?departmentId=" + id, Method.GET);
            if (restManager.IsOperationSuccessful(responseObject))
            {
                lessons = JsonConvert.DeserializeObject<List<Lesson>>(restManager.ReadResponseField(responseObject, "data"));
                foreach (var lesson in lessons)
                {
                    DG_Lesson.Rows.Add( lesson.Id,
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
    }
}
