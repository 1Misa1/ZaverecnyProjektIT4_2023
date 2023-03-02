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
        SqlRepository sqlRepository;

        public FormLogin()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
            sqlRepository.ConvertUsersFromPasswordToPasswordHash();
        }

        private void btnStorno_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = sqlRepository.GetUser(txtUsername.Text.Trim());
            if (user != null)
            {
                if (user.VerifyPassword(txtPassword.Text))
                {
                    new FormMain(user).Show(this);
                    Hide();
                }
                else
                {
                    MessageBox.Show("Uživatelské jméno nebo heslo je špatně.");
                }
            }
            else
            {
                MessageBox.Show("Uživatelské jméno nebo heslo je špatně.");
            }
        }

    

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
