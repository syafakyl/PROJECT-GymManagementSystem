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
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            loadData();
        }

        void loadData()
        {
            Member mbr = new Member();
            DataSet memberDataSet = mbr.Read();
            membertx.Text = memberDataSet.Tables[0].Rows.Count.ToString();

            Inventory inv = new Inventory();
            DataSet inventoryDataSet = inv.Read();
            inventorytx.Text = inventoryDataSet.Tables[0].Rows.Count.ToString();

            PersonalTrainer pt = new PersonalTrainer();
            DataSet personalTrainerDataSet = pt.Select();
            coachtx.Text = personalTrainerDataSet.Tables[0].Rows.Count.ToString();
        }
    }
}
