using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Udemy.ContactList.Entities.staticRam;
using Udemy.ContactList.Entities.systemUser;
using Udemy.ContactList.Operation.Services;
using Udemy.ContactList.WindowsForms;

namespace Udemy.ContactList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAppClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAppClose_MouseMove(object sender, MouseEventArgs e)
        {
            Button X = (Button)sender;
            X.BackColor = Color.Red;
        }

        private void btnAppClose_MouseLeave(object sender, EventArgs e)
        {
            Button X = (Button)sender;
            X.BackColor = Color.FromArgb(255, 240, 240, 240);
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            systemUserService userService = new systemUserService();
            systemUsers systemUserData = userService.checkSystemUser(txtUserName.Text, txtPassword.Text);

            if(systemUserData == null || systemUserData.id == Guid.Empty)
            {
                MessageBox.Show("Girmiş olduğunuz bilgiler hatalı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                applicationStatics.currentSystemUser = systemUserData;
                mainForm main = new mainForm();
                main.Show();
                this.Hide();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUserName.Text = "cengiz.atilla";
        }
    }
}
