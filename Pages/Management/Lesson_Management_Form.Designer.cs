﻿
namespace UniOtomasyonUI.Pages.Administration
{
    partial class Lesson_Management_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lesson_Management_Form));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt_Code = new System.Windows.Forms.TextBox();
            this.CB_Department_Input = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Btn_Lesson_Add = new System.Windows.Forms.Button();
            this.Btn_Lesson_Update = new System.Windows.Forms.Button();
            this.Btn_Lesson_Delete = new System.Windows.Forms.Button();
            this.CB_Faculty_Input = new System.Windows.Forms.ComboBox();
            this.NUD_Class = new System.Windows.Forms.NumericUpDown();
            this.Txt_Credit = new System.Windows.Forms.NumericUpDown();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DG_Lesson = new System.Windows.Forms.DataGridView();
            this.LessonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessonCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LessonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LessonCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.CB_Faculty = new System.Windows.Forms.ComboBox();
            this.CB_Department = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Btn_List = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Class)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Credit)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Lesson)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.groupBox2.Controls.Add(this.Txt_Code);
            this.groupBox2.Controls.Add(this.CB_Department_Input);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.Btn_Lesson_Add);
            this.groupBox2.Controls.Add(this.Btn_Lesson_Update);
            this.groupBox2.Controls.Add(this.Btn_Lesson_Delete);
            this.groupBox2.Controls.Add(this.CB_Faculty_Input);
            this.groupBox2.Controls.Add(this.NUD_Class);
            this.groupBox2.Controls.Add(this.Txt_Credit);
            this.groupBox2.Controls.Add(this.Txt_Name);
            this.groupBox2.Controls.Add(this.label7);
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
            this.groupBox2.Text = "Ders Ekle";
            // 
            // Txt_Code
            // 
            this.Txt_Code.Location = new System.Drawing.Point(502, 119);
            this.Txt_Code.Name = "Txt_Code";
            this.Txt_Code.Size = new System.Drawing.Size(227, 23);
            this.Txt_Code.TabIndex = 14;
            // 
            // CB_Department_Input
            // 
            this.CB_Department_Input.FormattingEnabled = true;
            this.CB_Department_Input.Location = new System.Drawing.Point(502, 78);
            this.CB_Department_Input.Name = "CB_Department_Input";
            this.CB_Department_Input.Size = new System.Drawing.Size(227, 23);
            this.CB_Department_Input.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(396, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 12;
            this.label11.Text = "Ders Kodu :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(396, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 11;
            this.label10.Text = "Bölüm :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Lesson_Add
            // 
            this.Btn_Lesson_Add.BackColor = System.Drawing.Color.LimeGreen;
            this.Btn_Lesson_Add.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Btn_Lesson_Add.FlatAppearance.BorderSize = 0;
            this.Btn_Lesson_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Lesson_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Lesson_Add.Location = new System.Drawing.Point(641, 208);
            this.Btn_Lesson_Add.Name = "Btn_Lesson_Add";
            this.Btn_Lesson_Add.Size = new System.Drawing.Size(88, 28);
            this.Btn_Lesson_Add.TabIndex = 10;
            this.Btn_Lesson_Add.Text = "Ders Ekle";
            this.Btn_Lesson_Add.UseVisualStyleBackColor = false;
            this.Btn_Lesson_Add.Click += new System.EventHandler(this.Btn_Lesson_Add_Click);
            // 
            // Btn_Lesson_Update
            // 
            this.Btn_Lesson_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Btn_Lesson_Update.Enabled = false;
            this.Btn_Lesson_Update.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Btn_Lesson_Update.FlatAppearance.BorderSize = 0;
            this.Btn_Lesson_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Lesson_Update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Lesson_Update.Location = new System.Drawing.Point(522, 208);
            this.Btn_Lesson_Update.Name = "Btn_Lesson_Update";
            this.Btn_Lesson_Update.Size = new System.Drawing.Size(88, 28);
            this.Btn_Lesson_Update.TabIndex = 9;
            this.Btn_Lesson_Update.Text = "Ders Güncelle";
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
            this.Btn_Lesson_Delete.Location = new System.Drawing.Point(403, 208);
            this.Btn_Lesson_Delete.Name = "Btn_Lesson_Delete";
            this.Btn_Lesson_Delete.Size = new System.Drawing.Size(88, 28);
            this.Btn_Lesson_Delete.TabIndex = 8;
            this.Btn_Lesson_Delete.Text = "Ders Sil";
            this.Btn_Lesson_Delete.UseVisualStyleBackColor = false;
            this.Btn_Lesson_Delete.Click += new System.EventHandler(this.Btn_Lesson_Delete_Click);
            // 
            // CB_Faculty_Input
            // 
            this.CB_Faculty_Input.FormattingEnabled = true;
            this.CB_Faculty_Input.Location = new System.Drawing.Point(502, 34);
            this.CB_Faculty_Input.Name = "CB_Faculty_Input";
            this.CB_Faculty_Input.Size = new System.Drawing.Size(227, 23);
            this.CB_Faculty_Input.TabIndex = 7;
            this.CB_Faculty_Input.SelectedIndexChanged += new System.EventHandler(this.CB_Faculty_Input_SelectedIndexChanged);
            // 
            // NUD_Class
            // 
            this.NUD_Class.Location = new System.Drawing.Point(111, 119);
            this.NUD_Class.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NUD_Class.Name = "NUD_Class";
            this.NUD_Class.Size = new System.Drawing.Size(227, 23);
            this.NUD_Class.TabIndex = 6;
            // 
            // Txt_Credit
            // 
            this.Txt_Credit.Location = new System.Drawing.Point(112, 77);
            this.Txt_Credit.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.Txt_Credit.Name = "Txt_Credit";
            this.Txt_Credit.Size = new System.Drawing.Size(227, 23);
            this.Txt_Credit.TabIndex = 5;
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(112, 35);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(227, 23);
            this.Txt_Name.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Sınıf :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(396, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Fakülte :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ders Kredisi :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ders Adı :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DG_Lesson);
            this.groupBox1.Location = new System.Drawing.Point(9, 467);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 234);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tüm Dersler";
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
            this.DG_Lesson.ColumnHeadersHeight = 38;
            this.DG_Lesson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LessonId,
            this.lessonCode,
            this.LessonName,
            this.LessonCredit});
            this.DG_Lesson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DG_Lesson.Location = new System.Drawing.Point(3, 19);
            this.DG_Lesson.MultiSelect = false;
            this.DG_Lesson.Name = "DG_Lesson";
            this.DG_Lesson.ReadOnly = true;
            this.DG_Lesson.RowTemplate.Height = 25;
            this.DG_Lesson.Size = new System.Drawing.Size(757, 212);
            this.DG_Lesson.TabIndex = 0;
            // 
            // LessonId
            // 
            this.LessonId.HeaderText = "Id";
            this.LessonId.Name = "LessonId";
            this.LessonId.ReadOnly = true;
            // 
            // lessonCode
            // 
            this.lessonCode.HeaderText = "Ders Kodu";
            this.lessonCode.Name = "lessonCode";
            this.lessonCode.ReadOnly = true;
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
            this.CB_Faculty.SelectedIndexChanged += new System.EventHandler(this.CB_Faculty_SelectedIndexChanged);
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
            this.Btn_List.Click += new System.EventHandler(this.Btn_List_Click);
            // 
            // Lesson_Management_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lesson_Management_Form";
            this.Text = "Ders Yönetim Paneli";
            this.Load += new System.EventHandler(this.Lesson_Management_Form_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Class)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Credit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Lesson)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DG_Lesson;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_Lesson_Delete;
        private System.Windows.Forms.ComboBox CB_Faculty_Input;
        private System.Windows.Forms.NumericUpDown NUD_Class;
        private System.Windows.Forms.NumericUpDown Txt_Credit;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Lesson_Add;
        private System.Windows.Forms.Button Btn_Lesson_Update;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CB_Faculty;
        private System.Windows.Forms.ComboBox CB_Department;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn lessonCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonCredit;
        private System.Windows.Forms.Button Btn_List;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Txt_Code;
        private System.Windows.Forms.ComboBox CB_Department_Input;
    }
}