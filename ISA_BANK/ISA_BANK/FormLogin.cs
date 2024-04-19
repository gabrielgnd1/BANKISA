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
            }
            else
            {
                MessageBox.Show("Username can't be empty");
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
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show (txtUsername.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            //{
            //    errorProviderUsername.SetError(txtUsername, "Username is required");
            //    return;
            //}
            //else if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            //{
            //    errorProviderPassword.SetError(txtPassword, "Password is required");
            //    return;
            //}
            //else
            //{
            //    errorProviderUsername.SetError(txtUsername, string.Empty);
            //    errorProviderPassword.SetError(txtPassword, string.Empty);
            //}
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProviderUsername.SetError(txtUsername, "Username is required");
            }
            else
            {
                e.Cancel = true;
                errorProviderUsername.SetError(txtUsername, null);
            }

        }
    }
}
