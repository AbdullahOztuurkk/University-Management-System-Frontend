using System;
using UniOtomasyonUI.Pages;
using WinFormUI.Layout;

namespace UniOtomasyonUI
{
    public partial class Homepage : MasterForm
    {
        public Homepage()
        {
            InitializeComponent();
        }
        private void CB_User_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            Student_Form form = new Student_Form();
            form.ShowDialog();
        }
    }
}
