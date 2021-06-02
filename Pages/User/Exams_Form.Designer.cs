
namespace UniOtomasyonUI.Pages.User
{
    partial class Exams_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DG_Exam = new System.Windows.Forms.DataGridView();
            this.LessonCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LessonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LessonCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.announcementDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lbl_Soyad = new System.Windows.Forms.Label();
            this.Lbl_Ad = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PB_User_Image = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Exam)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_User_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 148);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 563);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DG_Exam);
            this.groupBox1.Location = new System.Drawing.Point(15, 155);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 393);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notlarım";
            // 
            // DG_Exam
            // 
            this.DG_Exam.AllowUserToAddRows = false;
            this.DG_Exam.AllowUserToDeleteRows = false;
            this.DG_Exam.AllowUserToResizeRows = false;
            this.DG_Exam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_Exam.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DG_Exam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Exam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DG_Exam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Exam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LessonCode,
            this.LessonName,
            this.LessonCredit,
            this.ExamType,
            this.Score,
            this.announcementDate});
            this.DG_Exam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DG_Exam.Location = new System.Drawing.Point(3, 19);
            this.DG_Exam.MultiSelect = false;
            this.DG_Exam.Name = "DG_Exam";
            this.DG_Exam.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Exam.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DG_Exam.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DG_Exam.RowTemplate.Height = 25;
            this.DG_Exam.Size = new System.Drawing.Size(748, 371);
            this.DG_Exam.TabIndex = 0;
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
            this.ExamType.HeaderText = "Tür";
            this.ExamType.Name = "ExamType";
            this.ExamType.ReadOnly = true;
            // 
            // Score
            // 
            this.Score.HeaderText = "Puan";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            // 
            // announcementDate
            // 
            this.announcementDate.HeaderText = "Yayınlanma Tarihi";
            this.announcementDate.Name = "announcementDate";
            this.announcementDate.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.Lbl_Soyad);
            this.panel2.Controls.Add(this.Lbl_Ad);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.PB_User_Image);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(15, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(754, 120);
            this.panel2.TabIndex = 12;
            // 
            // Lbl_Soyad
            // 
            this.Lbl_Soyad.AutoSize = true;
            this.Lbl_Soyad.Location = new System.Drawing.Point(181, 66);
            this.Lbl_Soyad.Name = "Lbl_Soyad";
            this.Lbl_Soyad.Size = new System.Drawing.Size(38, 15);
            this.Lbl_Soyad.TabIndex = 4;
            this.Lbl_Soyad.Text = "label6";
            // 
            // Lbl_Ad
            // 
            this.Lbl_Ad.AutoSize = true;
            this.Lbl_Ad.Location = new System.Drawing.Point(181, 29);
            this.Lbl_Ad.Name = "Lbl_Ad";
            this.Lbl_Ad.Size = new System.Drawing.Size(38, 15);
            this.Lbl_Ad.TabIndex = 3;
            this.Lbl_Ad.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Soyad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ad :";
            // 
            // PB_User_Image
            // 
            this.PB_User_Image.Image = global::UniOtomasyonUI.Properties.Resources.user;
            this.PB_User_Image.Location = new System.Drawing.Point(12, 10);
            this.PB_User_Image.Name = "PB_User_Image";
            this.PB_User_Image.Size = new System.Drawing.Size(100, 100);
            this.PB_User_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_User_Image.TabIndex = 0;
            this.PB_User_Image.TabStop = false;
            // 
            // Exams_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Exams_Form";
            this.Text = "Exams_Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Exams_Form_FormClosed);
            this.Load += new System.EventHandler(this.Exams_Form_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Exam)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_User_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DG_Exam;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Lbl_Soyad;
        private System.Windows.Forms.Label Lbl_Ad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PB_User_Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn announcementDate;
    }
}