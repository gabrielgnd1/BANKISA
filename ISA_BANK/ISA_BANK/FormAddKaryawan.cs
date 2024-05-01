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
            //Cabang c = new Cabang();
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

            Cabang selectedCabang = comboBoxCabang.SelectedItem as Cabang;
            if (selectedCabang == null)
            {
                MessageBox.Show("Pilih Cabang", "Peringatan");
                return; // Return if branch is not selected
            }


                k.Username = txtUsername.Text;
                k.Password = enPw;
                k.Nama = txtName.Text;
                k.Roles = comboBoxRoles.SelectedItem.ToString();
                k.Cabang = selectedCabang;
                k.Email = txtEmail.Text;
                k.NoTelp = textBoxPhoneNum.Text;
                k.TglLahir = dateTimePickerBirth.Value;
            
            Karyawan.TambahData(k);
            MessageBox.Show("Data Telah Tersimpan.", "Informasi");
            this.Close();
        }

        private void FormAddKaryawan_Load(object sender, EventArgs e)
        {
            List<Cabang> ListData = Cabang.BacaData("", "");
            comboBoxCabang.DataSource = ListData;
            comboBoxCabang.DisplayMember = "Nama";

        }

        private void comboBoxCabang_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
