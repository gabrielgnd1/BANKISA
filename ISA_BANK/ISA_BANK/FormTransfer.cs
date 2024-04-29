using ISA_BANK.DB_CLASS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISA_BANK
{
    public partial class FormTransfer : Form
    {
        public FormTransfer()
        {
            InitializeComponent();
        }

        List<Nasabah> listNasabah = new List<Nasabah>();
        List<Rekening> listRekening = new List<Rekening>();

        private void FormTransfer_Load(object sender, EventArgs e)
        {
            FormMain frm = (FormMain)this.Owner;
            //lblRekNum1.Text = 

        }
    }
}
