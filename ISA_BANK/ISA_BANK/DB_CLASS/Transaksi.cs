using MySql.Data.MySqlClient;
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

        public Transaksi()
        {

        }

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

        #region Methods
        public static List<Transaksi> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "")
            {
                sql = "select * from transaksis";
            }
            else
            {
                sql = "select * from transaksis where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Transaksi> listHasil = new List<Transaksi>();
            while (hasil.Read() == true)
            {
                Rekening r = new Rekening();
                Transaksi t = new Transaksi();
                Teller tl = new Teller();

                
                t.Tanggal = DateTime.Parse(hasil.GetValue(1).ToString());
                t.Jumlah = int.Parse(hasil.GetValue(2).ToString());
                t.Keterangan = hasil.GetValue(3).ToString();    
                tl.Id = int.Parse(hasil.GetValue(4).ToString());
                r.Id = int.Parse(hasil.GetValue(5).ToString());
                listHasil.Add(t);
            }
            return listHasil;
            #endregion
        }
}
