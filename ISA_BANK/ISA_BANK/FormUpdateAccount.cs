using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISA_BANK.DB_CLASS;
using System.Windows.Forms;

namespace ISA_BANK
{
    public partial class FormUpdateAccount : Form
    {
        public FormUpdateAccount()
        {
            InitializeComponent();
        }

        FormMain frmMain;
        List<Nasabah> listNasabah = new List<Nasabah>();

        private void FormUpdateAccount_Load(object sender, EventArgs e)
        {
            comboBoxNik.Focus();
            frmMain = (FormMain)this.Owner;
            listNasabah = Nasabah.BacaData("", "");

            // Decrypt NIK values
            foreach (var nasabah in listNasabah)
            {
                nasabah.Nik = AES.Decrypt(nasabah.Nik);
            }

            listNasabah.Insert(0, new Nasabah { Id = -1, Nik = "" });

            comboBoxNik.DataSource = listNasabah;
            comboBoxNik.ValueMember = "Id";
            comboBoxNik.DisplayMember = "NIK";
            comboBoxNik.SelectedIndex = 0;
        }

        private void comboBoxNik_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNik.SelectedItem != null)
            {
                Nasabah pilih = (Nasabah)comboBoxNik.SelectedItem;
                txtCustName.Text = pilih.Nama;
                comboBoxNik.Text = pilih.Nik;
                txtUsername.Text = pilih.Username;
                textBoxPhoneNum.Text = pilih.No_telepon;
            }
            else
            {
                txtCustName.Text = "";
                comboBoxNik.Text = "";
                txtUsername.Text = "";
                textBoxPhoneNum.Text = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //buat objek penampung 
                Nasabah nas = new Nasabah();
                nas.Nama = txtCustName.Text;
                nas.Nik = comboBoxNik.Text;
                nas.Username = txtUsername.Text;
                nas.No_telepon = textBoxPhoneNum.Text;
                //nas.Id = nas.Id;
                //nas.Password = nas.Password;
                //nas.Ttl = nas.Ttl;

                //ubah data di database:
                Nasabah.UbahData(nas);

                MessageBox.Show("Ubah Data berhasil");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ubah Data gagal. Error : " + ex.Message);
            }
        }
    }
}
