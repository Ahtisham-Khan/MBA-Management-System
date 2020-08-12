using MBAManagementSystem.Forms.UserForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBAManagementSystem
{
    public partial class frmMainForm : Form
    {
        frmUserTypes UserTypesForm;
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void purchasingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addUserTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserTypesForm == null)
            {
                UserTypesForm = new frmUserTypes();
            }
            UserTypesForm.ShowDialog();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUsers frm = new frmAddUsers();
            frm.ShowDialog();
        }

        private void tsbLogin_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin(this);
            frm.ShowDialog();

        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
            tsbLogin.Visible = true;
            tsbLogout.Visible = false;
            msAll.Enabled = false;
        }

        private void tsbLogout_ButtonClick(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateUser frm = new frmUpdateUser();
            frm.ShowDialog();

        }
    }
}
