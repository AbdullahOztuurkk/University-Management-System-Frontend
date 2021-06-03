
namespace UniOtomasyonUI.Pages.User
{
    partial class Lessons_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DG_UserLesson = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lbl_Soyad = new System.Windows.Forms.Label();
            this.Lbl_Ad = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PB_User_Image = new System.Windows.Forms.PictureBox();
            this.LessonCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LessonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LessonSeason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LessonCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LessonAverage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_UserLesson)).BeginInit();
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
            this.groupBox1.Controls.Add(this.DG_UserLesson);
            this.groupBox1.Location = new System.Drawing.Point(15, 155);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 393);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notlarım";
            // 
            // DG_UserLesson
            // 
            this.DG_UserLesson.AllowUserToAddRows = false;
            this.DG_UserLesson.AllowUserToDeleteRows = false;
            this.DG_UserLesson.AllowUserToResizeRows = false;
            this.DG_UserLesson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_UserLesson.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DG_UserLesson.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_UserLesson.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_UserLesson.ColumnHeadersHeight = 38;
            this.DG_UserLesson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LessonCode,
            this.LessonName,
            this.LessonSeason,
            this.LessonCredit,
            this.LessonAverage});
            this.DG_UserLesson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DG_UserLesson.Location = new System.Drawing.Point(3, 19);
            this.DG_UserLesson.MultiSelect = false;
            this.DG_UserLesson.Name = "DG_UserLesson";
            this.DG_UserLesson.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_UserLesson.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DG_UserLesson.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DG_UserLesson.RowTemplate.Height = 25;
            this.DG_UserLesson.Size = new System.Drawing.Size(748, 371);
            this.DG_UserLesson.TabIndex = 0;
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
            // LessonSeason
            // 
            this.LessonSeason.HeaderText = "Dönem";
            this.LessonSeason.Name = "LessonSeason";
            this.LessonSeason.ReadOnly = true;
            // 
            // LessonCredit
            // 
            this.LessonCredit.HeaderText = "Kredi";
            this.LessonCredit.Name = "LessonCredit";
            this.LessonCredit.ReadOnly = true;
            // 
            // LessonAverage
            // 
            this.LessonAverage.HeaderText = "Ortalama";
            this.LessonAverage.Name = "LessonAverage";
            this.LessonAverage.ReadOnly = true;
            // 
            // Lessons_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Lessons_Form";
            this.Text = "Öğrenci Ders Paneli";
            this.Load += new System.EventHandler(this.Lessons_Form_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_UserLesson)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_User_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DG_UserLesson;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Lbl_Soyad;
        private System.Windows.Forms.Label Lbl_Ad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PB_User_Image;
        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn LessonCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonSeason;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonAverage;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonStatus;
    }
}