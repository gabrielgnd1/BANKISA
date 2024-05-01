using ISA_BANK.DB_CLASS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        public Nasabah CurrentNasabah;

        List<Nasabah> listNasabah = new List<Nasabah>();
        List<Rekening> listRekening = new List<Rekening>();
        Rekening noRek;

        private void FormTransfer_Load(object sender, EventArgs e)
        {
            FormMain frm = (FormMain)this.Owner;

            noRek = Rekening.BacaId("nasabahs_id", CurrentNasabah.Id.ToString());
            string r = noRek.Nomor;
            lblRekNum1.Text = r;


        }

        private void btnTranfer_Click(object sender, EventArgs e)
        {
            //TransaksiRekening tr = new TransaksiRekening();
            //tr.RekeningTujuan = textBoxRekTujuan.Text;
            //TransaksiRekening.TambahData(tr);

            //Transaksi t = new Transaksi();
            //t.Jumlah = int.Parse(textBoxJml.Text);
            //t.Keterangan = "Transfer";
            //t.Tanggal = DateTime.Now;
            //Transaksi.TambahData(t);


            // Mendapatkan data rekening pengirim (CurrentNasabah)
            Rekening rekeningPengirim = Rekening.BacaId("nasabahs_id", CurrentNasabah.Id.ToString());

            // Validasi apakah saldo mencukupi untuk transfer
            int jumlahTransfer;
            if (!int.TryParse(textBoxJml.Text, out jumlahTransfer))
            {
                MessageBox.Show("Masukkan jumlah transfer yang valid.");
                return;
            }
            if (jumlahTransfer <= 0)
            {
                MessageBox.Show("Jumlah transfer harus lebih dari 0.");
                return;
            }
            if (rekeningPengirim.Jumlah_saldo < jumlahTransfer)
            {
                MessageBox.Show("Saldo tidak mencukupi untuk transfer.");
                return;
            }

            // Mendapatkan data rekening tujuan
            Rekening rekeningTujuan = Rekening.BacaData("nomor", textBoxRekTujuan.Text).FirstOrDefault();
            if (rekeningTujuan == null)
            {
                MessageBox.Show("Rekening tujuan tidak ditemukan.");
                return;
            }

            // Mengurangi saldo dari rekening pengirim
            Rekening.WithdrawalData(rekeningPengirim, jumlahTransfer);

            // Menambahkan saldo ke rekening tujuan
            Rekening.DepositData(rekeningTujuan, jumlahTransfer);

            // Mencatat transaksi transfer ke database
            Transaksi transaksi = new Transaksi();
            transaksi.Jumlah = jumlahTransfer;
            transaksi.Keterangan = "Transfer ke " + textBoxRekTujuan.Text;
            transaksi.Tanggal = DateTime.Now;

            Transaksi.TambahData(transaksi);

            TransaksiRekening tr = new TransaksiRekening();
            tr.IdTransaksi = transaksi;
            tr.IdRekening = rekeningPengirim;
            tr.RekeningTujuan = rekeningTujuan.Id.ToString();
            TransaksiRekening.TambahData(tr);

            // Menampilkan pesan sukses
            MessageBox.Show("Transfer berhasil dilakukan.");

            // Bersihkan isian textbox
            textBoxJml.Clear();
            textBoxRekTujuan.Clear();


        }

        public static void CetakTransaksi(string namaUser)
        {
            string nama = "Laporan Transaksi " + DateTime.Now.ToString("yyyyMMddHHmm") + ".txt";
            Transaksi t = new Transaksi();
            using (StreamWriter NamaFile = new StreamWriter(nama))
            {
                NamaFile.WriteLine("LAPORAN TRANSAKSI");
                NamaFile.WriteLine();
                NamaFile.WriteLine("Transaksi Oleh :" + t.Rekening);
                NamaFile.WriteLine("Sejumlah :" + t.Jumlah);
                NamaFile.WriteLine("Menuju : Savings Account");
                NamaFile.WriteLine("Status : SUKSES");
                NamaFile.WriteLine("--------------------------------");
                NamaFile.WriteLine("Dicetak pada tanggal " + DateTime.Now.ToString("dd-MM-yyyy HH:mm"));
                NamaFile.Close();
            }

            // proses mencetak ke printer
            CustomPrintcs p = new CustomPrintcs(new System.Drawing.Font("courier new", 12), nama);
            p.KirimkePrinter();



        }
    }
}