using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZaverecnyProjekt_IT4
{
    public partial class FormLogin : Form
    {

        public User LoggedUser { get; private set; }

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnStorno_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = SqlRepository.CheckLogin(txtUsername.Text, txtPassword.Text);
            if (user == null)
            {
                MessageBox.Show("Špatné přihlašovací údaje");
            }
            else
            {
                LoggedUser = user;
                Close();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = txtUsername.Text != string.Empty && txtPassword.Text != string.Empty;
        }
    }
}
