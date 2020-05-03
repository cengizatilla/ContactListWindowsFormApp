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
    public partial class viewUpdateContact : Form
    {
        contacts data;
        public viewUpdateContact(Guid contactId)
        {
            InitializeComponent();
            getContactData(contactId);
            getContactComm(contactId);
        }

        void getContactData(Guid contactId)
        {
            contactService contactService = new contactService();
            data = contactService.getRecordByContactId(contactId);
            txtFirstName.Text = data.firstName;
            txtLastName.Text = data.lastName;
            txtCompany.Text = data.company;
            txtTitle.Text = data.title;
            txtNote.Text = data.personelNote;
        }

        public void getContactComm(Guid contactId)
        {
            contactCommService contactComm = new contactCommService();
            List<contactComms> dataList = contactComm.getContactAllComm(contactId);

            CommTypes commTypes = new CommTypes();

            var dataGridValues = (from I in dataList
                                  select new
                                  {
                                      id = I.id,
                                      commType = commTypes.getCommTypes().Find(x => x.Id == I.commType).Value,
                                      commValue = I.commValue
                                  }).ToList();

            grdComm.DataSource = dataGridValues;

            grdComm.Columns["id"].Visible = false;

            grdComm.Columns["commType"].HeaderText = "İletişim Tip";
            grdComm.Columns["commType"].Width = 100;
            
            grdComm.Columns["commValue"].HeaderText = "İletişim Degeri";
            grdComm.Columns["commValue"].Width = 300;


        }


        private void viewUpdateContact_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateContact_Click(object sender, EventArgs e)
        {
            contactService contactService = new contactService();
            int resultInt = contactService.updateContact(data.id, txtFirstName.Text, txtLastName.Text, txtCompany.Text, txtTitle.Text, txtNote.Text);
            if (resultInt > 0)
            {
                MessageBox.Show("Kayıt güncelleme işlemi başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainForm formMain = (mainForm)Application.OpenForms["mainForm"];
                formMain.getAllRecordsBySystemUserId();

                DialogResult res = MessageBox.Show("İletişim bilgisi girmeye veya kaydı incelemeye devam etmek istiyor musunuz ?", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.No)
                {
                    this.Close();
                }


            }
            else
            {
                MessageBox.Show("Kayıt güncelleme işlemi başarısız", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNewComm_Click(object sender, EventArgs e)
        {
            addNewComm newComm = new addNewComm(data.id);
            newComm.ShowDialog(this);
        }

        private void grdComm_DoubleClick(object sender, EventArgs e)
        {
            Guid selectedCommID = (Guid)grdComm.SelectedRows[0].Cells["id"].Value;
            operationCommForm operationComm = new operationCommForm(data.id, selectedCommID);
            operationComm.ShowDialog(this);

        }
    }
}
