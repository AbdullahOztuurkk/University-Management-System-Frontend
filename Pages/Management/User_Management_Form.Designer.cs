
namespace UniOtomasyonUI.Pages.Management
{
    partial class User_Management_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Management_Form));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.CB_Status = new System.Windows.Forms.ComboBox();
            this.Txt_Password_Again = new System.Windows.Forms.TextBox();
            this.Txt_Surname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Btn_User_Add = new System.Windows.Forms.Button();
            this.Btn_User_Update = new System.Windows.Forms.Button();
            this.Btn_User_Delete = new System.Windows.Forms.Button();
            this.CB_Role = new System.Windows.Forms.ComboBox();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DG_Lesson = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Lesson)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 148);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(780, 283);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Txt_Password);
            this.groupBox2.Controls.Add(this.CB_Status);
            this.groupBox2.Controls.Add(this.Txt_Password_Again);
            this.groupBox2.Controls.Add(this.Txt_Surname);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.Btn_User_Add);
            this.groupBox2.Controls.Add(this.Btn_User_Update);
            this.groupBox2.Controls.Add(this.Btn_User_Delete);
            this.groupBox2.Controls.Add(this.CB_Role);
            this.groupBox2.Controls.Add(this.Txt_Name);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(15, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(750, 253);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kullanıcı Ekle";
            // 
            // Txt_Password
            // 
            this.Txt_Password.Location = new System.Drawing.Point(135, 78);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(227, 23);
            this.Txt_Password.TabIndex = 3;
            this.Txt_Password.UseSystemPasswordChar = true;
            // 
            // CB_Status
            // 
            this.CB_Status.FormattingEnabled = true;
            this.CB_Status.Items.AddRange(new object[] {
            "Aktif",
            "İnaktif",
            "Mezun",
            "Terk"});
            this.CB_Status.Location = new System.Drawing.Point(500, 120);
            this.CB_Status.Name = "CB_Status";
            this.CB_Status.Size = new System.Drawing.Size(227, 23);
            this.CB_Status.TabIndex = 6;
            // 
            // Txt_Password_Again
            // 
            this.Txt_Password_Again.Location = new System.Drawing.Point(500, 78);
            this.Txt_Password_Again.Name = "Txt_Password_Again";
            this.Txt_Password_Again.Size = new System.Drawing.Size(227, 23);
            this.Txt_Password_Again.TabIndex = 4;
            this.Txt_Password_Again.UseSystemPasswordChar = true;
            // 
            // Txt_Surname
            // 
            this.Txt_Surname.Location = new System.Drawing.Point(500, 36);
            this.Txt_Surname.Name = "Txt_Surname";
            this.Txt_Surname.Size = new System.Drawing.Size(227, 23);
            this.Txt_Surname.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(394, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 13;
            this.label9.Text = "Mevcut Durum :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(394, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 12;
            this.label10.Text = "Şifre (Tekrar) :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(394, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 11;
            this.label11.Text = "Soyadı :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_User_Add
            // 
            this.Btn_User_Add.BackColor = System.Drawing.Color.LimeGreen;
            this.Btn_User_Add.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Btn_User_Add.FlatAppearance.BorderSize = 0;
            this.Btn_User_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_User_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_User_Add.Location = new System.Drawing.Point(637, 210);
            this.Btn_User_Add.Name = "Btn_User_Add";
            this.Btn_User_Add.Size = new System.Drawing.Size(111, 28);
            this.Btn_User_Add.TabIndex = 9;
            this.Btn_User_Add.Text = "Kullanıcı Ekle";
            this.Btn_User_Add.UseVisualStyleBackColor = false;
            // 
            // Btn_User_Update
            // 
            this.Btn_User_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Btn_User_Update.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Btn_User_Update.FlatAppearance.BorderSize = 0;
            this.Btn_User_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_User_Update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_User_Update.Location = new System.Drawing.Point(510, 210);
            this.Btn_User_Update.Name = "Btn_User_Update";
            this.Btn_User_Update.Size = new System.Drawing.Size(111, 28);
            this.Btn_User_Update.TabIndex = 8;
            this.Btn_User_Update.Text = "Kullanıcı Güncelle";
            this.Btn_User_Update.UseVisualStyleBackColor = false;
            // 
            // Btn_User_Delete
            // 
            this.Btn_User_Delete.BackColor = System.Drawing.Color.Red;
            this.Btn_User_Delete.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Btn_User_Delete.FlatAppearance.BorderSize = 0;
            this.Btn_User_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_User_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_User_Delete.Location = new System.Drawing.Point(383, 210);
            this.Btn_User_Delete.Name = "Btn_User_Delete";
            this.Btn_User_Delete.Size = new System.Drawing.Size(111, 28);
            this.Btn_User_Delete.TabIndex = 7;
            this.Btn_User_Delete.Text = "Kullanıcı Sil";
            this.Btn_User_Delete.UseVisualStyleBackColor = false;
            // 
            // CB_Role
            // 
            this.CB_Role.FormattingEnabled = true;
            this.CB_Role.Items.AddRange(new object[] {
            "Öğrenci",
            "Öğretmen",
            "Yetkili"});
            this.CB_Role.Location = new System.Drawing.Point(133, 120);
            this.CB_Role.Name = "CB_Role";
            this.CB_Role.Size = new System.Drawing.Size(227, 23);
            this.CB_Role.TabIndex = 5;
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(133, 36);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(227, 23);
            this.Txt_Name.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(27, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Yetki :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(27, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Şifre :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(27, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Adı :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DG_Lesson);
            this.groupBox1.Location = new System.Drawing.Point(9, 437);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 264);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tüm Kullanıcılar";
            // 
            // DG_Lesson
            // 
            this.DG_Lesson.AllowUserToAddRows = false;
            this.DG_Lesson.AllowUserToDeleteRows = false;
            this.DG_Lesson.AllowUserToResizeColumns = false;
            this.DG_Lesson.AllowUserToResizeRows = false;
            this.DG_Lesson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_Lesson.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DG_Lesson.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_Lesson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Lesson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DG_Lesson.Location = new System.Drawing.Point(3, 19);
            this.DG_Lesson.MultiSelect = false;
            this.DG_Lesson.Name = "DG_Lesson";
            this.DG_Lesson.ReadOnly = true;
            this.DG_Lesson.RowTemplate.Height = 25;
            this.DG_Lesson.Size = new System.Drawing.Size(757, 242);
            this.DG_Lesson.TabIndex = 0;
            // 
            // User_Management_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "User_Management_Form";
            this.Text = "Ders Yönetim Paneli";
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Lesson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DG_Lesson;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_User_Delete;
        private System.Windows.Forms.ComboBox CB_Role;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_User_Add;
        private System.Windows.Forms.Button Btn_User_Update;
        private System.Windows.Forms.ComboBox CB_Status;
        private System.Windows.Forms.TextBox Txt_Password_Again;
        private System.Windows.Forms.TextBox Txt_Surname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Txt_Password;
    }
}