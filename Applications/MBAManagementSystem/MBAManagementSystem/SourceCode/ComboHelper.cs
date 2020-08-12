using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace MBAManagementSystem.SourceCode
{
    public class ComboHelper
    {
        public static void FillUserTypes(ComboBox cmb)
        {
            DataTable dtUserType = new DataTable();
            dtUserType.Columns.Add("UserTypeID");
            dtUserType.Columns.Add("UserType");
            dtUserType.Rows.Add("0", "---Select---");
            try
            {
                DataTable dt = DatabaseAccess.Retrive("select UserTypeID , UserType from UserTypesTable");
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow usertype in dt.Rows)
                        {
                            dtUserType.Rows.Add(usertype["UserTypeID"], usertype["UserType"]);

                        }
                    }
                }
                cmb.DataSource = dtUserType;
                cmb.ValueMember = "UserTypeID";
                cmb.DisplayMember = "UserType";
            }
            catch
            {
                cmb.DataSource = dtUserType;
                cmb.ValueMember = "UserTypeID";
                cmb.DisplayMember = "UserType"; 
            }
             




        }
    }
}
