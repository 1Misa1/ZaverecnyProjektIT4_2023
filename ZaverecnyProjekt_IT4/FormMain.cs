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

        public void Show(Form parentForm)
        {

        }


        private void btnLogOut_Click(object sender, EventArgs e)
        {


        }

        // Kdo se přihlásil ? 

        private void FormMain_Load(object sender, EventArgs e)
        {

        }



        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Close();
        }
    }
}
