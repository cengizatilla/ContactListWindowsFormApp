using ContactListApp.OperationLayer.Entities;
using ContactListApp.OperationLayer.Entities.staticEntities;
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
    public partial class updateContactCommunication : Form
    {
        contactCommunicationList data;
        public updateContactCommunication(Guid communicationID)
        {
            InitializeComponent();
            getCommunicationTypeList();
            getCommunicationById(communicationID);
        }

        void getCommunicationTypeList()
        {
            cmbCommType.DataSource = communicationType.getCommunicationTypeList();
            cmbCommType.DisplayMember = "values";
            cmbCommType.ValueMember = "communicationTypeId";

        }

        void getCommunicationById(Guid communicationID)
        {
            contactCommunicationService contactCommunicationService = new contactCommunicationService();
            data = contactCommunicationService.getRecordById(applicationStatics.currentSystemUser.Id, communicationID);
            txtValue.Text = data.communicationValue;
            cmbCommType.SelectedValue = data.communicationType;
        }

        private void updateContactCommunication_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            data.communicationType = ((communicationType)cmbCommType.SelectedItem).communicationTypeId;
            data.communicationValue = txtValue.Text;

            contactCommunicationService contactCommunicationService = new contactCommunicationService();
            int resultInt = contactCommunicationService.updateRecord(data);

            if (resultInt > 0)
            {
                Form mainForm = Application.OpenForms["viewUpdateContactRecord"];
                ((viewUpdateContactRecord)mainForm).getContactCommList();
                this.Close();
            }
        }
    }
}
