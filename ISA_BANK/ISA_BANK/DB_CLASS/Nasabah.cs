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
        private string nik;
        private string no_telepon;
        private string gender;
        private string username;
        private string password;

        public Nasabah()
        {
            Id = 0;
            Nama = "";
            Ttl = DateTime.Now;
            Nik = "";
            No_telepon = "";
            Gender = "";
            Username = "";
            Password = "";
        }

        public Nasabah(int id, string nama, DateTime ttl, string nik, string no_telepon, string gender, string username, string password)
        {
            this.Id = id;
            this.Nama = nama;
            this.Ttl = ttl;
            this.Nik = nik;
            this.No_telepon = no_telepon;
            this.Gender = gender;
            this.Username = username;
            this.Password = password;
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public DateTime Ttl { get => ttl; set => ttl = value; }
        public string Nik { get => nik; set => nik = value; }
        public string No_telepon { get => no_telepon; set => no_telepon = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public static Nasabah CekLogin(string username, string password)
        {
            string sql = ""; 
            sql = "select * from nasabahs where username='" + username + "' AND password = SHA2('" + password + "', 512)";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);//ksekusi perintah diatass

            // selama masih ada data yang dibaca di data reader
            if (hasil.Read() == true)
            {
                Nasabah tampung = new Nasabah(); //tampung ke sebuah kategori
                tampung.Id = int.Parse(hasil.GetValue(0).ToString());
                tampung.Nama = hasil.GetValue(1).ToString();
                tampung.Ttl = DateTime.Parse(hasil.GetValue(2).ToString());
                tampung.Nik = hasil.GetValue(3).ToString();
                tampung.No_telepon = hasil.GetValue(4).ToString();
                tampung.Gender = hasil.GetValue(5).ToString();
                tampung.Username = hasil.GetValue(6).ToString();
                tampung.Password = hasil.GetValue(7).ToString();             
                return tampung;
            }

            else return null;
        }

        public static Nasabah BacaDataPerNasabah(string username)
        {
            string sql = "select * from nasabahs where username = '" + username + "'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            //buat list utk tampung data
            List<Nasabah> listNasabah = new List<Nasabah>();
            while (hasil.Read() == true) // selama masih ada data atau masih bisa membaca data 
            {
                Nasabah tampung = new Nasabah(); //tampung ke sebuah kategori
                tampung.Id = int.Parse(hasil.GetValue(0).ToString());
                tampung.Nama = hasil.GetValue(1).ToString();
                tampung.Ttl = DateTime.Parse(hasil.GetValue(2).ToString());
                tampung.Nik = hasil.GetValue(3).ToString();
                tampung.No_telepon = hasil.GetValue(4).ToString();
                tampung.Gender = hasil.GetValue(5).ToString();
                tampung.Username = hasil.GetValue(6).ToString();
                tampung.Password = hasil.GetValue(7).ToString();


                return tampung;
            }
            return null;
        }

        public static List<Nasabah> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";
            if (kriteria == "") //jika tidak ada kriteria yang diisikan
            {
                sql = "select * from nasabahs";
            }
            else
            {
                sql = "select * from nasabahs where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            //buat list utk tampung data
            List<Nasabah> listNasabah = new List<Nasabah>();
            while (hasil.Read() == true) // selama masih ada data atau masih bisa membaca data 
            {
                Nasabah tampung = new Nasabah(); //tampung ke sebuah kategori
                tampung.Id = int.Parse(hasil.GetValue(0).ToString());
                tampung.Nama = hasil.GetValue(1).ToString();
                tampung.Ttl = DateTime.Parse(hasil.GetValue(2).ToString());
                tampung.Nik = hasil.GetValue(3).ToString();
                tampung.No_telepon = hasil.GetValue(4).ToString();
                tampung.Gender = hasil.GetValue(5).ToString();
                tampung.Username = hasil.GetValue(6).ToString();
                tampung.Password = hasil.GetValue(7).ToString();


                listNasabah.Add(tampung);
            }
            return listNasabah;
        }

        public static void TambahData(Nasabah n)
        {
            //string sql = "insert into nasabahs(nama, ttl, nik, no_telepon, gender, username, password) values('" +
            //    n.Nama.Replace("'", "\\") + "','" + n.Ttl + "','" + n.Nik + "','" + n.No_telepon + "','" + n.Gender + "','" +
            //    n.Username + "','" + ", sha2('" + n.Password + "', 512),'" + "')";
            string sql = "INSERT INTO nasabahs" + "(nama, ttl, nik, no_telepon, gender, username, password) VALUES ('" +
             n.Nama + "','" +
             n.Ttl.ToString("yyyy-MM-dd") + "','" +
             n.Nik + "','" +
             n.No_telepon + "','" +
             n.Gender + "','" +
             n.Username + "', SHA2('" + 
             n.Password + "',512));";

            Koneksi.JalankanPerintahDML(sql);

        }

        public static Boolean HapusData(int id)
        {
            string sql = "delete from nasabahs where id='" + id + "'";

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

        public static Boolean UbahData(Nasabah n)
        {      
            string sql = "update nasabahs set Nama='" + n.Nama.Replace("'", "\\") + "',ttl='" + n.Ttl + "',nik='" + n.Nik + 
                "',no_telepon='" + n.No_telepon + "',gender='" + n.Gender + "',username='" + n.Username + "' where id='" + n.Id + "'";

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

        public static Nasabah BacaId(string namaAttribute, string initialData)
        {
            {
                string sql = "select * from nasabahs where " + namaAttribute + " Like '%" + initialData + "%'";
                MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
                if (hasil.Read() == true)
                {
                    Nasabah tampung = new Nasabah();

                    tampung.Id = int.Parse(hasil.GetValue(0).ToString());
                    tampung.Nama = hasil.GetValue(1).ToString();
                    tampung.Ttl = DateTime.Parse(hasil.GetValue(2).ToString());
                    tampung.Nik = hasil.GetValue(3).ToString();
                    tampung.No_telepon = hasil.GetValue(4).ToString();
                    tampung.Gender = hasil.GetValue(5).ToString();
                    tampung.Username = hasil.GetValue(6).ToString();
                    tampung.Password = hasil.GetValue(7).ToString();

                    return tampung;


                }
                else
                {
                    return null; ;
                }
            }
        }
    }
}
