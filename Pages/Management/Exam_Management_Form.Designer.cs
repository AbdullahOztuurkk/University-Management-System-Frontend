
namespace UniOtomasyonUI.Pages.Management
{
    partial class Exam_Management_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exam_Management_Form));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NUD_Score = new System.Windows.Forms.NumericUpDown();
            this.CB_Type = new System.Windows.Forms.ComboBox();
            this.CB_Name = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DG_User = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_UserSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Lesson_Add = new System.Windows.Forms.Button();
            this.Btn_Lesson_Update = new System.Windows.Forms.Button();
            this.Btn_Lesson_Delete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DG_Exam = new System.Windows.Forms.DataGridView();
            this.Id_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LessonName_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamType_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnnouncementDate_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LessonCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LessonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LessonCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamAnnouncementDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_User)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Exam)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
            this.groupBox2.Controls.Add(this.NUD_Score);
            this.groupBox2.Controls.Add(this.CB_Type);
            this.groupBox2.Controls.Add(this.CB_Name);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.DG_User);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Btn_Lesson_Add);
            this.groupBox2.Controls.Add(this.Btn_Lesson_Update);
            this.groupBox2.Controls.Add(this.Btn_Lesson_Delete);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(15, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(750, 253);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sınav Ekle";
            // 
            // NUD_Score
            // 
            this.NUD_Score.Location = new System.Drawing.Point(106, 144);
            this.NUD_Score.Name = "NUD_Score";
            this.NUD_Score.Size = new System.Drawing.Size(211, 23);
            this.NUD_Score.TabIndex = 18;
            // 
            // CB_Type
            // 
            this.CB_Type.FormattingEnabled = true;
            this.CB_Type.Items.AddRange(new object[] {
            "Vize",
            "Proje",
            "Final",
            "Büt"});
            this.CB_Type.Location = new System.Drawing.Point(106, 88);
            this.CB_Type.Name = "CB_Type";
            this.CB_Type.Size = new System.Drawing.Size(211, 23);
            this.CB_Type.TabIndex = 17;
            // 
            // CB_Name
            // 
            this.CB_Name.FormattingEnabled = true;
            this.CB_Name.Location = new System.Drawing.Point(106, 33);
            this.CB_Name.Name = "CB_Name";
            this.CB_Name.Size = new System.Drawing.Size(211, 23);
            this.CB_Name.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Puan :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sınav Türü :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ders Adı :";
            // 
            // DG_User
            // 
            this.DG_User.AllowUserToAddRows = false;
            this.DG_User.AllowUserToDeleteRows = false;
            this.DG_User.AllowUserToResizeRows = false;
            this.DG_User.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_User.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DG_User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_User.ColumnHeadersHeight = 38;
            this.DG_User.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.GV_UserName,
            this.GV_UserSurname});
            this.DG_User.Location = new System.Drawing.Point(349, 19);
            this.DG_User.MultiSelect = false;
            this.DG_User.Name = "DG_User";
            this.DG_User.ReadOnly = true;
            this.DG_User.RowHeadersWidth = 30;
            this.DG_User.RowTemplate.Height = 25;
            this.DG_User.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_User.Size = new System.Drawing.Size(395, 219);
            this.DG_User.TabIndex = 0;
            this.DG_User.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_User_CellClick);
            this.DG_User.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_User_CellClick);
            // 
            // Id
            // 
            this.Id.FillWeight = 30F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // GV_UserName
            // 
            this.GV_UserName.FillWeight = 130.9645F;
            this.GV_UserName.HeaderText = "Adı";
            this.GV_UserName.Name = "GV_UserName";
            this.GV_UserName.ReadOnly = true;
            // 
            // GV_UserSurname
            // 
            this.GV_UserSurname.FillWeight = 130.9645F;
            this.GV_UserSurname.HeaderText = "Soyadı";
            this.GV_UserSurname.Name = "GV_UserSurname";
            this.GV_UserSurname.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 11;
            // 
            // Btn_Lesson_Add
            // 
            this.Btn_Lesson_Add.BackColor = System.Drawing.Color.LimeGreen;
            this.Btn_Lesson_Add.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Btn_Lesson_Add.FlatAppearance.BorderSize = 0;
            this.Btn_Lesson_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Lesson_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Lesson_Add.Location = new System.Drawing.Point(250, 210);
            this.Btn_Lesson_Add.Name = "Btn_Lesson_Add";
            this.Btn_Lesson_Add.Size = new System.Drawing.Size(93, 28);
            this.Btn_Lesson_Add.TabIndex = 10;
            this.Btn_Lesson_Add.Text = "Sınav Ekle";
            this.Btn_Lesson_Add.UseVisualStyleBackColor = false;
            this.Btn_Lesson_Add.Click += new System.EventHandler(this.Btn_Lesson_Add_Click);
            // 
            // Btn_Lesson_Update
            // 
            this.Btn_Lesson_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Btn_Lesson_Update.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Btn_Lesson_Update.FlatAppearance.BorderSize = 0;
            this.Btn_Lesson_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Lesson_Update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Lesson_Update.Location = new System.Drawing.Point(134, 210);
            this.Btn_Lesson_Update.Name = "Btn_Lesson_Update";
            this.Btn_Lesson_Update.Size = new System.Drawing.Size(93, 28);
            this.Btn_Lesson_Update.TabIndex = 9;
            this.Btn_Lesson_Update.Text = "Sınav Güncelle";
            this.Btn_Lesson_Update.UseVisualStyleBackColor = false;
            this.Btn_Lesson_Update.Click += new System.EventHandler(this.Btn_Lesson_Update_Click);
            // 
            // Btn_Lesson_Delete
            // 
            this.Btn_Lesson_Delete.BackColor = System.Drawing.Color.Red;
            this.Btn_Lesson_Delete.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Btn_Lesson_Delete.FlatAppearance.BorderSize = 0;
            this.Btn_Lesson_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Lesson_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Lesson_Delete.Location = new System.Drawing.Point(18, 210);
            this.Btn_Lesson_Delete.Name = "Btn_Lesson_Delete";
            this.Btn_Lesson_Delete.Size = new System.Drawing.Size(93, 28);
            this.Btn_Lesson_Delete.TabIndex = 8;
            this.Btn_Lesson_Delete.Text = "Sınav Kaldır";
            this.Btn_Lesson_Delete.UseVisualStyleBackColor = false;
            this.Btn_Lesson_Delete.Click += new System.EventHandler(this.Btn_Lesson_Delete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DG_Exam);
            this.groupBox1.Location = new System.Drawing.Point(9, 434);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 267);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tüm Dersler";
            // 
            // DG_Exam
            // 
            this.DG_Exam.AllowUserToAddRows = false;
            this.DG_Exam.AllowUserToDeleteRows = false;
            this.DG_Exam.AllowUserToResizeRows = false;
            this.DG_Exam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_Exam.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DG_Exam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_Exam.ColumnHeadersHeight = 38;
            this.DG_Exam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Column,
            this.Name_Column,
            this.Surname_Column,
            this.Code_Column,
            this.LessonName_Column,
            this.Credit_Column,
            this.ExamType_Column,
            this.Score_Column,
            this.AnnouncementDate_Column});
            this.DG_Exam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DG_Exam.Location = new System.Drawing.Point(3, 19);
            this.DG_Exam.MultiSelect = false;
            this.DG_Exam.Name = "DG_Exam";
            this.DG_Exam.ReadOnly = true;
            this.DG_Exam.RowTemplate.Height = 25;
            this.DG_Exam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Exam.Size = new System.Drawing.Size(757, 245);
            this.DG_Exam.TabIndex = 0;
            this.DG_Exam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Exam_CellClick);
            // 
            // Id_Column
            // 
            this.Id_Column.FillWeight = 40F;
            this.Id_Column.HeaderText = "Id";
            this.Id_Column.Name = "Id_Column";
            this.Id_Column.ReadOnly = true;
            // 
            // Name_Column
            // 
            this.Name_Column.HeaderText = "Adı";
            this.Name_Column.Name = "Name_Column";
            this.Name_Column.ReadOnly = true;
            // 
            // Surname_Column
            // 
            this.Surname_Column.HeaderText = "Soyadı";
            this.Surname_Column.Name = "Surname_Column";
            this.Surname_Column.ReadOnly = true;
            // 
            // Code_Column
            // 
            this.Code_Column.HeaderText = "Ders Kodu";
            this.Code_Column.Name = "Code_Column";
            this.Code_Column.ReadOnly = true;
            // 
            // LessonName_Column
            // 
            this.LessonName_Column.HeaderText = "Ders Adı";
            this.LessonName_Column.Name = "LessonName_Column";
            this.LessonName_Column.ReadOnly = true;
            // 
            // Credit_Column
            // 
            this.Credit_Column.HeaderText = "Kredi";
            this.Credit_Column.Name = "Credit_Column";
            this.Credit_Column.ReadOnly = true;
            // 
            // ExamType_Column
            // 
            this.ExamType_Column.HeaderText = "Sınav Türü";
            this.ExamType_Column.Name = "ExamType_Column";
            this.ExamType_Column.ReadOnly = true;
            // 
            // Score_Column
            // 
            this.Score_Column.HeaderText = "Puan";
            this.Score_Column.Name = "Score_Column";
            this.Score_Column.ReadOnly = true;
            // 
            // AnnouncementDate_Column
            // 
            this.AnnouncementDate_Column.HeaderText = "Tarih";
            this.AnnouncementDate_Column.Name = "AnnouncementDate_Column";
            this.AnnouncementDate_Column.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.FillWeight = 101.0787F;
            this.UserName.HeaderText = "Kullanıcı Adı";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // UserSurname
            // 
            this.UserSurname.FillWeight = 101.0787F;
            this.UserSurname.HeaderText = "Kullanıcı Soyadı";
            this.UserSurname.Name = "UserSurname";
            this.UserSurname.ReadOnly = true;
            // 
            // LessonCode
            // 
            this.LessonCode.FillWeight = 101.0787F;
            this.LessonCode.HeaderText = "Ders Kodu";
            this.LessonCode.Name = "LessonCode";
            this.LessonCode.ReadOnly = true;
            // 
            // LessonName
            // 
            this.LessonName.FillWeight = 101.0787F;
            this.LessonName.HeaderText = "Ders Adı";
            this.LessonName.Name = "LessonName";
            this.LessonName.ReadOnly = true;
            // 
            // LessonCredit
            // 
            this.LessonCredit.FillWeight = 101.0787F;
            this.LessonCredit.HeaderText = "Kredi";
            this.LessonCredit.Name = "LessonCredit";
            this.LessonCredit.ReadOnly = true;
            // 
            // ExamType
            // 
            this.ExamType.FillWeight = 101.0787F;
            this.ExamType.HeaderText = "Sınav Türü";
            this.ExamType.Name = "ExamType";
            this.ExamType.ReadOnly = true;
            // 
            // ExamScore
            // 
            this.ExamScore.FillWeight = 101.0787F;
            this.ExamScore.HeaderText = "Not";
            this.ExamScore.Name = "ExamScore";
            this.ExamScore.ReadOnly = true;
            // 
            // ExamAnnouncementDate
            // 
            this.ExamAnnouncementDate.FillWeight = 101.0787F;
            this.ExamAnnouncementDate.HeaderText = "Yayınlanma Tarih";
            this.ExamAnnouncementDate.Name = "ExamAnnouncementDate";
            this.ExamAnnouncementDate.ReadOnly = true;
            // 
            // Exam_Management_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Exam_Management_Form";
            this.Text = "Sınav Yönetim Paneli";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Exam_Management_System_FormClosed);
            this.Load += new System.EventHandler(this.Exam_Management_System_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_User)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Exam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DG_Exam;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_Lesson_Delete;
        private System.Windows.Forms.Button Btn_Lesson_Add;
        private System.Windows.Forms.Button Btn_Lesson_Update;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn announcementDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DG_User;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NUD_Score;
        private System.Windows.Forms.ComboBox CB_Type;
        private System.Windows.Forms.ComboBox CB_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamAnnouncementDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_UserSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonName_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamType_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnnouncementDate_Column;
    }
}