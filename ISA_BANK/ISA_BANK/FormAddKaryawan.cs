using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISA_BANK.DB_CLASS;
using ISA_BANK.Security;

namespace ISA_BANK
{
    public partial class FormAddKaryawan : Form
    {
        public FormAddKaryawan()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Karyawan k = new Karyawan();
            Cabang c = new Cabang();
            if (rdoMale.Checked)
            {
                k.Gender = "Pria";
            }
            else if (rdoFemale.Checked)
            {
                k.Gender = "Wanita";
            }
            else
            {
                MessageBox.Show("Pilih Jenis Kelamin", "Peringatan");
            }

            string enPw = AES.Encrypt(txtPassword.Text);

            k.Username = txtUsername.Text;
            k.Password = enPw;
            k.Nama = txtName.Text;
            //k.Roles = comboBoxRoles.;
            //c.Id = 
            k.Email = txtEmail.Text;
            k.NoTelp = textBoxPhoneNum.Text;
            k.TglLahir = dateTimePickerBirth.Value;

            Karyawan.TambahData(k);
            MessageBox.Show("Data Telah Tersimpan.", "Informasi");
            this.Close();
        }
    }
}
