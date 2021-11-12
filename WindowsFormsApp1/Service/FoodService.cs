using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Helper;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Service
{
    class FoodService
    {
        public DataTable getListFood()
        {
            SqlConnection cnn = new SqlConnection(Constain.connectingString);
            try
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_getFindAll", cnn))
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

        public int getFoodByName(string name)
        {
            SqlConnection cnn = new SqlConnection(Constain.connectingString);
            try
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_getFoodByName", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", name);

                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    data.Fill(dataTable);

                    if (dataTable.Rows.Count >= 1)
                    {
                        return 1;
                    }

                    return 0;
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
            return 0;
        }


        public DataTable getByName(string name)
        {
            SqlConnection cnn = new SqlConnection(Constain.connectingString);
            try
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_getFoodByName", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", name);

                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    data.Fill(dataTable);

                    if (dataTable.Rows.Count >= 1)
                    {
                        return dataTable;
                    }

                    return null;
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

        public int insertFood(Food model)
        {
            SqlConnection cnn = new SqlConnection(Constain.connectingString);
            try
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_insertFood", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", model.Name);
                    cmd.Parameters.AddWithValue("@price", model.Price);
                    cmd.Parameters.AddWithValue("@description", model.Description);

                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    data.Fill(dataTable);

                    if (dataTable.Rows.Count == 1)
                    {
                        return 1;
                    }

                    return 0;
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
            return 0;
        }

        public int updateFood(Food model)
        {
            SqlConnection cnn = new SqlConnection(Constain.connectingString);
            try
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_updateFood", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", model.Id);
                    cmd.Parameters.AddWithValue("@name", model.Name);
                    cmd.Parameters.AddWithValue("@price", model.Price);
                    cmd.Parameters.AddWithValue("@description", model.Description);

                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    data.Fill(dataTable);

                    if (dataTable.Rows.Count == 1)
                    {
                        return 1;
                    }

                    return 0;
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
            return 0;
        }

        public int updateDelete (string id, string status)
        {
            SqlConnection cnn = new SqlConnection(Constain.connectingString);
            try
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_updateDelete", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@status", status);

                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    data.Fill(dataTable);

                    if (dataTable.Rows.Count == 1)
                    {
                        return 1;
                    }

                    return 0;
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
            return 0;
        }

        public DataTable getSearchName(string name)
        {
            SqlConnection cnn = new SqlConnection(Constain.connectingString);
            try
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_search", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", name);

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
