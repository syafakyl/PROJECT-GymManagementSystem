using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace GymManagement
{
    internal class Member
    {
        public string MCode;
        public string MName;
        public string MPhone;
        public string MAddress;
        public string MPackage;
        public string PersonalT;
        public DateTime RegistrationDate;


        Koneksi koneksi = new Koneksi();
        public void Create()
        {
            try
            {
                koneksi.bukaKoneksi();
                //string query = "INSERT INTO dbo.members VALUES (@nama, @nohp ,@alamat, @paket, @pelatih, @tanggal)";
                string query = "INSERT INTO Members (MemberID, MemberName, Phone, Address, Package, PersonalTrainer, RegistrationDate)VALUES(LEFT(CAST(NEWID() AS VARCHAR(36)), 5), @nama, @nohp, @alamat, @paket, @pelatih, @tanggal)";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                //com.Parameters.AddWithValue("@kode", MCode);
                com.Parameters.AddWithValue("@nama", MName);
                com.Parameters.AddWithValue("@nohp", MPhone);
                com.Parameters.AddWithValue("@alamat", MAddress);
                com.Parameters.AddWithValue("@paket", MPackage);
                com.Parameters.AddWithValue("@pelatih", PersonalT);
                com.Parameters.AddWithValue("@tanggal", RegistrationDate);

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
                //string query = "SELECT * FROM dbo.members";
                string query = "SELECT M.MemberID, M.MemberName, M.Phone, M.Address, P.PackageName, PT.CoachName, M.RegistrationDate FROM dbo.Members M JOIN dbo.Packages P ON M.Package = P.PackageID JOIN dbo.PersonalTraining PT ON M.PersonalTrainer = PT.CoachID";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds, "member");
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
                string query = "UPDATE dbo.members SET MemberName = @nama, Phone = @nohp, Address = @alamat, Package = @paket, PersonalTrainer = @pelatih WHERE MemberID = @kode";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@nama", MName);
                com.Parameters.AddWithValue("@nohp", MPhone);
                com.Parameters.AddWithValue("@alamat", MAddress);
                com.Parameters.AddWithValue("@paket", MPackage);
                com.Parameters.AddWithValue("@pelatih", PersonalT);
                com.Parameters.AddWithValue("@kode", MCode);

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
                string query = "DELETE dbo.members WHERE MemberID = @kode";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@kode", MCode);

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


