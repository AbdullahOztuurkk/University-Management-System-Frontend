using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UniOtomasyonUI.Manager;
using WinFormUI.Layout;

namespace UniOtomasyonUI.Pages.Management
{
    public partial class User_Management_Form : MasterForm
    {
        RestManager restManager;
        public User_Management_Form()
        {
            InitializeComponent();
            restManager = new RestManager();
        }

        private void User_Management_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.OpenHiddenForm(new Administrator_Form().Name);
        }

        private void User_Management_Form_Load(object sender, EventArgs e)
        {
            GetUsers();
        }

        /// <summary>
        /// Get All student users 
        /// </summary>
        private void GetUsers()
        {
            restManager.AddCookie("token", Program.ACCESS_TOKEN);
            //restManager.AddParameter("departmentId", departmentId);
            RestResponse responseObject = (RestResponse)restManager.CreateHttpRequest("/v1/users/students", Method.GET);
            if (restManager.IsOperationSuccessful(responseObject))
            {
                List<Models.User> users = JsonConvert.DeserializeObject<List<Models.User>>(restManager.ReadResponseField(responseObject, "data").ToString());
                foreach (var user in users)
                {
                    DG_User.Rows.Add(user.Id,
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
    }
}
