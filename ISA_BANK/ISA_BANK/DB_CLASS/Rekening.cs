using MySql.Data.MySqlClient;
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

        public Rekening() { }

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



        #region method
        public static List<Rekening> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "")
            {
                sql = "select * from rekenings";
            }
            else
            {
                sql = "select * from rekenings where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Rekening> listRekening = new List<Rekening>();
            while (hasil.Read() == true)
            {


                Rekening r = new Rekening();
                Nasabah n = Nasabah.BacaId("id", hasil.GetInt32(5).ToString());

                r.Id = hasil.GetInt32(0);
                r.Nomor = hasil.GetValue(1).ToString();
                r.Jumlah_saldo = hasil.GetInt32(2);
                r.Nomor_kartu = hasil.GetValue(3).ToString();
                r.Jenis_kartu = hasil.GetValue(4).ToString();
                r.Nasabah = n;


                listRekening.Add(r);
            }
            return listRekening;
        }

        public static void HapusData(string KodeHapus)
        {   //susun perintah query
            string perintah = "delete from rekenings where id='" + KodeHapus + "';";

            Koneksi.JalankanPerintahDML(perintah);
        }

        public static void TambahData(Rekening obj)
        {
            string sql = "INSERT INTO rekenings(nomor, jumlah_saldo, nomor_kartu, nasabahs_id, jenis_kartu) " +
                "VALUES(" +
                "'" + obj.Nomor + "'," +
                "'" + obj.Jumlah_saldo + "'," +
                "'" + obj.Nomor_kartu + "'," +
                "'" + obj.Nasabah.Id + "'," +
                "'" + obj.Jenis_kartu + "');";
            Koneksi.JalankanPerintahDML(sql);
        }

        public static Rekening BacaId(string namaAttribute, string initialData)
        {
            {
                string sql = "select * from rekenings where " + namaAttribute + " Like '%" + initialData + "%'";
                MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
                if (hasil.Read() == true)
                {
                    Rekening r = new Rekening();
                    Nasabah n = Nasabah.BacaId("id", hasil.GetInt32(5).ToString());
                   
                    r.Id = hasil.GetInt32(0);
                    r.Nomor = hasil.GetValue(1).ToString();
                    r.Jumlah_saldo = hasil.GetInt32(2);
                    r.Nomor_kartu = hasil.GetValue(3).ToString();
                    r.Jenis_kartu = hasil.GetValue(4).ToString();
                    r.Nasabah = n;
                    return r;
                }
                else
                {
                    return null; ;
                }
            }
        }

        public static void WithdrawalData(Rekening rek, int jumlah_penarikan)
        {   //susun perintah query
            string perintah = "UPDATE rekenings SET jumlah_saldo = jumlah_saldo -" + jumlah_penarikan + " WHERE nasabahs_id = " + rek.Nasabah.Id + "";

            Koneksi.JalankanPerintahQuery(perintah); //kirim ke command
        }

        public static void DepositData(Rekening rek, int jumlah_penarikan)
        {   //susun perintah query
            string perintah = "UPDATE rekenings SET jumlah_saldo = jumlah_saldo +" + jumlah_penarikan + " WHERE nasabahs_id = " + rek.Nasabah.Id + "";

            Koneksi.JalankanPerintahQuery(perintah); //kirim ke command
        }

        #endregion
    }


}
