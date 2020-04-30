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

namespace ContactListApp.ApplicationForms.MainForm
{
    public partial class recordActions : Form
    {
        contact contactData;

        public recordActions(Guid contactId)
        {
            InitializeComponent();
            getContactDetail(contactId);
        }

        void getContactDetail(Guid contactId)
        {
            contactService contactService = new contactService();
            contactData = contactService.getContactDetails(contactId, applicationStatics.currentSystemUser.Id);
            txtPersonelTitle.Text = contactData.title;
            txtPersonelName.Text = contactData.firstname;
            txtPersonelLastname.Text = contactData.lastname;
            txtPersonelCompany.Text = contactData.company;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void recordActions_Load(object sender, EventArgs e)
        {

        }

        private void btnPersonelRecordDelete_Click(object sender, EventArgs e)
        {
            contactService contactService = new contactService();
            int resultInt = contactService.deleteRecordByContactId(contactData.Id, applicationStatics.currentSystemUser.Id);
            if(resultInt > 0)
            {
                MessageBox.Show($"{contactData.firstname} {contactData.lastname} kaydınız başarılı şekilde silinmiştir.");
                Form mainForm = Application.OpenForms["mainApp"];
                ((mainApp)mainForm).getContactList();

                this.Close();
            }
        }

        private void btnUpdateView_Click(object sender, EventArgs e)
        {
            Form mainForm = Application.OpenForms["mainApp"];
            viewUpdateContactRecord record = new viewUpdateContactRecord(contactData.Id);
            record.Show(mainForm);
        }
    }
}
