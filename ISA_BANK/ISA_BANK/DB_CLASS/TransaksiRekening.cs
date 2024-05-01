using Google.Protobuf.Collections;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISA_BANK.DB_CLASS
{
    public class TransaksiRekening
    {
        Transaksi idTransaksi;
        Rekening idRekening;
        string rekeningTujuan;

        public TransaksiRekening()
        {
        }

        public TransaksiRekening(Transaksi idTransaksi, Rekening idRekening, string rekeningTujuan)
        {
            this.IdTransaksi = idTransaksi;
            this.IdRekening = idRekening;
            this.RekeningTujuan = rekeningTujuan;
        }

        public Transaksi IdTransaksi { get => idTransaksi; set => idTransaksi = value; }
        public Rekening IdRekening { get => idRekening; set => idRekening = value; }
        public string RekeningTujuan { get => rekeningTujuan; set => rekeningTujuan = value; }




        #region method
        public static List<TransaksiRekening> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "")
            {
                sql = "select * from transaksi_rekening";
            }
            else
            {
                sql = "select * from transaksi_rekening where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<TransaksiRekening> listHasil = new List<TransaksiRekening>();
            while (hasil.Read() == true)
            {
                TransaksiRekening tr = new TransaksiRekening();
                Transaksi t = Transaksi.BacaId("id", hasil.GetString(0));
                Rekening r = Rekening.BacaId("id", hasil.GetString(1));

                tr.IdTransaksi = t;
                tr.IdRekening = r;
                tr.RekeningTujuan = hasil.GetString(2);

                listHasil.Add(tr);
            }
            return listHasil;

        }

        public static void TambahData(TransaksiRekening tr)
        {
            string sql = "INSERT INTO transaksi_rekening(rekenings_id, rekeningtujuan_id, transaksis_id) VALUES('" +
                tr.IdRekening.Id + "','" + tr.RekeningTujuan + "','" + tr.IdTransaksi.Id + "')";
            Koneksi.JalankanPerintahDML(sql);
        }

        #endregion

    }
}
