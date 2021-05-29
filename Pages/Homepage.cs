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
        public static int SECURITY_CODE_LENGTH = 5;

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            Student_Form form = new Student_Form();
            form.ShowDialog();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            Txt_Code.Text = Create_Security_Code();
        }

        static string Create_Security_Code()
        {
            return new Random().Next(99999999).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Txt_Code.Text = Create_Security_Code();
        }
    }
}
