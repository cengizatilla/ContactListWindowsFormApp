using ContactListApp.OperationLayer.Entities;
using ContactListApp.OperationLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactListApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_MouseMove(object sender, MouseEventArgs e)
        {
            Button closeButton = ((Button)sender);
            closeButton.BackColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            Button closeButton = ((Button)sender);
            closeButton.BackColor = Color.White;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCheckUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text))
                MessageBox.Show("Lütfen form alanında bulunan bilgileri eksiksiz olarak doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {

                systemUserService systemUserService = new systemUserService();
                Guid systemUserId = systemUserService.checkSystemUser(txtUserName.Text, txtPassword.Text);

                if (systemUserId == Guid.Empty)
                {
                    DialogResult res = MessageBox.Show("Kullanıcı adınız veya şifre bilginiz hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (res == DialogResult.OK)
                    {
                        txtUserName.Text = string.Empty;
                        txtPassword.Text = string.Empty;
                    }
                }
                else
                {
                    systemUser systemUserType = systemUserService.getUserInformation(systemUserId);
                    ApplicationForms.MainForm.mainApp mainMenu = new ApplicationForms.MainForm.mainApp(systemUserType);
                    mainMenu.Show();
                    this.Hide();
                }

            }

        }
    }
}
