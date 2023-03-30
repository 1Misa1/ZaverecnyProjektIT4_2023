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
    public partial class FormAddorEditWorkType : Form
    {
        private int id = -1;

        public FormAddorEditWorkType()
        {
            InitializeComponent();
        }

        public FormAddorEditWorkType(WorkType worktype)
        {
            id = worktype.ID;
            InitializeComponent();
            txtName.Text = worktype.Name;
            txtDescription.Text = worktype.Description;

            btnAdd.Text = "Upravit";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                SqlRepository.AddWorktype(new WorkType(txtName.Text, txtDescription.Text));
            }
            else 
            { 
                SqlRepository.EditWorktype(id,new WorkType(txtName.Text, txtDescription.Text));                           
            }

            Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtDescription.Text != "")
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }
    }
}
