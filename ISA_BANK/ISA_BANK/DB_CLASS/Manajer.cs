using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISA_BANK.DB_CLASS
{
    public class Manajer
    {
        private int id;
        private string nama;
        private Cabang cabang;
        private Akun akun;

        public Manajer(int id, string nama, Cabang cabang, Akun akun)
        {
            this.Id = id;
            this.Nama = nama;
            this.Cabang = cabang;
            this.Akun = akun;
        }

        public Manajer()
        {
            Id = 0;
            Nama = "";
            Cabang = new Cabang(id, nama);
            Akun = new Akun();

        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public Cabang Cabang { get => cabang; set => cabang = value; }
        public Akun Akun { get => akun; set => akun = value; }

        public static Manajer CekLogin(string uid, string pwd)
        {
            Manajer m = new Manajer();

            string perintah = "SELECT id, nama, cabangs_id, akuns_id FROM manajers";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(perintah); //eksekusi perintah diatas

            // selama masih ada data yang dibaca di data reader
            if (hasil.Read() == true)
            {
                Manajer tampung = new Manajer(); //tampung ke sebuah kategori
                tampung.Id = int.Parse(hasil.GetValue(0).ToString());
                tampung.Nama = hasil.GetValue(1).ToString();

                Cabang c = new Cabang();
                c.Id = int.Parse(hasil.GetValue(2).ToString());
                c.Nama = hasil.GetValue(3).ToString();
                tampung.Cabang = c;

                Akun a = new Akun();
                a.Id = int.Parse(hasil.GetValue(4).ToString());
                a.Username = hasil.GetValue(5).ToString();
                a.Password = hasil.GetValue(6).ToString();

                tampung.Akun = a;
                return tampung;
            }

            else return null;
        }
    }
}
