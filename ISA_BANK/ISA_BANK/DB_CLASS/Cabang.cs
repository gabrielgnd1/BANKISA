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

        public Cabang()
        {
            Id = 0;
            Nama = "";
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
    }
}
