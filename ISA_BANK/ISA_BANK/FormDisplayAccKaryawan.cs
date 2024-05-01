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
    public partial class FormDisplayAccKaryawan : Form
    {
        public FormDisplayAccKaryawan()
        {
            InitializeComponent();
        }

        private void FormDisplayAccKaryawan_Load(object sender, EventArgs e)
        {
            List<Karyawan> ListData = Karyawan.BacaData("", "");
            dataGridView1.DataSource = ListData;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string kriteria;
            if (cbSearchBy.SelectedIndex == 0)
            {
                kriteria = "nama";
            }

            else
            {
                kriteria = "roles";
            }


            string nilai = textBox1.Text;

            List<Karyawan> ListData = Karyawan.BacaData(kriteria, nilai);
            dataGridView1.DataSource = ListData;
        }
    }
}
