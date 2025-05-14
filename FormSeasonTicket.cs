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
    public partial class FormSeasonTicket : Form
    {
        public FormSeasonTicket()
        {
            InitializeComponent();
        }
        int id = 0;
        string str = "";
        int index = 0;
        bool presBack = false;
        
        private void FormSeasonTicket_Load(object sender, EventArgs e)
        {
            //соеденение с БД
            string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = dataBase.accdb;";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);//создаём новое соеденение 

            //выполнение запроса к БД
            dbConnection.Open();//открытие соеденения
            string query = "SELECT * FROM seasonTicket";//сам запрос
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);// команда
            OleDbDataReader dbReader = dbCommand.ExecuteReader();//считывание данных

            //проверяем данные
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
            }//если данные считались 


            //закрытие соеденения с БД
            dbReader.Close();
            dbConnection.Close();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {

            switch (str)
            {
                case "change":

                    if (textBoxService.Text == "" || textBoxPrise.Text == "" || textBoxSuitableFor.Text == "")//если  не введены какие-то параметры 
                    {
                        MessageBox.Show("не все данные введены!", "Винимание!");
                        return;
                    }

                    //считываем данные
                    string serviceStr = textBoxService.Text.ToString();
                    string priseStr = textBoxPrise.Text.ToString();
                    string suitableForStr = textBoxSuitableFor.Text.ToString();

                    //соеденение с БД
                    string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = dataBase.accdb;";
                    OleDbConnection dbConnection = new OleDbConnection(connectionString);//создаём новое соеденение 

                    //выполнение запроса к БД
                    dbConnection.Open();//открытие соеденения
                    string query = "UPDATE seasonTicket SET ID = " + id + ", service = '" + serviceStr + "', prise = '" + priseStr + "', suitableFor = '" + suitableForStr + "' WHERE ID = " + id;//сам запрос
                    OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);// команда

                    //выполнение запроса 
                    if (dbCommand.ExecuteNonQuery() != 1)//этот метот возвращает кол-во добавленных строк 
                    { MessageBox.Show("Ошибка выполнения запроса!", "Внимание!"); return; }
                    else
                    {
                        dataGridView1.Rows[id].Cells[0].Value = id;
                        dataGridView1.Rows[id].Cells[1].Value = serviceStr;
                        dataGridView1.Rows[id].Cells[2].Value = priseStr;
                        dataGridView1.Rows[id].Cells[3].Value = suitableForStr;
                        MessageBox.Show("Данные изменены", "Готово!");
                    }

                    //закрытие соединения с БД
                    dbConnection.Close();

                    buttonSave.Enabled = false;

                    break;
                case "add":
                    if (textBoxService.Text == "" || textBoxPrise.Text == "" || textBoxSuitableFor.Text == "")//если  не введены какие-то параметры 
                    {
                        MessageBox.Show("не все данные введены!", "Винимание!");
                        return;
                    }

                    //считываем данные
                    string serviceStrAdd = textBoxService.Text.ToString();
                    string priseStrAdd = textBoxPrise.Text.ToString();
                    string suitableForStrAdd = textBoxSuitableFor.Text.ToString();

                    //соеденение с БД
                    string connectionStringAdd = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = dataBase.accdb;";
                    OleDbConnection dbConnectionAdd = new OleDbConnection(connectionStringAdd);//создаём новое соеденение 

                    //выполнение запроса к БД
                    dbConnectionAdd.Open();//открытие соеденения
                    string queryAdd = "INSERT INTO seasonTicket VALUES(" + id + ",'" + serviceStrAdd + "','" + priseStrAdd + "','" + suitableForStrAdd + "')";//сам запрос
                    OleDbCommand dbCommandAdd = new OleDbCommand(queryAdd, dbConnectionAdd);// команда

                    //выполнение запроса 
                    if (dbCommandAdd.ExecuteNonQuery() != 1)//выполнение команды 
                    { MessageBox.Show("Ошибка выполнения запроса!", "Внимание!"); return; }
                    else
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[id].Cells[0].Value = id;
                        dataGridView1.Rows[id].Cells[1].Value = serviceStrAdd;
                        dataGridView1.Rows[id].Cells[2].Value = priseStrAdd;
                        dataGridView1.Rows[id].Cells[3].Value = suitableForStrAdd;
                        MessageBox.Show("Данные добавленны", "Готово!");
                    }

                    //закрытие соединения с БД
                    dbConnectionAdd.Close();

                    buttonSave.Enabled = false;

                    break;
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonChange.Enabled = true;
            buttonDelete.Enabled = true;

            id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());//узнаём выбранную строку 

            dataGridView1.Rows[id].Selected = true;

            string service = dataGridView1.Rows[id].Cells[1].Value.ToString();
            string prise = dataGridView1.Rows[id].Cells[2].Value.ToString();
            string SuitableFor = dataGridView1.Rows[id].Cells[3].Value.ToString();
            
            textBoxService.Text = service;
            textBoxPrise.Text = prise;
            textBoxSuitableFor.Text = SuitableFor;

            textBoxService.Enabled = false;
            textBoxPrise.Enabled = false;
            textBoxSuitableFor.Enabled = false;
            buttonSave.Enabled = false;
        }
        private void textBoxSuitableFor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBoxPrise_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            buttonSave.Enabled = true;
            textBoxService.Enabled = true;
            textBoxPrise.Enabled = true;
            textBoxSuitableFor.Enabled = true;

            textBoxService.Text = "";
            textBoxPrise.Text = "";
            textBoxSuitableFor.Text = "";

            str = "add";

            id = dataGridView1.Rows.Count;
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Пожалуйста выберите только одну строку!", "Внимание!");
                return;
            }
            buttonSave.Enabled = true;
            textBoxService.Enabled = true;
            textBoxPrise.Enabled = true;
            textBoxSuitableFor.Enabled = true;

            str = "change";
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Пожалуйста выберите только одну строку!", "Внимание!");
                return;
            }

            //соеденение с БД
            string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = dataBase.accdb;";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);//создаём новое соеденение 

            //выполнение запроса к БД
            dbConnection.Open();//открытие соеденения
            string query = "DELETE FROM seasonTicket WHERE ID = " + id;// запрос
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            //выполнение запроса 
            if (dbCommand.ExecuteNonQuery() != 1)
            { MessageBox.Show("Ошибка выполнения запроса!", "Внимание!"); return; }
            else
            {
                
                
                dataGridView1.Rows.RemoveAt(id);
                textBoxService.Text = "";
                textBoxPrise.Text = "";
                textBoxSuitableFor.Text = "";

                int i = 0;
                string queryUpdate = "UPDATE seasonTicket SET ID = " + i + " WHERE ID = " + id;
                
                for (; i < dataGridView1.Rows.Count; i++)
                {
                    id = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    queryUpdate = "UPDATE seasonTicket SET ID = " + i + " WHERE ID = " + id;
                    OleDbCommand dbCommandUpdate = new OleDbCommand(queryUpdate, dbConnection);
                    if (dbCommandUpdate.ExecuteNonQuery() != 1)
                    { MessageBox.Show("Ошибка выполнения запроса!", "Внимание!"); return; }
                    dataGridView1.Rows[i].Cells[0].Value = i;
                }//этот цикл меняет последовательность ID в БД и в dataGrideView
                MessageBox.Show("Данные Удалены", "Готово!");
            }
            //закрытие соединения с БД
            dbConnection.Close();
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Owner.Show();
            presBack = true;
            this.Close();
        }
        private void FormSeasonTicket_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (presBack == false)
                Application.Exit();
        }
    }
}
