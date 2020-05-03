using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Udemy.ContactList.Operation.Services;

namespace Udemy.ContactList.WindowsForms
{
    public partial class addNewContact : Form
    {
        public addNewContact()
        {
            InitializeComponent();
        }

        private void btnNewContact_Click(object sender, EventArgs e)
        {
            contactService contactService = new contactService();
            int resultInt = contactService.addNewContact(txtFirstName.Text, txtLastName.Text, txtCompany.Text, txtTitle.Text, txtNote.Text);

            if(resultInt > 0)
            {
                MessageBox.Show("Kayıt ekleme işlemi başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult result = MessageBox.Show("Kayıt detaylarını şimdi girmek ister misiniz?", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if(result == DialogResult.Yes)
                {
                    // Eğer tamam ise o zaman bizim burada güncelleme formun açmamız gerekli... Burada unuttuğumuz bir şey var ... 
                }
                else
                {
                    mainForm OpenForm = (mainForm)Application.OpenForms["mainForm"];
                    OpenForm.getAllRecordsBySystemUserId();
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Kayıt eklenemedi, Form içerisinde bulunan alanlardan isim ve soyisim değerlerinin dolu olduğuna emin olunuz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
