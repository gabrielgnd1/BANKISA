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

        public FormMain()
        {
            InitializeComponent();
        }

        private void createNewAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateNewBankAccount newAcc = new FormCreateNewBankAccount();
            newAcc.TopLevel = false;
            panelMain.Controls.Add(newAcc);
            newAcc.BringToFront();
            newAcc.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void updateAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUpdateAccount updateAcc = new FormUpdateAccount();
            updateAcc.TopLevel = false;
            panelMain.Controls.Add(updateAcc);
            updateAcc.BringToFront();
            updateAcc.Show();
        }

        private void DisplayAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDisplayAllAccount displayAcc = new FormDisplayAllAccount();
            displayAcc.TopLevel = false;
            panelMain.Controls.Add(displayAcc);
            displayAcc.BringToFront();
            displayAcc.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        public void SetHakAkses()
        {
            if (nasabah != null)
            {
                transferToolStripMenuItem.Visible = true;
                transactionHistoryToolStripMenuItem.Visible = true;
            }
            else if (karyawan != null)
            {
                if (karyawan.Roles == "Manajer")
                {
                    displayAccToolStripMenuItem.Visible = true;

                }
                else if (karyawan.Roles == "Teller")
                {
                    withdrawalToolStripMenuItem.Visible = true;
                    depositToolStripMenuItem.Visible = true;
 
                }
                else if (karyawan.Roles == "CS")
                {
                    createNewAccountToolStripMenuItem.Visible = true;
                    updateAccountToolStripMenuItem.Visible = true;
                    DisplayAccountToolStripMenuItem.Visible = false;

                }

            }
        }
    }
}
