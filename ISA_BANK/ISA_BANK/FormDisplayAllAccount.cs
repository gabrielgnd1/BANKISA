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
    public partial class FormDisplayAllAccount : Form
    {
        public FormDisplayAllAccount()
        {
            InitializeComponent();
        }

        private void FormDisplayAllAccount_Load(object sender, EventArgs e)
        {
            List<Nasabah> ListData = Nasabah.BacaData("", "");
            dataGridView1.DataSource = ListData;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string kriteria;
            string nilai;
            if (cbSearchBy.SelectedIndex == 0)
            {
                kriteria = "nama";
                nilai = textBox1.Text;
            }

            else
            {
                kriteria = "nik";
                nilai = AES.Encrypt(textBox1.Text);
            }
                
            
            //string nilai = textBox1.Text;

            List<Nasabah> ListData = Nasabah.BacaData(kriteria, nilai);
            dataGridView1.DataSource = ListData;
        }
    }
}
