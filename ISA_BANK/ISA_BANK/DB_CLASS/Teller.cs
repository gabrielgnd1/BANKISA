using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISA_BANK.DB_CLASS
{
    public class Teller
    {
        private int id;
        private string nama;
        private Cabang cabang;
        private Akun akun;

        public Teller(int id, string nama, Cabang cabang, Akun akun)
        {
            this.Id = id;
            this.Nama = nama;
            this.Cabang = cabang;
            this.Akun = akun;
        }
        public Teller() { } 
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public Cabang Cabang { get => cabang; set => cabang = value; }
        public Akun Akun { get => akun; set => akun = value; }

        #region method
        public static List<Teller> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "")
            {
                sql = "select * from tellers";
            }
            else
            {
                sql = "select * from tellers where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Teller> listTeller = new List<Teller>();
            while (hasil.Read() == true)
            {
                Teller t = new Teller();
                Cabang c = new Cabang(); //kurang cabang
                Akun a = new Akun();

                t.Nama = hasil.GetValue(1).ToString();
                c.Id = int.Parse(hasil.GetValue(2).ToString());
                a.Id = int.Parse(hasil.GetValue(3).ToString());

                listTeller.Add(t);
            }
            return listTeller;
        }

        #endregion
    }
}
