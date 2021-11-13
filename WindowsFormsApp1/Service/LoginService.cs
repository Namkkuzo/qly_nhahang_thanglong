using WindowsFormsApp1.Helper;
using WindowsFormsApp1.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Service
{
    public class LoginService
    {

        List<Constain.Role> getRoleUser (Int32 id)
        {
            SqlConnection cnn = new SqlConnection(Constain.connectingString);
            using (SqlCommand cmd = new SqlCommand("login", cnn))
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
                        if (Constain.getRoleByString(row[0].ToString().Trim()) != null )
                        listRole.Add(Constain.getRoleByString(row[1].ToString())?? Constain.Role.DANG_NHAP);
                    }   
                    
                }
                catch
                {
                    
                }
                cnn.Close();
                return listRole;
            }
        }

        public SortedDictionary<String ,dynamic> Login(int id , String password)
        {
            SortedDictionary<String, dynamic> result = new SortedDictionary<String, dynamic>();
            SqlConnection cnn = new  SqlConnection(Constain.connectingString);
            DataTable table = new DataTable();
            using (SqlCommand cmd = new SqlCommand("login", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cnn.Open();
                
                User user = new  User();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        user.id = Convert.ToInt32(table.Rows[0]["Id"]);
                        user.gender = Convert.ToInt32(table.Rows[0]["bGender"]);
                        user.fullName = table.Rows[0]["sFullName"].ToString();
                        user.email = table.Rows[0]["email"].ToString();
                        user.passportNumber = table.Rows[0]["sPassportNumber"].ToString();
                        user.dateOfBirth = Convert.ToDateTime(table.Rows[0]["dDateOfBirth"]);
                        user.phoneNumber = table.Rows[0]["sPhone"].ToString();
                        user.address =table.Rows[0]["sAddress"].ToString();
                        user.userName = table.Rows[0]["sName"].ToString();
                        user.listRole = getRoleUser(id);
                        String a = PasswordHash.MD5Hash(password);
                        String b = table.Rows[0]["sPassword"].ToString();
                        // check pass ở đây , hash pass
                        if (PasswordHash.MD5Hash(password) == table.Rows[0]["sPassword"].ToString())
                        {
                            if (user.listRole.Contains(Constain.Role.DANG_NHAP))
                            {
                                result.Add("message", "Bạn không có quyền đăng nhâp");
                                result.Add("user", new User());
                            }
                            else
                            {
                                result.Add("message", "đang nhập thành công");
                                result.Add("user", user);
                            }

                        }
                        else
                        {
                            result.Add("message", "sai mật khẩu");
                            result.Add("user", new User());
                        }
                        
                    }
                    else
                    {
                        result.Add("message", "Sai tên đang nhập");
                        result.Add("user", new User());
                    }
                    
                }
                catch
                {
                    
                }
                cnn.Close();
                return result;
            }
            
        }
    }
}
