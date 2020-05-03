using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Udemy.ContactList.Entities.contact;
using Udemy.ContactList.Entities.contactComm;
using Udemy.ContactList.Entities.staticRam;
using Udemy.ContactList.Operation.Services;

namespace Udemy.ContactList.WindowsForms
{
    public partial class viewUpdateContactComm : Form
    {
        contacts dataContact;
        contactComms dataComm;
        public viewUpdateContactComm(Guid contactID, Guid contactCommID)
        {
            InitializeComponent();
            contactDetail(contactID);
            getContactTypes();
            getContactComm(contactCommID);

        }

        void contactDetail(Guid contactId)
        {
            contactService contactService = new contactService();
            dataContact = contactService.getRecordByContactId(contactId);

            txtFirstname.Text = dataContact.firstName;
            txtLastname.Text = dataContact.lastName;
            txtCompany.Text = dataContact.company;
            txtTitle.Text = dataContact.title;

        }

        void getContactTypes()
        {
            CommTypes commTypes = new CommTypes();
            cmbCommTypes.DataSource = commTypes.getCommTypes();
            cmbCommTypes.DisplayMember = "Value";
            cmbCommTypes.ValueMember = "Id";
        }

        void getContactComm(Guid contactCommID)
        {
            contactCommService contactCommService = new contactCommService();
            dataComm = contactCommService.getContactCommId(contactCommID);

            cmbCommTypes.SelectedValue = dataComm.commType;
            txtCommValue.Text = dataComm.commValue;
        }

        private void viewUpdateContactComm_Load(object sender, EventArgs e)
        {

        }

        private void btnCommUpdate_Click(object sender, EventArgs e)
        {
            // ((CommTypes)cmbCommTypes.SelectedItem).Id;
            CommTypes comboBoxSelected = (CommTypes)cmbCommTypes.SelectedItem;

            contactCommService contactComm = new contactCommService();
           int resultInt = contactComm.updateContactComm(dataComm.id, comboBoxSelected.Id, txtCommValue.Text);
            if(resultInt > 0)
            {
                MessageBox.Show("Güncelleme işlemi başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                viewUpdateContact viewUpdate = (viewUpdateContact)Application.OpenForms["viewUpdateContact"];
                viewUpdate.getContactComm(dataContact.id);

                this.Close();

            }
        }
    }
}
