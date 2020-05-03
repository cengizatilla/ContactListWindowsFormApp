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
using Udemy.ContactList.Operation.Services;

namespace Udemy.ContactList.WindowsForms
{
    public partial class operationContactForm : Form
    {
        contacts data;
        public operationContactForm(Guid recordId)
        {
            InitializeComponent();
            getContactById(recordId);
        }

        void getContactById(Guid recordId)
        {
            contactService contactService = new contactService();
            data = contactService.getRecordByContactId(recordId);
            txtFirstname.Text = data.firstName;
            txtLastname.Text = data.lastName;
            txtCompany.Text = data.company;
            txtTitle.Text = data.title;
        }

        private void operationContactForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRecordDelete_Click(object sender, EventArgs e)
        {
            contactService contactService = new contactService();
            int resultInt = contactService.deleteRecordByID(data.id);
            if(resultInt > 0)
            {
                mainForm mainformValue = (mainForm)Application.OpenForms["mainForm"];
                mainformValue.getAllRecordsBySystemUserId();
                this.Close();
            }
            else
            {
                MessageBox.Show("Silme işlemi başarısız", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnViewUpdate_Click(object sender, EventArgs e)
        {
            viewUpdateContact viewUpdate = new viewUpdateContact(data.id);
            viewUpdate.ShowDialog(this);
            this.Close();
        }
    }
}
