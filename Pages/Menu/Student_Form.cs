using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UniOtomasyonUI.Pages.Informations;
using WinFormUI.Layout;

namespace UniOtomasyonUI.Pages
{
    public partial class Student_Form : MasterForm
    {
        public Student_Form()
        {
            InitializeComponent();
        }

        private void Panel_Exams_Click(object sender, EventArgs e)
        {
            //Code Here
        }

        private void Panel_Informations_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            Information_Form form = new Information_Form();
            form.ShowDialog();
        }
    }
}
