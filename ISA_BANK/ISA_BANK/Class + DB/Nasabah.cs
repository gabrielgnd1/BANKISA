using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISA_BANK.Class___DB
{
    internal class Nasabah
    {
        #region datamember
        private string id;
        private string nama;
        private DateTime ttl;
        private string nik;
        private string no_telepon;
        #endregion

        #region constructor
        public Nasabah(string id, string nama, DateTime ttl, string nik, string no_telepon)
        {
            this.Id = id;
            this.Nama = nama;
            this.Ttl = ttl;
            this.Nik = nik;
            this.No_telepon = no_telepon;
        }
        #endregion

        //test
        #region properties
        public string Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public DateTime Ttl { get => ttl; set => ttl = value; }
        public string Nik { get => nik; set => nik = value; }
        public string No_telepon { get => no_telepon; set => no_telepon = value; }
        #endregion

        #region method



        #endregion
    }
}
