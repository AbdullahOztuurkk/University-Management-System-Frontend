﻿
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
            this.CB_Department = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CB_Faculty = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.DG_User = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_User)).BeginInit();
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
            this.groupBox2.Controls.Add(this.CB_Department);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.CB_Faculty);
            this.groupBox2.Controls.Add(this.label7);
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
            // CB_Department
            // 
            this.CB_Department.FormattingEnabled = true;
            this.CB_Department.Items.AddRange(new object[] {
            "Öğrenci",
            "Öğretmen",
            "Yetkili"});
            this.CB_Department.Location = new System.Drawing.Point(133, 211);
            this.CB_Department.Name = "CB_Department";
            this.CB_Department.Size = new System.Drawing.Size(113, 23);
            this.CB_Department.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(27, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Bölüm";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CB_Faculty
            // 
            this.CB_Faculty.FormattingEnabled = true;
            this.CB_Faculty.Items.AddRange(new object[] {
            "Öğrenci",
            "Öğretmen",
            "Yetkili"});
            this.CB_Faculty.Location = new System.Drawing.Point(133, 165);
            this.CB_Faculty.Name = "CB_Faculty";
            this.CB_Faculty.Size = new System.Drawing.Size(113, 23);
            this.CB_Faculty.TabIndex = 15;
            this.CB_Faculty.SelectedIndexChanged += new System.EventHandler(this.CB_Faculty_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(27, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fakülte :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Txt_Password
            // 
            this.Txt_Password.Location = new System.Drawing.Point(133, 78);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(229, 23);
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
            this.Btn_User_Add.Enabled = false;
            this.Btn_User_Add.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Btn_User_Add.FlatAppearance.BorderSize = 0;
            this.Btn_User_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_User_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_User_Add.Location = new System.Drawing.Point(636, 210);
            this.Btn_User_Add.Name = "Btn_User_Add";
            this.Btn_User_Add.Size = new System.Drawing.Size(112, 28);
            this.Btn_User_Add.TabIndex = 9;
            this.Btn_User_Add.Text = "Kullanıcı Ekle";
            this.Btn_User_Add.UseVisualStyleBackColor = false;
            this.Btn_User_Add.Click += new System.EventHandler(this.Btn_User_Add_Click);
            // 
            // Btn_User_Update
            // 
            this.Btn_User_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Btn_User_Update.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Btn_User_Update.FlatAppearance.BorderSize = 0;
            this.Btn_User_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_User_Update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_User_Update.Location = new System.Drawing.Point(509, 210);
            this.Btn_User_Update.Name = "Btn_User_Update";
            this.Btn_User_Update.Size = new System.Drawing.Size(112, 28);
            this.Btn_User_Update.TabIndex = 8;
            this.Btn_User_Update.Text = "Kullanıcı Güncelle";
            this.Btn_User_Update.UseVisualStyleBackColor = false;
            this.Btn_User_Update.Click += new System.EventHandler(this.Btn_User_Update_Click);
            // 
            // Btn_User_Delete
            // 
            this.Btn_User_Delete.BackColor = System.Drawing.Color.Red;
            this.Btn_User_Delete.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Btn_User_Delete.FlatAppearance.BorderSize = 0;
            this.Btn_User_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_User_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_User_Delete.Location = new System.Drawing.Point(382, 210);
            this.Btn_User_Delete.Name = "Btn_User_Delete";
            this.Btn_User_Delete.Size = new System.Drawing.Size(112, 28);
            this.Btn_User_Delete.TabIndex = 7;
            this.Btn_User_Delete.Text = "Kullanıcı Sil";
            this.Btn_User_Delete.UseVisualStyleBackColor = false;
            this.Btn_User_Delete.Click += new System.EventHandler(this.Btn_User_Delete_Click);
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
            this.CB_Role.Size = new System.Drawing.Size(229, 23);
            this.CB_Role.TabIndex = 5;
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(133, 36);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(229, 23);
            this.Txt_Name.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(27, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Yetki :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(27, 78);
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
            this.groupBox1.Controls.Add(this.DG_User);
            this.groupBox1.Location = new System.Drawing.Point(9, 437);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 264);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tüm Öğrenciler";
            // 
            // DG_User
            // 
            this.DG_User.AllowUserToAddRows = false;
            this.DG_User.AllowUserToDeleteRows = false;
            this.DG_User.AllowUserToResizeColumns = false;
            this.DG_User.AllowUserToResizeRows = false;
            this.DG_User.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_User.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DG_User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_User.ColumnHeadersHeight = 38;
            this.DG_User.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.UserName,
            this.UserSurname,
            this.UserStatus,
            this.Email});
            this.DG_User.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DG_User.Location = new System.Drawing.Point(3, 19);
            this.DG_User.MultiSelect = false;
            this.DG_User.Name = "DG_User";
            this.DG_User.ReadOnly = true;
            this.DG_User.RowTemplate.Height = 25;
            this.DG_User.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_User.Size = new System.Drawing.Size(757, 242);
            this.DG_User.TabIndex = 0;
            this.DG_User.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_User_CellClick);
            this.DG_User.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_User_CellClick);
            // 
            // UserId
            // 
            this.UserId.HeaderText = "Id";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Adı";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // UserSurname
            // 
            this.UserSurname.HeaderText = "Soyadı";
            this.UserSurname.Name = "UserSurname";
            this.UserSurname.ReadOnly = true;
            // 
            // UserStatus
            // 
            this.UserStatus.HeaderText = "Durum";
            this.UserStatus.Name = "UserStatus";
            this.UserStatus.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "İletişim Adresi";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
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
            this.Text = "Kullanıcı Yönetim Paneli";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.User_Management_Form_FormClosed);
            this.Load += new System.EventHandler(this.User_Management_Form_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_User)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DG_User;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.ComboBox CB_Faculty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CB_Department;
    }
}