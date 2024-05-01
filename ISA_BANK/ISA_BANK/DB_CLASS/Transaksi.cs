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
        private Karyawan karyawan;
        private Rekening rekening;
        

        public Transaksi()
        {

        }

        public Transaksi(int id, DateTime tanggal, int jumlah, string keterangan, Karyawan karyawan, Rekening rekening)
        {
            this.Id = id;
            this.Tanggal = tanggal;
            this.Jumlah = jumlah;
            this.Keterangan = keterangan;
            this.Karyawan = karyawan;
            this.Rekening = rekening;
            
        }

        public int Id { get => id; set => id = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public int Jumlah { get => jumlah; set => jumlah = value; }
        public string Keterangan { get => keterangan; set => keterangan = value; }
        public Karyawan Karyawan { get => karyawan; set => karyawan = value; }
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
                Karyawan k = new Karyawan();

                Rekening rek = Rekening.BacaId("id", hasil.GetString(5));
                Karyawan kar = Karyawan.BacaId("id", hasil.GetString(4));


                t.Tanggal = DateTime.Parse(hasil.GetValue(1).ToString());
                t.Jumlah = int.Parse(hasil.GetValue(2).ToString());
                t.Keterangan = hasil.GetValue(3).ToString();
                t.Karyawan = kar;
                t.Rekening = rek;
             
                listHasil.Add(t);
            }
            return listHasil;
            
        }

        public static Boolean HapusData(int id)
        {
            string sql = "delete from transaksis where id='" + id + "'";

            int JumlahDitambahkan = Koneksi.JalankanPerintahDML(sql);
            Boolean Status;
            if (JumlahDitambahkan == 0)
            {
                Status = false;
            }
            else
            {
                Status = true;
            }
            return Status;
        }

        public static Boolean UbahData(Transaksi t)
        {
            string sql = "update transaksis set tanggal='" + t.Tanggal + "',jumlah='" + t.Jumlah + "',keterangan='" + t.Keterangan +
                "',rekenings_id" + t.Rekening.Id + "',karyawans_id='" + t.Karyawan.Id +  "' where id='" + t.Id + "'";

            int jumlahDiubah = Koneksi.JalankanPerintahDML(sql);
            Boolean Status;
            if (jumlahDiubah == 0)
            {
                Status = false;
            }
            else
            {
                Status = true;
            }
            return Status;
        }

        public static Boolean TambahData(Transaksi t)
        {
            string sql = "insert into transaksis(tanggal, jumlah, keterangan, karyawans_id) values('" +
                t.Tanggal + "','" + t.Jumlah + "','" + t.Keterangan + "','";

            if (t.Karyawan != null)
            {
                sql += "'" + t.Karyawan.Id + "')";
            }
            else
            {
                sql += "')";
            }
            int jumlah = Koneksi.JalankanPerintahDML(sql);

            if (jumlah == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public static Transaksi BacaId(string namaAttribute, string initialData)
        {
            {
                string sql = "select * from films where " + namaAttribute + " Like '%" + initialData + "%'";
                MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
                if (hasil.Read() == true)
                {
                    Karyawan k = Karyawan.BacaId("id", hasil.GetValue(4).ToString());
                    
                    Transaksi t = new Transaksi();

                    t.Id = int.Parse(hasil.GetValue(0).ToString());
                    t.Tanggal = DateTime.Parse(hasil.GetValue(1).ToString());
                    t.Jumlah = int.Parse(hasil.GetValue(2).ToString());
                    t.Keterangan = hasil.GetValue(3).ToString();
                    t.Karyawan = k;




                    return t;
                }
                else
                {
                    return null; ;
                }
            }
        }
        #endregion
    }
}
