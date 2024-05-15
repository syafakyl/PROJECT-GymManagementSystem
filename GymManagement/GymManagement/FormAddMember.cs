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
    public partial class FormAddMember : Form
    {
        public FormAddMember()
        {
            InitializeComponent();
        }

        private void FormAddMember_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        void ClearData()
        {
            nametx.Text = "";
            phonetx.Text = "";
            addresstx.Text = "";
            packagecb.SelectedIndex = -1;
            personalTrainercb.SelectedIndex = -1;

            Member mbr = new Member();
            mbr.MName = "";
            mbr.MPhone = "";
            mbr.MAddress = "";
            mbr.MPackage = "";
            mbr.PersonalT = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Member mbr = new Member();
            mbr.MName = nametx.Text;
            mbr.MPhone = phonetx.Text;
            mbr.MAddress = addresstx.Text;
            mbr.MPackage = (packagecb.SelectedIndex + 1).ToString();
            mbr.PersonalT = (personalTrainercb.SelectedIndex + 1).ToString();
            mbr.RegistrationDate = DateTime.Now.AddMonths(-1);
            mbr.Create();
            ClearData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}
