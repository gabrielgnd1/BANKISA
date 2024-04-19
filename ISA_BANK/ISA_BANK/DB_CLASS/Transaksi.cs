using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISA_BANK.DB_CLASS
{
    public class Transaksi
    {
        private int id;
        private DateTime tanggal;
        private int jumlah;
        private string keterangan;
        private Teller teller;
        private Rekening rekening;

        public Transaksi(int id, DateTime tanggal, int jumlah, string keterangan, Teller teller, Rekening rekening)
        {
            this.Id = id;
            this.Tanggal = tanggal;
            this.Jumlah = jumlah;
            this.Keterangan = keterangan;
            this.Teller = teller;
            this.Rekening = rekening;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public int Jumlah { get => jumlah; set => jumlah = value; }
        public string Keterangan { get => keterangan; set => keterangan = value; }
        public Teller Teller { get => teller; set => teller = value; }
        public Rekening Rekening { get => rekening; set => rekening = value; }
    }
}
