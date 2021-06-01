using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace UniOtomasyonUI.Manager
{
    public static class FormManager
    {
        /// <summary>
        /// Open Hidden Form when another form is closed
        /// </summary>
        /// <param name="formName">Opened form name list</param>
        public static void OpenHiddenForm(params string[] formName)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Visible == false)
                {
                    foreach(string name in formName)
                    {
                        if (frm.Name == name)
                            frm.Visible = true;
                    }
                }
            }
        }
    }
}
