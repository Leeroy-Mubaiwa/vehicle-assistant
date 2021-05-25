namespace Transnational_Auto_3
{
    partial class StockType
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label descriptionLabel;
            this.servicesDatagridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transnational_Auto_3DataSet = new Transnational_Auto_3.Transnational_Auto_3DataSet();
            this.btndeletestock = new System.Windows.Forms.Button();
            this.btnreturn = new System.Windows.Forms.Button();
            this.stockTypesTableAdapter = new Transnational_Auto_3.Transnational_Auto_3DataSetTableAdapters.StockTypesTableAdapter();
            this.tableAdapterManager = new Transnational_Auto_3.Transnational_Auto_3DataSetTableAdapters.TableAdapterManager();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.btnaddstock = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDatagridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transnational_Auto_3DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 66);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 19);
            idLabel.TabIndex = 15;
            idLabel.Text = "id:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(12, 97);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(78, 19);
            descriptionLabel.TabIndex = 17;
            descriptionLabel.Text = "description:";
            // 
            // servicesDatagridView
            // 
            this.servicesDatagridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.servicesDatagridView.AutoGenerateColumns = false;
            this.servicesDatagridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.servicesDatagridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.servicesDatagridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.servicesDatagridView.ColumnHeadersHeight = 30;
            this.servicesDatagridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.servicesDatagridView.DataSource = this.stockTypesBindingSource;
            this.servicesDatagridView.EnableHeadersVisualStyles = false;
            this.servicesDatagridView.GridColor = System.Drawing.Color.WhiteSmoke;
            this.servicesDatagridView.Location = new System.Drawing.Point(16, 160);
            this.servicesDatagridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.servicesDatagridView.Name = "servicesDatagridView";
            this.servicesDatagridView.RowHeadersVisible = false;
            this.servicesDatagridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.servicesDatagridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.servicesDatagridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.servicesDatagridView.Size = new System.Drawing.Size(912, 381);
            this.servicesDatagridView.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // stockTypesBindingSource
            // 
            this.stockTypesBindingSource.DataMember = "StockTypes";
            this.stockTypesBindingSource.DataSource = this.transnational_Auto_3DataSet;
            // 
            // transnational_Auto_3DataSet
            // 
            this.transnational_Auto_3DataSet.DataSetName = "Transnational_Auto_3DataSet";
            this.transnational_Auto_3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btndeletestock
            // 
            this.btndeletestock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btndeletestock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btndeletestock.FlatAppearance.BorderSize = 0;
            this.btndeletestock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeletestock.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.btndeletestock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.btndeletestock.Location = new System.Drawing.Point(656, 549);
            this.btndeletestock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btndeletestock.Name = "btndeletestock";
            this.btndeletestock.Size = new System.Drawing.Size(133, 38);
            this.btndeletestock.TabIndex = 14;
            this.btndeletestock.Text = "Delete";
            this.btndeletestock.UseVisualStyleBackColor = false;
            this.btndeletestock.Click += new System.EventHandler(this.btndeletestock_Click);
            // 
            // btnreturn
            // 
            this.btnreturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnreturn.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnreturn.FlatAppearance.BorderSize = 0;
            this.btnreturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreturn.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.btnreturn.ForeColor = System.Drawing.Color.White;
            this.btnreturn.Location = new System.Drawing.Point(795, 549);
            this.btnreturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(133, 38);
            this.btnreturn.TabIndex = 15;
            this.btnreturn.Text = "Save all and return";
            this.btnreturn.UseVisualStyleBackColor = false;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // stockTypesTableAdapter
            // 
            this.stockTypesTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.StockTypesTableAdapter = this.stockTypesTableAdapter;
            this.tableAdapterManager.TransactionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Transnational_Auto_3.Transnational_Auto_3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehiclesTableAdapter = null;
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockTypesBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(96, 66);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 25);
            this.idTextBox.TabIndex = 16;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockTypesBindingSource, "description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(96, 97);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(832, 25);
            this.descriptionTextBox.TabIndex = 18;
            // 
            // btnaddstock
            // 
            this.btnaddstock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnaddstock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnaddstock.FlatAppearance.BorderSize = 0;
            this.btnaddstock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddstock.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.btnaddstock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.btnaddstock.Location = new System.Drawing.Point(96, 21);
            this.btnaddstock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnaddstock.Name = "btnaddstock";
            this.btnaddstock.Size = new System.Drawing.Size(100, 38);
            this.btnaddstock.TabIndex = 19;
            this.btnaddstock.Text = "Add new ";
            this.btnaddstock.UseVisualStyleBackColor = false;
            this.btnaddstock.Click += new System.EventHandler(this.btnaddstock_Click);
            // 
            // StockType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 601);
            this.Controls.Add(this.btnaddstock);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.btndeletestock);
            this.Controls.Add(this.btnreturn);
            this.Controls.Add(this.servicesDatagridView);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1108, 808);
            this.Name = "StockType";
            this.ShowIcon = false;
            this.Text = "StockType";
            this.Load += new System.EventHandler(this.StockType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servicesDatagridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transnational_Auto_3DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView servicesDatagridView;
        private System.Windows.Forms.Button btndeletestock;
        private System.Windows.Forms.Button btnreturn;
        private Transnational_Auto_3DataSet transnational_Auto_3DataSet;
        private System.Windows.Forms.BindingSource stockTypesBindingSource;
        private Transnational_Auto_3DataSetTableAdapters.StockTypesTableAdapter stockTypesTableAdapter;
        private Transnational_Auto_3DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button btnaddstock;
    }
}