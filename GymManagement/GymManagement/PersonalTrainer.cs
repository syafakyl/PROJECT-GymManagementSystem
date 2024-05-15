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
    internal class PersonalTrainer
    {
        public string PTCode;
        public string PTName;
        public string PTPrice;

        Koneksi koneksi = new Koneksi();
        public void Create()
        {
            try
            {
                koneksi.bukaKoneksi();
                //string query = "INSERT INTO dbo.members VALUES (@nama, @nohp ,@alamat, @paket, @pelatih)";
                string query = "INSERT INTO PersonalTraining (CoachID, CoachName, CoachPrice)VALUES(@kode, @nama, @harga)";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@kode", PTCode);
                com.Parameters.AddWithValue("@nama", PTName);
                com.Parameters.AddWithValue("@harga", PTPrice);

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
                string query = "SELECT * FROM dbo.PersonalTraining WHERE CoachName = @nama";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@nama", PTName);
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds, "PersonalTraining");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return ds;
        }

        public DataSet Select()
        {
            DataSet ds = new DataSet();
            try
            {
                string query = "SELECT * FROM dbo.PersonalTraining";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds, "PersonalTraining");
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
                string query = "UPDATE dbo.PersonalTraining SET CoachName = @nama, CoachPrice = @price WHERE CoachID = @kode";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@nama", PTName);
                com.Parameters.AddWithValue("@price", PTPrice);
                com.Parameters.AddWithValue("@kode", PTCode);

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
                string query = "DELETE dbo.PersonalTraining WHERE CoachID = @kode";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@kode", PTCode);

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
