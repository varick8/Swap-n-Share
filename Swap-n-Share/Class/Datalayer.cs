using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private static string username;
        private static Guid userid; // Change userid to Guid
        private static string phone;
        private static string bio;
        private static string pw;
        private static Image pict;

        public static string USERNAME
        {
            get
            {
                return username;
            }
            private set
            {
                username = value;
            }
        }
        public static Image PICT
        {
            get
            {
                return pict;
            }
            private set
            {
                pict = value;
            }
        }

        public static Guid ID // Update the property to return Guid
        {
            get
            {
                return userid;
            }
            private set
            {
                userid = value;
            }
        }

        public static string PHONE
        {
            get
            {
                return phone;
            }
            private set
            {
                phone = value;
            }
        }

        public static string BIO
        {
            get
            {
                return bio;
            }
            private set
            {
                bio = value;
            }
        }

        public static string PW
        {
            get
            {
                return pw;
            }
            private set
            {
                pw = value;
            }
        }

        // Public getter, private setter for message encapsulation
        public string getmessage { get; set; }

        public Datalayer()
        {
            // Inisialisasi string koneksi
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

        public string InsertUpdateDeleteCreate(string query, NpgsqlParameter[] parameters = null)
        {
            string ret = "";
            try
            {
                // Set up command
                cmd_.CommandText = query;
                cmd_.Connection = conn_;
                cmd_.Parameters.Clear();

                // Add parameters if they exist
                if (parameters != null)
                {
                    cmd_.Parameters.AddRange(parameters);
                }

                // Open connection and execute query
                connect();
                int rowsAffected = cmd_.ExecuteNonQuery();

                // Determine the type of query and provide feedback
                if (query.Trim().StartsWith("INSERT INTO", StringComparison.OrdinalIgnoreCase))
                {
                    ret = $"{rowsAffected} row(s) inserted successfully.";
                }
                else if (query.Trim().StartsWith("DELETE FROM", StringComparison.OrdinalIgnoreCase))
                {
                    ret = $"{rowsAffected} row(s) deleted successfully.";
                }
                else if (query.Trim().StartsWith("UPDATE", StringComparison.OrdinalIgnoreCase))
                {
                    ret = $"{rowsAffected} row(s) updated successfully.";
                }
                else if (query.Trim().StartsWith("CREATE TABLE", StringComparison.OrdinalIgnoreCase))
                {
                    ret = "Table created successfully.";
                }
                else
                {
                    ret = "Query executed successfully.";
                }
            }
            catch (Exception exp)
            {
                ret = "Failed to execute query: " + query + "\nReason: " + exp.Message;
            }
            finally
            {
                disconnect();
            }

            return ret;
        }


        public DataTable GetData(NpgsqlCommand command)
        {
            DataTable dt = new DataTable();
            try
            {
                command.Connection = conn_;
                using (var adapter = new NpgsqlDataAdapter(command))
                {
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Swap n Share", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public static bool UserDetails(string user, string pass)
        {
            bool isValid = false;

            // Parameterized query to avoid SQL injection
            string qry = "SELECT * FROM public.\"User\" WHERE username = @user AND password = @pass";

            // Use NpgsqlCommand and NpgsqlDataAdapter instead of SQLite classes
            using (var con = new NpgsqlConnection("User Id=postgres;Host=localhost;Database=SwapnShare;Port=5432;password=password;"))
            {
                try
                {
                    con.Open();
                    using (var cmd = new NpgsqlCommand(qry, con))
                    {
                        cmd.Parameters.AddWithValue("@user", user);
                        cmd.Parameters.AddWithValue("@pass", pass);

                        using (var da = new NpgsqlDataAdapter(cmd))
                        {
                            var ds = new DataSet();
                            da.Fill(ds);

                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                username = ds.Tables[0].Rows[0]["username"].ToString();
                                phone = ds.Tables[0].Rows[0]["phone"].ToString();
                                bio = ds.Tables[0].Rows[0]["bio"].ToString();
                                pw = ds.Tables[0].Rows[0]["password"].ToString();
                                userid = Guid.Parse(ds.Tables[0].Rows[0]["user_id"].ToString());
                                if (ds.Tables[0].Rows[0]["image"] != DBNull.Value)
                                {
                                    byte[] imageArray = (byte[])ds.Tables[0].Rows[0]["image"];
                                    pict = Image.FromStream(new MemoryStream(imageArray));
                                }
                                else
                                {
                                    // Assign a default image or handle null image scenario
                                    pict = null; // Or assign a placeholder image if necessary
                                }
                                isValid = true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Swap n Share", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }

            return isValid;
        }

        public void UpdateUsername(string username)
        {
            USERNAME = username;
        }

        public void UpdateBio(string bio)
        {
            BIO = bio;
        }

        public void UpdatePict(Image pict)
        {
            PICT = pict;
        }
    }
}
