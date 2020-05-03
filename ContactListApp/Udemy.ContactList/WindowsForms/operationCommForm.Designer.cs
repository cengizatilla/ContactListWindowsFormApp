namespace Udemy.ContactList.WindowsForms
{
    partial class operationCommForm
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
            this.btnViewUpdate = new System.Windows.Forms.Button();
            this.btnRecordDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnViewUpdate);
            this.groupBox2.Controls.Add(this.btnRecordDelete);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 179);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlem Seçim";
            // 
            // btnViewUpdate
            // 
            this.btnViewUpdate.Location = new System.Drawing.Point(18, 38);
            this.btnViewUpdate.Name = "btnViewUpdate";
            this.btnViewUpdate.Size = new System.Drawing.Size(249, 33);
            this.btnViewUpdate.TabIndex = 0;
            this.btnViewUpdate.Text = "Görüntüle / Güncelle";
            this.btnViewUpdate.UseVisualStyleBackColor = true;
            this.btnViewUpdate.Click += new System.EventHandler(this.btnViewUpdate_Click);
            // 
            // btnRecordDelete
            // 
            this.btnRecordDelete.Location = new System.Drawing.Point(18, 77);
            this.btnRecordDelete.Name = "btnRecordDelete";
            this.btnRecordDelete.Size = new System.Drawing.Size(249, 33);
            this.btnRecordDelete.TabIndex = 0;
            this.btnRecordDelete.Text = "Sil";
            this.btnRecordDelete.UseVisualStyleBackColor = true;
            this.btnRecordDelete.Click += new System.EventHandler(this.btnRecordDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(18, 116);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(249, 33);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // operationCommForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 207);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "operationCommForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "operationCommForm";
            this.Load += new System.EventHandler(this.operationCommForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnViewUpdate;
        private System.Windows.Forms.Button btnRecordDelete;
        private System.Windows.Forms.Button btnClose;
    }
}