using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class choosingService : Form
    {
        FormCustomers form1;
        public choosingService(FormCustomers form1)
        {
            InitializeComponent();
           this.form1 = form1;
        }
        

        int id = 0;
        string service = "Услуга";
        string seasonTicketTo = "";
        int before = 0;
        bool PresChoesService = false;
        private void choosingService_Load(object sender, EventArgs e)
        {

            string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = dataBase.accdb;";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query = "SELECT * FROM seasonTicket";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            OleDbDataReader dbReader = dbCommand.ExecuteReader();

            if (dbReader.HasRows == false)
            {
                MessageBox.Show("Данные не найдены", "Внимаение!");
            }
            else
            {
                while (dbReader.Read())
                {
                    dataGridView1.Rows.Add(dbReader["ID"], dbReader["service"], dbReader["prise"], dbReader["suitableFor"]);
                    id++;
                }
            }

            dbReader.Close();
            dbConnection.Close();
        }
        private void buttonChooesService_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Пожалуйста выберите только одну строку!", "Внимание!");
                return;
            }
            DateTime dateBefore = DateTime.Now.AddDays(before);

            seasonTicketTo = Convert.ToString(dateBefore.ToString("dd.MM.yyyy"));

            form1.setService(service);
            form1.setseasonTicketTo(seasonTicketTo);
            form1.setButtonSaveEnabled(true);
            PresChoesService = true;
            this.Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());//узнаём выбранную строку 

            service = dataGridView1.Rows[id].Cells[1].Value.ToString();
            before = Int32.Parse(dataGridView1.Rows[id].Cells[3].Value.ToString());

            buttonChooesService.Enabled = true;
        }
        private void buttonCancellation_Click(object sender, EventArgs e)
        {
            form1.setButtonSaveEnabled(false);
            this.Close();
        }
        private void choosingService_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(PresChoesService == false) { 
            form1.setButtonSaveEnabled(false);}
        }


    }
}
