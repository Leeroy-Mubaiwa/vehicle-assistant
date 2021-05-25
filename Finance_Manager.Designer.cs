namespace Transnational_Auto_3
{
    partial class Finance_Manager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Finance_Manager));
            this.transactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transnational_Auto_3DataSet = new Transnational_Auto_3.Transnational_Auto_3DataSet();
            this.transactionsTableAdapter = new Transnational_Auto_3.Transnational_Auto_3DataSetTableAdapters.TransactionsTableAdapter();
            this.tableAdapterManager = new Transnational_Auto_3.Transnational_Auto_3DataSetTableAdapters.TableAdapterManager();
            this.timer_Balance = new System.Windows.Forms.Timer(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnsave_transactions = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btndebit = new System.Windows.Forms.Button();
            this.btntotaldiff = new System.Windows.Forms.Button();
            this.btncredit = new System.Windows.Forms.Button();
            this.transactionsdataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companycodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xuiFlatTab1 = new XanderUI.XUIFlatTab();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transnational_Auto_3DataSet)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsdataGridView)).BeginInit();
            this.xuiFlatTab1.SuspendLayout();
            this.SuspendLayout();
            // 
            // transactionsBindingSource
            // 
            this.transactionsBindingSource.DataMember = "Transactions";
            this.transactionsBindingSource.DataSource = this.transnational_Auto_3DataSet;
            // 
            // transnational_Auto_3DataSet
            // 
            this.transnational_Auto_3DataSet.DataSetName = "Transnational_Auto_3DataSet";
            this.transnational_Auto_3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionsTableAdapter
            // 
            this.transactionsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthenticationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompanyTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.Invoice_DescriptionTableAdapter = null;
            this.tableAdapterManager.InvoicesTableAdapter = null;
            this.tableAdapterManager.PositionsTableAdapter = null;
            this.tableAdapterManager.Quotation_DescriptionTableAdapter = null;
            this.tableAdapterManager.QuotationTableAdapter = null;
            this.tableAdapterManager.SalaryTableAdapter = null;
            this.tableAdapterManager.ServicesSubCategoriesTableAdapter = null;
            this.tableAdapterManager.ServicesTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.StockTypesTableAdapter = null;
            this.tableAdapterManager.TransactionsTableAdapter = this.transactionsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Transnational_Auto_3.Transnational_Auto_3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehiclesTableAdapter = null;
            // 
            // timer_Balance
            // 
            this.timer_Balance.Tick += new System.EventHandler(this.timer_Balance_Tick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 20);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1056, 697);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.btnsave_transactions);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.transactionsdataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 20);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage1.Size = new System.Drawing.Size(1056, 697);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // btnsave_transactions
            // 
            this.btnsave_transactions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsave_transactions.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnsave_transactions.FlatAppearance.BorderSize = 0;
            this.btnsave_transactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave_transactions.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.btnsave_transactions.ForeColor = System.Drawing.Color.White;
            this.btnsave_transactions.Location = new System.Drawing.Point(885, 73);
            this.btnsave_transactions.Name = "btnsave_transactions";
            this.btnsave_transactions.Size = new System.Drawing.Size(129, 23);
            this.btnsave_transactions.TabIndex = 27;
            this.btnsave_transactions.Text = "Save Changes";
            this.btnsave_transactions.UseVisualStyleBackColor = false;
            this.btnsave_transactions.Click += new System.EventHandler(this.btnsave_transactions_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btndebit);
            this.panel1.Controls.Add(this.btntotaldiff);
            this.panel1.Controls.Add(this.btncredit);
            this.panel1.Location = new System.Drawing.Point(22, 566);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 75);
            this.panel1.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Algerian", 13F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(767, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "$";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Algerian", 13F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(768, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "$";
            // 
            // btndebit
            // 
            this.btndebit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btndebit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btndebit.FlatAppearance.BorderSize = 0;
            this.btndebit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndebit.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.btndebit.ForeColor = System.Drawing.Color.White;
            this.btndebit.Location = new System.Drawing.Point(794, 1);
            this.btndebit.Name = "btndebit";
            this.btndebit.Size = new System.Drawing.Size(99, 35);
            this.btndebit.TabIndex = 28;
            this.btndebit.Text = "0";
            this.btndebit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndebit.UseVisualStyleBackColor = false;
            // 
            // btntotaldiff
            // 
            this.btntotaldiff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btntotaldiff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(155)))), ((int)(((byte)(235)))));
            this.btntotaldiff.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btntotaldiff.FlatAppearance.BorderSize = 0;
            this.btntotaldiff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntotaldiff.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.btntotaldiff.ForeColor = System.Drawing.Color.White;
            this.btntotaldiff.Location = new System.Drawing.Point(794, 36);
            this.btntotaldiff.Name = "btntotaldiff";
            this.btntotaldiff.Size = new System.Drawing.Size(198, 35);
            this.btntotaldiff.TabIndex = 27;
            this.btntotaldiff.Text = "0";
            this.btntotaldiff.UseVisualStyleBackColor = false;
            // 
            // btncredit
            // 
            this.btncredit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncredit.BackColor = System.Drawing.Color.Tomato;
            this.btncredit.FlatAppearance.BorderSize = 0;
            this.btncredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncredit.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.btncredit.ForeColor = System.Drawing.Color.White;
            this.btncredit.Location = new System.Drawing.Point(893, 1);
            this.btncredit.Name = "btncredit";
            this.btncredit.Size = new System.Drawing.Size(99, 35);
            this.btncredit.TabIndex = 27;
            this.btncredit.Text = "0";
            this.btncredit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncredit.UseVisualStyleBackColor = false;
            // 
            // transactionsdataGridView
            // 
            this.transactionsdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionsdataGridView.AutoGenerateColumns = false;
            this.transactionsdataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.transactionsdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transactionsdataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.transactionsdataGridView.ColumnHeadersHeight = 30;
            this.transactionsdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.companycodeDataGridViewTextBoxColumn,
            this.desriptionDataGridViewTextBoxColumn,
            this.sourceDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.debitDataGridViewTextBoxColumn,
            this.creditDataGridViewTextBoxColumn});
            this.transactionsdataGridView.DataSource = this.transactionsBindingSource;
            this.transactionsdataGridView.EnableHeadersVisualStyles = false;
            this.transactionsdataGridView.GridColor = System.Drawing.Color.WhiteSmoke;
            this.transactionsdataGridView.Location = new System.Drawing.Point(22, 102);
            this.transactionsdataGridView.Name = "transactionsdataGridView";
            this.transactionsdataGridView.RowHeadersVisible = false;
            this.transactionsdataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.transactionsdataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.transactionsdataGridView.RowTemplate.Height = 25;
            this.transactionsdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transactionsdataGridView.Size = new System.Drawing.Size(992, 463);
            this.transactionsdataGridView.TabIndex = 25;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // companycodeDataGridViewTextBoxColumn
            // 
            this.companycodeDataGridViewTextBoxColumn.DataPropertyName = "company_code";
            this.companycodeDataGridViewTextBoxColumn.HeaderText = "Com Code";
            this.companycodeDataGridViewTextBoxColumn.Name = "companycodeDataGridViewTextBoxColumn";
            // 
            // desriptionDataGridViewTextBoxColumn
            // 
            this.desriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.desriptionDataGridViewTextBoxColumn.DataPropertyName = "desription";
            this.desriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.desriptionDataGridViewTextBoxColumn.Name = "desriptionDataGridViewTextBoxColumn";
            // 
            // sourceDataGridViewTextBoxColumn
            // 
            this.sourceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sourceDataGridViewTextBoxColumn.DataPropertyName = "source";
            this.sourceDataGridViewTextBoxColumn.HeaderText = "Source";
            this.sourceDataGridViewTextBoxColumn.Name = "sourceDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // debitDataGridViewTextBoxColumn
            // 
            this.debitDataGridViewTextBoxColumn.DataPropertyName = "debit";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = "0";
            this.debitDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.debitDataGridViewTextBoxColumn.HeaderText = "Income";
            this.debitDataGridViewTextBoxColumn.Name = "debitDataGridViewTextBoxColumn";
            // 
            // creditDataGridViewTextBoxColumn
            // 
            this.creditDataGridViewTextBoxColumn.DataPropertyName = "credit";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0";
            this.creditDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.creditDataGridViewTextBoxColumn.HeaderText = "Expense";
            this.creditDataGridViewTextBoxColumn.Name = "creditDataGridViewTextBoxColumn";
            // 
            // xuiFlatTab1
            // 
            this.xuiFlatTab1.ActiveHeaderColor = System.Drawing.Color.RoyalBlue;
            this.xuiFlatTab1.ActiveTextColor = System.Drawing.Color.White;
            this.xuiFlatTab1.BorderColor = System.Drawing.Color.White;
            this.xuiFlatTab1.Controls.Add(this.tabPage1);
            this.xuiFlatTab1.Controls.Add(this.tabPage2);
            this.xuiFlatTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFlatTab1.HeaderBackgroundColor = System.Drawing.Color.White;
            this.xuiFlatTab1.InActiveHeaderColor = System.Drawing.Color.WhiteSmoke;
            this.xuiFlatTab1.InActiveTextColor = System.Drawing.Color.WhiteSmoke;
            this.xuiFlatTab1.ItemSize = new System.Drawing.Size(240, 16);
            this.xuiFlatTab1.Location = new System.Drawing.Point(0, 0);
            this.xuiFlatTab1.Name = "xuiFlatTab1";
            this.xuiFlatTab1.PageColor = System.Drawing.Color.White;
            this.xuiFlatTab1.SelectedIndex = 0;
            this.xuiFlatTab1.ShowBorder = false;
            this.xuiFlatTab1.Size = new System.Drawing.Size(1064, 721);
            this.xuiFlatTab1.TabIndex = 28;
            // 
            // Finance_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 721);
            this.Controls.Add(this.xuiFlatTab1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Finance_Manager";
            this.Text = "Finance_Manager";
            this.Load += new System.EventHandler(this.Finance_Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transnational_Auto_3DataSet)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsdataGridView)).EndInit();
            this.xuiFlatTab1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Transnational_Auto_3DataSet transnational_Auto_3DataSet;
        private System.Windows.Forms.BindingSource transactionsBindingSource;
        private Transnational_Auto_3DataSetTableAdapters.TransactionsTableAdapter transactionsTableAdapter;
        private Transnational_Auto_3DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Timer timer_Balance;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnsave_transactions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndebit;
        private System.Windows.Forms.Button btntotaldiff;
        private System.Windows.Forms.Button btncredit;
        private System.Windows.Forms.DataGridView transactionsdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companycodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditDataGridViewTextBoxColumn;
        private XanderUI.XUIFlatTab xuiFlatTab1;
    }
}