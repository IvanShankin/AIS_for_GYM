using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class FormCustomers : Form
    {
        string manegerFIO;
        public FormCustomers(string manegerFIO)
        {
            InitializeComponent();
            this.manegerFIO = manegerFIO;

        }
        
        public string getManegerFIO()
        {
            return manegerFIO;
        }
        int id = 0;//отображает id у выбронной строки
        string str = "";
        int index = 0;//отображает текущий index выбранной строки в dataGrideView
        bool presBack = false; 
        string service = "Услуга";
        string seasonTicketTo = "";//абонемент на (дней)
        bool presSearch = false; //true если нажат поиск 
        int idReport = 0;//отображает ID для отчёта 

        string fioSearch;
        string phoneSearch;
       
      
        private void FormCustomers_Load(object sender, EventArgs e)
        {
            //соеденение с БД
            string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = dataBase.accdb;";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);//создаём новое соеденение 

            //выполнение запроса к БД
            dbConnection.Open();//открытие соеденения
            string query = "SELECT * FROM customers";//сам запрос
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);// команда
            OleDbDataReader dbReader = dbCommand.ExecuteReader();//считывание данных

            //проверяем данные
            if (dbReader.HasRows == false)
            {
                MessageBox.Show("Данные не найдены", "Внимание!");
            }
            else
            {
                while (dbReader.Read())
                {
                    dataGridView1.Rows.Add(dbReader["ID"], dbReader["FIO"], dbReader["Phone"], dbReader["DateOfBirth"], dbReader["Service"], dbReader["FIOCoach"],  dbReader["seasonTicketTo"],dbReader["manager"], dbReader["TimeOfRegistration"]);
                    id++;
                }
            }//если данные считались 

            string query2 = "SELECT * FROM theCoach WHERE post = 'Тренер'";
            OleDbCommand dbCommand2 = new OleDbCommand(query2, dbConnection);//выполнение команды
            OleDbDataReader dbReader2 = dbCommand2.ExecuteReader();

            while (dbReader2.Read())//true если есть данные которые можно считать
            {
                comboBoxFIOCoach.Items.Add(Convert.ToString(dbReader2["FIO"]));
            }
           
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                try
                {
                    if (DateTime.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString()) <= DateTime.Now)
                    {
                        dataGridView1.Rows[i].Cells[6].Value = "Просрочен";
                    }
                } 
                catch { }
            } //проверка на просроченность абонемента(эти данные где написанно просрочен не синхронизированны с БД)
            //то есть надпись просрочен отображается только в dataGrideView ("просрочен" только для удобства пользователя)
            
            //закрытие соеденения с БД
            dbReader.Close();
            dbReader2.Close();
            dbConnection.Close();
            index = id;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                return;
            }
            //елси данных нету в dgv и мы нажимаем на заголовок столбцов, то может выдать ошибку 

            id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());//узнаём выбранную строку 

            index = id;

            buttonChange.Enabled = true;
            buttonDelete.Enabled = true;
            buttonToExtend.Enabled = false;
            buttonSave.Enabled = false;

            index = dataGridView1.CurrentRow.Index;

            if (dataGridView1.Rows[index].Cells[6].Value.ToString() == "Просрочен") 
            { buttonToExtend.Enabled = true;} 

            string FIO = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string phone = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string dateOfBirth = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string FIOCoach = dataGridView1.Rows[index].Cells[5].Value.ToString();


            textBoxFIO.Text = FIO;
            maskedTextBoxPhone.Text = phone;
            dateTimePicker1.Text = dateOfBirth;
            comboBoxFIOCoach.Text = FIOCoach;
            newClient.Text = "Новый клиент";

            textBoxFIO.Enabled = false;
            maskedTextBoxPhone.Enabled = false;
            dateTimePicker1.Enabled = false;
            comboBoxFIOCoach.Enabled = false;

           
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            switch (str)
            {
                case "newClient":
                    id = dataGridView1.RowCount;
                    index = id;

                    if (textBoxFIO.Text == "" || maskedTextBoxPhone.MaskCompleted == false || dateTimePicker1.Value.ToShortDateString() == Convert.ToString(DateTime.Now.ToString("dd.MM.yyyy")) || comboBoxFIOCoach.Text == "")
                    {
                        MessageBox.Show("Не все данные введены", "Внимание!");
                        return;
                    }

                    string FIO = textBoxFIO.Text;
                    string phone = maskedTextBoxPhone.Text;
                    string dateOfBer = dateTimePicker1.Value.ToString("dd/MM/yyyy");//здесь преобразуем в простой string т.к. будет красивее
                    string FIOCoach = comboBoxFIOCoach.Text;

                    string connectionStringAdd = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = dataBase.accdb;";
                    OleDbConnection dbConnectionAdd = new OleDbConnection(connectionStringAdd);//создаём новое соеденение 

                    dbConnectionAdd.Open();

                    string queryid = "SELECT * FROM customers";//сам запрос
                    OleDbCommand dbCommandid = new OleDbCommand(queryid, dbConnectionAdd);// команда
                    OleDbDataReader dbReader = dbCommandid.ExecuteReader();//считывание данных

                    if (dbReader.HasRows == false)
                    {
                        id = 0;
                    }
                    else
                    {
                        while (dbReader.Read())
                        {
                            id = Convert.ToInt32(dbReader["ID"]);
                        }
                        id++;//т.к. установить ID на 1 чем последний ID в БД
                    }//если данные считались 
                    dbReader.Close();

                    string queryAdd = "INSERT INTO customers VALUES(" + id + ",'" + FIO + "','" + phone + "','" + dateOfBer + "','" + service + "','"+ FIOCoach + "','" + manegerFIO + "','" + seasonTicketTo + "', '" + Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy")) + "')";//сам запрос
                    OleDbCommand dbCommandAdd = new OleDbCommand(queryAdd, dbConnectionAdd);// команда

                    //выполнение запроса 
                    if (dbCommandAdd.ExecuteNonQuery() != 1)//этот метот возвращает кол-во добавленных строк 
                    { MessageBox.Show("Ошибка выполнения запроса!", "Внимание!"); return; }
                    else
                    {
                        
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[index].Cells[0].Value = id;
                        dataGridView1.Rows[index].Cells[1].Value = FIO;
                        dataGridView1.Rows[index].Cells[2].Value = phone;
                        dataGridView1.Rows[index].Cells[3].Value = dateOfBer;
                        dataGridView1.Rows[index].Cells[4].Value = service;
                        dataGridView1.Rows[index].Cells[5].Value = FIOCoach;
                        dataGridView1.Rows[index].Cells[6].Value = seasonTicketTo;
                        dataGridView1.Rows[index].Cells[7].Value = manegerFIO;
                        dataGridView1.Rows[index].Cells[8].Value = Convert.ToString(DateTime.Now.ToString("dd.MM.yyyy"));
                        MessageBox.Show("Данные добавленны", "Готово!");                       

                        //ниже добовление для таблицы в БД report (добовляем туда данные)
                        string queryReport2 = "SELECT [ID] FROM report WHERE ID = (SELECT MAX(ID) FROM report)";
                        OleDbCommand dbCommandReport2 = new OleDbCommand(queryReport2, dbConnectionAdd);//выполнение команды
                        OleDbDataReader dbReaderRepotr = dbCommandReport2.ExecuteReader();

                        idReport = 0;//обнуляем сщётчик 
                        while (dbReaderRepotr.Read())
                        {
                            idReport = Convert.ToInt32(dbReaderRepotr["ID"]);
                            idReport++;
                        } 
                        
                        string queryAddReport = "INSERT INTO report VALUES(" + idReport + ",'" + manegerFIO + "','"+ FIO +"','" + Convert.ToString(DateTime.Now) + "')";
                        OleDbCommand dbCommandAddReport = new OleDbCommand(queryAddReport, dbConnectionAdd);

                        dbCommandAddReport.ExecuteNonQuery();//выполнение команды
                        dbReaderRepotr.Close();
                        
                    }

                    //закрытие соединения с БД
                    
                    dbConnectionAdd.Close();
                    buttonSave.Enabled = false;

                    break;
                case "toExtend":

                    if (textBoxFIO.Text == "" || maskedTextBoxPhone.MaskCompleted == false || dateTimePicker1.Value.ToShortDateString() == Convert.ToString(DateTime.Now.ToString("dd.MM.yyyy")) || comboBoxFIOCoach.Text == "")
                    {
                        MessageBox.Show("Не все данные введены", "Внимание!");
                        return;
                    }

                    string connectionStringToExtend = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = dataBase.accdb;";
                    OleDbConnection dbConnectionToExtend = new OleDbConnection(connectionStringToExtend);//создаём новое соеденение 

                    //выполнение запроса к БД
                    dbConnectionToExtend.Open();//открытие соеденения
                    string queryToExtend = "UPDATE customers SET service = '" + service + "',manager = '"+ manegerFIO +"',seasonTicketTo = '" + seasonTicketTo + "',TimeOfRegistration = '"+ Convert.ToString(DateTime.Now.ToString("dd.MM.yyyy")) + "' WHERE ID = " + id;//сам запрос
                    OleDbCommand dbCommandToExtend = new OleDbCommand(queryToExtend, dbConnectionToExtend);// команда

                    //выполнение запроса 
                    if (dbCommandToExtend.ExecuteNonQuery() != 1)//этот метот возвращает кол-во добавленных строк 
                    { MessageBox.Show("Ошибка выполнения запроса!", "Внимание!"); return; }
                    else
                    {
                        dataGridView1.Rows[index].Cells[4].Value = service;
                        dataGridView1.Rows[index].Cells[6].Value = seasonTicketTo;
                        dataGridView1.Rows[index].Cells[7].Value = manegerFIO;
                        dataGridView1.Rows[index].Cells[8].Value = Convert.ToString(DateTime.Now.ToString("dd.MM.yyyy"));
                        MessageBox.Show("Абонемент продлён!", "Готово!");
                    }

                    //закрытие соединения с БД
                   
                    buttonSave.Enabled = false;
                    buttonToExtend.Enabled = false;



                    //ниже добовление для таблицы в БД report (добовляем туда данные)
                    string queryReport3 = "SELECT [ID] FROM report WHERE ID = (SELECT MAX(ID) FROM report)";//беру максимальное значение в столце ID
                    OleDbCommand dbCommandReport3 = new OleDbCommand(queryReport3, dbConnectionToExtend);//выполнение команды
                    OleDbDataReader dbReaderRepotr3 = dbCommandReport3.ExecuteReader();

                    idReport = 0;//обнуляем сщётчик 
                    while (dbReaderRepotr3.Read())
                    {
                        idReport = Convert.ToInt32(dbReaderRepotr3["ID"]);
                        idReport++;
                    }

                    string queryAddReport3 = "INSERT INTO report VALUES(" + idReport + ",'" + manegerFIO + "','" + dataGridView1.Rows[index].Cells[1].Value.ToString() + "','" + Convert.ToString(DateTime.Now) + "')";
                    OleDbCommand dbCommandAddReport3 = new OleDbCommand(queryAddReport3, dbConnectionToExtend);
                    
                    
                    dbCommandAddReport3.ExecuteNonQuery();//выполнение команды
                    dbReaderRepotr3.Close();
                    dbConnectionToExtend.Close();

                    break;
                case "change":
                    if (textBoxFIO.Text == "" || maskedTextBoxPhone.MaskCompleted == false || dateTimePicker1.Value.ToShortDateString() == Convert.ToString(DateTime.Now.ToString("dd.MM.yyyy")) || comboBoxFIOCoach.Text == "")
                    {
                        MessageBox.Show("Не все данные введены", "Внимание!");
                        return;
                    }

                    //считываем данные
                    string fioChange = textBoxFIO.Text.ToString();
                    string phoneChange = maskedTextBoxPhone.Text.ToString();
                    string FIOCoachChange = comboBoxFIOCoach.Text.ToString();
                    string DateOfBirthChange = dateTimePicker1.Value.ToString("dd/MM/yyyy");

                    //соеденение с БД
                    string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = dataBase.accdb;";
                    OleDbConnection dbConnection = new OleDbConnection(connectionString);//создаём новое соеденение 

                    //выполнение запроса к БД
                    dbConnection.Open();//открытие соеденения
                    string query = "UPDATE customers SET ID = " + id + ", FIO = '" + fioChange + "', Phone = '" + phoneChange + "', DateOfBirth = '" + DateOfBirthChange + "', FIOCoach = '" + FIOCoachChange + "' WHERE ID = " + id;//сам запрос
                    OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);// команда

                    //выполнение запроса 
                    if (dbCommand.ExecuteNonQuery() != 1)//этот метот возвращает кол-во добавленных строк 
                    { MessageBox.Show("Ошибка выполнения запроса!", "Внимание!"); return; }
                    else
                    {
                        dataGridView1.Rows[index].Cells[0].Value = id;
                        dataGridView1.Rows[index].Cells[1].Value = fioChange;
                        dataGridView1.Rows[index].Cells[2].Value = phoneChange;
                        dataGridView1.Rows[index].Cells[3].Value = DateOfBirthChange;
                        dataGridView1.Rows[index].Cells[5].Value = FIOCoachChange;
                        MessageBox.Show("Данные изменены", "Готово!");
                    }

                    //закрытие соединения с БД
                    dbConnection.Close();

                    buttonSave.Enabled = false;
                    textBoxFIO.Enabled = false;
                    maskedTextBoxPhone.Enabled = false;
                    dateTimePicker1.Enabled = false;
                    comboBoxFIOCoach.Enabled = false;

                    break;

            }
        }
        private void buttonNewClient_Click(object sender, EventArgs e)
        {

            if (newClient.Text == "Выбрать Услугу  ")
            {

                if (textBoxFIO.Text == "" || maskedTextBoxPhone.MaskCompleted == false || dateTimePicker1.Value.ToShortDateString() == Convert.ToString(DateTime.Now.ToString("dd.MM.yyyy")) || comboBoxFIOCoach.Text == "")
                {
                    MessageBox.Show("Не все данные введены", "Внимание!");
                    return;
                }
                choosingService form2 = new choosingService(this);
                form2.ShowDialog();
                
                newClient.Text = "Новый клиент    ";
                str = "newClient";

                buttonDelete.Enabled = false;
                buttonChange.Enabled = false;

                return;
            }    
            textBoxFIO.Enabled = true;
            maskedTextBoxPhone.Enabled = true;
            dateTimePicker1.Enabled = true;
            comboBoxFIOCoach.Enabled = true;

            textBoxFIO.Text = "";
            maskedTextBoxPhone.Text = "";
            dateTimePicker1.Text = "";
            comboBoxFIOCoach.Text = "";

            buttonDelete.Enabled = false;
            buttonChange.Enabled = false;

            newClient.Text = "Выбрать Услугу  ";
        } 
        private void buttonToExtend_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Пожалуйста выберите только одну строку!", "Внимание!");
                return;
            }
            choosingService form2 = new choosingService(this);
            form2.ShowDialog();
            str = "toExtend";
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Пожалуйста выберите только одну строку!", "Внимание!");
                return;
            }
            textBoxFIO.Enabled = true;
            maskedTextBoxPhone.Enabled = true;
            dateTimePicker1.Enabled = true;
            comboBoxFIOCoach.Enabled = true;
            buttonSave.Enabled = true;

            str = "change";
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Owner.Show();
            presBack = true;
            this.Close();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Пожалуйста выберите только одну строку!", "Внимание!");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                dataGridView1.Rows[index].Selected = false;

                //соеденение с БД
                string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = dataBase.accdb;";
                OleDbConnection dbConnection = new OleDbConnection(connectionString);

                //выполнение запроса к БД
                dbConnection.Open();
                string query = "DELETE FROM customers WHERE ID = " + id;

                OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

                if (dbCommand.ExecuteNonQuery() != 1)
                { MessageBox.Show("Ошибка выполнения запроса!", "Внимание!"); dbConnection.Close(); return; }
                else
                {
                    int count = 0;
                    string queryCount = "SELECT * FROM customers";
                    OleDbCommand dbCommandCount = new OleDbCommand(queryCount, dbConnection);
                    OleDbDataReader dbReaderCount = dbCommandCount.ExecuteReader();

                    if (dbReaderCount.HasRows == false)
                    { id = 0; }
                    else
                    {
                        while (dbReaderCount.Read())
                        {
                            count++;
                        }
                    }//если данные считались 
                    dbReaderCount.Close();


                    dataGridView1.Rows.RemoveAt(index);
                    string queryUpdate = "UPDATE customers SET ID = 0 WHERE ID = " + id;
                    id++;
                    for (int i = id - 1; i < count; i++, id++)
                    {
                        queryUpdate = "UPDATE customers SET ID = " + i + " WHERE ID = " + id;
                        OleDbCommand dbCommandUpdate = new OleDbCommand(queryUpdate, dbConnection);
                        if (dbCommandUpdate.ExecuteNonQuery() != 1)
                        { MessageBox.Show("Ошибка выполнения запроса!", "Внимание!"); return; }

                        for (int j = 0; j < dataGridView1.Rows.Count; j++)
                        {
                            if (Convert.ToInt32(dataGridView1.Rows[j].Cells[0].Value) == id)
                            { dataGridView1.Rows[j].Cells[0].Value = i; }
                        }//ищем ячейку с изменённым ID в БД и если нашли то изменяем её в DGV
                    }//этот цикл меняет последовательность ID в БД и в dataGrideView
                     //меняем все id в БД которые идту после удалённого ID

                    MessageBox.Show("Данные Удалены", "Готово!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //закрытие соединения с БД
                dbConnection.Close();
            }
            buttonSave.Enabled = false;
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            presSearch = true;

            //соеденение с БД
            string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = dataBase.accdb;";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);//создаём новое соеденение 

            fioSearch = textBoxFIOSearch.Text;
            phoneSearch = maskedTextBoxPhoneSearch.Text;

            //выполнение запроса к БД
            dbConnection.Open();//открытие соеденения
            string query = "SELECT * FROM customers WHERE FIO LIKE '%" + fioSearch + "%' or Phone ='"+ phoneSearch + "'";//сам запрос
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);// команда
            OleDbDataReader dbReader = dbCommand.ExecuteReader();//считывание данных

            //проверяем данные
            if (dbReader.HasRows == false)
            {
                MessageBox.Show("Таких данных нет", "Внимание!");
            }
            else
            {
                while (dbReader.Read())
                {
                    dataGridView1.Rows.Add(dbReader["ID"], dbReader["FIO"], dbReader["Phone"], dbReader["DateOfBirth"], dbReader["Service"], dbReader["FIOCoach"], dbReader["seasonTicketTo"], dbReader["manager"], dbReader["TimeOfRegistration"]);
                    id++;
                }
            }//если данные считались 

            string query2 = "SELECT * FROM theCoach WHERE post = 'Тренер'";
            OleDbCommand dbCommand2 = new OleDbCommand(query2, dbConnection);//выполнение команды
            OleDbDataReader dbReader2 = dbCommand2.ExecuteReader();

            while (dbReader2.Read())
            {
                comboBoxFIOCoach.Items.Add(Convert.ToString(dbReader2["ID"]));
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                try
                {
                    if (DateTime.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString()) <= DateTime.Now)
                    {
                        dataGridView1.Rows[i].Cells[6].Value = "Просрочен";
                    }
                }
                catch { }
            } //проверка на просроченность абонемента(эти данные где написанно просрочен не синхронизированны с БД)
              //то есть надпись просрочен отображается только в dataGrideView ("просрочен" только для удобства пользователя)

            //закрытие соеденения с БД
            dbReader.Close();
            dbReader2.Close();
            dbConnection.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            comboBoxFIOCoach.Items.Clear();
            comboBoxFIOCoach.Items.Add("Самостоятельно");
            presSearch = false;
            this.dataGridView1.Rows.Clear();
            newClient.Enabled = true;
            FormCustomers_Load(sender, e);
        }
        private void FormCustomers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (presBack == false)
                Application.Exit();
        }
        public void setService(string service)
        { 
            this.service = service;
        }//устанавливает значение Услуги
        public void setseasonTicketTo(string seasonTicketTo)
        {
            this.seasonTicketTo = seasonTicketTo;
        }//устанавливает Абонемент До
        public void setButtonSaveEnabled(bool a)
        { 
            buttonSave.Enabled = a;
        }//устанавливает enabled кнопки сохранить

    }
}
