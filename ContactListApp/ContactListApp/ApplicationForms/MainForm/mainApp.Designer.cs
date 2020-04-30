namespace ContactListApp.ApplicationForms.MainForm
{
    partial class mainApp
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
            this.grpList = new System.Windows.Forms.GroupBox();
            this.gridViewContactList = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCurrentUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewContact = new System.Windows.Forms.Button();
            this.btnApplicationExit = new System.Windows.Forms.Button();
            this.grpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewContactList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpList
            // 
            this.grpList.Controls.Add(this.gridViewContactList);
            this.grpList.Location = new System.Drawing.Point(12, 68);
            this.grpList.Name = "grpList";
            this.grpList.Size = new System.Drawing.Size(776, 395);
            this.grpList.TabIndex = 0;
            this.grpList.TabStop = false;
            this.grpList.Text = "Liste";
            // 
            // gridViewContactList
            // 
            this.gridViewContactList.AllowUserToAddRows = false;
            this.gridViewContactList.AllowUserToDeleteRows = false;
            this.gridViewContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewContactList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewContactList.Location = new System.Drawing.Point(3, 16);
            this.gridViewContactList.Name = "gridViewContactList";
            this.gridViewContactList.ReadOnly = true;
            this.gridViewContactList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewContactList.Size = new System.Drawing.Size(770, 376);
            this.gridViewContactList.TabIndex = 0;
            this.gridViewContactList.DoubleClick += new System.EventHandler(this.gridViewContactList_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCurrentUser);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnNewContact);
            this.groupBox2.Controls.Add(this.btnApplicationExit);
            this.groupBox2.Location = new System.Drawing.Point(15, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(773, 57);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kullanıcı İşlem Paneli";
            // 
            // txtCurrentUser
            // 
            this.txtCurrentUser.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCurrentUser.Enabled = false;
            this.txtCurrentUser.Location = new System.Drawing.Point(102, 21);
            this.txtCurrentUser.Name = "txtCurrentUser";
            this.txtCurrentUser.Size = new System.Drawing.Size(127, 20);
            this.txtCurrentUser.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aktif Kullanıcı  : ";
            // 
            // btnNewContact
            // 
            this.btnNewContact.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewContact.Location = new System.Drawing.Point(575, 19);
            this.btnNewContact.Name = "btnNewContact";
            this.btnNewContact.Size = new System.Drawing.Size(93, 23);
            this.btnNewContact.TabIndex = 0;
            this.btnNewContact.Text = "Yeni Kayıt";
            this.btnNewContact.UseVisualStyleBackColor = true;
            this.btnNewContact.Click += new System.EventHandler(this.btnNewContact_Click);
            // 
            // btnApplicationExit
            // 
            this.btnApplicationExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApplicationExit.Location = new System.Drawing.Point(674, 19);
            this.btnApplicationExit.Name = "btnApplicationExit";
            this.btnApplicationExit.Size = new System.Drawing.Size(93, 23);
            this.btnApplicationExit.TabIndex = 0;
            this.btnApplicationExit.Text = "Uygulama Kapat";
            this.btnApplicationExit.UseVisualStyleBackColor = true;
            this.btnApplicationExit.Click += new System.EventHandler(this.btnApplicationExit_Click);
            // 
            // mainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpList);
            this.Name = "mainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact List | Udemy";
            this.Load += new System.EventHandler(this.mainApp_Load);
            this.grpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewContactList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.DataGridView gridViewContactList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCurrentUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewContact;
        private System.Windows.Forms.Button btnApplicationExit;
    }
}