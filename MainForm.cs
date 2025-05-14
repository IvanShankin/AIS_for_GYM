using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class MainForm : Form
    {
        string manegerFIO;
        public MainForm(string manegerFIO)
        {
            InitializeComponent();
            this.manegerFIO = manegerFIO;
        }
        private void coach_Click(object sender, EventArgs e)
        {
            if (manegerFIO != "Администратор")
            {
                MessageBox.Show("У вас недостаточно прав для открытия этого раздела", "Внимание!");
                return;
            }    
            FormCoach coach = new FormCoach();
            this.Hide();
            coach.Show();
            coach.Owner = this;//задаём владельца формы couch
        }
        private void seasonTickets_Click(object sender, EventArgs e)
        {
            FormSeasonTicket ticket = new FormSeasonTicket();
            this.Hide();
            ticket.Show();
            ticket.Owner = this;
        }
        private void clients_Click(object sender, EventArgs e)
        {
            FormCustomers customers = new FormCustomers(manegerFIO);
            this.Hide();
            customers.Show();
            customers.Owner = this;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormReportClone report = new FormReportClone(manegerFIO);
            report.Show();
            this.Close();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
