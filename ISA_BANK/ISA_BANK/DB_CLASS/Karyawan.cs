using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISA_BANK.DB_CLASS
{
    public class Karyawan
    {
        private int id;
        private string username;
        private string password;
        private string nama;
        private string roles;
        private string email;
        private string noTelp;
        private DateTime tglLahir;
        private string gender;
        private Cabang cabang;

        public Karyawan()
        {
            Id = 0;
            Username = "";
            Password = "";
            Nama = "";
            Roles = "";
            Email = "";
            NoTelp = "";
            TglLahir = DateTime.Now;
            Gender = "";
            Cabang = new Cabang();
        }

        public Karyawan(int id, string username, string password, string nama, string roles, string email, string noTelp, DateTime tglLahir, string gender, Cabang cabang)
        {
            this.Id = id;
            this.Username = username;
            this.Password = password;
            this.Nama = nama;
            this.Roles = roles;
            this.Email = email;
            this.NoTelp = noTelp;
            this.TglLahir = tglLahir;
            this.Gender = gender;
            this.Cabang = cabang;
        }

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Roles { get => roles; set => roles = value; }
        public string Email { get => email; set => email = value; }
        public string NoTelp { get => noTelp; set => noTelp = value; }
        public DateTime TglLahir { get => tglLahir; set => tglLahir = value; }
        public string Gender { get => gender; set => gender = value; }
        public Cabang Cabang { get => cabang; set => cabang = value; }



        #region Methods
        public static Karyawan CekLogin(string username, string password)
        {
            string sql = "";

            //sql = "select * from karyawans where Username='" + username + "' AND Password = SHA2('" + password + "', 512)";
            sql = "select * from karyawans where Username='" + username + "' AND Password = '" + password + "'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            while (hasil.Read() == true) //selama ini masih ada data atau masih bisa membaca data
            {

                Karyawan k = new Karyawan();
                Cabang c = new Cabang();
                k.Id = int.Parse(hasil.GetValue(0).ToString());
                k.Username = hasil.GetValue(1).ToString();
                k.Password = hasil.GetValue(2).ToString();
                k.Nama = hasil.GetValue(3).ToString();
                k.Roles = hasil.GetValue(4).ToString();
                k.Cabang = c;
                k.Email = hasil.GetValue(6).ToString();
                k.NoTelp = hasil.GetValue(7).ToString();
                k.TglLahir = DateTime.Parse(hasil.GetValue(8).ToString());
                k.Gender = hasil.GetValue(9).ToString();

                return k;
            }
            return null;
        }

        public static List<Karyawan> BacaData(string filter = "", string nilai = "")
        {
            string sql = "";
            if (filter == "") //jika tidak ada kriteria yang diisikan
            {
                sql = "select * from karyawans";
            }
            else
            {
                sql = "select * from karyawans where" + filter + " like %" + nilai + "%";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            //buat list utk tampung data
            List<Karyawan> listKaryawan = new List<Karyawan>();
            while (hasil.Read() == true) // selama masih ada data atau masih bisa membaca data 
            {
                //baca data MySqlReader dan simpan di objek
                Karyawan k = new Karyawan();
                Cabang c = new Cabang();
                k.Id = int.Parse(hasil.GetValue(0).ToString());
                k.Username = hasil.GetValue(1).ToString();
                k.Password = hasil.GetValue(2).ToString();
                k.Nama = hasil.GetValue(3).ToString();
                k.Roles = hasil.GetValue(4).ToString();
                c.Id = int.Parse((hasil.GetValue(5).ToString()));
                k.Email = hasil.GetValue(6).ToString();
                k.NoTelp = hasil.GetValue(7).ToString();
                k.TglLahir = DateTime.Parse(hasil.GetValue(8).ToString());
                k.Gender = hasil.GetValue(9).ToString();
          
                listKaryawan.Add(k);
            }
            return listKaryawan;
        }

        public static Karyawan BacaId(string namaAttribute, string initialData)
        {
            {
                string sql = "select * from karyawans where " + namaAttribute + " Like '%" + initialData + "%'";
                MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
                if (hasil.Read() == true)
                {

                    Karyawan k = new Karyawan();
                    Cabang c = Cabang.BacaId("Id", hasil.GetString(5));


                    k.Id = int.Parse(hasil.GetValue(0).ToString());
                    k.Nama = hasil.GetValue(1).ToString();
                    k.Roles = hasil.GetValue(2).ToString();
                    k.Email = hasil.GetValue(3).ToString();
                    k.NoTelp = hasil.GetValue(4).ToString();
                    k.Cabang = c;
                    k.TglLahir = DateTime.Parse(hasil.GetValue(6).ToString());
                    k.Gender = hasil.GetValue(7).ToString();
                    k.Username = hasil.GetValue(8).ToString();
                    k.Password = hasil.GetValue(9).ToString();
                 

                    return k;
                }
                else
                {
                    return null; ;
                }
            }
        }

        public static void TambahData(Karyawan k)
        {
            //string sql = "insert into nasabahs(nama, ttl, nik, no_telepon, gender, username, password) values('" +
            //    n.Nama.Replace("'", "\\") + "','" + n.Ttl + "','" + n.Nik + "','" + n.No_telepon + "','" + n.Gender + "','" +
            //    n.Username + "','" + ", sha2('" + n.Password + "', 512),'" + "')";
            string sql = "INSERT INTO karyawans" + "(id, nama, roles, email, no_telepon, cabangs_id, tanggal_lahir, gender, username, password) VALUES ('" +
             k.Id + "','" +
             k.Nama + "','" +
             k.Roles + "','" +
             k.Email + "','" +
             k.NoTelp + "','" +
             k.Cabang.Id + "','" +
             k.tglLahir.ToString("yyyy-MM-dd") + "','" +
             k.Gender + "','" +
             k.Username + "', SHA2('" +
             k.Password + "',512));";

            Koneksi.JalankanPerintahDML(sql);
            //get string sql query


     

        }
        #endregion
    }
}
