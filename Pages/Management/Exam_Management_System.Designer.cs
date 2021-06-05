
namespace UniOtomasyonUI.Pages.Management
{
    partial class Exam_Management_System
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exam_Management_System));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_Lesson_Add = new System.Windows.Forms.Button();
            this.Btn_Lesson_Update = new System.Windows.Forms.Button();
            this.Btn_Lesson_Delete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DG_Exam = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LessonCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LessonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LessonCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamAnnouncementDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.CB_Faculty = new System.Windows.Forms.ComboBox();
            this.CB_Department = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Btn_List = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Exam)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 148);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(780, 283);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_Lesson_Add);
            this.groupBox2.Controls.Add(this.Btn_Lesson_Update);
            this.groupBox2.Controls.Add(this.Btn_Lesson_Delete);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(210, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(360, 253);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sınav Ekle";
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
            this.Btn_Lesson_Add.Size = new System.Drawing.Size(88, 28);
            this.Btn_Lesson_Add.TabIndex = 10;
            this.Btn_Lesson_Add.Text = "Ders Ekle";
            this.Btn_Lesson_Add.UseVisualStyleBackColor = false;
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
            this.Btn_Lesson_Update.Size = new System.Drawing.Size(88, 28);
            this.Btn_Lesson_Update.TabIndex = 9;
            this.Btn_Lesson_Update.Text = "Ders Güncelle";
            this.Btn_Lesson_Update.UseVisualStyleBackColor = false;
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
            this.Btn_Lesson_Delete.Size = new System.Drawing.Size(88, 28);
            this.Btn_Lesson_Delete.TabIndex = 8;
            this.Btn_Lesson_Delete.Text = "Ders Sil";
            this.Btn_Lesson_Delete.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DG_Exam);
            this.groupBox1.Location = new System.Drawing.Point(9, 467);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 234);
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
            this.UserName,
            this.UserSurname,
            this.LessonCode,
            this.LessonName,
            this.LessonCredit,
            this.ExamType,
            this.ExamScore,
            this.ExamAnnouncementDate});
            this.DG_Exam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DG_Exam.Location = new System.Drawing.Point(3, 19);
            this.DG_Exam.MultiSelect = false;
            this.DG_Exam.Name = "DG_Exam";
            this.DG_Exam.ReadOnly = true;
            this.DG_Exam.RowTemplate.Height = 25;
            this.DG_Exam.Size = new System.Drawing.Size(757, 212);
            this.DG_Exam.TabIndex = 0;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Kullanıcı Adı";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // UserSurname
            // 
            this.UserSurname.HeaderText = "Kullanıcı Soyadı";
            this.UserSurname.Name = "UserSurname";
            this.UserSurname.ReadOnly = true;
            // 
            // LessonCode
            // 
            this.LessonCode.HeaderText = "Ders Kodu";
            this.LessonCode.Name = "LessonCode";
            this.LessonCode.ReadOnly = true;
            // 
            // LessonName
            // 
            this.LessonName.HeaderText = "Ders Adı";
            this.LessonName.Name = "LessonName";
            this.LessonName.ReadOnly = true;
            // 
            // LessonCredit
            // 
            this.LessonCredit.HeaderText = "Kredi";
            this.LessonCredit.Name = "LessonCredit";
            this.LessonCredit.ReadOnly = true;
            // 
            // ExamType
            // 
            this.ExamType.HeaderText = "Sınav Türü";
            this.ExamType.Name = "ExamType";
            this.ExamType.ReadOnly = true;
            // 
            // ExamScore
            // 
            this.ExamScore.HeaderText = "Not";
            this.ExamScore.Name = "ExamScore";
            this.ExamScore.ReadOnly = true;
            // 
            // ExamAnnouncementDate
            // 
            this.ExamAnnouncementDate.HeaderText = "Yayınlanma Tarih";
            this.ExamAnnouncementDate.Name = "ExamAnnouncementDate";
            this.ExamAnnouncementDate.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.tableLayoutPanel2.Controls.Add(this.label8, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.CB_Faculty, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.CB_Department, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.Btn_List, 5, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 435);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(780, 26);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(22, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "Fakülte Seçiniz :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CB_Faculty
            // 
            this.CB_Faculty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CB_Faculty.FormattingEnabled = true;
            this.CB_Faculty.Location = new System.Drawing.Point(170, 3);
            this.CB_Faculty.Name = "CB_Faculty";
            this.CB_Faculty.Size = new System.Drawing.Size(142, 23);
            this.CB_Faculty.TabIndex = 1;
            // 
            // CB_Department
            // 
            this.CB_Department.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CB_Department.FormattingEnabled = true;
            this.CB_Department.Location = new System.Drawing.Point(466, 3);
            this.CB_Department.Name = "CB_Department";
            this.CB_Department.Size = new System.Drawing.Size(142, 23);
            this.CB_Department.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(318, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 26);
            this.label9.TabIndex = 3;
            this.label9.Text = "Bölüm Seçiniz :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_List
            // 
            this.Btn_List.BackColor = System.Drawing.Color.LimeGreen;
            this.Btn_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_List.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_List.ForeColor = System.Drawing.Color.White;
            this.Btn_List.Location = new System.Drawing.Point(611, 0);
            this.Btn_List.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_List.Name = "Btn_List";
            this.Btn_List.Size = new System.Drawing.Size(148, 26);
            this.Btn_List.TabIndex = 4;
            this.Btn_List.Text = "Listele";
            this.Btn_List.UseVisualStyleBackColor = false;
            // 
            // Exam_Management_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Exam_Management_System";
            this.Text = "Ders Yönetim Paneli";
            this.Load += new System.EventHandler(this.Exam_Management_System_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Exam)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CB_Faculty;
        private System.Windows.Forms.ComboBox CB_Department;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn announcementDate;
        private System.Windows.Forms.Button Btn_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamAnnouncementDate;
    }
}