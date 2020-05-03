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
using Udemy.ContactList.Entities.staticRam;
using Udemy.ContactList.Operation.Services;

namespace Udemy.ContactList.WindowsForms
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();

            txtCurrentSystemUser.Text = applicationStatics.currentSystemUser.userName;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            getAllRecordsBySystemUserId();
        }

        public void getAllRecordsBySystemUserId()
        {
            contactService contactService = new contactService();
            List<contacts> dataList = contactService.getAllRecordsBySystemUserId();
            if (dataList != null || dataList.Count > 0)
            {
                grdContacts.DataSource = dataList;

                grdContacts.Columns["systemUserId"].Visible = false;
                grdContacts.Columns["id"].Visible = false;
                grdContacts.Columns["createDate"].Visible = false;

                
                grdContacts.Columns["firstName"].HeaderText = "İsim";
                grdContacts.Columns["firstName"].Width = 100;

                grdContacts.Columns["lastName"].HeaderText = "Soyisim";
                grdContacts.Columns["lastName"].Width = 100;

                grdContacts.Columns["company"].HeaderText = "Firma";
                grdContacts.Columns["company"].Width = 100;

                grdContacts.Columns["title"].HeaderText = "Ünvan";
                grdContacts.Columns["title"].Width = 100;

                grdContacts.Columns["personelNote"].HeaderText = "Not";
                grdContacts.Columns["personelNote"].Width = 310;

            }
        }

        private void btnNewContact_Click(object sender, EventArgs e)
        {
            addNewContact newContact = new addNewContact();
            newContact.ShowDialog(this);
        }

        private void btnApplicationExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void grdContacts_DoubleClick(object sender, EventArgs e)
        {
            Guid selectedContactId = (Guid)grdContacts.SelectedRows[0].Cells["id"].Value;
            operationContactForm operationContact = new operationContactForm(selectedContactId);
            operationContact.ShowDialog(this);

        }
    }
}
