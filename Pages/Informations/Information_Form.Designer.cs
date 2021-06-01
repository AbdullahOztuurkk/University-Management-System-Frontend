
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
            this.Panel_Profile_Image = new System.Windows.Forms.Panel();
            this.Lbl_Ad_Soyad = new System.Windows.Forms.Label();
            this.PB_User_Image = new System.Windows.Forms.PictureBox();
            this.Txt_Status = new System.Windows.Forms.Label();
            this.Txt_Surname = new System.Windows.Forms.Label();
            this.Txt_Name = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Panel_Profile_Image.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_User_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.75077F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 148);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(763, 299);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Panel_Profile_Image);
            this.groupBox1.Controls.Add(this.Txt_Status);
            this.groupBox1.Controls.Add(this.Txt_Surname);
            this.groupBox1.Controls.Add(this.Txt_Name);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(723, 259);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Bilgilerim";
            // 
            // Panel_Profile_Image
            // 
            this.Panel_Profile_Image.BackColor = System.Drawing.Color.Gainsboro;
            this.Panel_Profile_Image.Controls.Add(this.Lbl_Ad_Soyad);
            this.Panel_Profile_Image.Controls.Add(this.PB_User_Image);
            this.Panel_Profile_Image.Location = new System.Drawing.Point(497, 0);
            this.Panel_Profile_Image.Name = "Panel_Profile_Image";
            this.Panel_Profile_Image.Size = new System.Drawing.Size(220, 225);
            this.Panel_Profile_Image.TabIndex = 7;
            // 
            // Lbl_Ad_Soyad
            // 
            this.Lbl_Ad_Soyad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Ad_Soyad.Location = new System.Drawing.Point(0, 193);
            this.Lbl_Ad_Soyad.Name = "Lbl_Ad_Soyad";
            this.Lbl_Ad_Soyad.Size = new System.Drawing.Size(220, 32);
            this.Lbl_Ad_Soyad.TabIndex = 9;
            this.Lbl_Ad_Soyad.Text = "Ad Soyad";
            this.Lbl_Ad_Soyad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PB_User_Image
            // 
            this.PB_User_Image.Image = global::UniOtomasyonUI.Properties.Resources.user;
            this.PB_User_Image.Location = new System.Drawing.Point(23, 11);
            this.PB_User_Image.Name = "PB_User_Image";
            this.PB_User_Image.Size = new System.Drawing.Size(175, 175);
            this.PB_User_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_User_Image.TabIndex = 8;
            this.PB_User_Image.TabStop = false;
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
            // Information_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 503);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Information_Form";
            this.Text = "Kullanıcı Bilgilerim";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Information_Form_FormClosed);
            this.Load += new System.EventHandler(this.Information_Form_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.Panel_Profile_Image.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_User_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Txt_Status;
        private System.Windows.Forms.Label Txt_Surname;
        private System.Windows.Forms.Label Txt_Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel Panel_Profile_Image;
        private System.Windows.Forms.Label Lbl_Ad_Soyad;
        private System.Windows.Forms.PictureBox PB_User_Image;
    }
}