using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISA_BANK.DB_CLASS
{
    public class Nasabah
    {
        private int id;
        private string nama;
        private DateTime ttl;
        private Akun akun;
        private string nik;
        private string no_telepon;
        private string gender;

        public Nasabah() { }

        public Nasabah(int id, string nama, DateTime ttl, Akun akun, string nik, string no_telepon, string gender)
        {
            this.Id = id;
            this.Nama = nama;
            this.Ttl = ttl;
            this.Akun = akun;
            this.Nik = nik;
            this.No_telepon = no_telepon;
            this.Gender = gender;
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public DateTime Ttl { get => ttl; set => ttl = value; }
        public Akun Akun { get => akun; set => akun = value; }
        public string Nik { get => nik; set => nik = value; }
        public string No_telepon { get => no_telepon; set => no_telepon = value; }
        public string Gender { get => gender; set => gender = value; }

        #region Methods
        public static List<Nasabah> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "")
            {
                sql = "select * from nasabah";
            }
            else
            {
                sql = "select * from nasabah where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Nasabah> listNasabah = new List<Nasabah>();
            while (hasil.Read() == true)
            {
                Nasabah n = new Nasabah();
                Akun a = new Akun();
                
                n.Nama = hasil.GetValue(1).ToString();
                n.Ttl = DateTime.Parse(hasil.GetValue(2).ToString());
                a.Id = int.Parse(hasil.GetValue(3).ToString());
                n.Nik = hasil.GetValue(4).ToString();
                n.No_telepon = hasil.GetValue(5).ToString();
                n.Gender = hasil.GetValue(6).ToString();

                listNasabah.Add(n);
            }
            return listNasabah;
        }
        #endregion
    }
}
