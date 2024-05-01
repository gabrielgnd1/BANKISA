using ISA_BANK.DB_CLASS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISA_BANK
{
    public partial class FormAddRekening : Form
    {
        public FormAddRekening()
        {
            InitializeComponent();
        }

        FormMain frmMain;
        List<Nasabah> listNasabah = new List<Nasabah>();


        private void FormAddRekening_Load(object sender, EventArgs e)
        {
            frmMain = (FormMain)this.Owner;
            listNasabah = Nasabah.BacaData("", "");

            // Decrypt NIK values
            foreach (var nasabah in listNasabah)
            {
                nasabah.Nik = AES.Decrypt(nasabah.Nik);
            }

            // Add an empty item as the first item in the list
            listNasabah.Insert(0, new Nasabah { Id = -1, Nik = "" }); // You can set appropriate default values

            cboNik.DataSource = listNasabah;
            cboNik.DisplayMember = "Nik";
            cboNik.ValueMember = "Id";

            // Select the first item in the combo box (empty item)
            cboNik.SelectedIndex = 0;
        }


        private void cboNik_SelectedIndexChanged(object sender, EventArgs e)
        {
            Nasabah pilih = (Nasabah)cboNik.SelectedItem;
            custName.Text = pilih.Nama;
            nikNum.Text = pilih.Nik;
            dateBirth.Text = pilih.Ttl.ToString("yyyy-MM-dd");
            gender.Text = pilih.Gender;
            phoneNum.Text = pilih.No_telepon;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Rekening rek = new Rekening();
                Nasabah pilih = (Nasabah)cboNik.SelectedItem;

                rek.Nomor = txtAccNum.Text;
                rek.Nomor_kartu = txtCardNum.Text;
                rek.Jumlah_saldo = int.Parse(txtDeposit.Text);
                rek.Jenis_kartu = cboJenisKartu.SelectedItem.ToString();
                rek.Nasabah = pilih;

                Rekening.TambahData(rek);

                MessageBox.Show("Tambah data berhasil");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah data gagal. ERROR : " + ex.Message);
            }
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            //string filter;
            //if (cboNik.SelectedIndex == 0)
            //    filter = "KodeKategori";
            //else
            //    filter = "nama";

            //string nilai = textBoxCari.Text;

            //List<Nasabah> ListData = Kategori.BacaData(filter, nilai);
            //dataGridViewData.DataSource = ListData;
        }
    }
}