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

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public Cabang Cabang { get => cabang; set => cabang = value; }
        public Akun Akun { get => akun; set => akun = value; }
    }
}
