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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txusername.Text = "";
            txpassword.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txusername.Text == "" ||  txpassword.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else if (txusername.Text == "Admin" && txpassword.Text == "admin")
            {
                Form1 mainform = new Form1();
                mainform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong ID or Password");
            }
        }
    }
}
