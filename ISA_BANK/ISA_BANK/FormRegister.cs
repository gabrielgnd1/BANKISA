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
                txtFullname.ForeColor = Color.Silver;
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
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Input Your Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Silver;
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
                txtPassword.ForeColor = Color.Silver;
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

        private void txtCardNum_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Input Your Card Number")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Silver;
            }
        }

        private void txtCardNum_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Input Your Card Number";
                txtPassword.ForeColor = Color.Silver;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            try
            {
                string gender;
                if (rdoMale.Checked)
                {
                    gender = "L";
                }
                else
                {
                    gender = "P";
                }
                Nasabah n = new Nasabah();
                n.Nama = txtFullname.Text;
                n.No_telepon = textBoxNoTelp.Text;
                n.Gender = gender;
                n.Ttl = ttlPicker.Value;
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
    }
}


