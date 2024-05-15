using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GymManagement
{
    internal class Koneksi
    {
        string source;
        public SqlConnection con;

        public Koneksi()
        {
            try
            {
                source = "Integrated Security=true;Initial Catalog=db_gms;Data Source=.";
                con = new SqlConnection(source);
            }
            catch (Exception sqle)
            {
                MessageBox.Show("Error: " + sqle.Message);
            }
        }

        public void bukaKoneksi()
        {
            try
            {
                con.Open();
                //MessageBox.Show("Buka Koneksi Berhasil");
            }
            catch (SqlException sqle)
            {
                MessageBox.Show("Error: " + sqle.Message);
            }
        }

        public void tutupKoneksi()
        {
            try
            {
                con.Close();
                //MessageBox.Show("Tutup Koneksi Berhasil");
            }
            catch (SqlException sqle)
            {
                MessageBox.Show("Error: " + sqle.Message);
            }
        }
    }
}