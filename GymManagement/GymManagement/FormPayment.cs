using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class FormPayment : Form
    {
        public FormPayment()
        {
            InitializeComponent();
        }

        private void FormPayment_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadData();
        }

        void LoadData()
        {
            Payment py = new Payment();
            DataSet ds = new DataSet();
            ds = py.Read();
            paymentsdg.DataSource = ds;
            paymentsdg.DataMember = "payments";
        }

        void ClearData()
        {
            Payment py = selectedPayment;
            py.MId = "";
            py.PId = "";
            py.CId = "";
            py.PyTotal = "";

            totalpaymenttx.Text = "";
            inputpaymenttx.Text = "";
        }

        private Payment selectedPayment;

        private void paymenybtn_Click(object sender, EventArgs e)
        {
            if (selectedPayment != null) // Pastikan objek selectedPayment tidak null
            {
                if (Convert.ToInt32(inputpaymenttx.Text) < Convert.ToInt32(totalpaymenttx.Text))
                {
                    MessageBox.Show("Masukkan Jumlah Sesuai Tagihan");
                }
                else
                {
                    // Menggunakan nilai-nilai yang sudah diisi sebelumnya dari objek selectedPayment
                    Payment py = selectedPayment;
                    py.PyDate = DateTime.Now;
                    py.PyTotal = inputpaymenttx.Text; // Memperbarui PyTotal jika diperlukan
                    py.Create();
                    ClearData();
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Pilih baris terlebih dahulu dari DataGridView");
            }
        }

        private void paymentsdg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex < paymentsdg.Rows.Count - 1)
            {
                selectedPayment = new Payment();
                selectedPayment.MId = paymentsdg.Rows[e.RowIndex].Cells[0].Value.ToString();
                string package = paymentsdg.Rows[e.RowIndex].Cells[4].Value.ToString();
                int i = -1;
                switch (package)
                {
                    case "Basic 1 Month":
                        i = 0;
                        break;
                    case "Standard 3 Months":
                        i = 1;
                        break;
                    case "Professional 6 Months":
                        i = 2;
                        break;
                    case "Premium 9 Months":
                        i = 3;
                        break;
                    case "Ultimate 1 Year":
                        i = 4;
                        break;
                }
                selectedPayment.PId = (i+1).ToString();

                string PT = paymentsdg.Rows[e.RowIndex].Cells[5].Value.ToString();
                int j = -1;
                switch (PT)
                {
                    case "No Coach":
                        j = 0;
                        break;
                    case "Laila Putri":
                        j = 1;
                        break;
                    case "Eka Dian":
                        j = 2;
                        break;
                    case "Rizky Pratama":
                        j = 3;
                        break;
                    case "Andi Wijaya":
                        j = 4;
                        break;
                    case "Galih Arya":
                        j = 5;
                        break;
                }
                selectedPayment.CId = (j+1).ToString();
                selectedPayment.PyTotal = paymentsdg.Rows[e.RowIndex].Cells[7].Value.ToString();

                totalpaymenttx.Text = selectedPayment.PyTotal;
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
