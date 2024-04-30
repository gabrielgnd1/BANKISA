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
    public partial class FormMain : Form
    {
        public Nasabah nasabah;
        public Karyawan karyawan;
        //public Nasabah n;

        public FormMain()
        {
            InitializeComponent();
        }

        private void createNewAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            FormCreateNewBankAccount newAcc = new FormCreateNewBankAccount();
            newAcc.TopLevel = false;
            panelMain.Controls.Add(newAcc);
            newAcc.BringToFront();
            newAcc.Show();
        }

        private void updateAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            FormUpdateAccount updateAcc = new FormUpdateAccount();
            updateAcc.TopLevel = false;
            panelMain.Controls.Add(updateAcc);
            updateAcc.BringToFront();
            updateAcc.Show();
        }

        private void DisplayAllAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            FormDisplayAllAccount displayAcc = new FormDisplayAllAccount();
            displayAcc.TopLevel = false;
            panelMain.Controls.Add(displayAcc);
            displayAcc.BringToFront();
            displayAcc.Show();
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            FormDeposit deposit = new FormDeposit();
            deposit.TopLevel = false;
            panelMain.Controls.Add(deposit);
            deposit.BringToFront();
            deposit.Show();
        }

        private void withdrawalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            FormWithdrawal withdrawal = new FormWithdrawal();
            withdrawal.TopLevel = false;
            panelMain.Controls.Add(withdrawal);
            withdrawal.BringToFront();
            withdrawal.Show();
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            FormTransfer transfer = new FormTransfer();
            transfer.TopLevel = false;
            panelMain.Controls.Add(transfer);
            transfer.BringToFront();
            transfer.Show();
        }

        private void transactionHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            FormTransactionHistory history = new FormTransactionHistory();
            history.TopLevel = false;
            panelMain.Controls.Add(history);
            history.BringToFront();
            history.Show();
        }

        private void displayAccToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            FormDisplayAllAccount displayAcc = new FormDisplayAllAccount();
            displayAcc.TopLevel = false;
            panelMain.Controls.Add(displayAcc);
            displayAcc.BringToFront();
            displayAcc.Show();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            //this.IsMdiContainer = true;
            try
            {
                Koneksi koneksi = new Koneksi();

                FormLogin frmLogin = new FormLogin();
                frmLogin.Owner = this;
                this.Visible = false;
                frmLogin.ShowDialog();

                if (frmLogin.DialogResult == DialogResult.OK)
                {
                    this.Visible = true;
                    if (nasabah != null)
                    {
                        MessageBox.Show("Selamat datang " + nasabah.Nama);
                    }
                    else if (karyawan != null)
                    {
                        MessageBox.Show("Selamat datang " + karyawan.Nama + " sebagai " + karyawan.Roles);
                    }
                }
                else
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi Gagal.Pesan Kesalahan : " + ex.Message);
            }
        }

        public void SetHakAkses()
        {
            if (nasabah != null)
            {
                nasabahToolStripMenuItem.Visible = true;
                //transferToolStripMenuItem.Visible = true;
                //transactionHistoryToolStripMenuItem.Visible = true;
                managerToolStripMenuItem.Visible = false;
                tellerToolStripMenuItem.Visible = false;
                customerServiceToolStripMenuItem.Visible = false;
            }
            else if (karyawan != null)
            {
                if (karyawan.Roles == "Manajer")
                {
                    //displayAccToolStripMenuItem.Visible = true;
                    managerToolStripMenuItem.Visible = true;
                    nasabahToolStripMenuItem.Visible = false;
                    tellerToolStripMenuItem.Visible = false;
                    customerServiceToolStripMenuItem.Visible = false;
                }
                else if (karyawan.Roles == "Teller")
                {
                    //withdrawalToolStripMenuItem.Visible = true;
                    //depositToolStripMenuItem.Visible = true;
                    managerToolStripMenuItem.Visible = false;
                    nasabahToolStripMenuItem.Visible = false;
                    tellerToolStripMenuItem.Visible = true;
                    customerServiceToolStripMenuItem.Visible = false;
                }
                else if (karyawan.Roles == "CS")
                {
                    //createNewAccountToolStripMenuItem.Visible = true;
                    //updateAccountToolStripMenuItem.Visible = true;
                    //DisplayAccountToolStripMenuItem.Visible = false;
                    managerToolStripMenuItem.Visible = false;
                    nasabahToolStripMenuItem.Visible = false;
                    tellerToolStripMenuItem.Visible = false;
                    customerServiceToolStripMenuItem.Visible = true;
                }
            }
        }

        private void infoAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            FormInfoAcc infoacc = new FormInfoAcc();
            infoacc.TopLevel = false;
            panelMain.Controls.Add(infoacc);
            infoacc.BringToFront();
            infoacc.Show();
        }

        private void addKaryawanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            FormAddKaryawan addkar = new FormAddKaryawan();
            addkar.TopLevel = false;
            panelMain.Controls.Add(addkar);
            addkar.BringToFront();
            addkar.Show();
        }
    }

}
