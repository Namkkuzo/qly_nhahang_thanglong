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
    public class UserService
    {
        static SqlConnection cnn = new SqlConnection(Constain.connectingString);
        public static DataTable getListUser()
        {
            DataTable data = new DataTable();
            using (SqlCommand cmd = new SqlCommand("selectAllUser", cnn))
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
        public static bool editUser(User user)
        {
            using (SqlCommand cmd = new SqlCommand("suanhanvien", cnn))
            {  
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", user.id);
                cmd.Parameters.AddWithValue("@sFullName", user.fullName);
                cmd.Parameters.AddWithValue("@dDateOfBirth", user.dateOfBirth);
                cmd.Parameters.AddWithValue("@bGender", user.gender);
                cmd.Parameters.AddWithValue("@sPhone", user.phoneNumber);
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    return false;
                }
                finally { cnn.Close(); }
            }
        }


        public static DataTable searchNhanVien(string hoten, DateTime sinhnhat, string sdt, Boolean gioitinh, Boolean havegt, Boolean havesn, string CMND, string diachi, string email)
        {
            DataTable table = new DataTable();
            using (SqlCommand cmd = new SqlCommand("timnhanvien", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sFullName", hoten);
                cmd.Parameters.AddWithValue("@sPassportNumber", CMND);
                cmd.Parameters.AddWithValue("@sAddress", diachi);
                cmd.Parameters.AddWithValue("@email", email);
                if (havesn)
                    cmd.Parameters.AddWithValue("@dDateOfBirth", sinhnhat);
                else
                    cmd.Parameters.AddWithValue("@dDateOfBirth", DBNull.Value);
                cmd.Parameters.AddWithValue("@sPhone", sdt);
                if (havegt)
                    cmd.Parameters.AddWithValue("@bGender", gioitinh);
                else
                    cmd.Parameters.AddWithValue("@bGender", DBNull.Value);
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(table);

                cnn.Close();

            }
            return table;
        }

        public static bool addUser(User user)
        {
            using (SqlCommand cmd = new SqlCommand("themnhanvien", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sFullName", user.fullName);
                cmd.Parameters.AddWithValue("@dDateOfBirth", user.dateOfBirth);
                cmd.Parameters.AddWithValue("@bGender", user.gender);
                cmd.Parameters.AddWithValue("@sPhone", user.phoneNumber);
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch
                {

                    return false;
                }
                finally { cnn.Close(); }
            }
        }
        public DataTable searchUser(String keySearch)
        {
            DataTable data = new DataTable();
            using (SqlCommand cmd = new SqlCommand("timnhanvien", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ten", keySearch);
                if (cnn.State == ConnectionState.Closed)
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

        public static bool deleteUser(User user)
        {
            using (SqlCommand cmd = new SqlCommand("xoaNhanVien", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", user.id);
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    return false;
                }
                finally { cnn.Close(); }
            }
        }
    }
}
