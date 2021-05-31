
namespace UniOtomasyonUI.Pages.Informations
{
    partial class Information_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Information_Form));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_Email = new System.Windows.Forms.Label();
            this.Txt_Status = new System.Windows.Forms.Label();
            this.Txt_Surname = new System.Windows.Forms.Label();
            this.Txt_Name = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_Change_Password = new System.Windows.Forms.Button();
            this.Txt_New_Password_Again = new System.Windows.Forms.TextBox();
            this.Txt_New_Password = new System.Windows.Forms.TextBox();
            this.Txt_Current_Password = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DG_Lesson = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Lesson)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.75077F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.498477F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.75075F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 148);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(763, 299);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_Email);
            this.groupBox1.Controls.Add(this.Txt_Status);
            this.groupBox1.Controls.Add(this.Txt_Surname);
            this.groupBox1.Controls.Add(this.Txt_Name);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 259);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Bilgilerim";
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(121, 218);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(93, 23);
            this.Txt_Email.TabIndex = 7;
            this.Txt_Email.Text = "Email";
            this.Txt_Email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Txt_Status
            // 
            this.Txt_Status.Location = new System.Drawing.Point(121, 167);
            this.Txt_Status.Name = "Txt_Status";
            this.Txt_Status.Size = new System.Drawing.Size(93, 23);
            this.Txt_Status.TabIndex = 6;
            this.Txt_Status.Text = "Status";
            this.Txt_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Txt_Surname
            // 
            this.Txt_Surname.Location = new System.Drawing.Point(121, 116);
            this.Txt_Surname.Name = "Txt_Surname";
            this.Txt_Surname.Size = new System.Drawing.Size(93, 23);
            this.Txt_Surname.TabIndex = 5;
            this.Txt_Surname.Text = "Surname";
            this.Txt_Surname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(121, 65);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(93, 23);
            this.Txt_Name.TabIndex = 4;
            this.Txt_Name.Text = "Name";
            this.Txt_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(5, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Email :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(5, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mevcut Durum :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(5, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Soyadı :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(5, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ad :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_Change_Password);
            this.groupBox2.Controls.Add(this.Txt_New_Password_Again);
            this.groupBox2.Controls.Add(this.Txt_New_Password);
            this.groupBox2.Controls.Add(this.Txt_Current_Password);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(410, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 259);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Şifreni Değiştir";
            // 
            // Btn_Change_Password
            // 
            this.Btn_Change_Password.BackColor = System.Drawing.Color.Red;
            this.Btn_Change_Password.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Btn_Change_Password.FlatAppearance.BorderSize = 0;
            this.Btn_Change_Password.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Change_Password.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Change_Password.Location = new System.Drawing.Point(197, 218);
            this.Btn_Change_Password.Name = "Btn_Change_Password";
            this.Btn_Change_Password.Size = new System.Drawing.Size(105, 28);
            this.Btn_Change_Password.TabIndex = 4;
            this.Btn_Change_Password.Text = "Şifreni Değiştir";
            this.Btn_Change_Password.UseVisualStyleBackColor = false;
            this.Btn_Change_Password.Click += new System.EventHandler(this.Btn_Change_Password_Click);
            // 
            // Txt_New_Password_Again
            // 
            this.Txt_New_Password_Again.Location = new System.Drawing.Point(129, 168);
            this.Txt_New_Password_Again.Name = "Txt_New_Password_Again";
            this.Txt_New_Password_Again.PasswordChar = '*';
            this.Txt_New_Password_Again.Size = new System.Drawing.Size(173, 23);
            this.Txt_New_Password_Again.TabIndex = 3;
            // 
            // Txt_New_Password
            // 
            this.Txt_New_Password.Location = new System.Drawing.Point(129, 117);
            this.Txt_New_Password.Name = "Txt_New_Password";
            this.Txt_New_Password.PasswordChar = '*';
            this.Txt_New_Password.Size = new System.Drawing.Size(173, 23);
            this.Txt_New_Password.TabIndex = 2;
            // 
            // Txt_Current_Password
            // 
            this.Txt_Current_Password.Location = new System.Drawing.Point(129, 66);
            this.Txt_Current_Password.Name = "Txt_Current_Password";
            this.Txt_Current_Password.PasswordChar = '*';
            this.Txt_Current_Password.Size = new System.Drawing.Size(173, 23);
            this.Txt_Current_Password.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Yeni Şifre (Tekrar)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 23);
            this.label9.TabIndex = 9;
            this.label9.Text = "Yeni Şifre :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(6, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 23);
            this.label10.TabIndex = 8;
            this.label10.Text = "Mevcut Şifre :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 453);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(763, 299);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DG_Lesson);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(20, 20);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(723, 259);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Derslerim";
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
            this.DG_Lesson.Size = new System.Drawing.Size(717, 237);
            this.DG_Lesson.TabIndex = 0;
            // 
            // Information_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 808);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Information_Form";
            this.Text = "Kullanıcı Bilgilerim";
            this.Load += new System.EventHandler(this.Information_Form_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Lesson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Txt_Email;
        private System.Windows.Forms.Label Txt_Status;
        private System.Windows.Forms.Label Txt_Surname;
        private System.Windows.Forms.Label Txt_Name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Change_Password;
        private System.Windows.Forms.TextBox Txt_New_Password_Again;
        private System.Windows.Forms.TextBox Txt_New_Password;
        private System.Windows.Forms.TextBox Txt_Current_Password;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DG_Lesson;
    }
}