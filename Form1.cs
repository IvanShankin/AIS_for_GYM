using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Gym
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string manegerFIO = "Администратор";//Хранит ФИО пользователя который зашёл в программу 

        bool manedger = true;//если пользователь выбрал менеджера, то true

       
        private void button1_Click(object sender, EventArgs e)
        {
            if (manedger == true)
            {
            if (textBoxID.Text == "")
                 {
                     MessageBox.Show("Строка с ID и Паролем обязательна для заполнения!","Внимание!");
                     return;
                 }

                int id = 0;

                try
                { 
                    id = int.Parse(textBoxID.Text.ToString());
                }
                catch (Exception)
                {
                    MessageBox.Show("Введён неврный Логин!", "Внимание!");
                    return;
                }

                
                //соеденение с БД
                string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = dataBase.accdb;";
                OleDbConnection dbConnection = new OleDbConnection(connectionString);//создаём новое соеденение 

                //выполнение запроса к БД
                dbConnection.Open();//открытие соеденения
                string query = "SELECT * FROM theCoach WHERE ID = " + id + " AND post = 'Менеджер'";//создаём сам запрос
                OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);//выполнение команды
                OleDbDataReader dbReader = dbCommand.ExecuteReader();//считывание данных

                //проверяем данные
                if (dbReader.HasRows == false)//этот метод вернёт false если таких данных в БД нету
                {
                    MessageBox.Show("Введён неверный ID", "Внимание!");
                }
                else
                {
                    string query2 = "SELECT * FROM theCoach WHERE passwor = '" + password.Text + "'";

                    OleDbCommand dbCommand2 = new OleDbCommand(query2, dbConnection);//выполнение команды
                    OleDbDataReader dbReader2 = dbCommand2.ExecuteReader();

                    if (dbReader2.HasRows == true)//мы узнаём в БД есть ли такой пароль (это на случий если он есть)
                    {
                        string query3 = "SELECT * FROM theCoach WHERE ID = " + id;
                        OleDbCommand dbCommand3 = new OleDbCommand(query3, dbConnection);//выполнение команды
                        OleDbDataReader dbReader3 = dbCommand3.ExecuteReader();

                        dbReader3.Read();
                        manegerFIO = Convert.ToString(dbReader3["FIO"]);
                        
                        dbReader2.Close();
                        dbReader3.Close();

                        MainForm mainForm = new MainForm(manegerFIO);
                        this.Hide();
                        mainForm.Show();

                        
                    }
                    else
                    {
                        MessageBox.Show("Введён неврный пароль!", "Внимание!");
                    }

                }//если данные удалось найти 

                //закрытие соеденения с БД
                
                dbReader.Close();
                dbConnection.Close();
            }
            else
            {
                if (password.Text == "admin")
                {
                    MainForm mainForm = new MainForm(manegerFIO);
                    this.Hide();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Введён неврный пароль!", "Внимание!");
                }
            }
        }

        private void buttonMenedger_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBoxID.Visible = true;
            this.password.Location = new System.Drawing.Point(177, 99);
            this.label2.Location = new System.Drawing.Point(66, 99);

            buttonAdmin.BackColor = SystemColors.Control;
            buttonMenedger.BackColor = Color.White;

            manedger = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            buttonMenedger_Click(sender, e);
        }
        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBoxID.Visible = false;
            this.password.Location = new System.Drawing.Point(177, 80);
            this.label2.Location = new System.Drawing.Point(66, 80);

            buttonMenedger.BackColor = SystemColors.Control;
            buttonAdmin.BackColor = Color.White;

            manedger = false;
        }
        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
