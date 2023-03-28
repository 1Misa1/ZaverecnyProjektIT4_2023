using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZaverecnyProjekt_IT4
{
    public partial class FormMain : Form
    {

        private Form parentForm;
        public User User { get; set; }
        private readonly SqlRepository sqlRepo;

        private int loggedInUserId;
        private int closeCounter = 0;
        bool isLoggingOut;

        public void Show(Form parentForm)
        {
            this.parentForm = parentForm;
            Show();
        }



        public FormMain(User user)
        {
            User = user;
            InitializeComponent();
            sqlRepo = new SqlRepository();

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            isLoggingOut = true;

            DialogResult result = MessageBox.Show("Opravdu ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
            }

        }

        // Kdo se přihlásil ? 

        private void FormMain_Load(object sender, EventArgs e)
        {
            var sqlRepo = new SqlRepository();
            var usersWithRoles = sqlRepo.GetUserWithRole();

            // Nastavení textu labelu
            label.Text = $"Role: {usersWithRoles[0].Item3} Jméno: {usersWithRoles[0].Item1} {usersWithRoles[0].Item2}";
        }
    


            private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // pokud se uživatel odhlašuje, neprovádět tuto akci
            if (!isLoggingOut)
            {
                if (closeCounter == 0)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        closeCounter++;
                        Application.Exit();
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
                else
                {
                    // vypnutí aplikace, pokud uživatel potvrdil zavření
                    Application.Exit();
                }
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Close();
        }
    }
}
