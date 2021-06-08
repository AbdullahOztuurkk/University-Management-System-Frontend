using System;
using System.Windows.Forms;
using UniOtomasyonUI.Pages.Informations;
using UniOtomasyonUI.Pages.Management;
using WinFormUI.Layout;

namespace UniOtomasyonUI.Pages
{
    public partial class Lecturer_Form : MasterForm
    {
        public Lecturer_Form()
        {
            InitializeComponent();
        }

        private void Panel_Note_Click(object sender, EventArgs e)
        {
            Exam_Management_Form form = new Exam_Management_Form();
            form.ShowDialog();
        }

        private void Panel_Informations_Click(object sender, EventArgs e)
        {
            Information_Form form = new Information_Form();
            form.ShowDialog();
        }
    }
}
