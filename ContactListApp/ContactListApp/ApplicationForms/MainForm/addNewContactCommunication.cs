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
    public partial class addNewContactCommunication : Form
    {
        public addNewContactCommunication()
        {
            InitializeComponent();
            getCommunicationTypeList();
        }

        void getCommunicationTypeList()
        {
            cmbCommType.DataSource = communicationType.getCommunicationTypeList();
            cmbCommType.DisplayMember = "values";
            cmbCommType.ValueMember = "communicationTypeId";

        }

        private void addNewContactCommunication_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            contactCommunicationService contactCommunicationService = new contactCommunicationService();
            int resultInt = contactCommunicationService.createRecord(new OperationLayer.Entities.contactCommunicationList()
            {
                Id = Guid.NewGuid(),
                personelId = applicationStatics.currentSystemUser.Id,
                communicationType = ((communicationType)cmbCommType.SelectedItem).communicationTypeId,
                communicationValue = txtValue.Text,
                creationDate = DateTime.Now
            });

            if(resultInt > 0)
            {
                Form mainForm = Application.OpenForms["viewUpdateContactRecord"];
                ((viewUpdateContactRecord)mainForm).getContactCommList();
                this.Close();
            }
        }
    }
}
