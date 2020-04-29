using ContactListApp.OperationLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactListApp.ApplicationForms.MainForm
{
    public partial class mainApp : Form
    {
        
        public mainApp(systemUser currentUser)
        {
            InitializeComponent();
            applicationStatics.currentSystemUser = currentUser;
        }

        private void mainApp_Load(object sender, EventArgs e)
        {
            txtCurrentUser.Text = applicationStatics.currentSystemUser.userName;
        }
    }
}
