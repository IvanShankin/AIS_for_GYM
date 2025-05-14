using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;//это для работы с данными которые хранятся в БД

namespace Gym
{
    public partial class FormCoach : Form
    {
        public FormCoach()
        {
            InitializeComponent();

        }
        int id = 0;
        string str = ""; 
        int index = 0;
        bool presBack = false;
        private void FormCoach_Load(object sender, EventArgs e)
        {
            string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = dataBase.accdb;";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            //выполнение запроса к БД
            dbConnection.Open();//открытие соеденения
            string query = "SELECT * FROM theCoach";//сам запрос
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
                    dataGridView1.Rows.Add(dbReader["ID"], dbReader["FIO"], dbReader["post"], dbReader["salary"], dbReader["passwor"]);
                    id++;
                }
            }//если данные считались 

           
            //закрытие соеденения с БД
            dbReader.Close();
            dbConnection.Close();

        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxFIO.Enabled == false)
            {
                MessageBox.Show("Выберите действие над строкой", "Внимание!");
            }
            switch (str)
            {
                case "change":

                    if (textBoxFIO.Text == "" || textBoxSalary.Text == "" || comboBoxPost.Text == "")//если  не введены какие-то параметры 
                    {
                        MessageBox.Show("не все данные введены!", "Внимание!");
                        return;
                    }

                    if (textBoxPassword.Visible == true)
                    {
                        if (textBoxPassword.Text == "")
                        {
                            MessageBox.Show("Введите пароль!", "Внимание!");
                            return;
                        }
                        if (textBoxPassword.Text.Length < 4)
                        {
                            MessageBox.Show("Пароль должен состоять более чем из 4 символов!", "Внимание!");
                            return;
                        }
                        if (textBoxPassword.Text.IndexOf(' ') >= 0)
                        {
                            MessageBox.Show("В пароле нельзя использовать пробел!", "Внимание!");
                            return;
                        }
                    }
                    else
                    {
                        textBoxPassword.Text = "нет";
                    }

                    //считываем данные
                    string fioStr = textBoxFIO.Text.ToString();
                    string salaryStr = textBoxSalary.Text.ToString();
                    string postStr = comboBoxPost.Text.ToString();
                    string password = textBoxPassword.Text.ToString();
                    if (comboBoxPost.Text != "Менеджер") {password = "нет";} 
                        
                    //соеденение с БД
                    string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = dataBase.accdb;";
                    OleDbConnection dbConnection = new OleDbConnection(connectionString);//создаём новое соеденение 

                    //выполнение запроса к БД
                    dbConnection.Open();//открытие соеденения
                    string query = "UPDATE theCoach SET ID = " + id + ", FIO = '" + fioStr + "', post = '" + postStr + "', salary = '" + salaryStr + "', passwor = '" + password + "' WHERE ID = " + id;//сам запрос
                    OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);// команда

                    //выполнение запроса 
                    if (dbCommand.ExecuteNonQuery() != 1)//этот метот возвращает кол-во добавленных строк 
                    { MessageBox.Show("Ошибка выполнения запроса!", "Внимание!"); return; }
                    else
                    {
                        dataGridView1.Rows[id].Cells[0].Value = id;
                        dataGridView1.Rows[id].Cells[1].Value = fioStr;
                        dataGridView1.Rows[id].Cells[2].Value = postStr;
                        dataGridView1.Rows[id].Cells[3].Value = salaryStr;
                        dataGridView1.Rows[id].Cells[4].Value = password;
                        MessageBox.Show("Данные изменены", "Готово!");
                    }

                    //закрытие соединения с БД
                    dbConnection.Close();
                    buttonSave.Enabled = false;

                    break;
                case "add":
                    if (textBoxFIO.Text == "" || textBoxSalary.Text == "" || comboBoxPost.Text == "")//если  не введены какие-то параметры 
                    {
                        MessageBox.Show("не все данные введены!", "Внимание!");
                        return;
                    }
                    if (textBoxPassword.Visible == true)
                    {
                        if (textBoxPassword.Text == "")
                        {
                            MessageBox.Show("Введите пароль!", "Внимание!");
                            return;
                        }
                        if (textBoxPassword.Text.Length < 4)
                        {
                            MessageBox.Show("Пароль должен состоять более чем из 4 символов!", "Внимание!");
                            return;
                        }
                        if (textBoxPassword.Text.IndexOf(' ') >= 0)
                        {
                            MessageBox.Show("В пароле нельзя использовать пробел!", "Внимание!");
                            return;
                        } 
                    }
                    else
                    {
                        textBoxPassword.Text = "нет";
                    }

                    //считываем данные
                    string fioStrAdd = textBoxFIO.Text.ToString();
                    string salaryStrAdd = textBoxSalary.Text.ToString();
                    string postStrAdd = comboBoxPost.Text.ToString();
                    string passwordAdd = textBoxPassword.Text.ToString();

                    //соеденение с БД
                    string connectionStringAdd = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = dataBase.accdb;";
                    OleDbConnection dbConnectionAdd = new OleDbConnection(connectionStringAdd);//создаём новое соеденение 

                    //выполнение запроса к БД
                    dbConnectionAdd.Open();//открытие соеденения
                    string queryAdd = "INSERT INTO theCoach VALUES(" + id + ",'" + fioStrAdd + "','" + postStrAdd + "','" + salaryStrAdd + "','"+ passwordAdd +"')";//сам запрос
                    OleDbCommand dbCommandAdd = new OleDbCommand(queryAdd, dbConnectionAdd);// команда

                    //выполнение запроса 
                    if (dbCommandAdd.ExecuteNonQuery() != 1)//этот метот возвращает кол-во добавленных строк 
                    { MessageBox.Show("Ошибка выполнения запроса!", "Внимание!"); return; }
                    else
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[id].Cells[0].Value = id;
                        dataGridView1.Rows[id].Cells[1].Value = fioStrAdd; 
                        dataGridView1.Rows[id].Cells[2].Value = postStrAdd;
                        dataGridView1.Rows[id].Cells[3].Value = salaryStrAdd;
                        dataGridView1.Rows[id].Cells[4].Value = passwordAdd;
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

            string fio = dataGridView1.Rows[id].Cells[1].Value.ToString();
            string post = dataGridView1.Rows[id].Cells[2].Value.ToString();
            string salary = dataGridView1.Rows[id].Cells[3].Value.ToString();
            string password = dataGridView1.Rows[id].Cells[4].Value.ToString();

            textBoxFIO.Text = fio;
            comboBoxPost.Text = post;
            textBoxSalary.Text = salary;
            textBoxPassword.Text = password;

            textBoxFIO.Enabled = false;
            textBoxSalary.Enabled = false;
            comboBoxPost.Enabled = false;
            textBoxPassword.Enabled = false;
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Пожалуйста выберите только одну строку!", "Внимание!");
                return;
            }

            buttonSave.Enabled = true;
            textBoxFIO.Enabled = true;
            textBoxSalary.Enabled = true;
            comboBoxPost.Enabled = true;
            textBoxPassword.Enabled = true;

            str = "change";
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            buttonSave.Enabled = true;
            textBoxFIO.Enabled = true;
            textBoxSalary.Enabled = true;
            comboBoxPost.Enabled = true;
            textBoxPassword.Enabled = true;
            
            textBoxFIO.Text = "";
            textBoxSalary.Text = "";
            comboBoxPost.Text = "";
            textBoxPassword.Text = "";

            str = "add";

            id = dataGridView1.Rows.Count;
        }
        private void FormCoach_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(presBack==false)
            Application.Exit();
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
            string query = "DELETE FROM theCoach WHERE ID = " + id;//сам запрос
            //DELETE - Удали FROM - из  theCoach - имя таблицы     WHERE - условие  
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);// команда

            //выполнение запроса 
            if (dbCommand.ExecuteNonQuery() != 1)//этот метот возвращает кол-во добавленных строк 
            { MessageBox.Show("Ошибка выполнения запроса!", "Внимание!"); return; }
            else
            {
                dataGridView1.Rows.RemoveAt(id);
                textBoxFIO.Text = "";
                textBoxSalary.Text = "";
                comboBoxPost.Text = "";

                int i = 0;
                string queryUpdate = "UPDATE theCoach SET ID = " + i + " WHERE ID = " + id;//сам запрос

                for (; i < dataGridView1.Rows.Count; i++)
                {
                    id = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    queryUpdate = "UPDATE theCoach SET ID = " + i + " WHERE ID = " + id;//запрос
                    OleDbCommand dbCommandUpdate = new OleDbCommand(queryUpdate, dbConnection);// команда
                    if (dbCommandUpdate.ExecuteNonQuery() != 1)
                    { MessageBox.Show("Ошибка выполнения запроса!", "Внимание!"); return; }
                    dataGridView1.Rows[i].Cells[0].Value = i;
                }//этот цикл меняет последовательность ID в БД и в dataGrideView

                MessageBox.Show("Данные Удалены", "Готово!");
            }

            //закрытие соединения с БД
            dbConnection.Close();
        }
        private void textBoxSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            { 
                e.Handled = true;
            }
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Owner.Show();
            presBack = true;
            this.Close();
            
        }
        private void comboBoxPost_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPost.SelectedIndex == 1)
            {
                label4.Visible = true;
                textBoxPassword.Visible = true;
            }
            else
            {
                label4.Visible = false;
                textBoxPassword.Visible = false;
            }
        }
    }
}