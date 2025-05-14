namespace Gym
{
    partial class FormCustomers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnServices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIDCoach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSeasonTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnManager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTimeOfRegistration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxFIOSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxFIOCoach = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonToExtend = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.maskedTextBoxPhoneSearch = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBack.BackgroundImage")));
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(1094, 625);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(127, 32);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.Text = "Назад      ";
            this.buttonBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSave.BackgroundImage")));
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSave.Enabled = false;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(901, 625);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(187, 32);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Сохранить        ";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(219)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnFIO,
            this.ColumnPhone,
            this.ColumnDate,
            this.ColumnServices,
            this.ColumnIDCoach,
            this.ColumnSeasonTicket,
            this.ColumnManager,
            this.ColumnTimeOfRegistration});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(219)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 52);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1209, 496);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Width = 40;
            // 
            // ColumnFIO
            // 
            this.ColumnFIO.HeaderText = "ФИО";
            this.ColumnFIO.Name = "ColumnFIO";
            this.ColumnFIO.ReadOnly = true;
            this.ColumnFIO.Width = 370;
            // 
            // ColumnPhone
            // 
            this.ColumnPhone.HeaderText = "Телефон";
            this.ColumnPhone.Name = "ColumnPhone";
            this.ColumnPhone.ReadOnly = true;
            this.ColumnPhone.Width = 150;
            // 
            // ColumnDate
            // 
            this.ColumnDate.HeaderText = "Дата рождения";
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            // 
            // ColumnServices
            // 
            this.ColumnServices.HeaderText = "Услуга";
            this.ColumnServices.Name = "ColumnServices";
            this.ColumnServices.ReadOnly = true;
            this.ColumnServices.Width = 260;
            // 
            // ColumnIDCoach
            // 
            this.ColumnIDCoach.HeaderText = "ID тренера";
            this.ColumnIDCoach.Name = "ColumnIDCoach";
            this.ColumnIDCoach.Width = 130;
            // 
            // ColumnSeasonTicket
            // 
            this.ColumnSeasonTicket.HeaderText = "Абонемент до";
            this.ColumnSeasonTicket.Name = "ColumnSeasonTicket";
            this.ColumnSeasonTicket.ReadOnly = true;
            this.ColumnSeasonTicket.Width = 135;
            // 
            // ColumnManager
            // 
            this.ColumnManager.HeaderText = "ФИО Менеджера оформивший заказ";
            this.ColumnManager.Name = "ColumnManager";
            this.ColumnManager.ReadOnly = true;
            this.ColumnManager.Visible = false;
            // 
            // ColumnTimeOfRegistration
            // 
            this.ColumnTimeOfRegistration.HeaderText = "Время оформления заказа";
            this.ColumnTimeOfRegistration.Name = "ColumnTimeOfRegistration";
            this.ColumnTimeOfRegistration.ReadOnly = true;
            this.ColumnTimeOfRegistration.Visible = false;
            // 
            // newClient
            // 
            this.newClient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newClient.BackgroundImage")));
            this.newClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.newClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newClient.Location = new System.Drawing.Point(901, 558);
            this.newClient.Name = "newClient";
            this.newClient.Size = new System.Drawing.Size(187, 32);
            this.newClient.TabIndex = 10;
            this.newClient.Text = "Новый клиент    ";
            this.newClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newClient.UseVisualStyleBackColor = true;
            this.newClient.Click += new System.EventHandler(this.buttonNewClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 558);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "ФИО:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 610);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Телефон:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(170, 610);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Дата рождения:";
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Enabled = false;
            this.textBoxFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFIO.Location = new System.Drawing.Point(12, 580);
            this.textBoxFIO.Multiline = true;
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(503, 25);
            this.textBoxFIO.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(170, 637);
            this.dateTimePicker1.MaxDate = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.MaximumSize = new System.Drawing.Size(1000, 25);
            this.dateTimePicker1.MinDate = new System.DateTime(1924, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSearch.BackgroundImage")));
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(417, 21);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(133, 25);
            this.buttonSearch.TabIndex = 17;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxFIOSearch
            // 
            this.textBoxFIOSearch.Location = new System.Drawing.Point(48, 24);
            this.textBoxFIOSearch.Name = "textBoxFIOSearch";
            this.textBoxFIOSearch.Size = new System.Drawing.Size(242, 20);
            this.textBoxFIOSearch.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(45, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "ФИО:";
            // 
            // comboBoxFIOCoach
            // 
            this.comboBoxFIOCoach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFIOCoach.Enabled = false;
            this.comboBoxFIOCoach.FormattingEnabled = true;
            this.comboBoxFIOCoach.Items.AddRange(new object[] {
            "Самостоятельно"});
            this.comboBoxFIOCoach.Location = new System.Drawing.Point(350, 637);
            this.comboBoxFIOCoach.Name = "comboBoxFIOCoach";
            this.comboBoxFIOCoach.Size = new System.Drawing.Size(236, 21);
            this.comboBoxFIOCoach.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 615);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "ФИО прекреплённого тренера: ";
            // 
            // buttonToExtend
            // 
            this.buttonToExtend.Enabled = false;
            this.buttonToExtend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToExtend.Location = new System.Drawing.Point(901, 592);
            this.buttonToExtend.Name = "buttonToExtend";
            this.buttonToExtend.Size = new System.Drawing.Size(187, 32);
            this.buttonToExtend.TabIndex = 24;
            this.buttonToExtend.Text = "Продлить абонемент";
            this.buttonToExtend.UseVisualStyleBackColor = true;
            this.buttonToExtend.Click += new System.EventHandler(this.buttonToExtend_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(12, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 25);
            this.button1.TabIndex = 25;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(293, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Телефон:";
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(12, 631);
            this.maskedTextBoxPhone.Mask = "+7 000 000-00-00";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(141, 26);
            this.maskedTextBoxPhone.TabIndex = 26;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDelete.BackgroundImage")));
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(1094, 592);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(127, 32);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Удалить  ";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonChange.BackgroundImage")));
            this.buttonChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonChange.Enabled = false;
            this.buttonChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChange.Location = new System.Drawing.Point(1094, 558);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(127, 32);
            this.buttonChange.TabIndex = 7;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // maskedTextBoxPhoneSearch
            // 
            this.maskedTextBoxPhoneSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxPhoneSearch.Location = new System.Drawing.Point(296, 24);
            this.maskedTextBoxPhoneSearch.Mask = "+7 000 000-00-00";
            this.maskedTextBoxPhoneSearch.Name = "maskedTextBoxPhoneSearch";
            this.maskedTextBoxPhoneSearch.Size = new System.Drawing.Size(115, 22);
            this.maskedTextBoxPhoneSearch.TabIndex = 27;
            // 
            // FormCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1233, 669);
            this.Controls.Add(this.maskedTextBoxPhoneSearch);
            this.Controls.Add(this.maskedTextBoxPhone);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonToExtend);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxFIOCoach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFIOSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newClient);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(1249, 708);
            this.MinimumSize = new System.Drawing.Size(1249, 708);
            this.Name = "FormCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCustomers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCustomers_FormClosing);
            this.Load += new System.EventHandler(this.FormCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button newClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxFIOSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxFIOCoach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonToExtend;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhoneSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDCoach;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSeasonTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTimeOfRegistration;
    }
}