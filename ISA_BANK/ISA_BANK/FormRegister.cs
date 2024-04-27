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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void txtFullname_Enter(object sender, EventArgs e)
        {
            if (txtFullname.Text == "Input Your Fullname")
            {
                txtFullname.Text = "";
                txtFullname.ForeColor = Color.Black;
            }
        }

        private void txtFullname_Leave(object sender, EventArgs e)
        {
            if (txtFullname.Text == "")
            {
                txtFullname.Text = "Input Your Fullname";
                txtFullname.ForeColor = Color.Silver;
            }
        }

        private void txtNIK_Enter(object sender, EventArgs e)
        {
            if (txtNIK.Text == "Input Your NIK")
            {
                txtNIK.Text = "";
                txtNIK.ForeColor = Color.Black;
            }
        }
        private void txtNIK_Leave(object sender, EventArgs e)
        {
            if (txtNIK.Text == "")
            {
                txtNIK.Text = "Input Your NIK";
                txtNIK.ForeColor = Color.Silver;
            }
        }
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Input Your Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Input Your Username";
                txtUsername.ForeColor = Color.Silver;
            }
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Input Your Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Input Your Password";
                txtPassword.ForeColor = Color.Silver;
            }
        }

        private void txtNoTelp_Enter(object sender, EventArgs e)
        {
            if (txtNoTelp.Text == "Input Your Phone Number")
            {
                txtNoTelp.Text = "";
                txtNoTelp.ForeColor = Color.Black;
            }
        }

        private void txtNoTelp_Leave(object sender, EventArgs e)
        {
            if (txtNoTelp.Text == "")
            {
                txtNoTelp.Text = "Input Your Phone Number";
                txtNoTelp.ForeColor = Color.Silver;
            }
        }
        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            Nasabah n = new Nasabah();
            try
            {


                if (rdoMale.Checked)
                {
                    n.Gender = rdoMale.Text;
                }
                else
                {
                    n.Gender = rdoFemale.Text;
                }
                //Nasabah n = new Nasabah();
                n.Nama = txtFullname.Text;
                n.Ttl = ttlPicker.Value;
                n.Nik = txtNIK.Text;
                n.No_telepon = txtNoTelp.Text;
                n.Username = txtUsername.Text;
                n.Password = txtPassword.Text;

                Nasabah.TambahData(n);
                MessageBox.Show("Data Telah Tersimpan.", "Informasi");
            }


            catch (Exception x)
            {
                MessageBox.Show("Gagal Register : " + x.Message);
            }
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        
    }
}


