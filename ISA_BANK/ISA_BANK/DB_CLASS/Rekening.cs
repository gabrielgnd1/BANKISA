using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISA_BANK.DB_CLASS
{
    public class Rekening
    {
        private int id;
        private string nomor;
        private int jumlah_saldo;
        private string nomor_kartu;
        private Nasabah nasabah;
        private string jenis_kartu;

        public Rekening(int id, string nomor, int jumlah_saldo, string nomor_kartu, Nasabah nasabah, string jenis_kartu)
        {
            this.Id = id;
            this.Nomor = nomor;
            this.Jumlah_saldo = jumlah_saldo;
            this.Nomor_kartu = nomor_kartu;
            this.Nasabah = nasabah;
            this.Jenis_kartu = jenis_kartu;
        }

        public int Id { get => id; set => id = value; }
        public string Nomor { get => nomor; set => nomor = value; }
        public int Jumlah_saldo { get => jumlah_saldo; set => jumlah_saldo = value; }
        public string Nomor_kartu { get => nomor_kartu; set => nomor_kartu = value; }
        public Nasabah Nasabah { get => nasabah; set => nasabah = value; }
        public string Jenis_kartu { get => jenis_kartu; set => jenis_kartu = value; }
    }
}
