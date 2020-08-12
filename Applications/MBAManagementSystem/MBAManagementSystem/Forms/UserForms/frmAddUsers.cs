using MBAManagementSystem.SourceCode;
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
    public partial class frmAddUsers : Form
    {
        public frmAddUsers()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            txtFullName.Focus();

        }

        private void frmAddUsers_Load(object sender, EventArgs e)
        {
            ComboHelper.FillUserTypes(cmbSelectUserType);
            cmbSelectUserType.Focus();
            return;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           frmUserTypes frm = new frmUserTypes();
            frm.ShowDialog();
            button3_Click(sender, e); 


        }

        private void button3_Click(object sender, EventArgs e)
        {
            ComboHelper.FillUserTypes(cmbSelectUserType);

        }

        private void cmbSelectUserType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ClearForm()
        {
            cmbSelectUserType.SelectedIndex = 0;
            txtFullName.Clear();
            txtContactNo.Clear();
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if(cmbSelectUserType.SelectedIndex == 0)
            {
                ep.SetError(cmbSelectUserType, "please select user type !");
                cmbSelectUserType.Focus();
                return;
            }
            if(txtFullName.Text.Trim().Length ==0)
            {
                ep.SetError(txtFullName, "please enter full name !");
                txtFullName.Focus();
                return;
            }
            if (txtContactNo.Text.Trim().Length == 0)
            {
                ep.SetError(txtContactNo, "please enter Contact Number !");
                txtContactNo.Focus();
                return;
            }
            if (txtEmail.Text.Trim().Length == 0)
            {
                ep.SetError(txtEmail, "please enter full name !");
                txtEmail.Focus();
                return;
            }
            if (txtUsername.Text.Trim().Length == 0)
            {
                ep.SetError(txtUsername, "please enter the user name !");
                txtUsername.Focus();
                return;
            }
            if (txtPassword.Text.Trim().Length == 0)
            {
                ep.SetError(txtPassword, "please enter the password!");
                txtPassword.Focus();
                return;
            }
            if (txtConfirmPassword.Text.Trim().Length == 0)
            {
                ep.SetError(txtConfirmPassword, "please re-enter the password  !");
                txtConfirmPassword.Focus();
                return;
            }
            if(txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                ep.SetError(txtConfirmPassword, "No matched b/w the password and re-entered password found  !");
                txtConfirmPassword.Focus();
                return;
            }
            DataTable dt  = DatabaseAccess.Retrive("select * from UsersTable where UserName = '" + txtUsername + "'");
            if (dt != null)
            {
                if(dt.Rows.Count > 0)
                {
                    ep.SetError(txtUsername, "User Name Already Exist !");
                    txtUsername.Focus();
                    return;

                }
                
            }
            dt = null;
            dt = DatabaseAccess.Retrive("select * from UsersTable where FullName = '" + txtFullName.Text.Trim() + "' and ContactNo = '"+txtContactNo.Text.Trim()+"'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txtFullName, "User  Already Registered !");
                    txtFullName.Focus();
                    return;

                }
            }

            String insertquery = string.Format("insert into UsersTable(UserType_ID,FullName,Email,ContactNo,UserName,Password) values ('{0}','{1}','{2}','{3}','{4}','{5}')",
                cmbSelectUserType.SelectedValue,txtFullName.Text.Trim(),txtEmail.Text.Trim(),txtContactNo.Text.Trim(),txtUsername.Text.Trim(),txtPassword.Text.Trim());
            bool result = DatabaseAccess.Insert(insertquery);
            if(result)
            {
                MessageBox.Show("User Registered Successfully ");
                this.Close();
                 
            }
            else
            {
                MessageBox.Show("Un expected error has occured ! Please contact concern person ...");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
