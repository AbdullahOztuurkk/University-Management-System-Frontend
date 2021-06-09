
namespace UniOtomasyonUI
{
    partial class Homepage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Txt_Code = new System.Windows.Forms.Label();
            this.Txt_Security_Code = new System.Windows.Forms.MaskedTextBox();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Txt_User_Password = new System.Windows.Forms.TextBox();
            this.Txt_User_Email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PB_Security = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Security)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 148);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(780, 563);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.PB_Security);
            this.panel2.Controls.Add(this.Txt_Code);
            this.panel2.Controls.Add(this.Txt_Security_Code);
            this.panel2.Controls.Add(this.Btn_Login);
            this.panel2.Controls.Add(this.Txt_User_Password);
            this.panel2.Controls.Add(this.Txt_User_Email);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(199, 126);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 309);
            this.panel2.TabIndex = 0;
            // 
            // Txt_Code
            // 
            this.Txt_Code.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Txt_Code.Location = new System.Drawing.Point(128, 166);
            this.Txt_Code.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_Code.Name = "Txt_Code";
            this.Txt_Code.Size = new System.Drawing.Size(46, 20);
            this.Txt_Code.TabIndex = 6;
            this.Txt_Code.Text = "12345";
            // 
            // Txt_Security_Code
            // 
            this.Txt_Security_Code.Location = new System.Drawing.Point(181, 167);
            this.Txt_Security_Code.Mask = "00000";
            this.Txt_Security_Code.Name = "Txt_Security_Code";
            this.Txt_Security_Code.PromptChar = ' ';
            this.Txt_Security_Code.Size = new System.Drawing.Size(154, 23);
            this.Txt_Security_Code.TabIndex = 2;
            this.Txt_Security_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Security_Code.ValidatingType = typeof(int);
            // 
            // Btn_Login
            // 
            this.Btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(111)))));
            this.Btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Login.ForeColor = System.Drawing.Color.White;
            this.Btn_Login.Location = new System.Drawing.Point(255, 228);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(104, 33);
            this.Btn_Login.TabIndex = 4;
            this.Btn_Login.Text = "Giriş Yap";
            this.Btn_Login.UseVisualStyleBackColor = false;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Txt_User_Password
            // 
            this.Txt_User_Password.Location = new System.Drawing.Point(87, 114);
            this.Txt_User_Password.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Txt_User_Password.MaxLength = 16;
            this.Txt_User_Password.Name = "Txt_User_Password";
            this.Txt_User_Password.Size = new System.Drawing.Size(272, 23);
            this.Txt_User_Password.TabIndex = 1;
            this.Txt_User_Password.UseSystemPasswordChar = true;
            // 
            // Txt_User_Email
            // 
            this.Txt_User_Email.Location = new System.Drawing.Point(87, 61);
            this.Txt_User_Email.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Txt_User_Email.MaxLength = 50;
            this.Txt_User_Email.Name = "Txt_User_Email";
            this.Txt_User_Email.Size = new System.Drawing.Size(272, 23);
            this.Txt_User_Email.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(22, 166);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Güvenlik Kodu :";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(22, 113);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Şifre :";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(22, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(33, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sisteme Giriş";
            // 
            // PB_Security
            // 
            this.PB_Security.BackColor = System.Drawing.Color.Transparent;
            this.PB_Security.Image = global::UniOtomasyonUI.Properties.Resources.refresh;
            this.PB_Security.Location = new System.Drawing.Point(336, 167);
            this.PB_Security.Name = "PB_Security";
            this.PB_Security.Size = new System.Drawing.Size(23, 23);
            this.PB_Security.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Security.TabIndex = 7;
            this.PB_Security.TabStop = false;
            this.PB_Security.Click += new System.EventHandler(this.PB_Security_Click);
            // 
            // Homepage
            // 
            this.AcceptButton = this.Btn_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "Homepage";
            this.ShowIcon = false;
            this.Text = "Sivas Cumhuriyet Üniversitesi OBS";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Security)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_User_Password;
        private System.Windows.Forms.TextBox Txt_User_Email;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.MaskedTextBox Txt_Security_Code;
        private System.Windows.Forms.Label Txt_Code;
        private System.Windows.Forms.PictureBox PB_Security;
    }
}