namespace Gym
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.coach = new System.Windows.Forms.Button();
            this.seasonTickets = new System.Windows.Forms.Button();
            this.clients = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // coach
            // 
            this.coach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.coach.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("coach.BackgroundImage")));
            this.coach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.coach.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coach.ForeColor = System.Drawing.Color.White;
            this.coach.Location = new System.Drawing.Point(450, 308);
            this.coach.Name = "coach";
            this.coach.Size = new System.Drawing.Size(428, 253);
            this.coach.TabIndex = 2;
            this.coach.Text = "Персонал";
            this.coach.UseVisualStyleBackColor = false;
            this.coach.Click += new System.EventHandler(this.coach_Click);
            // 
            // seasonTickets
            // 
            this.seasonTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.seasonTickets.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("seasonTickets.BackgroundImage")));
            this.seasonTickets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.seasonTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seasonTickets.ForeColor = System.Drawing.Color.White;
            this.seasonTickets.Location = new System.Drawing.Point(450, 52);
            this.seasonTickets.Name = "seasonTickets";
            this.seasonTickets.Size = new System.Drawing.Size(209, 250);
            this.seasonTickets.TabIndex = 1;
            this.seasonTickets.Text = "Услуги";
            this.seasonTickets.UseVisualStyleBackColor = false;
            this.seasonTickets.Click += new System.EventHandler(this.seasonTickets_Click);
            // 
            // clients
            // 
            this.clients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.clients.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clients.BackgroundImage")));
            this.clients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clients.ForeColor = System.Drawing.Color.White;
            this.clients.Location = new System.Drawing.Point(12, 52);
            this.clients.Name = "clients";
            this.clients.Size = new System.Drawing.Size(432, 509);
            this.clients.TabIndex = 0;
            this.clients.Text = "Клиенты";
            this.clients.UseVisualStyleBackColor = false;
            this.clients.Click += new System.EventHandler(this.clients_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(669, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 250);
            this.button1.TabIndex = 3;
            this.button1.Text = "Отчёт";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(13, 13);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(128, 33);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Выход";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(890, 603);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.coach);
            this.Controls.Add(this.seasonTickets);
            this.Controls.Add(this.clients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(890, 603);
            this.MinimumSize = new System.Drawing.Size(890, 603);
            this.Name = "MainForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clients;
        private System.Windows.Forms.Button seasonTickets;
        private System.Windows.Forms.Button coach;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonClose;
    }
}