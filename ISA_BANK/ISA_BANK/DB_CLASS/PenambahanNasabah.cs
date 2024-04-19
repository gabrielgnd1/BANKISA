using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISA_BANK.DB_CLASS
{
    public class PenambahanNasabah
    {
        private CS cs;
        private Rekening rekening;
        private DateTime createdAt;
        private DateTime updatedAt;

        public PenambahanNasabah(CS cs, Rekening rekening, DateTime createdAt, DateTime updatedAt)
        {
            this.Cs = cs;
            this.Rekening = rekening;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        public CS Cs { get => cs; set => cs = value; }
        public Rekening Rekening { get => rekening; set => rekening = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
        public DateTime UpdatedAt { get => updatedAt; set => updatedAt = value; }
    }
}
