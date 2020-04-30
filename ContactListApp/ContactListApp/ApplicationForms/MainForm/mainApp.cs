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
    public partial class mainApp : Form
    {
        
        public mainApp(systemUser currentUser)
        {
            InitializeComponent();
            applicationStatics.currentSystemUser = currentUser;
            getContactList();
        }

        internal void getContactList()
        {
            contactService contactService = new contactService();
            List<contact> contactRecords = contactService.getContactListBySystemUserId(applicationStatics.currentSystemUser.Id);
            if(contactRecords != null && contactRecords.Count>0)
            {
                gridViewContactList.DataSource = contactRecords;

                gridViewContactList.Columns["company"].HeaderText = "Firma";
                gridViewContactList.Columns["company"].Width = 100;

                gridViewContactList.Columns["title"].HeaderText = "Ünvan";
                gridViewContactList.Columns["title"].Width = 100;

                gridViewContactList.Columns["firstname"].HeaderText = "İsim";
                gridViewContactList.Columns["firstname"].Width = 100;

                gridViewContactList.Columns["lastname"].HeaderText = "Soyisim";
                gridViewContactList.Columns["lastname"].Width = 100;

                gridViewContactList.Columns["personelNote"].HeaderText = "Not";
                gridViewContactList.Columns["personelNote"].Width = 320;

                gridViewContactList.Columns["systemUserId"].Visible = false;
                gridViewContactList.Columns["Id"].Visible = false;
                gridViewContactList.Columns["creationDate"].Visible = false;
            }
        }

        private void mainApp_Load(object sender, EventArgs e)
        {
            txtCurrentUser.Text = applicationStatics.currentSystemUser.userName;
        }

        private void btnNewContact_Click(object sender, EventArgs e)
        {
            newRecord record = new newRecord();
            record.Show();
        }

        private void gridViewContactList_DoubleClick(object sender, EventArgs e)
        {
            Guid selectedContact = (Guid)gridViewContactList.SelectedRows[0].Cells["Id"].Value;
            recordActions actionSelect = new recordActions(selectedContact);
            actionSelect.ShowDialog(this);
        }

        private void btnApplicationExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
