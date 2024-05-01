using ISA_BANK.DB_CLASS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISA_BANK.Security;


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
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Input Your Password";
                txtPassword.ForeColor = Color.Silver;
                txtPassword.PasswordChar = '\0';
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
                //string gender;
                string enPw = AES.Encrypt(txtPassword.Text);
                string enNIK = AES.Encrypt(txtNIK.Text);
                  
                if (rdoMale.Checked)
                {
                    n.Gender = "Pria";
                }
                else if(rdoFemale.Checked)
                {
                    n.Gender = "Wanita";
                }
                else
                {
                    MessageBox.Show("Pilih Jenis Kelamin", "Peringatan");
                }
                //Nasabah n = new Nasabah();
                n.Nama = txtFullname.Text;
                n.Ttl = ttlPicker.Value;
                n.Nik = enNIK;
                n.No_telepon = txtNoTelp.Text;
                n.Username = txtUsername.Text;
                n.Password = enPw;
                

                Nasabah.TambahData(n);
                MessageBox.Show("Data Telah Tersimpan.", "Informasi");
                this.Close();
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


