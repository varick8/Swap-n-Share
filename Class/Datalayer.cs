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
        // Encapsulated private fields
        private NpgsqlCommand cmd_; 
        private NpgsqlConnection conn_; //deklarasi Koneksi
        private NpgsqlDataAdapter adptr_; 
        private NpgsqlDataReader reader_; 
        private DataTable dtable_;
        private DataSet dset_;

        // Public getter, private setter for message encapsulation
        public string getmessage { get; set; }

        public Datalayer()
        {
            // Inisialisasi string koneksi
            string cs = "User Id=postgres;Host=serverpgsql.postgres.database.azure.com;Database=SwapnShare;Port=5432;password=Password8!;";
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
                conn_.Open(); // Membuka koneksi ke database
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
                conn_.Close(); // Menutup koneksi ke database
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
                cmd_.Connection = conn_; // Memastikan bahwa perintah yang dieksekusi akan dilakukan pada koneksi yang tepat
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

        public string GetSingleColumnValueByIndexParameterized(string query, out string columndata, int index)
        {
            string ret = null;
            string val = null;

            try
            {
                cmd_.Connection = conn_;  // Memastikan bahwa perintah yang dieksekusi akan dilakukan pada koneksi yang tepat
                cmd_.CommandText = query;
                // Open connection
                connect();

                reader_ = cmd_.ExecuteReader();
                while (reader_.Read())
                {

                    val = reader_.GetGuid(index).ToString();

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

            columndata = val;
            return ret;
        }

    }
}
