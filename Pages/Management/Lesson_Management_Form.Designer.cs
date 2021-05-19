
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_Lesson_Add = new System.Windows.Forms.Button();
            this.Btn_Lesson_Update = new System.Windows.Forms.Button();
            this.Btn_Lesson_Delete = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DG_Lesson = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Lesson)).BeginInit();
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
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(210, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(360, 253);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ders Ekle";
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(112, 119);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(227, 23);
            this.comboBox1.TabIndex = 7;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(112, 162);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(227, 23);
            this.numericUpDown2.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(112, 78);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(227, 23);
            this.numericUpDown1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 23);
            this.textBox1.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Sınıf :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Bölüm :";
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
            this.groupBox1.Location = new System.Drawing.Point(9, 437);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 264);
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
            // Lesson_Management_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Lesson_Management_Form";
            this.Text = "Ders Yönetim Paneli";
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.Button Btn_Lesson_Delete;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Lesson_Add;
        private System.Windows.Forms.Button Btn_Lesson_Update;
    }
}