namespace Transnational_Auto_3
{
    partial class GrandLists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrandLists));
            System.Windows.Forms.Label imageLabel;
            this.transnational_Auto_3DataSet = new Transnational_Auto_3.Transnational_Auto_3DataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new Transnational_Auto_3.Transnational_Auto_3DataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new Transnational_Auto_3.Transnational_Auto_3DataSetTableAdapters.TableAdapterManager();
            this.customersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.customersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.customersListBox = new System.Windows.Forms.ListBox();
            this.vehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiclesTableAdapter = new Transnational_Auto_3.Transnational_Auto_3DataSetTableAdapters.VehiclesTableAdapter();
            this.vehiclesListBox = new System.Windows.Forms.ListBox();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoicesTableAdapter = new Transnational_Auto_3.Transnational_Auto_3DataSetTableAdapters.InvoicesTableAdapter();
            this.invoicesListBox = new System.Windows.Forms.ListBox();
            this.quotationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quotationTableAdapter = new Transnational_Auto_3.Transnational_Auto_3DataSetTableAdapters.QuotationTableAdapter();
            this.quotationListBox = new System.Windows.Forms.ListBox();
            this.invoice_DescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoice_DescriptionTableAdapter = new Transnational_Auto_3.Transnational_Auto_3DataSetTableAdapters.Invoice_DescriptionTableAdapter();
            this.invoice_DescriptionListBox = new System.Windows.Forms.ListBox();
            this.quotation_DescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quotation_DescriptionTableAdapter = new Transnational_Auto_3.Transnational_Auto_3DataSetTableAdapters.Quotation_DescriptionTableAdapter();
            this.quotation_DescriptionListBox = new System.Windows.Forms.ListBox();
            this.customersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customersComboBox = new System.Windows.Forms.ComboBox();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            imageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.transnational_Auto_3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).BeginInit();
            this.customersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoice_DescriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotation_DescriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // transnational_Auto_3DataSet
            // 
            this.transnational_Auto_3DataSet.DataSetName = "Transnational_Auto_3DataSet";
            this.transnational_Auto_3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.transnational_Auto_3DataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthenticationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompanyTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
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
            this.tableAdapterManager.TransactionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Transnational_Auto_3.Transnational_Auto_3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehiclesTableAdapter = null;
            // 
            // customersBindingNavigator
            // 
            this.customersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.customersBindingNavigator.BindingSource = this.customersBindingSource;
            this.customersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.customersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.customersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.customersBindingNavigatorSaveItem});
            this.customersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.customersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.customersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.customersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.customersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.customersBindingNavigator.Name = "customersBindingNavigator";
            this.customersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.customersBindingNavigator.Size = new System.Drawing.Size(1064, 25);
            this.customersBindingNavigator.TabIndex = 0;
            this.customersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // customersBindingNavigatorSaveItem
            // 
            this.customersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customersBindingNavigatorSaveItem.Image")));
            this.customersBindingNavigatorSaveItem.Name = "customersBindingNavigatorSaveItem";
            this.customersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.customersBindingNavigatorSaveItem.Text = "Save Data";
            this.customersBindingNavigatorSaveItem.Click += new System.EventHandler(this.customersBindingNavigatorSaveItem_Click);
            // 
            // customersListBox
            // 
            this.customersListBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customersListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customersListBox.DataSource = this.customersBindingSource;
            this.customersListBox.DisplayMember = "name";
            this.customersListBox.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.customersListBox.FormattingEnabled = true;
            this.customersListBox.ItemHeight = 17;
            this.customersListBox.Location = new System.Drawing.Point(12, 130);
            this.customersListBox.Name = "customersListBox";
            this.customersListBox.Size = new System.Drawing.Size(209, 204);
            this.customersListBox.TabIndex = 1;
            this.customersListBox.ValueMember = "cust_id";
            // 
            // vehiclesBindingSource
            // 
            this.vehiclesBindingSource.DataMember = "FK_Vehicles_Customers";
            this.vehiclesBindingSource.DataSource = this.customersBindingSource;
            // 
            // vehiclesTableAdapter
            // 
            this.vehiclesTableAdapter.ClearBeforeFill = true;
            // 
            // vehiclesListBox
            // 
            this.vehiclesListBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.vehiclesListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vehiclesListBox.DataSource = this.vehiclesBindingSource;
            this.vehiclesListBox.DisplayMember = "model";
            this.vehiclesListBox.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.vehiclesListBox.FormattingEnabled = true;
            this.vehiclesListBox.ItemHeight = 17;
            this.vehiclesListBox.Location = new System.Drawing.Point(273, 130);
            this.vehiclesListBox.Name = "vehiclesListBox";
            this.vehiclesListBox.Size = new System.Drawing.Size(300, 204);
            this.vehiclesListBox.TabIndex = 2;
            this.vehiclesListBox.ValueMember = "model";
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "FK_Invoices_Vehicles";
            this.invoicesBindingSource.DataSource = this.vehiclesBindingSource;
            // 
            // invoicesTableAdapter
            // 
            this.invoicesTableAdapter.ClearBeforeFill = true;
            // 
            // invoicesListBox
            // 
            this.invoicesListBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.invoicesListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.invoicesListBox.DataSource = this.invoicesBindingSource;
            this.invoicesListBox.DisplayMember = "issue_date";
            this.invoicesListBox.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.invoicesListBox.FormattingEnabled = true;
            this.invoicesListBox.ItemHeight = 17;
            this.invoicesListBox.Location = new System.Drawing.Point(615, 130);
            this.invoicesListBox.Name = "invoicesListBox";
            this.invoicesListBox.Size = new System.Drawing.Size(300, 204);
            this.invoicesListBox.TabIndex = 3;
            this.invoicesListBox.ValueMember = "issue_date";
            // 
            // quotationBindingSource
            // 
            this.quotationBindingSource.DataMember = "FK_Quotation_Vehicles";
            this.quotationBindingSource.DataSource = this.vehiclesBindingSource;
            // 
            // quotationTableAdapter
            // 
            this.quotationTableAdapter.ClearBeforeFill = true;
            // 
            // quotationListBox
            // 
            this.quotationListBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.quotationListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quotationListBox.DataSource = this.quotationBindingSource;
            this.quotationListBox.DisplayMember = "issue_date";
            this.quotationListBox.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.quotationListBox.FormattingEnabled = true;
            this.quotationListBox.ItemHeight = 17;
            this.quotationListBox.Location = new System.Drawing.Point(12, 379);
            this.quotationListBox.Name = "quotationListBox";
            this.quotationListBox.Size = new System.Drawing.Size(300, 204);
            this.quotationListBox.TabIndex = 4;
            this.quotationListBox.ValueMember = "issue_date";
            // 
            // invoice_DescriptionBindingSource
            // 
            this.invoice_DescriptionBindingSource.DataMember = "FK_Invoice_Description_Invoices";
            this.invoice_DescriptionBindingSource.DataSource = this.invoicesBindingSource;
            // 
            // invoice_DescriptionTableAdapter
            // 
            this.invoice_DescriptionTableAdapter.ClearBeforeFill = true;
            // 
            // invoice_DescriptionListBox
            // 
            this.invoice_DescriptionListBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.invoice_DescriptionListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.invoice_DescriptionListBox.DataSource = this.invoice_DescriptionBindingSource;
            this.invoice_DescriptionListBox.DisplayMember = "description";
            this.invoice_DescriptionListBox.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.invoice_DescriptionListBox.FormattingEnabled = true;
            this.invoice_DescriptionListBox.ItemHeight = 17;
            this.invoice_DescriptionListBox.Location = new System.Drawing.Point(342, 379);
            this.invoice_DescriptionListBox.Name = "invoice_DescriptionListBox";
            this.invoice_DescriptionListBox.Size = new System.Drawing.Size(300, 204);
            this.invoice_DescriptionListBox.TabIndex = 5;
            this.invoice_DescriptionListBox.ValueMember = "inv_key";
            // 
            // quotation_DescriptionBindingSource
            // 
            this.quotation_DescriptionBindingSource.DataMember = "FK_Quotation_Description_Quotation";
            this.quotation_DescriptionBindingSource.DataSource = this.quotationBindingSource;
            // 
            // quotation_DescriptionTableAdapter
            // 
            this.quotation_DescriptionTableAdapter.ClearBeforeFill = true;
            // 
            // quotation_DescriptionListBox
            // 
            this.quotation_DescriptionListBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.quotation_DescriptionListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quotation_DescriptionListBox.DataSource = this.quotation_DescriptionBindingSource;
            this.quotation_DescriptionListBox.DisplayMember = "description";
            this.quotation_DescriptionListBox.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.quotation_DescriptionListBox.FormattingEnabled = true;
            this.quotation_DescriptionListBox.ItemHeight = 17;
            this.quotation_DescriptionListBox.Location = new System.Drawing.Point(660, 379);
            this.quotation_DescriptionListBox.Name = "quotation_DescriptionListBox";
            this.quotation_DescriptionListBox.Size = new System.Drawing.Size(300, 204);
            this.quotation_DescriptionListBox.TabIndex = 6;
            this.quotation_DescriptionListBox.ValueMember = "quote_key";
            // 
            // customersBindingSource1
            // 
            this.customersBindingSource1.DataMember = "Customers";
            this.customersBindingSource1.DataSource = this.transnational_Auto_3DataSet;
            // 
            // customersComboBox
            // 
            this.customersComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customersComboBox.DataSource = this.customersBindingSource1;
            this.customersComboBox.DisplayMember = "id_number";
            this.customersComboBox.FormattingEnabled = true;
            this.customersComboBox.Location = new System.Drawing.Point(12, 88);
            this.customersComboBox.Name = "customersComboBox";
            this.customersComboBox.Size = new System.Drawing.Size(300, 21);
            this.customersComboBox.TabIndex = 7;
            this.customersComboBox.ValueMember = "cust_id";
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            imageLabel.Location = new System.Drawing.Point(546, 67);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new System.Drawing.Size(38, 13);
            imageLabel.TabIndex = 8;
            imageLabel.Text = "image:";
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.vehiclesBindingSource, "image", true));
            this.imagePictureBox.Location = new System.Drawing.Point(778, 39);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(274, 263);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePictureBox.TabIndex = 9;
            this.imagePictureBox.TabStop = false;
            // 
            // GrandLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 721);
            this.Controls.Add(imageLabel);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(this.customersComboBox);
            this.Controls.Add(this.quotation_DescriptionListBox);
            this.Controls.Add(this.invoice_DescriptionListBox);
            this.Controls.Add(this.quotationListBox);
            this.Controls.Add(this.invoicesListBox);
            this.Controls.Add(this.vehiclesListBox);
            this.Controls.Add(this.customersListBox);
            this.Controls.Add(this.customersBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.Name = "GrandLists";
            this.Text = "GrandLists";
            this.Load += new System.EventHandler(this.GrandLists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transnational_Auto_3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).EndInit();
            this.customersBindingNavigator.ResumeLayout(false);
            this.customersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoice_DescriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotation_DescriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Transnational_Auto_3DataSet transnational_Auto_3DataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private Transnational_Auto_3DataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private Transnational_Auto_3DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator customersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton customersBindingNavigatorSaveItem;
        private System.Windows.Forms.ListBox customersListBox;
        private System.Windows.Forms.BindingSource vehiclesBindingSource;
        private Transnational_Auto_3DataSetTableAdapters.VehiclesTableAdapter vehiclesTableAdapter;
        private System.Windows.Forms.ListBox vehiclesListBox;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private Transnational_Auto_3DataSetTableAdapters.InvoicesTableAdapter invoicesTableAdapter;
        private System.Windows.Forms.ListBox invoicesListBox;
        private System.Windows.Forms.BindingSource quotationBindingSource;
        private Transnational_Auto_3DataSetTableAdapters.QuotationTableAdapter quotationTableAdapter;
        private System.Windows.Forms.ListBox quotationListBox;
        private System.Windows.Forms.BindingSource invoice_DescriptionBindingSource;
        private Transnational_Auto_3DataSetTableAdapters.Invoice_DescriptionTableAdapter invoice_DescriptionTableAdapter;
        private System.Windows.Forms.ListBox invoice_DescriptionListBox;
        private System.Windows.Forms.BindingSource quotation_DescriptionBindingSource;
        private Transnational_Auto_3DataSetTableAdapters.Quotation_DescriptionTableAdapter quotation_DescriptionTableAdapter;
        private System.Windows.Forms.ListBox quotation_DescriptionListBox;
        private System.Windows.Forms.BindingSource customersBindingSource1;
        private System.Windows.Forms.ComboBox customersComboBox;
        private System.Windows.Forms.PictureBox imagePictureBox;
    }
}