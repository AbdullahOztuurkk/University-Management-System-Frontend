using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UniOtomasyonUI.Constants;
using UniOtomasyonUI.Manager;
using UniOtomasyonUI.Models;
using WinFormUI.Layout;

namespace UniOtomasyonUI.Pages.Informations
{
    public partial class Information_Form : MasterForm
    {
        Models.User CurrentUser = Program.CURRENT_USER;
        public Information_Form()
        {
            InitializeComponent();
        }

        private void Information_Form_Load(object sender, EventArgs e)
        {
            Txt_Name.Text = CurrentUser.FirstName;
            Txt_Surname.Text = CurrentUser.LastName;
            Txt_Status.Text = GetStatus(CurrentUser.Status);
            Lbl_Ad_Soyad.Text = String.Concat(CurrentUser.FirstName, " ", CurrentUser.LastName);
            //PB_User_Image.Image = CurrentUser.Image;
        }

        /// <summary>
        /// Get Turkish status
        /// </summary>
        /// <param name="status">User status</param>
        /// <returns>Turkish status</returns>
        private string GetStatus(string status)
        {
            switch (status)
            {
                case "ACTIVE": return "Aktif";
                case "INACTIVE": return "İnAktif";
                case "GRADUATE": return "Mezun";
                case "LEFT": return "Terk";
            }
            return null;
        }

        private void Information_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.OpenHiddenForm(new Student_Form().Name, new Lecturer_Form().Name, new Administrator_Form().Name);
        }
    }
}
