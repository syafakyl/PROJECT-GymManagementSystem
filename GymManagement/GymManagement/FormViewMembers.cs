using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class FormViewMembers : Form
    {
        public FormViewMembers()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            Member mbr = new Member();
            DataSet ds = new DataSet();
            ds = mbr.Read();
            membersdg.DataSource = ds;
            membersdg.DataMember = "member";
        }

        private void FormViewMembers_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadData();
        }

        private void membersdg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1 && e.RowIndex < membersdg.Rows.Count - 1)
            {
                nametx.Text = membersdg.Rows[e.RowIndex].Cells[1].Value.ToString();
                phonetx.Text = membersdg.Rows[e.RowIndex].Cells[2].Value.ToString();
                addresstx.Text = membersdg.Rows[e.RowIndex].Cells[3].Value.ToString();
                string package = membersdg.Rows[e.RowIndex].Cells[4].Value.ToString();
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
                packagecb.SelectedIndex = i;

                string PT = membersdg.Rows[e.RowIndex].Cells[5].Value.ToString();
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
                personalTrainercb.SelectedIndex = j;
            }
        }

        private void phonetx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Member mbr = new Member();
            mbr.MCode = membersdg.CurrentRow.Cells[0].Value.ToString();
            mbr.MName = nametx.Text;
            mbr.MPhone = phonetx.Text;
            mbr.MAddress = addresstx.Text;
            mbr.MPackage = (packagecb.SelectedIndex + 1).ToString();
            mbr.PersonalT = (personalTrainercb.SelectedIndex + 1).ToString();
            mbr.Update();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nametx.Text = "";
            phonetx.Text = "";
            addresstx.Text = "";
            packagecb.SelectedIndex = -1;
            personalTrainercb.SelectedIndex = -1;

            Member mbr = new Member();
            mbr.MCode = "";
            mbr.MName = "";
            mbr.MPhone = "";
            mbr.MAddress = "";
            mbr.MPackage = "";
            mbr.PersonalT = "";
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            Member mbr = new Member();
            mbr.MCode = idtx.Text;
            mbr.Delete();
        }
    }
}
