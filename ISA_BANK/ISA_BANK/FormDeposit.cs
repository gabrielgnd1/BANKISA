using ISA_BANK.DB_CLASS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISA_BANK
{
    public partial class FormDeposit : Form
    {
        public FormDeposit()
        {
            InitializeComponent();
        }

        CultureInfo culture = new CultureInfo("id-ID");

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string accNum = txtAccNum.Text;
            //string nik = txtNik.Text;

            //Nasabah nasabah = Nasabah.BacaId("Nik", nik);
            Rekening rekening = Rekening.BacaId("nomor", accNum);

            if (rekening != null)
            {
                custName.Text = rekening.Nasabah.Nama;
                nikNum.Text = AES.Decrypt(rekening.Nasabah.Nik);
                curBalance.Text = rekening.Jumlah_saldo.ToString("C", culture);
            }
            else
            {
                MessageBox.Show("No Nasabah tidak ditemukan");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string accNum = txtAccNum.Text;
            int depositAmount;

            if (int.TryParse(txtDeposit.Text, out depositAmount))
            {
                Rekening rekening = Rekening.BacaId("nomor", accNum);


                if (rekening != null)
                {
                        rekening.Jumlah_saldo += depositAmount;
                        Rekening.DepositData(rekening, depositAmount);
                        curBalance.Text = rekening.Jumlah_saldo.ToString("C", culture);
                        MessageBox.Show("Deposit berhasil.");
                   
        
                }
                else
                {
                    MessageBox.Show("No Nasabah tidak ditemukan.");
                }
            }
            else
            {
                MessageBox.Show("Masukkan jumlah Deposit yang valid.");
            }
        }
    }
}
