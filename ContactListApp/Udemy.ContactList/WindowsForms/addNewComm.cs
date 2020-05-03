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
    public partial class addNewComm : Form
    {
        contacts data;
        public addNewComm(Guid contactId)
        {
            InitializeComponent();
            getContactDetail(contactId);
            getCommTypes();
        }

        void getContactDetail(Guid contactID)
        {
            contactService contactService = new contactService();
            data = contactService.getRecordByContactId(contactID);
            txtFirstname.Text = data.firstName;
            txtLastname.Text = data.lastName;
            txtTitle.Text = data.title;
            txtCompany.Text = data.company;
        }

        void getCommTypes()
        {
            CommTypes comm = new CommTypes();
            List<CommTypes> dataList = comm.getCommTypes();
            cmbCommTypes.DataSource = dataList;
            cmbCommTypes.DisplayMember = "Value";
            cmbCommTypes.ValueMember = "Id";
        }

        private void addNewComm_Load(object sender, EventArgs e)
        {

        }

        private void btnCommNew_Click(object sender, EventArgs e)
        {
            // ((CommTypes)cmbCommTypes.SelectedItem).Id
            CommTypes selectedComm = (CommTypes)cmbCommTypes.SelectedItem;

            contactCommService contactComm = new contactCommService();
            int resultInt = contactComm.addNewComm(data.id, selectedComm.Id, txtCommValue.Text);
            if (resultInt > 0)
            {
                MessageBox.Show("Kayıt Başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                viewUpdateContact viewForm = (viewUpdateContact)Application.OpenForms["viewUpdateContact"];
                viewForm.getContactComm(data.id);

                // ((viewUpdateContact)Application.OpenForms["viewUpdateContact"]).getContactComm(data.id);

                this.Close();
            }
        }
    }
}
