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
    public partial class frmUserTypes : Form
    {
        public frmUserTypes()
        {
            InitializeComponent();
        }
        //fill grid method to retrive data from database and to search value in the box 
        private void FillGrid(string searchvalue)
        {
            string query = string.Empty;
            //query and technique to search box and search the value in the grid
            if(String.IsNullOrEmpty(searchvalue) && String.IsNullOrWhiteSpace(searchvalue))
            {
                 query = "select UserTypeID [ID] , UserType [User Type] from UserTypesTable ";
            }
            else
            {
                 query = "select UserTypeID [ID] , UserType [User Type] from UserTypesTable where UserType like '%" +searchvalue +"%'";
            }
            DataTable dt = new DataTable();
            
            dt = DatabaseAccess.Retrive(query);

            if(dt!=null)
            {
                if(dt.Rows.Count >0)
                {
                    dgvUserType.DataSource = dt;
                    dgvUserType.Columns[0].Width = 100;
                    dgvUserType.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                }
                else
                {
                    dgvUserType.DataSource = null;

                }
            }
            else
            {
                dgvUserType.DataSource = null;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //save button functionality to 
        private void btnSave_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if(txtEnterUserType.Text.Trim().Length == 0) // to check that text box is not empty //trim method is used to remove white spaces from the String 
            {
                ep.SetError(txtEnterUserType, "Please Enter the User Types ! "); //if it is empty then show the error
                txtEnterUserType.Focus(); //focus method is used to focus on the text box 
                return;

            }
            //writing some line so that the same usertype can not be inserted again that already exists  
            DataTable dt = new DataTable() ;
            dt = DatabaseAccess.Retrive("select * from UserTypesTable where UserType = '"+txtEnterUserType.Text.Trim()+ "'");
            if(dt != null)
            {
                if(dt.Rows.Count >0 )
                {
                    ep.SetError(txtEnterUserType, "This Type Of User Is Already Registered !");
                    txtEnterUserType.Focus();
                    return;
                }
            }

            String query = String.Format("insert into UserTypesTable(UserType) values('{0}')", txtEnterUserType.Text.Trim());
            bool result = DatabaseAccess.Insert(query);
            if(result) 
            {
                MessageBox.Show("save successfully !");
                FillGrid("");

            }
            else
            {
                MessageBox.Show("Unexpected error has occured ! Please contact to concern person ");
            }
        }
        //when the user type form loads functionality button 
        private void frmUserTypes_Load(object sender, EventArgs e)
        {
            FillGrid("");
        }
        //search box method 
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FillGrid(txtSearch.Text.Trim());
        }

        //clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEnterUserType.Clear();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        //menu strip button functionality to bring the selected row data in the txtenter user type button 
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvUserType != null)
            {
                if (dgvUserType.SelectedRows.Count > 0)
                {

                    if(dgvUserType.SelectedRows.Count == 1)
                    {
                        txtEnterUserType.Text = Convert.ToString(dgvUserType.CurrentRow.Cells[1].Value);
                        EnableControls();
                    }
                    else
                    {
                        MessageBox.Show("Please select more then one reocrd !");
                    }
                }
                else
                {
                    MessageBox.Show("List Is empty !");
                }
            }
            else
            {
                MessageBox.Show("List Is empty !");
            }
        }
        //method to enabale the edit and delete button 
        private void EnableControls()
        {
            btnEdit.Enabled = true;
            btnCancel.Enabled = true;
            btnSave.Enabled = false; 
            dgvUserType.Enabled = false;
            txtSearch.Enabled = false;

        }
        //method to enabale other controls after editing or deletion is done 

        private void DisableControls()
        {
            btnEdit.Enabled = false;
            btnCancel.Enabled = false;
            btnSave.Enabled = true;
            dgvUserType.Enabled = true;
            txtSearch.Enabled = true;
            FillGrid("");
            txtEnterUserType.Clear();

        }

        //edit button
        private void btnEdit_Click(object sender, EventArgs e) //method to edit a record 
        {
            ep.Clear();
            if (txtEnterUserType.Text.Trim().Length == 0) // to check that text box is not empty //trim method is used to remove white spaces from the String 
            {
                ep.SetError(txtEnterUserType, "Please Enter the User Types ! "); //if it is empty then show the error
                txtEnterUserType.Focus(); //focus method is used to focus on the text box 
                return;

            }

            //writing some line so that the same usertype can not be inserted again that already exists  
            DataTable dt = new DataTable();
            dt = DatabaseAccess.Retrive("select * from UserTypesTable where UserType = '" + txtEnterUserType.Text.Trim() + "'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txtEnterUserType, "This Type Of User Is Already Registered !");
                    txtEnterUserType.Focus();
                    return;
                }
            }


            String query = String.Format("update  UserTypesTable set UserType = '{0}'  where UserTypeID =  '{1}'", txtEnterUserType.Text.Trim(),Convert.ToString( dgvUserType.CurrentRow.Cells[0].Value));
            bool result = DatabaseAccess.Update(query);
            if (result)
            {
                MessageBox.Show("Updated  successfully !");
                
                DisableControls();

            }
            else
            {
                MessageBox.Show("Unexpected error has occured ! Please contact to concern person ");
            }
        }
        //cancel button
        private void btnCancel_Click(object sender, EventArgs e)
        { 
            DisableControls();
        }

        //delete strip menu button funncationality 
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvUserType != null)
            {
                if (dgvUserType.SelectedRows.Count > 0)
                {

                    if (dgvUserType.SelectedRows.Count == 1)
                    {
                        
                        if(MessageBox.Show("Are You Sure You Want To Delete This Record ! ","Confiramtion " ,MessageBoxButtons.YesNo ,MessageBoxIcon.Exclamation) == DialogResult.Yes) 
                        {
                            bool result = DatabaseAccess.Delete("delete from UserTypesTable where UserTypeID = '" + dgvUserType.CurrentRow.Cells[0].Value + "'");
                            if (result)
                            {
                                FillGrid("");
                                MessageBox.Show("Deleted Successfully");
                            }
                            else
                            {
                                MessageBox.Show("some contacts are dependent please contact to the concern person ");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select more then one reocrd !");
                    }
                }
                else
                {
                    MessageBox.Show("List Is empty !");
                }
            }
            else
            {
                MessageBox.Show("List Is empty !");
            }
        }
    }
}
