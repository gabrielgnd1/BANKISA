using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISA_BANK.DB_CLASS
{
    public class Mutasi
    {
        private Transaksi transaksi;
        private Nasabah nasabah;

        public Mutasi(Transaksi transaksi, Nasabah nasabah)
        {
            this.Transaksi = transaksi;
            this.Nasabah = nasabah;
        }

        public Transaksi Transaksi { get => transaksi; set => transaksi = value; }
        public Nasabah Nasabah { get => nasabah; set => nasabah = value; }
    }
}
