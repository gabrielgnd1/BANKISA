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
            cboNik.DataSource = listNasabah;
            cboNik.DisplayMember = "Nama";
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
            Rekening rek = new Rekening();
            rek.Nomor = txtAccNum.Text;
            rek.Nomor_kartu = txtCardNum.Text;
            rek.Jumlah_saldo = int.Parse(txtDeposit.Text);
            rek.Jenis_kartu = cboJenisKartu.SelectedItem.ToString();
        }
    }
}
