﻿namespace ContactListApp.ApplicationForms.MainForm
{
    partial class newRecord
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPersonelName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPersonelLastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPersonelCompany = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPersonelTitle = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPersonelNote = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCreateNewRecord = new System.Windows.Forms.Button();
            this.grdContactList = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContactList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPersonelTitle);
            this.groupBox1.Controls.Add(this.txtPersonelName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPersonelCompany);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPersonelLastname);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişi Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // txtPersonelName
            // 
            this.txtPersonelName.Location = new System.Drawing.Point(82, 84);
            this.txtPersonelName.Name = "txtPersonelName";
            this.txtPersonelName.Size = new System.Drawing.Size(145, 20);
            this.txtPersonelName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyisim";
            // 
            // txtPersonelLastname
            // 
            this.txtPersonelLastname.Location = new System.Drawing.Point(82, 110);
            this.txtPersonelLastname.Name = "txtPersonelLastname";
            this.txtPersonelLastname.Size = new System.Drawing.Size(145, 20);
            this.txtPersonelLastname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Firma";
            // 
            // txtPersonelCompany
            // 
            this.txtPersonelCompany.Location = new System.Drawing.Point(82, 28);
            this.txtPersonelCompany.Name = "txtPersonelCompany";
            this.txtPersonelCompany.Size = new System.Drawing.Size(145, 20);
            this.txtPersonelCompany.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ünvan";
            // 
            // txtPersonelTitle
            // 
            this.txtPersonelTitle.Location = new System.Drawing.Point(82, 54);
            this.txtPersonelTitle.Name = "txtPersonelTitle";
            this.txtPersonelTitle.Size = new System.Drawing.Size(145, 20);
            this.txtPersonelTitle.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPersonelNote);
            this.groupBox2.Location = new System.Drawing.Point(12, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 231);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Not";
            // 
            // txtPersonelNote
            // 
            this.txtPersonelNote.Location = new System.Drawing.Point(6, 19);
            this.txtPersonelNote.Multiline = true;
            this.txtPersonelNote.Name = "txtPersonelNote";
            this.txtPersonelNote.Size = new System.Drawing.Size(240, 206);
            this.txtPersonelNote.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grdContactList);
            this.groupBox3.Location = new System.Drawing.Point(270, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(518, 391);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İletişim Bilgileri";
            // 
            // btnCreateNewRecord
            // 
            this.btnCreateNewRecord.Location = new System.Drawing.Point(18, 415);
            this.btnCreateNewRecord.Name = "btnCreateNewRecord";
            this.btnCreateNewRecord.Size = new System.Drawing.Size(246, 23);
            this.btnCreateNewRecord.TabIndex = 0;
            this.btnCreateNewRecord.Text = "Kayıt Oluştur";
            this.btnCreateNewRecord.UseVisualStyleBackColor = true;
            this.btnCreateNewRecord.Click += new System.EventHandler(this.btnCreateNewRecord_Click);
            // 
            // grdContactList
            // 
            this.grdContactList.AllowUserToAddRows = false;
            this.grdContactList.AllowUserToDeleteRows = false;
            this.grdContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdContactList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdContactList.Location = new System.Drawing.Point(3, 16);
            this.grdContactList.Name = "grdContactList";
            this.grdContactList.ReadOnly = true;
            this.grdContactList.Size = new System.Drawing.Size(512, 372);
            this.grdContactList.TabIndex = 0;
            // 
            // newRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreateNewRecord);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "newRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Kayıt";
            this.Load += new System.EventHandler(this.newRecord_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdContactList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPersonelTitle;
        private System.Windows.Forms.TextBox txtPersonelName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPersonelCompany;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPersonelLastname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPersonelNote;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView grdContactList;
        private System.Windows.Forms.Button btnCreateNewRecord;
    }
}