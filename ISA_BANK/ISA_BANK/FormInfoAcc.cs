using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISA_BANK.DB_CLASS;

namespace ISA_BANK
{
    public partial class FormInfoAcc : Form
    {
        public FormInfoAcc()
        {
            InitializeComponent();
        }

        public Nasabah CurrentNasabah;
        Rekening curbal;

        private void FormInfoAcc_Load(object sender, EventArgs e)
        {
            
            labelCustName.Text = CurrentNasabah.Nama;
            labelNik.Text = AES.Decrypt(CurrentNasabah.Nik);
            dateTimePickerBirth.Value = CurrentNasabah.Ttl;
            lblgender.Text = CurrentNasabah.Gender;
            lblnum.Text = CurrentNasabah.No_telepon;
            curbal = Rekening.BacaId("nasabahs_id", CurrentNasabah.Id.ToString());
            lblCurBalance.Text = curbal.Jumlah_saldo.ToString();
        }

    }
}
