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
    }
}
