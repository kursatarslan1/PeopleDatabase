namespace PeopleDatabase
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
            this.components = new System.ComponentModel.Container();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.btnMinimized = new System.Windows.Forms.Button();
            this.btnMaximized = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.btnAddPeople = new System.Windows.Forms.Button();
            this.btnAllPeople = new System.Windows.Forms.Button();
            this.pnlTopSideBar = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlMiddle = new System.Windows.Forms.Panel();
            this.btnGetLogs = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıpAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peopleLogDataSet = new PeopleDatabase.PeopleLogDataSet();
            this.logTableAdapter = new PeopleDatabase.PeopleLogDataSetTableAdapters.logTableAdapter();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTopBar.SuspendLayout();
            this.pnlSideBar.SuspendLayout();
            this.pnlTopSideBar.SuspendLayout();
            this.pnlMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleLogDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlTopBar.Controls.Add(this.btnMinimized);
            this.pnlTopBar.Controls.Add(this.btnMaximized);
            this.pnlTopBar.Controls.Add(this.btnExit);
            this.pnlTopBar.Controls.Add(this.btnCloseChildForm);
            this.pnlTopBar.Controls.Add(this.lblTitle);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(872, 91);
            this.pnlTopBar.TabIndex = 0;
            this.pnlTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseDown);
            // 
            // btnMinimized
            // 
            this.btnMinimized.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimized.FlatAppearance.BorderSize = 0;
            this.btnMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimized.Location = new System.Drawing.Point(710, 0);
            this.btnMinimized.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(52, 91);
            this.btnMinimized.TabIndex = 3;
            this.btnMinimized.Text = "_";
            this.btnMinimized.UseVisualStyleBackColor = true;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // btnMaximized
            // 
            this.btnMaximized.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximized.FlatAppearance.BorderSize = 0;
            this.btnMaximized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximized.Location = new System.Drawing.Point(762, 0);
            this.btnMaximized.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximized.Name = "btnMaximized";
            this.btnMaximized.Size = new System.Drawing.Size(55, 91);
            this.btnMaximized.TabIndex = 2;
            this.btnMaximized.Text = "O";
            this.btnMaximized.UseVisualStyleBackColor = true;
            this.btnMaximized.Click += new System.EventHandler(this.btnMaximized_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(817, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(55, 91);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(84, 91);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.Text = "X";
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(336, 36);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(153, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PEOPLE DATABASE";
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.IndianRed;
            this.pnlSideBar.Controls.Add(this.btnAddPeople);
            this.pnlSideBar.Controls.Add(this.btnAllPeople);
            this.pnlSideBar.Controls.Add(this.pnlTopSideBar);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(254, 638);
            this.pnlSideBar.TabIndex = 1;
            // 
            // btnAddPeople
            // 
            this.btnAddPeople.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddPeople.FlatAppearance.BorderSize = 0;
            this.btnAddPeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPeople.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPeople.Location = new System.Drawing.Point(0, 203);
            this.btnAddPeople.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPeople.Name = "btnAddPeople";
            this.btnAddPeople.Size = new System.Drawing.Size(254, 79);
            this.btnAddPeople.TabIndex = 5;
            this.btnAddPeople.Text = "Add People";
            this.btnAddPeople.UseVisualStyleBackColor = true;
            this.btnAddPeople.Click += new System.EventHandler(this.btnAddPeople_Click);
            // 
            // btnAllPeople
            // 
            this.btnAllPeople.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllPeople.FlatAppearance.BorderSize = 0;
            this.btnAllPeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllPeople.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllPeople.Location = new System.Drawing.Point(0, 124);
            this.btnAllPeople.Margin = new System.Windows.Forms.Padding(2);
            this.btnAllPeople.Name = "btnAllPeople";
            this.btnAllPeople.Size = new System.Drawing.Size(254, 79);
            this.btnAllPeople.TabIndex = 4;
            this.btnAllPeople.Text = "All People";
            this.btnAllPeople.UseVisualStyleBackColor = true;
            this.btnAllPeople.Click += new System.EventHandler(this.btnAllPeople_Click);
            // 
            // pnlTopSideBar
            // 
            this.pnlTopSideBar.Controls.Add(this.lblLogo);
            this.pnlTopSideBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopSideBar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTopSideBar.Name = "pnlTopSideBar";
            this.pnlTopSideBar.Size = new System.Drawing.Size(254, 124);
            this.pnlTopSideBar.TabIndex = 1;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(94, 47);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(56, 23);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "LOGO";
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.Controls.Add(this.label1);
            this.pnlMiddle.Controls.Add(this.txtBoxSearch);
            this.pnlMiddle.Controls.Add(this.btnGetLogs);
            this.pnlMiddle.Controls.Add(this.dataGridView1);
            this.pnlMiddle.Controls.Add(this.pnlTopBar);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddle.Location = new System.Drawing.Point(254, 0);
            this.pnlMiddle.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(872, 638);
            this.pnlMiddle.TabIndex = 2;
            // 
            // btnGetLogs
            // 
            this.btnGetLogs.Location = new System.Drawing.Point(710, 124);
            this.btnGetLogs.Name = "btnGetLogs";
            this.btnGetLogs.Size = new System.Drawing.Size(125, 42);
            this.btnGetLogs.TabIndex = 2;
            this.btnGetLogs.Text = "Get Logs";
            this.btnGetLogs.UseVisualStyleBackColor = true;
            this.btnGetLogs.Click += new System.EventHandler(this.btnGetLogs_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıpAddressDataGridViewTextBoxColumn,
            this.processDataGridViewTextBoxColumn,
            this.changeDateDataGridViewTextBoxColumn,
            this.changeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.logBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(5, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(855, 422);
            this.dataGridView1.TabIndex = 1;
            // 
            // ıpAddressDataGridViewTextBoxColumn
            // 
            this.ıpAddressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ıpAddressDataGridViewTextBoxColumn.DataPropertyName = "IpAddress";
            this.ıpAddressDataGridViewTextBoxColumn.HeaderText = "IpAddress";
            this.ıpAddressDataGridViewTextBoxColumn.Name = "ıpAddressDataGridViewTextBoxColumn";
            // 
            // processDataGridViewTextBoxColumn
            // 
            this.processDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.processDataGridViewTextBoxColumn.DataPropertyName = "Process";
            this.processDataGridViewTextBoxColumn.HeaderText = "Process";
            this.processDataGridViewTextBoxColumn.Name = "processDataGridViewTextBoxColumn";
            // 
            // changeDateDataGridViewTextBoxColumn
            // 
            this.changeDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.changeDateDataGridViewTextBoxColumn.DataPropertyName = "ChangeDate";
            this.changeDateDataGridViewTextBoxColumn.HeaderText = "ChangeDate";
            this.changeDateDataGridViewTextBoxColumn.Name = "changeDateDataGridViewTextBoxColumn";
            // 
            // changeDataGridViewTextBoxColumn
            // 
            this.changeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.changeDataGridViewTextBoxColumn.DataPropertyName = "Change";
            this.changeDataGridViewTextBoxColumn.HeaderText = "Change";
            this.changeDataGridViewTextBoxColumn.Name = "changeDataGridViewTextBoxColumn";
            // 
            // logBindingSource
            // 
            this.logBindingSource.DataMember = "log";
            this.logBindingSource.DataSource = this.peopleLogDataSet;
            // 
            // peopleLogDataSet
            // 
            this.peopleLogDataSet.DataSetName = "PeopleLogDataSet";
            this.peopleLogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logTableAdapter
            // 
            this.logTableAdapter.ClearBeforeFill = true;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(110, 140);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(288, 20);
            this.txtBoxSearch.TabIndex = 3;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1126, 638);
            this.Controls.Add(this.pnlMiddle);
            this.Controls.Add(this.pnlSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "People Database";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlSideBar.ResumeLayout(false);
            this.pnlTopSideBar.ResumeLayout(false);
            this.pnlTopSideBar.PerformLayout();
            this.pnlMiddle.ResumeLayout(false);
            this.pnlMiddle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleLogDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Panel pnlMiddle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddPeople;
        private System.Windows.Forms.Button btnAllPeople;
        private System.Windows.Forms.Panel pnlTopSideBar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimized;
        private System.Windows.Forms.Button btnMaximized;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PeopleLogDataSet peopleLogDataSet;
        private System.Windows.Forms.BindingSource logBindingSource;
        private PeopleLogDataSetTableAdapters.logTableAdapter logTableAdapter;
        private System.Windows.Forms.Button btnGetLogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıpAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn processDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Label label1;
    }
}

