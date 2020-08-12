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
    public partial class frmUpdateUser : Form
    {
        public frmUpdateUser()
        {
            InitializeComponent();
            if(CurrentUser.UserID >0 )
            {
                cmbSelectUserType.SelectedValue = CurrentUser.UserType_ID;
                txtFullName.Text = CurrentUser.FullName;
                txtContactNo.Text = CurrentUser.ContactNo;
                txtEmail.Text = CurrentUser.Email;
                txtUsername.Text = CurrentUser.UserName;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmUpdateUser_Load(object sender, EventArgs e)
        {
            ComboHelper.FillUserTypes(cmbSelectUserType);
            cmbSelectUserType.Focus();
            
            if (CurrentUser.UserID > 0)
            {
                cmbSelectUserType.SelectedValue = CurrentUser.UserType_ID;
                txtFullName.Text = CurrentUser.FullName;
                txtContactNo.Text = CurrentUser.ContactNo;
                txtEmail.Text = CurrentUser.Email;
                txtUsername.Text = CurrentUser.UserName;

            }
        }

        private void btnAddUserTypes_Click(object sender, EventArgs e)
        {
            frmUserTypes frm = new frmUserTypes();
            frm.ShowDialog();
            btnRefresh_Click(sender, e);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ComboHelper.FillUserTypes(cmbSelectUserType);


        }
        //program to clear all the text boxes that are filled 
        private void ClearForm()
        {
            
            txtFullName.Clear();
            txtContactNo.Clear();
            txtEmail.Clear();
            txtUsername.Clear();
            txtOldPassword.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (cmbSelectUserType.SelectedIndex == 0)
            {
                ep.SetError(cmbSelectUserType, "please select user type !");
                cmbSelectUserType.Focus();
                return;
            }
            if (txtFullName.Text.Trim().Length == 0)
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
            if (txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                ep.SetError(txtConfirmPassword, "No matched b/w the password and re-entered password found  !");
                txtConfirmPassword.Focus();
                return;
            }
            // ye basically ye check kr raha hai ke database koi is is username wala aur dori id wala to nhi hai mtlb ke koi aesa bnda jiska naam yeh ho aur id koi aur ho to ye show kra do ke user already exist
            DataTable dt = DatabaseAccess.Retrive("select * from UsersTable where UserName = '" + txtUsername + "' and UserID != '" + CurrentUser.UserID +"'"); //here it is not changing user name and changing other things thats why we are using userid!= currentuser.userid.
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txtUsername, "User Name Already Exist !");
                    txtUsername.Focus();
                    return;

                }

            }
            dt = null;
            dt = DatabaseAccess.Retrive("select * from UsersTable where FullName = '" + txtFullName.Text.Trim() + "' and ContactNo = '" + txtContactNo.Text.Trim() + "' and UserID != '"+CurrentUser.UserID +"'" );
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txtFullName, "User  Already Exist !");
                    txtFullName.Focus();
                    return;

                }
            }

            String updatequery = string.Format("update  UsersTabl set UserType_ID = '{0}',FullName = '{1}',Email = '{2}',ContactNo = '{3}',UserName = '{4}',Password = '{5}' where UserID = '" +CurrentUser.UserID +"' ",
                cmbSelectUserType.SelectedValue, txtFullName.Text.Trim(), txtEmail.Text.Trim(), txtContactNo.Text.Trim(), txtUsername.Text.Trim(), txtPassword.Text.Trim());
            bool result = DatabaseAccess.Update(updatequery );
            if (result)
            {
                MessageBox.Show("User Updated Successfully ");
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
