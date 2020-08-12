using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBAManagementSystem.Forms.UserForms
{
    public partial class frmLogin : Form
    {
        private frmMainForm MainForm;

        public frmLogin()
        {
            InitializeComponent();
        }

        public frmLogin(frmMainForm frmMainForm)
        {
            InitializeComponent();
            this.MainForm = frmMainForm;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            ep.Clear();
            if(txtUserName.Text.Trim().Length == 0)
            {
                ep.SetError(txtUserName, "please enter the user name !");
                txtUserName.Focus();
                return;

            }
            if (txtPassword.Text.Trim().Length == 0)
            {
                ep.SetError(txtPassword, "please enter the Password !");
                txtPassword.Focus();
                return;

            }
            String getQuery = "select UserID,UserType_ID,FullName,Email,ContactNo,UserName from UsersTable where UserName = '" + txtUserName.Text.Trim()+ "'and Password = '" +txtPassword.Text.Trim()+ "'";
            DataTable dt = DatabaseAccess.Retrive(getQuery);
         
            if (dt == null)
            {
                lblError.Visible = true;
                Console.WriteLine("this line is working");
                MainForm.tsbLogin.Visible = true;
                MainForm.tsbLogout.Visible = false;
                MainForm.msAll.Enabled = false;
                return;

            }
            else if (dt.Rows.Count > 0)
            {
           


                MainForm.tsbLogin.Visible = false;
                MainForm.tsbLogout.Visible = true;
                MainForm.msAll.Enabled = true;
                CurrentUser.UserID = Convert.ToInt16(dt.Rows[0]["UserID"]);
                CurrentUser.UserType_ID = Convert.ToInt16(dt.Rows[0]["UserType_ID"]);
                CurrentUser.FullName = Convert.ToString(dt.Rows[0]["FullName"]);
                CurrentUser.Email = Convert.ToString(dt.Rows[0]["Email"]);
                CurrentUser.ContactNo = Convert.ToString(dt.Rows[0]["ContactNo"]);
                CurrentUser.UserName = Convert.ToString(dt.Rows[0]["UserName"]);
                this.Close();
                return;
            }
            else
            {
                lblError.Visible = false;
            }

        }
    }
}
