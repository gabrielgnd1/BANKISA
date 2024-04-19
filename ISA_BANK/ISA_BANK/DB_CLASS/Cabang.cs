using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISA_BANK.DB_CLASS
{
    public class Cabang
    {
        private int id;
        private string nama;

        public Cabang(int id, string nama)
        {
            this.Id = id;
            this.Nama = nama;
        }
        public Cabang() { }

        public Cabang()
        {
            Id = 0;
            Nama = "";
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }

        public static List<Cabang> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "")
            {
                sql = "select * from cabang";
            }
            else
            {
                sql = "select * from cabang where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Cabang> listCabang = new List<Cabang>();
            while (hasil.Read() == true)
            {
                Cabang c = new Cabang();

                c.Nama = hasil.GetValue(1).ToString();
                c.Id = int.Parse(hasil.GetValue(4).ToString());
           

                listCabang.Add(c);
            }
            return listCabang;
        }
    }
}
