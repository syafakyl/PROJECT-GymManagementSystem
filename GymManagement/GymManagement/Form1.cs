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
    public partial class Form1 : Form
    {
        FormDashboard dashboard;
        FormAddMember addmember;
        FormViewMembers viewmembers;
        FormPersonalTrain personaltrainer;
        FormInventory inventory;
        FormPayment payment;

        public Form1()
        {
            InitializeComponent();
        }
        bool menuExpand = false;
        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if(!menuExpand)
            {
                memberContainer.Height += 10;
                if(memberContainer.Height >= 123)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                memberContainer.Height -= 10;
                if (memberContainer.Height <= 40)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void member_Click(object sender, EventArgs e)
        {
            menuTransition.Start();

        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if(sidebarExpand)
            {
                sidebar.Width -= 5;
                if(sidebar.Width <= 50)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    pnDashboard.Width = sidebar.Width;
                    memberContainer.Width = sidebar.Width;
                    pnPersonalTrain.Width = sidebar.Width;
                    pnInventory.Width = sidebar.Width;
                    pnPayment.Width = sidebar.Width;
                    pnLogout.Width = sidebar.Width;
                }
            } else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 161)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    pnDashboard.Width = sidebar.Width;
                    memberContainer.Width = sidebar.Width;
                    pnPersonalTrain.Width = sidebar.Width;
                    pnInventory.Width = sidebar.Width;
                    pnPayment.Width = sidebar.Width;
                    pnLogout.Width = sidebar.Width;
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CloseFormIfOpen(Form form)
        {
            if (form != null && !form.IsDisposed)
            {
                form.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dashboard == null || dashboard.IsDisposed)
            {
                dashboard = new FormDashboard();
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Show();
            }
            else
            {
                dashboard.Activate();
            }

            // Menutup form lain yang mungkin terbuka
            CloseFormIfOpen(addmember);
            CloseFormIfOpen(viewmembers);
            CloseFormIfOpen(personaltrainer);
            CloseFormIfOpen(inventory);
            CloseFormIfOpen(payment);
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }

        private void memberadd_Click(object sender, EventArgs e)
        {
            if (addmember == null || addmember.IsDisposed)
            {
                addmember = new FormAddMember();
                addmember.FormClosed += memberadd_FormClosed;
                addmember.MdiParent = this;
                addmember.Dock = DockStyle.Fill;
                addmember.Show();
            }
            else
            {
                addmember.Activate();
            }

            // Menutup form lain yang mungkin terbuka
            CloseFormIfOpen(dashboard);
            CloseFormIfOpen(viewmembers);
            CloseFormIfOpen(personaltrainer);
            CloseFormIfOpen(inventory);
            CloseFormIfOpen(payment);
        }

        private void memberadd_FormClosed(object sender, FormClosedEventArgs e)
        {
            addmember = null;
        }
        
        private void memberview_Click(object sender, EventArgs e)
        {
            if (viewmembers == null || viewmembers.IsDisposed)
            {
                viewmembers = new FormViewMembers();
                viewmembers.FormClosed += memberview_FormClosed;
                viewmembers.MdiParent = this;
                viewmembers.Dock = DockStyle.Fill;
                viewmembers.Show();
            }
            else
            {
                viewmembers.Activate();
            }
            // Menutup form lain yang mungkin terbuka
            CloseFormIfOpen(addmember);
            CloseFormIfOpen(dashboard);
            CloseFormIfOpen(personaltrainer);
            CloseFormIfOpen(inventory);
            CloseFormIfOpen(payment);
        }

        private void memberview_FormClosed(object sender, FormClosedEventArgs e)
        {
            viewmembers = null;
        }

        private void btPersonalTrainer_Click(object sender, EventArgs e)
        {
            if (personaltrainer == null || personaltrainer.IsDisposed)
            {   
                personaltrainer = new FormPersonalTrain();
                personaltrainer.FormClosed += memberview_FormClosed;
                personaltrainer.MdiParent = this;
                personaltrainer.Dock = DockStyle.Fill;
                personaltrainer.Show();
            }   
            else
            {   
                personaltrainer.Activate();
            }

            // Menutup form lain yang mungkin terbuka
            CloseFormIfOpen(addmember);
            CloseFormIfOpen(viewmembers);
            CloseFormIfOpen(dashboard);
            CloseFormIfOpen(inventory);
            CloseFormIfOpen(payment);
        }

        private void btPersonalTrainer_FormClosed(object sender, FormClosedEventArgs e)
        {
            personaltrainer = null;
        }

        private void btInven_Click(object sender, EventArgs e)
        {
            if (inventory == null || inventory.IsDisposed)
            {
                inventory = new FormInventory();
                inventory.FormClosed += memberview_FormClosed;
                inventory.MdiParent = this;
                inventory.Dock = DockStyle.Fill;
                inventory.Show();
            }
            else
            {
                inventory.Activate();
            }
            // Menutup form lain yang mungkin terbuka
            CloseFormIfOpen(addmember);
            CloseFormIfOpen(viewmembers);
            CloseFormIfOpen(personaltrainer);
            CloseFormIfOpen(dashboard);
            CloseFormIfOpen(payment);
        }

        private void btInven_FormClosed(object sender, FormClosedEventArgs e)
        {
            inventory = null;
        }

        private void btPayment_Click(object sender, EventArgs e)
        {
            if (payment == null || payment.IsDisposed)
            {
                payment = new FormPayment();
                payment.FormClosed += memberview_FormClosed;
                payment.MdiParent = this;
                payment.Dock = DockStyle.Fill;
                payment.Show();
            }
            else
            {
                payment.Activate();
            }
            // Menutup form lain yang mungkin terbuka
            CloseFormIfOpen(addmember);
            CloseFormIfOpen(viewmembers);
            CloseFormIfOpen(personaltrainer);
            CloseFormIfOpen(inventory);
            CloseFormIfOpen(dashboard);
        }

        private void btPayment_FormClosed(object sender, FormClosedEventArgs e)
        {
            payment = null;
        }
    }
}
