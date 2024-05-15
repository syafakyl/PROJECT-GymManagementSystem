using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GymManagement
{
    public partial class FormInventory : Form
    {
        public FormInventory()
        {
            InitializeComponent();
        }

        private void FormInventory_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadData();
        }

        void LoadData()
        {
            Inventory inv = new Inventory();
            DataSet ds = new DataSet();
            ds = inv.Read();
            inventorydg.DataSource = ds;
            inventorydg.DataMember = "inventory";
        }

        private void inventorydg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex < inventorydg.RowCount - 1)
            {
                Inventory inv = new Inventory();

                inv.ICode = inventorydg.Rows[e.RowIndex].Cells[0].Value.ToString();
                inv.IName = inventorydg.Rows[e.RowIndex].Cells[1].Value.ToString();
                inv.ICondition = inventorydg.Rows[e.RowIndex].Cells[2].Value.ToString();

                idtx.Text = inv.ICode;
                nametx.Text = inv.IName;
                string status = inv.ICondition;
                int i = -1;
                switch (status)
                {
                    case "Normal":
                        i = 0;
                        break;
                    case "Need Service":
                        i = 1;
                        break;
                    case "On Service":
                        i = 2;
                        break;
                }
                statuscb.SelectedIndex = i;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inventory inv = new Inventory();
            inv.ICode = idtx.Text;
            inv.IName = nametx.Text;
            inv.ICondition = statuscb.SelectedItem.ToString();
            inv.Update();

            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inventory inv = new Inventory();
            inv.ICode = idtx.Text;
            inv.Delete();
        }
    }
}
