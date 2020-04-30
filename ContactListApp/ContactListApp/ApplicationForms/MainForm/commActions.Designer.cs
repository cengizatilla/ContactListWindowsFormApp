namespace ContactListApp.ApplicationForms.MainForm
{
    partial class commActions
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPersonelRecordDelete = new System.Windows.Forms.Button();
            this.btnUpdateView = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnPersonelRecordDelete);
            this.groupBox2.Controls.Add(this.btnUpdateView);
            this.groupBox2.Controls.Add(this.btnView);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 155);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlem Listesi";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(6, 109);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(188, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPersonelRecordDelete
            // 
            this.btnPersonelRecordDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPersonelRecordDelete.Location = new System.Drawing.Point(6, 80);
            this.btnPersonelRecordDelete.Name = "btnPersonelRecordDelete";
            this.btnPersonelRecordDelete.Size = new System.Drawing.Size(188, 23);
            this.btnPersonelRecordDelete.TabIndex = 0;
            this.btnPersonelRecordDelete.Text = "Sil";
            this.btnPersonelRecordDelete.UseVisualStyleBackColor = true;
            this.btnPersonelRecordDelete.Click += new System.EventHandler(this.btnPersonelRecordDelete_Click);
            // 
            // btnUpdateView
            // 
            this.btnUpdateView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateView.Location = new System.Drawing.Point(6, 51);
            this.btnUpdateView.Name = "btnUpdateView";
            this.btnUpdateView.Size = new System.Drawing.Size(188, 23);
            this.btnUpdateView.TabIndex = 0;
            this.btnUpdateView.Text = "Güncelle";
            this.btnUpdateView.UseVisualStyleBackColor = true;
            this.btnUpdateView.Click += new System.EventHandler(this.btnUpdateView_Click);
            // 
            // btnView
            // 
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnView.Location = new System.Drawing.Point(6, 22);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(188, 23);
            this.btnView.TabIndex = 0;
            this.btnView.Text = "Görüntüle";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnUpdateView_Click);
            // 
            // commActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 179);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "commActions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İletişim Bilgileri";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPersonelRecordDelete;
        private System.Windows.Forms.Button btnUpdateView;
        private System.Windows.Forms.Button btnView;
    }
}