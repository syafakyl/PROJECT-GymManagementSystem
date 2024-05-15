using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement
{
    internal class Inventory
    {
        
        public string ICode;
        public string IName;
        public string ICondition;

        Koneksi koneksi = new Koneksi();
        public void Create()
        {
            try
            {
                koneksi.bukaKoneksi();
                string query = "INSERT INTO Members (MemberID, MemberName, Phone, Address, Package, PersonalTrainer)VALUES(LEFT(CAST(NEWID() AS VARCHAR(36)), 5), @nama, @nohp, @alamat, @paket, @pelatih)";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@kode", ICode);
                com.Parameters.AddWithValue("@nama", IName);
                com.Parameters.AddWithValue("@nohp", ICondition);

                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Data Berhasil Dimasukkan");
                }
                else
                {
                    MessageBox.Show("Data Gagal Dimasukkan");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                koneksi.tutupKoneksi();
            }
        }
        public DataSet Read()
        {
            DataSet ds = new DataSet();
            try
            {
                string query = "SELECT * FROM dbo.Inventory";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds, "inventory");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return ds;
        }
        public void Update()
        {
            try
            {
                koneksi.bukaKoneksi();
                string query = "UPDATE dbo.Inventory SET ItemName = @nama, Condition = @kondisi WHERE ItemID = @kode";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@nama", IName);
                com.Parameters.AddWithValue("@kondisi", ICondition);
                com.Parameters.AddWithValue("@kode", ICode);

                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Data Berhasil DiUbah");
                }
                else
                {
                    MessageBox.Show("Data Gagal DiUbah");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                koneksi.tutupKoneksi();
            }
        }
        public void Delete()
        {
            try
            {
                koneksi.bukaKoneksi();
                string query = "DELETE dbo.Inventory WHERE ItemID = @kode";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@kode", ICode);

                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Data Berhasil Dihapus");
                }
                else
                {
                    MessageBox.Show("Data Gagal Dihapus");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                koneksi.tutupKoneksi();
            }
        }
    }
}
