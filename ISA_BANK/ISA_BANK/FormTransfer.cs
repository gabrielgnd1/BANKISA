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
    public partial class FormTransfer : Form
    {
        public FormTransfer()
        {
            InitializeComponent();
        }

        List<Nasabah> listNasabah = new List<Nasabah>();
        List<Rekening> listRekening = new List<Rekening>();
        Rekening r = new Rekening();
        private void FormTransfer_Load(object sender, EventArgs e)
        {
            FormMain frm = (FormMain)this.Owner;
            r = Rekening.BacaId("nasabahs_id", frm.nasabah.Id.ToString());
            lblRekNum1.Text = r.Nomor;


        }

        private void btnTranfer_Click(object sender, EventArgs e)
        {
            TransaksiRekening tr = new TransaksiRekening();
            tr.RekeningTujuan = textBoxRekTujuan.Text;
            TransaksiRekening.TambahData(tr);

            Transaksi t = new Transaksi();
            t.Jumlah = int.Parse(textBoxJml.Text);
            t.Keterangan = "Transfer";
            t.Tanggal = DateTime.Now;
            Transaksi.TambahData(t);
        }

        private void btnTranfer_Click_1(object sender, EventArgs e)
        {

        }
    }
}