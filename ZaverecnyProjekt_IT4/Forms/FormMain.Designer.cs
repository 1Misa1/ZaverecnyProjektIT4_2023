namespace ZaverecnyProjekt_IT4
{

    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWho = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtSearchEmployee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.lvEmployee = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtSearchContract = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteContract = new System.Windows.Forms.Button();
            this.btnEditContract = new System.Windows.Forms.Button();
            this.btnAddContract = new System.Windows.Forms.Button();
            this.lvContract = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.lblWho);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 78);
            this.panel1.TabIndex = 0;
            // 
            // lblWho
            // 
            this.lblWho.AutoSize = true;
            this.lblWho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblWho.Location = new System.Drawing.Point(91, 9);
            this.lblWho.Name = "lblWho";
            this.lblWho.Size = new System.Drawing.Size(51, 20);
            this.lblWho.TabIndex = 3;
            this.lblWho.Text = "label1";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogOut.Location = new System.Drawing.Point(640, 45);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(94, 27);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Odhlásit se";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label.Location = new System.Drawing.Point(12, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(73, 20);
            this.label.TabIndex = 1;
            this.label.Text = "Uživatel :";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 78);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(741, 346);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtSearchEmployee);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnDeleteEmployee);
            this.tabPage1.Controls.Add(this.btnEditEmployee);
            this.tabPage1.Controls.Add(this.btnAddEmployee);
            this.tabPage1.Controls.Add(this.lvEmployee);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(733, 320);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Zaměstnanci";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtSearchEmployee
            // 
            this.txtSearchEmployee.Location = new System.Drawing.Point(458, 291);
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.Size = new System.Drawing.Size(145, 20);
            this.txtSearchEmployee.TabIndex = 5;
            this.txtSearchEmployee.TextChanged += new System.EventHandler(this.txtHledatEmployee_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vyhledávání :";
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Enabled = false;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(247, 289);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(116, 23);
            this.btnDeleteEmployee.TabIndex = 3;
            this.btnDeleteEmployee.Text = "Smazat zaměstnance";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Enabled = false;
            this.btnEditEmployee.Location = new System.Drawing.Point(124, 289);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(117, 23);
            this.btnEditEmployee.TabIndex = 2;
            this.btnEditEmployee.Text = "Upravit zaměstnance";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(6, 289);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(112, 23);
            this.btnAddEmployee.TabIndex = 1;
            this.btnAddEmployee.Text = "Přidat zaměstnance";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // lvEmployee
            // 
            this.lvEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvEmployee.FullRowSelect = true;
            this.lvEmployee.GridLines = true;
            this.lvEmployee.HideSelection = false;
            this.lvEmployee.Location = new System.Drawing.Point(3, 3);
            this.lvEmployee.Name = "lvEmployee";
            this.lvEmployee.Size = new System.Drawing.Size(727, 283);
            this.lvEmployee.TabIndex = 0;
            this.lvEmployee.UseCompatibleStateImageBehavior = false;
            this.lvEmployee.View = System.Windows.Forms.View.Details;
            this.lvEmployee.SelectedIndexChanged += new System.EventHandler(this.lvEmployee_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 56;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Jméno";
            this.columnHeader2.Width = 91;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Příjmení";
            this.columnHeader3.Width = 84;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Datum narození";
            this.columnHeader4.Width = 122;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Email";
            this.columnHeader5.Width = 134;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Telefonní číslo";
            this.columnHeader6.Width = 140;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtSearchContract);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnDeleteContract);
            this.tabPage2.Controls.Add(this.btnEditContract);
            this.tabPage2.Controls.Add(this.btnAddContract);
            this.tabPage2.Controls.Add(this.lvContract);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(733, 320);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Zakázky";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtSearchContract
            // 
            this.txtSearchContract.Location = new System.Drawing.Point(389, 291);
            this.txtSearchContract.Name = "txtSearchContract";
            this.txtSearchContract.Size = new System.Drawing.Size(145, 20);
            this.txtSearchContract.TabIndex = 10;
            this.txtSearchContract.TextChanged += new System.EventHandler(this.txtSearchContract_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Vyhledávání :";
            // 
            // btnDeleteContract
            // 
            this.btnDeleteContract.Enabled = false;
            this.btnDeleteContract.Location = new System.Drawing.Point(203, 289);
            this.btnDeleteContract.Name = "btnDeleteContract";
            this.btnDeleteContract.Size = new System.Drawing.Size(101, 23);
            this.btnDeleteContract.TabIndex = 8;
            this.btnDeleteContract.Text = "Smazat zakázku";
            this.btnDeleteContract.UseVisualStyleBackColor = true;
            this.btnDeleteContract.Click += new System.EventHandler(this.btnDeleteContract_Click);
            // 
            // btnEditContract
            // 
            this.btnEditContract.Enabled = false;
            this.btnEditContract.Location = new System.Drawing.Point(105, 289);
            this.btnEditContract.Name = "btnEditContract";
            this.btnEditContract.Size = new System.Drawing.Size(92, 23);
            this.btnEditContract.TabIndex = 7;
            this.btnEditContract.Text = "Upravit zakázku";
            this.btnEditContract.UseVisualStyleBackColor = true;
            this.btnEditContract.Click += new System.EventHandler(this.btnEditContract_Click);
            // 
            // btnAddContract
            // 
            this.btnAddContract.Location = new System.Drawing.Point(5, 289);
            this.btnAddContract.Name = "btnAddContract";
            this.btnAddContract.Size = new System.Drawing.Size(94, 23);
            this.btnAddContract.TabIndex = 6;
            this.btnAddContract.Text = "Přidat zakázku";
            this.btnAddContract.UseVisualStyleBackColor = true;
            this.btnAddContract.Click += new System.EventHandler(this.btnAddContract_Click);
            // 
            // lvContract
            // 
            this.lvContract.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvContract.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvContract.FullRowSelect = true;
            this.lvContract.GridLines = true;
            this.lvContract.HideSelection = false;
            this.lvContract.Location = new System.Drawing.Point(3, 3);
            this.lvContract.Name = "lvContract";
            this.lvContract.Size = new System.Drawing.Size(727, 283);
            this.lvContract.TabIndex = 0;
            this.lvContract.UseCompatibleStateImageBehavior = false;
            this.lvContract.View = System.Windows.Forms.View.Details;
            this.lvContract.SelectedIndexChanged += new System.EventHandler(this.lvContract_SelectedIndexChanged);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Zákazník";
            this.columnHeader8.Width = 110;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Popis";
            this.columnHeader9.Width = 93;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Id";
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(741, 424);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Systém zakázek";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView lvEmployee;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lvContract;
        private System.Windows.Forms.Label lblWho;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox txtSearchEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.TextBox txtSearchContract;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteContract;
        private System.Windows.Forms.Button btnEditContract;
        private System.Windows.Forms.Button btnAddContract;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}