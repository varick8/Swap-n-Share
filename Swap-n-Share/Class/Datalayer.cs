using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_n_Share.Class
{
    public class Datalayer
    {
        NpgsqlCommand cmd_; // Changed to NpgsqlCommand
        NpgsqlConnection conn_; // Changed to NpgsqlConnection
        NpgsqlDataAdapter adptr_; // Changed to NpgsqlDataAdapter
        NpgsqlDataReader reader_; // Changed to NpgsqlDataReader
        DataTable dtable_;
        DataSet dset_;
        public string getmessage { get; set; }

        public Datalayer()
        {
            string cs = "User Id=postgres;Host=localhost;Database=SwapnShare;Port=5432;password=password;";
            conn_ = new NpgsqlConnection(cs);
            cmd_ = new NpgsqlCommand();
            dtable_ = new DataTable();
            adptr_ = new NpgsqlDataAdapter();
            dset_ = new DataSet();
        }

        public bool connect()
        {
            try
            {
                conn_.Open();
                getmessage = "successfully connected";
                return true;
            }
            catch (Exception ex)
            {
                getmessage = "connection error: " + ex.Message;
                return false;
            }
        }

        public bool disconnect()
        {
            try
            {
                conn_.Close(); // Changed from Clone to Close for Npgsql
                return true;
            }
            catch (Exception ex)
            {
                getmessage = "disconnection error: " + ex.Message;
                return false;
            }
        }

        public string InsertUpdateDeleteCreate(string query)
        {
            string ret = "";

            try
            {
                cmd_.CommandText = query;
                cmd_.Connection = conn_;
                connect();
                cmd_.ExecuteNonQuery();

                if (query.Contains("Insert Into"))
                {
                    ret = getmessage = (" inseteted successfully ");
                }
                else if (query.Contains("Delete From"))
                {
                    ret = getmessage = ("delete successfull");
                }
                else if (query.Contains("Update into") && query.Contains("set"))
                {
                    ret = getmessage = ("update successfull");
                }
                else if (query.Contains("Creat table"))
                {
                    ret = getmessage = ("create table successful");
                }

            }
            catch (Exception exp)
            {

                ret = getmessage = "failed to execute" + query + "\n resoin :" + exp.Message;
            }
            finally { disconnect(); }
            return ret;
        }

        public string GetSingleColumnValueByIndexParameterized(string query, string username, string password, int index)
        {
            string ret = null;
            string val = null;

            try
            {
                // Open connection
                connect();

                // Prepare the command with parameterized query
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn_))
                {
                    // Set the parameter values
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);  // No hashing here

                    // Execute the query and read the result
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Read the value as UUID (Guid in C#)
                            val = reader.GetGuid(index).ToString();  // Converting Guid to string
                        }
                    }
                }

                ret = "Operation Successful!";
                getmessage = "Values successfully retrieved using GetSingleColumnValueByIndexParameterized() function.";
            }
            catch (Exception exp)
            {
                ret = "Error in Datalayer -> GetSingleColumnValueByIndexParameterized() Reason: " + exp.Message;
                getmessage = "Error in Datalayer GetSingleColumnValueByIndexParameterized() for reader_\n" + exp.Message;
            }
            finally
            {
                disconnect();  // Close the connection
            }

            return val;
        }

    }
}
