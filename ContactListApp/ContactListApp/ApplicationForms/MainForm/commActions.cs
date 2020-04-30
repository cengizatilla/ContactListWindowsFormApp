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

namespace ContactListApp.ApplicationForms.MainForm
{
    public partial class commActions : Form
    {
        public Guid communicationId;
        public commActions(Guid communicationId)
        {
            InitializeComponent();
            this.communicationId = communicationId;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPersonelRecordDelete_Click(object sender, EventArgs e)
        {
            contactCommunicationService contactCommunicationService = new contactCommunicationService();
            int result = contactCommunicationService.deleteRecordById(this.communicationId);
            if (result > 0)
            {
                Form mainForm = Application.OpenForms["viewUpdateContactRecord"];
                ((viewUpdateContactRecord)mainForm).getContactCommList();
                this.Close();
            }
        }

        private void btnUpdateView_Click(object sender, EventArgs e)
        {

            updateContactCommunication contactCommunication = new updateContactCommunication(this.communicationId);
            Form mainForm = Application.OpenForms["viewUpdateContactRecord"];
            contactCommunication.ShowDialog(mainForm);
            this.Close();
        }
    }
}
