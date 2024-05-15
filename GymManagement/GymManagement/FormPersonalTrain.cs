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
    public partial class FormPersonalTrain : Form
    {
        public FormPersonalTrain()
        {
            InitializeComponent();
        }

        private void FormPersonalTrain_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            PersonalTrainer pt = new PersonalTrainer();
            DataSet ds = new DataSet();
            ds = pt.Select();
            button1.Text = ds.Tables["PersonalTraining"].Rows[1]["CoachName"].ToString();
            button2.Text = ds.Tables["PersonalTraining"].Rows[2]["CoachName"].ToString();
            button4.Text = ds.Tables["PersonalTraining"].Rows[3]["CoachName"].ToString();
            button3.Text = ds.Tables["PersonalTraining"].Rows[4]["CoachName"].ToString();
            button7.Text = ds.Tables["PersonalTraining"].Rows[5]["CoachName"].ToString();
        }

        void ClearData()
        {
            idtx.Text = "";
            nametx.Text = "";
            ratetx.Text = "";

            PersonalTrainer pt = new PersonalTrainer();
            pt.PTCode = "";
            pt.PTName = "";
            pt.PTPrice = "";
        }

        void loadData()
        {
            PersonalTrainer pt = new PersonalTrainer();
            pt.Read();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonalTrainer pt = new PersonalTrainer();
            pt.PTName = button1.Text;

            DataSet ds = new DataSet();
            ds = pt.Read();
            pt.PTCode = ds.Tables["PersonalTraining"].Rows[0]["CoachID"].ToString();
            pt.PTName = ds.Tables["PersonalTraining"].Rows[0]["CoachName"].ToString();
            pt.PTPrice = ds.Tables["PersonalTraining"].Rows[0]["CoachPrice"].ToString();

            idtx.Text = pt.PTCode;
            nametx.Text = pt.PTName;
            ratetx.Text = pt.PTPrice;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonalTrainer pt = new PersonalTrainer();
            pt.PTName = button2.Text;

            DataSet ds = new DataSet();
            ds = pt.Read();
            pt.PTCode = ds.Tables["PersonalTraining"].Rows[0]["CoachID"].ToString();
            pt.PTPrice = ds.Tables["PersonalTraining"].Rows[0]["CoachPrice"].ToString();

            idtx.Text = pt.PTCode;
            nametx.Text = pt.PTName;
            ratetx.Text = pt.PTPrice;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PersonalTrainer pt = new PersonalTrainer();
            pt.PTName = button4.Text;

            DataSet ds = new DataSet();
            ds = pt.Read();
            pt.PTCode = ds.Tables["PersonalTraining"].Rows[0]["CoachID"].ToString();
            pt.PTPrice = ds.Tables["PersonalTraining"].Rows[0]["CoachPrice"].ToString();

            idtx.Text = pt.PTCode;
            nametx.Text = pt.PTName;
            ratetx.Text = pt.PTPrice;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonalTrainer pt = new PersonalTrainer();
            pt.PTName = button3.Text;

            DataSet ds = new DataSet();
            ds = pt.Read();
            pt.PTCode = ds.Tables["PersonalTraining"].Rows[0]["CoachID"].ToString();
            pt.PTPrice = ds.Tables["PersonalTraining"].Rows[0]["CoachPrice"].ToString();

            idtx.Text = pt.PTCode;
            nametx.Text = pt.PTName;
            ratetx.Text = pt.PTPrice;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PersonalTrainer pt = new PersonalTrainer();
            pt.PTName = button7.Text;

            DataSet ds = new DataSet();
            ds = pt.Read();
            pt.PTCode = ds.Tables["PersonalTraining"].Rows[0]["CoachID"].ToString();
            pt.PTPrice = ds.Tables["PersonalTraining"].Rows[0]["CoachPrice"].ToString();

            idtx.Text = pt.PTCode;
            nametx.Text = pt.PTName;
            ratetx.Text = pt.PTPrice;
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            PersonalTrainer pt = new PersonalTrainer();
            pt.PTCode = idtx.Text;
            pt.PTName = nametx.Text;
            pt.PTPrice = ratetx.Text;
            pt.Update();

            DataSet ds = new DataSet();
            ds = pt.Select();
            button1.Text = ds.Tables["PersonalTraining"].Rows[1]["CoachName"].ToString();
            button2.Text = ds.Tables["PersonalTraining"].Rows[2]["CoachName"].ToString();
            button4.Text = ds.Tables["PersonalTraining"].Rows[3]["CoachName"].ToString();
            button3.Text = ds.Tables["PersonalTraining"].Rows[4]["CoachName"].ToString();
            button7.Text = ds.Tables["PersonalTraining"].Rows[5]["CoachName"].ToString();

            ClearData();
        }
    }
}
