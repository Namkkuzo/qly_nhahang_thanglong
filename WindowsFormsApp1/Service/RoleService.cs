using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Helper;

namespace WindowsFormsApp1.Service
{
    public class RoleService
    {
        static SqlConnection cnn = new SqlConnection(Constain.connectingString);
        public static DataTable getAllRole()
        {
            DataTable data = new DataTable();
            using (SqlCommand cmd = new SqlCommand("getallQuyen", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cnn.Open();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(data);
                }


                catch { }
                finally { cnn.Close(); }
            }
            return data;
        }
        public static List<Constain.Role> getRoleUser(Int32 id)
        {
            SqlConnection cnn = new SqlConnection(Constain.connectingString);
            using (SqlCommand cmd = new SqlCommand("getRoleUser", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cnn.Open();

                List<Constain.Role> listRole = new List<Constain.Role>();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    da.Fill(table);
                    foreach (DataRow row in table.Rows)
                    {
                        listRole.Add(Constain.getRoleByString(row[1].ToString()) ?? Constain.Role.NO_ROLE);
                    }

                }
                catch
                {

                }
                cnn.Close();
                return listRole;
            }
        }

    }
}
