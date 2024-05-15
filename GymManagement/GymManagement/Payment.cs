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
    internal class Payment
    {
        public string PyCode;
        public string MId;
        public string PId;
        public string CId;
        public string PyTotal;
        public DateTime PyDate;


        Koneksi koneksi = new Koneksi();
        public void Create()
        {
            try
            {
                koneksi.bukaKoneksi();
                string query = "INSERT INTO Payments (PaymentID, PaymentDate, MemberID, PackageID, CoachID, TotalPayment)VALUES(LEFT(CAST(NEWID() AS VARCHAR(36)), 50), @tanggal, @member, @paket, @pelatih, @total)";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@member", MId);
                com.Parameters.AddWithValue("@paket", PId);
                com.Parameters.AddWithValue("@pelatih", CId);
                com.Parameters.AddWithValue("@total", PyTotal);
                com.Parameters.AddWithValue("@tanggal", PyDate);

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
                /*string query = @"SELECT M.MemberID, M.MemberName, M.Phone, M.Address, P.PackageName, PT.CoachName, 
                                M.RegistrationDate, (PK.PackagePrice + PT.CoachPrice) AS TotalPayment
                         FROM dbo.Members M 
                         JOIN dbo.Packages P ON M.Package = P.PackageID 
                         JOIN dbo.PersonalTraining PT ON M.PersonalTrainer = PT.CoachID 
                         JOIN dbo.Packages PK ON P.PackageName = PK.PackageName
                         WHERE M.RegistrationDate <= DATEADD(MONTH, -1, GETDATE())";*/
                string query = @"SELECT M.MemberID, M.MemberName, M.Phone, M.Address, P.PackageName, PT.CoachName, 
                    M.RegistrationDate, (PK.PackagePrice + PT.CoachPrice) AS TotalPayment FROM dbo.Members M 
                    JOIN dbo.Packages P ON M.Package = P.PackageID 
                    JOIN dbo.PersonalTraining PT ON M.PersonalTrainer = PT.CoachID 
                    JOIN dbo.Packages PK ON P.PackageName = PK.PackageName
                    LEFT JOIN dbo.Payments PM ON M.MemberID = PM.MemberID
                    WHERE M.RegistrationDate <= DATEADD(MONTH, -1, GETDATE())
                    AND PM.MemberID IS NULL";


                SqlCommand com = new SqlCommand(query, koneksi.con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds, "payments");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return ds;
        }
    }
}

