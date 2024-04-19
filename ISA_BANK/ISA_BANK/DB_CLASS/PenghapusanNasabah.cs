using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISA_BANK.DB_CLASS
{
    public class PenghapusanNasabah
    {
        private Manajer manajer;
        private Rekening rekening;
        private DateTime deletedAt;

        public PenghapusanNasabah(Manajer manajer, Rekening rekening, DateTime deletedAt)
        {
            this.Manajer = manajer;
            this.Rekening = rekening;
            this.DeletedAt = deletedAt;
        }

        public Manajer Manajer { get => manajer; set => manajer = value; }
        public Rekening Rekening { get => rekening; set => rekening = value; }
        public DateTime DeletedAt { get => deletedAt; set => deletedAt = value; }
    }
}
