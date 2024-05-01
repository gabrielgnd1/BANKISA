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
using System.Globalization;

namespace ISA_BANK
{
    public partial class FormWithdrawal : Form
    {
        public FormWithdrawal()
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

            if (rekening != null )
            {
                custName.Text = rekening.Nasabah.Nama;
                nikNum.Text =AES.Decrypt(rekening.Nasabah.Nik);
                curBalance.Text = rekening.Jumlah_saldo.ToString("C", culture);
            }
            else
            {
                MessageBox.Show("No Nasabah tidak ditemukan");
            }
        }


        private void btnWithDrawal_Click(object sender, EventArgs e)
        {
            string accNum = txtAccNum.Text;
            int withdrawalAmount;

            if (int.TryParse(txtWithAmount.Text, out withdrawalAmount))
            {
                Rekening rekening = Rekening.BacaId("nomor", accNum);


                if (rekening != null)
                {
                    if (rekening.Jumlah_saldo >= withdrawalAmount)
                    {
                        rekening.Jumlah_saldo -= withdrawalAmount;
                        Rekening.WithdrawalData(rekening, withdrawalAmount);
                        curBalance.Text = rekening.Jumlah_saldo.ToString("C", culture);
                        MessageBox.Show("Penarikan berhasil.");
                    }
                    else
                    {
                        MessageBox.Show("Saldo tidak mencukupi untuk melakukan penarikan.");
                    }
                }
                else
                {
                    MessageBox.Show("No Nasabah tidak ditemukan.");
                }
            }
            else
            {
                MessageBox.Show("Masukkan jumlah penarikan yang valid.");
            }
        }

        
    }
}