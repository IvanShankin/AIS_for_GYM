namespace Gym
{
    partial class choosingService
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSuitableFor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonChooesService = new System.Windows.Forms.Button();
            this.buttonCancellation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(219)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnService,
            this.ColumnPrise,
            this.ColumnSuitableFor});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(219)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(553, 307);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.Visible = false;
            // 
            // ColumnService
            // 
            this.ColumnService.HeaderText = "Услуга";
            this.ColumnService.Name = "ColumnService";
            this.ColumnService.ReadOnly = true;
            this.ColumnService.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnService.Width = 300;
            // 
            // ColumnPrise
            // 
            this.ColumnPrise.HeaderText = "Цена";
            this.ColumnPrise.Name = "ColumnPrise";
            this.ColumnPrise.ReadOnly = true;
            this.ColumnPrise.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnPrise.Width = 125;
            // 
            // ColumnSuitableFor
            // 
            this.ColumnSuitableFor.HeaderText = "Годен на";
            this.ColumnSuitableFor.Name = "ColumnSuitableFor";
            this.ColumnSuitableFor.ReadOnly = true;
            this.ColumnSuitableFor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnSuitableFor.Width = 125;
            // 
            // buttonChooesService
            // 
            this.buttonChooesService.Enabled = false;
            this.buttonChooesService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChooesService.Location = new System.Drawing.Point(13, 325);
            this.buttonChooesService.Name = "buttonChooesService";
            this.buttonChooesService.Size = new System.Drawing.Size(135, 36);
            this.buttonChooesService.TabIndex = 1;
            this.buttonChooesService.Text = "Выбрать услугу";
            this.buttonChooesService.UseVisualStyleBackColor = true;
            this.buttonChooesService.Click += new System.EventHandler(this.buttonChooesService_Click);
            // 
            // buttonCancellation
            // 
            this.buttonCancellation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancellation.Location = new System.Drawing.Point(430, 325);
            this.buttonCancellation.Name = "buttonCancellation";
            this.buttonCancellation.Size = new System.Drawing.Size(135, 36);
            this.buttonCancellation.TabIndex = 2;
            this.buttonCancellation.Text = "Отмена";
            this.buttonCancellation.UseVisualStyleBackColor = true;
            this.buttonCancellation.Click += new System.EventHandler(this.buttonCancellation_Click);
            // 
            // choosingService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 373);
            this.Controls.Add(this.buttonCancellation);
            this.Controls.Add(this.buttonChooesService);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(594, 412);
            this.MinimumSize = new System.Drawing.Size(594, 412);
            this.Name = "choosingService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор услуги";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.choosingService_FormClosing);
            this.Load += new System.EventHandler(this.choosingService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonChooesService;
        private System.Windows.Forms.Button buttonCancellation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnService;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrise;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSuitableFor;
    }
}