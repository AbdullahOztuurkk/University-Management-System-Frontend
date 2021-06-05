using System;
using UniOtomasyonUI.Pages.Administration;
using UniOtomasyonUI.Pages.Informations;
using UniOtomasyonUI.Pages.Management;
using WinFormUI.Layout;

namespace UniOtomasyonUI.Pages
{
    public partial class Administrator_Form : MasterForm
    {
        public Administrator_Form()
        {
            InitializeComponent();
        }

        private void Panel_Informations_Click(object sender, EventArgs e)
        {
            Information_Form form = new Information_Form();
            form.ShowDialog();
        }

        private void Panel_Lessons_Click(object sender, EventArgs e)
        {
            Lesson_Management_Form form = new Lesson_Management_Form();
            form.ShowDialog();
        }

        private void Panel_Notes_Click(object sender, EventArgs e)
        {
            Note_Management_System form = new Note_Management_System();
            form.ShowDialog();
        }

        private void Panel_User_Click(object sender, EventArgs e)
        {
            User_Management_Form form = new User_Management_Form();
            form.ShowDialog();
        }
    }
}
