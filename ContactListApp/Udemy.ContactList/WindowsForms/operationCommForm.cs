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
    public partial class operationCommForm : Form
    {
        contacts data;
        Guid contactCommID;
        public operationCommForm(Guid contactId, Guid contactCommId)
        {
            InitializeComponent();
            // opsiyonel olarak alındı. 
            getContact(contactId);
            this.contactCommID = contactCommId;
        }

        void getContact(Guid contactId)
        {
            contactService contactService = new contactService();
            data = contactService.getRecordByContactId(contactId);
        }

        private void operationCommForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRecordDelete_Click(object sender, EventArgs e)
        {
            contactCommService commService = new contactCommService();
            int resultInt = commService.deleteContactComm(this.contactCommID);
            if (resultInt > 0)
            {
                MessageBox.Show("Silme işlemi başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                viewUpdateContact view = (viewUpdateContact)Application.OpenForms["viewUpdateContact"];
                view.getContactComm(data.id);

                this.Close();
            }
        }

        private void btnViewUpdate_Click(object sender, EventArgs e)
        {
            viewUpdateContactComm viewUpdateContact = new viewUpdateContactComm(data.id, this.contactCommID);
            viewUpdateContact.ShowDialog(this);
            this.Close();
        }
    }
}
