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
    public partial class newRecord : Form
    {
        public newRecord()
        {
            InitializeComponent();
        }

        private void btnCreateNewRecord_Click(object sender, EventArgs e)
        {
            contactService contactService = new contactService();
            int returnvalue = contactService.addNewRecord(new OperationLayer.Entities.contact()
            {
                Id = Guid.NewGuid(),
                title = txtPersonelTitle.Text,
                company = txtPersonelCompany.Text,
                firstname = txtPersonelName.Text,
                lastname = txtPersonelLastname.Text,
                personelNote = txtPersonelNote.Text,
                systemUserId = applicationStatics.currentSystemUser.Id,
                creationDate = DateTime.Now
            });
            if (returnvalue > 0)
            {
                MessageBox.Show("Kayıt ekleme işlemi başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult resultDialog = MessageBox.Show("Kayıt detaylarını şimdi girmek ister misiniz ? ", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultDialog == DialogResult.Yes)
                {

                }
                else
                {
                    Form mainForm = Application.OpenForms["mainApp"];
                    ((mainApp)mainForm).getContactList();

                    this.Close();
                }
            }

        }

        private void newRecord_Load(object sender, EventArgs e)
        {

        }
    }
}
