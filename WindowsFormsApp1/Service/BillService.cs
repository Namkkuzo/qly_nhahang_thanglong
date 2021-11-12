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
    class BillService
    {

        public DataTable getListBill()
        {
            SqlConnection cnn = new SqlConnection(Constain.connectingString);
            try
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_getAllBill", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    data.Fill(dataTable);

                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connect " + ex.Message);
            }
            finally
            {
                cnn.Close();
            }
            return null;
        }

        public DataTable getListBillDetail(string idBill)
        {
            SqlConnection cnn = new SqlConnection(Constain.connectingString);
            try
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_getBillDetail", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idBill", idBill);

                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    data.Fill(dataTable);

                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connect " + ex.Message);
            }
            finally
            {
                cnn.Close();
            }
            return null;
        }

        public DataTable getListBillDetailByDate(string from, string to)
        {
            SqlConnection cnn = new SqlConnection(Constain.connectingString);
            try
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_thongke_ngay", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@from", from);
                    cmd.Parameters.AddWithValue("@to", to);

                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    data.Fill(dataTable);

                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connect " + ex.Message);
            }
            finally
            {
                cnn.Close();
            }
            return null;
        }


        public DataTable getListBillDetailByUserName(string username)
        {
            SqlConnection cnn = new SqlConnection(Constain.connectingString);
            try
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_timkiem_username", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", username);

                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    data.Fill(dataTable);

                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connect " + ex.Message);
            }
            finally
            {
                cnn.Close();
            }
            return null;
        }

    }
}
