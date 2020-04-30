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
    public partial class viewUpdateContactRecord : Form
    {
        contact selectedContact;
        public viewUpdateContactRecord(Guid contactId)
        {
            InitializeComponent();
            getContactDetail(contactId);
            getContactCommList();
            var updateForm = Application.OpenForms["recordActions"];
            updateForm.Close();
        }

        void getContactDetail(Guid contactId)
        {
            contactService contactService = new contactService();
            selectedContact = contactService.getContactDetails(contactId, applicationStatics.currentSystemUser.Id);
            txtPersonelTitle.Text = selectedContact.title;
            txtPersonelName.Text = selectedContact.firstname;
            txtPersonelLastname.Text = selectedContact.lastname;
            txtPersonelCompany.Text = selectedContact.company;
            txtPersonelNote.Text = selectedContact.personelNote;
        }

        internal void getContactCommList()
        {
            contactCommunicationService communicationService = new contactCommunicationService();
            List<contactCommunicationList> dataList = communicationService.getAllRecords(applicationStatics.currentSystemUser.Id);
            if(dataList != null)
            {
                grdContactList.DataSource = (from I in dataList
                                             select new
                                             {
                                                 Id = I.Id,
                                                 communicationType = communicationType.getCommunicationTypeList().Find(x => x.communicationTypeId == I.communicationType).values,
                                                 communicationValue = I.communicationValue.ToString()
                                             }).ToList();


                grdContactList.Columns["communicationType"].HeaderText = "İletişim Tip";
                grdContactList.Columns["communicationType"].Width = 100;

                grdContactList.Columns["communicationValue"].HeaderText = "İletişim Değer";
                grdContactList.Columns["communicationValue"].Width = 400;

                grdContactList.Columns["Id"].Visible = false;
            }
            
        }

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            selectedContact.company = txtPersonelCompany.Text;
            selectedContact.title = txtPersonelTitle.Text;
            selectedContact.firstname = txtPersonelName.Text;
            selectedContact.lastname = txtPersonelLastname.Text;
            selectedContact.personelNote = txtPersonelNote.Text;

            contactService contactService = new contactService();
            int contactResult = contactService.updateRecord(selectedContact);
            if (contactResult > 0)
            {
                MessageBox.Show("Kayıt güncelleme işlemi tamamlandı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form mainForm = Application.OpenForms["mainApp"];
                ((mainApp)mainForm).getContactList();
            }
        }

        private void btnAddNewComm_Click(object sender, EventArgs e)
        {
            addNewContactCommunication communication = new addNewContactCommunication();
            communication.ShowDialog(this);
        }

        private void viewUpdateContactRecord_Load(object sender, EventArgs e)
        {

        }

        private void grdContactList_DoubleClick(object sender, EventArgs e)
        {
            Guid selectedComm = (Guid)grdContactList.SelectedRows[0].Cells["Id"].Value;
            commActions commActions = new commActions(selectedComm);
            commActions.ShowDialog(this);


        }
    }
}
