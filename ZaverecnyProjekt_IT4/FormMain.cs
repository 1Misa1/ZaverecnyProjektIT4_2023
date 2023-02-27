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
    public partial class FormMain : Form
    {

        private Form parentForm;
        public User User { get; set; }

        public void Show(Form parentForm)
        {
            this.parentForm = parentForm;
            Show();
        }

        public FormMain(User user)
        {
            User = user;
            InitializeComponent();
            lblUser.Text = User.Username;
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (parentForm != null)
            {
                parentForm.Close();
            }
        }

        
    }
}
