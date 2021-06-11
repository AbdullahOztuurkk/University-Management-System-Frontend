using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UniOtomasyonUI.Constants;
using UniOtomasyonUI.Manager;
using UniOtomasyonUI.Models.User;
using UniOtomasyonUI.Pages.Administration;
using WinFormUI.Layout;

namespace UniOtomasyonUI.Pages.Management
{
    public partial class User_Management_Form : MasterForm
    {
        RestManager restManager;
        int RowIndexModified;
        string errorMessage;
        public User_Management_Form()
        {
            InitializeComponent();
            restManager = new RestManager();
            CB_Role.SelectedIndex = 0;
            CB_Status.SelectedIndex = 0;
            Lesson_Management_Form.GetFaculties(CB_Faculty);
        }

        private void User_Management_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.OpenHiddenForm(new Administrator_Form().Name);
        }

        private void User_Management_Form_Load(object sender, EventArgs e)
        {
            GetUsers(DG_User);
        }

        /// <summary>
        /// Get All student users 
        /// </summary>
        public void GetUsers(DataGridView dg_view)
        {
            restManager.AddCookie("token", Program.ACCESS_TOKEN);
            //restManager.AddParameter("departmentId", departmentId);
            RestResponse responseObject = (RestResponse)restManager.CreateHttpRequest("/v1/users/students", Method.GET);
            if (restManager.IsOperationSuccessful(responseObject))
            {
                List<Models.User.User> users = JsonConvert.DeserializeObject<List<Models.User.User>>(restManager.ReadResponseField(responseObject, "data").ToString());
                foreach (var user in users)
                {
                    dg_view.Rows.Add(user.Id,
                                    user.FirstName,
                                    user.LastName,
                                    GetStatusDescription(user.Status),
                                    user.Email);
                }
            }
        }

        /// <summary>
        /// Get status description 
        /// </summary>
        private string GetStatusDescription(string status)
        {
            switch (status)
            {
                case "ACTIVE": status = "Aktif"; break;
                case "INACTIVE": status = "İnaktif"; break;
                case "GRADUATE": status = "Mezun"; break;
                case "LEFT": status = "Terk"; break;
            }
            return status;
        }

        /// <summary>
        /// Delete the user if a cell clicked in datagridview_user
        /// </summary>
        private void Btn_User_Delete_Click(object sender, EventArgs e)
        {
            if (DG_User.SelectedRows.Count > 0)
            {
                restManager.AddCookie("token", Program.ACCESS_TOKEN);
                RestResponse responseObject = (RestResponse)restManager.CreateHttpRequest(
                    String.Concat("/v1/users/", DG_User.Rows[RowIndexModified].Cells[0].Value), Method.DELETE);
                if (restManager.IsOperationSuccessful(responseObject))
                {
                    MessageBox.Show(Messages.User_Deleted, "Bilgilendirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(Messages.User_Delete_But_Unselected, "Bilgilendirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Get row index for update or delete data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DG_User_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowIndexModified = e.RowIndex;
        }

        /// <summary>
        /// Update the existed user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_User_Update_Click(object sender, EventArgs e)
        {
            if (DG_User.SelectedRows.Count > 0)
            {
                if (CheckValidation())
                {
                    UpdateUserDto userDto = new UpdateUserDto
                    {
                        FirstName = Txt_Name.Text,
                        LastName = Txt_Surname.Text,
                        Password = Txt_Password.Text,
                        Status = CB_Status.Text,
                        Role = CB_Role.Text
                    };
                    restManager.AddCookie("token", Program.ACCESS_TOKEN);
                    RestResponse responseObject = (RestResponse)restManager.CreateHttpRequest(
                        String.Concat("/v1/users/", DG_User.Rows[RowIndexModified].Cells[0].Value), Method.DELETE);
                    if (restManager.IsOperationSuccessful(responseObject))
                    {
                        MessageBox.Show(Messages.User_Deleted, "Bilgilendirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show(Messages.User_Delete_But_Unselected, "Bilgilendirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Add User to database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_User_Add_Click(object sender, EventArgs e)
        {
            if (CheckValidation())
            {
                CreateUserDto userDto = new CreateUserDto
                {
                    FirstName = Txt_Name.Text,
                    LastName = Txt_Surname.Text,
                    Password = Txt_Password.Text,
                    Role = CB_Role.Text,
                    DepartmentId = (CB_Department.SelectedIndex + 1)
                };
                restManager.AddCookie("token", Program.ACCESS_TOKEN);
                RestResponse responseObject = (RestResponse)restManager.CreateHttpRequest(
                    String.Concat("/v1/users/", DG_User.Rows[RowIndexModified].Cells[0].Value), Method.POST, userDto);
                if (restManager.IsOperationSuccessful(responseObject))
                {
                    MessageBox.Show(Messages.User_Added, "Bilgilendirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(errorMessage, "Bilgilendirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        ///  Check input values for security
        /// </summary>
        /// <returns>Validity</returns>
        private bool CheckValidation()
        {
            errorMessage = null;
            if (String.IsNullOrEmpty(Txt_Name.Text) ||
                String.IsNullOrEmpty(Txt_Password.Text) ||
                String.IsNullOrEmpty(Txt_Password_Again.Text) ||
                String.IsNullOrEmpty(Txt_Surname.Text)) { errorMessage = Messages.Not_Empty_User_Properties; }
            else if (Txt_Password.Text != Txt_Password_Again.Text) { errorMessage = Messages.Doesnt_Match_Password; }
            else if (CB_Department.SelectedItem == null) { errorMessage = Messages.Not_Empty_Department_Or_Faculty; }
            return errorMessage == null ? true : false;
        }

        private void CB_Faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lesson_Management_Form.GetDepartments(CB_Department, CB_Faculty);
        }
    }
}
