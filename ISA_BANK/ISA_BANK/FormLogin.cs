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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
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
                MessageBox.Show("Input Username first");
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
                MessageBox.Show("Input Password first");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            try
            {
                Koneksi koneksi = new Koneksi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi koneksi = new Koneksi();

                Nasabah n = Nasabah.CekLogin(txtUsername.Text, txtPassword.Text);

                if (n != null)
                {
                    FormMain frm = (FormMain)this.Owner;
                    frm.nasabah = n;

                    MessageBox.Show("Selamat Datang di Bank ISA.", "Login Berhasil");
                    

                    Nasabah nasabah = Nasabah.BacaDataPerNasabah(txtUsername.Text);
                    

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else if (n == null)
                {
                    Karyawan k = Karyawan.CekLogin(txtUsername.Text, txtPassword.Text);
                    if (k != null)
                    {
                        FormMain frm = (FormMain)this.Owner;
                        frm.karyawan = k;
                        MessageBox.Show("Selamat Datang di Bank ISA.", "Login Berhasil");
                        
                        frm.SetHakAkses();

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Username tidak ditemukan atau password salah");
                    }
                }
                else
                {
                    MessageBox.Show("Username tidak ditemukan atau password salah");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal. Pesan Kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FormRegister frm = new FormRegister();
            frm.Owner = this;
            frm.ShowDialog();   
        }
    }
}
