﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using UniOtomasyonUI.Constants;
using UniOtomasyonUI.Manager;
using UniOtomasyonUI.Models;
using UniOtomasyonUI.Models.Concrete.Dto;
using UniOtomasyonUI.Pages;
using WinFormUI.Layout;

namespace UniOtomasyonUI
{
    public partial class Homepage : MasterForm
    {
        private string errorMessage;
        RestManager restManager;
        public Homepage()
        {
            InitializeComponent();
            restManager = new RestManager();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if (CheckValidation())
            {
                var userLoginDto = new UserLoginDto() { Email = Txt_User_Email.Text, Password = Txt_User_Password.Text };
                RestResponse responseObject = (RestResponse)restManager.CreateHttpRequest("/v1/auth/login", Method.POST, userLoginDto);
                if (restManager.ReadResponseField(responseObject, "success") == false.ToString())
                {
                    MessageBox.Show(restManager.ReadResponseField(responseObject, "message"), "Bilgilendirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else if (restManager.ReadResponseField(responseObject, "success") == true.ToString())
                {
                    Program.ACCESS_TOKEN = responseObject.Cookies[0].Value;
                    restManager.AddCookie("token", Program.ACCESS_TOKEN);
                    RestResponse responseMe = (RestResponse)restManager.CreateHttpRequest("/v1/auth/me", Method.GET);
                    Program.CURRENT_USER = JsonConvert.DeserializeObject<User>(restManager.ReadResponseField(responseMe, "data"));
                    OpenUserForm(Program.CURRENT_USER.Role);
                }
            }
            else
            {
                MessageBox.Show(errorMessage, "Bilgilendirme", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// Security code is generated when the form is opened 
        /// </summary>
        private void Homepage_Load(object sender, EventArgs e)
        {
            Txt_Code.Text = Create_Security_Code();
        }

        /// <summary>
        /// Generate security code before login
        /// </summary>
        /// <returns></returns>
        static string Create_Security_Code()
        {
            return new Random().Next(10000, 99999).ToString();
        }

        /// <summary>
        /// Check the email address is valid
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Regenerate security code
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            Txt_Code.Text = Create_Security_Code();
        }

        /// <summary>
        /// Open user form by role
        /// </summary>
        /// <param name="role">User Role</param>
        private void OpenUserForm(string role)
        {
            switch (role)
            {
                case "STUDENT":
                    Student_Form student_Form = new Student_Form();
                    student_Form.ShowDialog();
                    break;
                case "TEACHER":
                    Lecturer_Form lecturer_Form = new Lecturer_Form();
                    lecturer_Form.ShowDialog();
                    break;
                case "ADMIN":
                    Administrator_Form administrator_Form = new Administrator_Form();
                    administrator_Form.ShowDialog();
                    break;
            }
        }

        /// <summary>
        /// Check user input for security
        /// </summary>
        /// <returns>Validity</returns>
        private bool CheckValidation()
        {
            errorMessage = null;
            if (!IsValidEmail(Txt_User_Email.Text)) { errorMessage = Messages.Invalid_Email; }
            else if (Txt_User_Email.Text == "" || Txt_User_Password.Text == "") { errorMessage = Messages.Not_Empty_Credentials; }
            else if (Txt_Security_Code.Text != Txt_Code.Text) { errorMessage = Messages.Invalid_Security_Code; }

            return errorMessage == null ? true : false;
        }
    }
}
