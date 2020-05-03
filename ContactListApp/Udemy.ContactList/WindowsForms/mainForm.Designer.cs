namespace Udemy.ContactList.WindowsForms
{
    partial class mainForm
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
            this.txtCurrentSystemUser = new System.Windows.Forms.TextBox();
            this.btnApplicationExit = new System.Windows.Forms.Button();
            this.btnNewContact = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdContacts = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNewContact);
            this.groupBox1.Controls.Add(this.btnApplicationExit);
            this.groupBox1.Controls.Add(this.txtCurrentSystemUser);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1027, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operasyon Bölümü";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aktif Kullanıcı :";
            // 
            // txtCurrentSystemUser
            // 
            this.txtCurrentSystemUser.Enabled = false;
            this.txtCurrentSystemUser.Location = new System.Drawing.Point(120, 25);
            this.txtCurrentSystemUser.Name = "txtCurrentSystemUser";
            this.txtCurrentSystemUser.Size = new System.Drawing.Size(150, 22);
            this.txtCurrentSystemUser.TabIndex = 1;
            // 
            // btnApplicationExit
            // 
            this.btnApplicationExit.Location = new System.Drawing.Point(880, 21);
            this.btnApplicationExit.Name = "btnApplicationExit";
            this.btnApplicationExit.Size = new System.Drawing.Size(131, 26);
            this.btnApplicationExit.TabIndex = 1;
            this.btnApplicationExit.Text = "Uygulama Çıkış";
            this.btnApplicationExit.UseVisualStyleBackColor = true;
            this.btnApplicationExit.Click += new System.EventHandler(this.btnApplicationExit_Click);
            // 
            // btnNewContact
            // 
            this.btnNewContact.Location = new System.Drawing.Point(743, 21);
            this.btnNewContact.Name = "btnNewContact";
            this.btnNewContact.Size = new System.Drawing.Size(131, 26);
            this.btnNewContact.TabIndex = 1;
            this.btnNewContact.Text = "Yeni Kayıt";
            this.btnNewContact.UseVisualStyleBackColor = true;
            this.btnNewContact.Click += new System.EventHandler(this.btnNewContact_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdContacts);
            this.groupBox2.Location = new System.Drawing.Point(12, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1027, 467);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste";
            // 
            // grdContacts
            // 
            this.grdContacts.AllowUserToAddRows = false;
            this.grdContacts.AllowUserToDeleteRows = false;
            this.grdContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdContacts.Location = new System.Drawing.Point(3, 18);
            this.grdContacts.Name = "grdContacts";
            this.grdContacts.ReadOnly = true;
            this.grdContacts.RowHeadersWidth = 51;
            this.grdContacts.RowTemplate.Height = 24;
            this.grdContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdContacts.Size = new System.Drawing.Size(1021, 446);
            this.grdContacts.TabIndex = 0;
            this.grdContacts.DoubleClick += new System.EventHandler(this.grdContacts_DoubleClick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Apps ";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdContacts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCurrentSystemUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewContact;
        private System.Windows.Forms.Button btnApplicationExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grdContacts;
    }
}