using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MBAManagementSystem
{
    
    public class DatabaseAccess
    {
        public static SqlConnection conn;
        //making method for connection to the database 
        private static SqlConnection connOpen()
        {
            if (conn == null)
            {
                conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=MBAManagementSystemDb;Integrated Security=True");
            }
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
            return conn;

        }
        //method to insert something in database 
        public static bool Insert(String query )
        {
            //if any erroe occurs si exception would catch it 
            try
            {
                int NoOfRows = 0;
                SqlCommand cmd = new SqlCommand(query, connOpen());
                NoOfRows = cmd.ExecuteNonQuery(); //it basically return us the no of rows effected like the message we get in sql server
                if (NoOfRows > 0) //means insertions has been done
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        //method to update something in database 
        public static bool Update(String query)
        {
            //if any erroe occurs si exception would catch it 
            try
            {
                int NoOfRows = 0;
                SqlCommand cmd = new SqlCommand(query, connOpen());
                NoOfRows = cmd.ExecuteNonQuery(); //it basically return us the no of rows effected like the message we get in sql server
                if (NoOfRows > 0) //means insertions has been done
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        //method to delete something in database 
        public static bool Delete(String query)
        {
            //if any erroe occurs si exception would catch it 
            try
            {
                int NoOfRows = 0;
                SqlCommand cmd = new SqlCommand(query, connOpen());
                NoOfRows = cmd.ExecuteNonQuery(); //it basically return us the no of rows effected like the message we get in sql server
                if (NoOfRows > 0) //means insertions has been done
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        //method to retreive something in database 
        public static DataTable Retrive(String query)
        {
            //if any erroe occurs si exception would catch it 
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(query, connOpen()); // we use sql data apdapter here because it bring the data from database retreive the data /
                da.Fill(dt);
                return dt;

            }
            catch
            {
                return null;
            }
        }
    }
}
