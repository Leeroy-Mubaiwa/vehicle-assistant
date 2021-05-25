namespace Transnational_Auto_3
{
    partial class Customer_Vehicles
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
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label vehicles_idLabel;
            System.Windows.Forms.Label cust_idLabel;
            System.Windows.Forms.Label reg_numberLabel;
            System.Windows.Forms.Label engine_numberLabel;
            System.Windows.Forms.Label chasis_numberLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label makeLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label mileage_inLabel;
            System.Windows.Forms.Label mileage_outLabel;
            System.Windows.Forms.Label fuel_inLabel;
            System.Windows.Forms.Label imageLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Vehicles));
            this.btndeleteSelected = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnSaveSubCategories = new System.Windows.Forms.Button();
            this.btnnewservice = new System.Windows.Forms.Button();
            this.btnSearch_Service = new System.Windows.Forms.Button();
            this.txtsearch_service = new System.Windows.Forms.TextBox();
            this.servicesSubCategoriesDataGridView = new System.Windows.Forms.DataGridView();
            this.vehiclesidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.custidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enginenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chasisnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mileageinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mileageoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transnational_Auto_3DataSet = new Transnational_Auto_3.Transnational_Auto_3DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersTableAdapter = new Transnational_Auto_3.Transnational_Auto_3DataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new Transnational_Auto_3.Transnational_Auto_3DataSetTableAdapters.TableAdapterManager();
            this.vehiclesTableAdapter = new Transnational_Auto_3.Transnational_Auto_3DataSetTableAdapters.VehiclesTableAdapter();
            this.vehicles_idTextBox = new System.Windows.Forms.TextBox();
            this.cust_idTextBox = new System.Windows.Forms.TextBox();
            this.reg_numberTextBox = new System.Windows.Forms.TextBox();
            this.engine_numberTextBox = new System.Windows.Forms.TextBox();
            this.chasis_numberTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.yearDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.mileage_inTextBox = new System.Windows.Forms.TextBox();
            this.mileage_outTextBox = new System.Windows.Forms.TextBox();
            this.fuel_inTextBox = new System.Windows.Forms.TextBox();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.btnimage_vehicle = new System.Windows.Forms.Button();
            this.lblfoundnumber = new System.Windows.Forms.Label();
            this.btnnewvehicle = new System.Windows.Forms.Button();
            this.btnvehicles = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            descriptionLabel = new System.Windows.Forms.Label();
            vehicles_idLabel = new System.Windows.Forms.Label();
            cust_idLabel = new System.Windows.Forms.Label();
            reg_numberLabel = new System.Windows.Forms.Label();
            engine_numberLabel = new System.Windows.Forms.Label();
            chasis_numberLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            makeLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            mileage_inLabel = new System.Windows.Forms.Label();
            mileage_outLabel = new System.Windows.Forms.Label();
            fuel_inLabel = new System.Windows.Forms.Label();
            imageLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.servicesSubCategoriesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transnational_Auto_3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            descriptionLabel.ForeColor = System.Drawing.Color.Black;
            descriptionLabel.Location = new System.Drawing.Point(14, 21);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(119, 15);
            descriptionLabel.TabIndex = 10;
            descriptionLabel.Text = "Vehicle Owner in blue";
            // 
            // vehicles_idLabel
            // 
            vehicles_idLabel.AutoSize = true;
            vehicles_idLabel.Location = new System.Drawing.Point(348, 41);
            vehicles_idLabel.Name = "vehicles_idLabel";
            vehicles_idLabel.Size = new System.Drawing.Size(25, 19);
            vehicles_idLabel.TabIndex = 18;
            vehicles_idLabel.Text = "ID:";
            // 
            // cust_idLabel
            // 
            cust_idLabel.AutoSize = true;
            cust_idLabel.Location = new System.Drawing.Point(451, 41);
            cust_idLabel.Name = "cust_idLabel";
            cust_idLabel.Size = new System.Drawing.Size(51, 19);
            cust_idLabel.TabIndex = 20;
            cust_idLabel.Text = "cust id:";
            // 
            // reg_numberLabel
            // 
            reg_numberLabel.AutoSize = true;
            reg_numberLabel.Location = new System.Drawing.Point(685, 81);
            reg_numberLabel.Name = "reg_numberLabel";
            reg_numberLabel.Size = new System.Drawing.Size(134, 19);
            reg_numberLabel.TabIndex = 22;
            reg_numberLabel.Text = "Registration Number";
            // 
            // engine_numberLabel
            // 
            engine_numberLabel.AutoSize = true;
            engine_numberLabel.Location = new System.Drawing.Point(343, 103);
            engine_numberLabel.Name = "engine_numberLabel";
            engine_numberLabel.Size = new System.Drawing.Size(106, 19);
            engine_numberLabel.TabIndex = 24;
            engine_numberLabel.Text = "engine number:";
            // 
            // chasis_numberLabel
            // 
            chasis_numberLabel.AutoSize = true;
            chasis_numberLabel.Location = new System.Drawing.Point(343, 134);
            chasis_numberLabel.Name = "chasis_numberLabel";
            chasis_numberLabel.Size = new System.Drawing.Size(101, 19);
            chasis_numberLabel.TabIndex = 26;
            chasis_numberLabel.Text = "chasis number:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(343, 166);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(50, 19);
            modelLabel.TabIndex = 28;
            modelLabel.Text = "model:";
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Location = new System.Drawing.Point(343, 197);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new System.Drawing.Size(45, 19);
            makeLabel.TabIndex = 30;
            makeLabel.Text = "make:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(343, 229);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(39, 19);
            yearLabel.TabIndex = 32;
            yearLabel.Text = "year:";
            // 
            // mileage_inLabel
            // 
            mileage_inLabel.AutoSize = true;
            mileage_inLabel.Location = new System.Drawing.Point(685, 140);
            mileage_inLabel.Name = "mileage_inLabel";
            mileage_inLabel.Size = new System.Drawing.Size(74, 19);
            mileage_inLabel.TabIndex = 34;
            mileage_inLabel.Text = "mileage in:";
            // 
            // mileage_outLabel
            // 
            mileage_outLabel.AutoSize = true;
            mileage_outLabel.Location = new System.Drawing.Point(685, 200);
            mileage_outLabel.Name = "mileage_outLabel";
            mileage_outLabel.Size = new System.Drawing.Size(83, 19);
            mileage_outLabel.TabIndex = 36;
            mileage_outLabel.Text = "mileage out:";
            // 
            // fuel_inLabel
            // 
            fuel_inLabel.AutoSize = true;
            fuel_inLabel.Location = new System.Drawing.Point(344, 262);
            fuel_inLabel.Name = "fuel_inLabel";
            fuel_inLabel.Size = new System.Drawing.Size(49, 19);
            fuel_inLabel.TabIndex = 38;
            fuel_inLabel.Text = "fuel in:";
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Location = new System.Drawing.Point(891, 63);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new System.Drawing.Size(49, 19);
            imageLabel.TabIndex = 40;
            imageLabel.Text = "image:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.Tomato;
            label1.Location = new System.Drawing.Point(557, 259);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(37, 19);
            label1.TabIndex = 42;
            label1.Text = "litres";
            // 
            // btndeleteSelected
            // 
            this.btndeleteSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btndeleteSelected.BackColor = System.Drawing.SystemColors.Window;
            this.btndeleteSelected.FlatAppearance.BorderSize = 0;
            this.btndeleteSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeleteSelected.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.btndeleteSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.btndeleteSelected.Location = new System.Drawing.Point(853, 633);
            this.btndeleteSelected.Name = "btndeleteSelected";
            this.btndeleteSelected.Size = new System.Drawing.Size(122, 28);
            this.btndeleteSelected.TabIndex = 18;
            this.btndeleteSelected.Text = "Delete selected";
            this.btndeleteSelected.UseVisualStyleBackColor = false;
            this.btndeleteSelected.Click += new System.EventHandler(this.btndeleteSelected_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrefresh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnrefresh.FlatAppearance.BorderSize = 0;
            this.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefresh.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.btnrefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.btnrefresh.Location = new System.Drawing.Point(981, 12);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 25);
            this.btnrefresh.TabIndex = 17;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = false;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnSaveSubCategories
            // 
            this.btnSaveSubCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveSubCategories.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSaveSubCategories.FlatAppearance.BorderSize = 0;
            this.btnSaveSubCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSubCategories.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.btnSaveSubCategories.ForeColor = System.Drawing.Color.White;
            this.btnSaveSubCategories.Location = new System.Drawing.Point(981, 633);
            this.btnSaveSubCategories.Name = "btnSaveSubCategories";
            this.btnSaveSubCategories.Size = new System.Drawing.Size(75, 28);
            this.btnSaveSubCategories.TabIndex = 15;
            this.btnSaveSubCategories.Text = "Save data";
            this.btnSaveSubCategories.UseVisualStyleBackColor = false;
            this.btnSaveSubCategories.Click += new System.EventHandler(this.btnSaveSubCategories_Click);
            // 
            // btnnewservice
            // 
            this.btnnewservice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnnewservice.FlatAppearance.BorderSize = 0;
            this.btnnewservice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnewservice.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.btnnewservice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.btnnewservice.Location = new System.Drawing.Point(139, 11);
            this.btnnewservice.Name = "btnnewservice";
            this.btnnewservice.Size = new System.Drawing.Size(119, 25);
            this.btnnewservice.TabIndex = 14;
            this.btnnewservice.Text = "Add new customer";
            this.btnnewservice.UseVisualStyleBackColor = false;
            this.btnnewservice.Click += new System.EventHandler(this.btnnewservice_Click);
            // 
            // btnSearch_Service
            // 
            this.btnSearch_Service.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch_Service.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearch_Service.FlatAppearance.BorderSize = 0;
            this.btnSearch_Service.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch_Service.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.btnSearch_Service.ForeColor = System.Drawing.Color.White;
            this.btnSearch_Service.Location = new System.Drawing.Point(893, 12);
            this.btnSearch_Service.Name = "btnSearch_Service";
            this.btnSearch_Service.Size = new System.Drawing.Size(75, 25);
            this.btnSearch_Service.TabIndex = 13;
            this.btnSearch_Service.Text = "Search";
            this.btnSearch_Service.UseVisualStyleBackColor = false;
            this.btnSearch_Service.Click += new System.EventHandler(this.btnSearch_Service_Click);
            // 
            // txtsearch_service
            // 
            this.txtsearch_service.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsearch_service.Location = new System.Drawing.Point(613, 12);
            this.txtsearch_service.Name = "txtsearch_service";
            this.txtsearch_service.Size = new System.Drawing.Size(274, 25);
            this.txtsearch_service.TabIndex = 12;
            this.txtsearch_service.TextChanged += new System.EventHandler(this.txtsearch_service_TextChanged);
            // 
            // servicesSubCategoriesDataGridView
            // 
            this.servicesSubCategoriesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.servicesSubCategoriesDataGridView.AutoGenerateColumns = false;
            this.servicesSubCategoriesDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.servicesSubCategoriesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.servicesSubCategoriesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.servicesSubCategoriesDataGridView.ColumnHeadersHeight = 30;
            this.servicesSubCategoriesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehiclesidDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn,
            this.custidDataGridViewTextBoxColumn,
            this.regnumberDataGridViewTextBoxColumn,
            this.enginenumberDataGridViewTextBoxColumn,
            this.chasisnumberDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.makeDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.mileageinDataGridViewTextBoxColumn,
            this.mileageoutDataGridViewTextBoxColumn,
            this.fuelinDataGridViewTextBoxColumn});
            this.servicesSubCategoriesDataGridView.DataSource = this.vehiclesBindingSource;
            this.servicesSubCategoriesDataGridView.EnableHeadersVisualStyles = false;
            this.servicesSubCategoriesDataGridView.GridColor = System.Drawing.Color.WhiteSmoke;
            this.servicesSubCategoriesDataGridView.Location = new System.Drawing.Point(12, 320);
            this.servicesSubCategoriesDataGridView.Name = "servicesSubCategoriesDataGridView";
            this.servicesSubCategoriesDataGridView.RowHeadersVisible = false;
            this.servicesSubCategoriesDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.servicesSubCategoriesDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.servicesSubCategoriesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.servicesSubCategoriesDataGridView.Size = new System.Drawing.Size(1041, 307);
            this.servicesSubCategoriesDataGridView.TabIndex = 11;
            // 
            // vehiclesidDataGridViewTextBoxColumn
            // 
            this.vehiclesidDataGridViewTextBoxColumn.DataPropertyName = "vehicles_id";
            this.vehiclesidDataGridViewTextBoxColumn.HeaderText = "vehicles_id";
            this.vehiclesidDataGridViewTextBoxColumn.Name = "vehiclesidDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "image";
            this.imageDataGridViewImageColumn.HeaderText = "image";
            this.imageDataGridViewImageColumn.Image = global::Transnational_Auto_3.Properties.Resources.LogoAuto;
            this.imageDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            // 
            // custidDataGridViewTextBoxColumn
            // 
            this.custidDataGridViewTextBoxColumn.DataPropertyName = "cust_id";
            this.custidDataGridViewTextBoxColumn.HeaderText = "cust_id";
            this.custidDataGridViewTextBoxColumn.Name = "custidDataGridViewTextBoxColumn";
            // 
            // regnumberDataGridViewTextBoxColumn
            // 
            this.regnumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.regnumberDataGridViewTextBoxColumn.DataPropertyName = "reg_number";
            this.regnumberDataGridViewTextBoxColumn.HeaderText = "reg_number";
            this.regnumberDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.regnumberDataGridViewTextBoxColumn.Name = "regnumberDataGridViewTextBoxColumn";
            // 
            // enginenumberDataGridViewTextBoxColumn
            // 
            this.enginenumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.enginenumberDataGridViewTextBoxColumn.DataPropertyName = "engine_number";
            this.enginenumberDataGridViewTextBoxColumn.HeaderText = "engine_number";
            this.enginenumberDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.enginenumberDataGridViewTextBoxColumn.Name = "enginenumberDataGridViewTextBoxColumn";
            // 
            // chasisnumberDataGridViewTextBoxColumn
            // 
            this.chasisnumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chasisnumberDataGridViewTextBoxColumn.DataPropertyName = "chasis_number";
            this.chasisnumberDataGridViewTextBoxColumn.HeaderText = "chasis_number";
            this.chasisnumberDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.chasisnumberDataGridViewTextBoxColumn.Name = "chasisnumberDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // makeDataGridViewTextBoxColumn
            // 
            this.makeDataGridViewTextBoxColumn.DataPropertyName = "make";
            this.makeDataGridViewTextBoxColumn.HeaderText = "make";
            this.makeDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.makeDataGridViewTextBoxColumn.Name = "makeDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "year";
            this.yearDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // mileageinDataGridViewTextBoxColumn
            // 
            this.mileageinDataGridViewTextBoxColumn.DataPropertyName = "mileage_in";
            this.mileageinDataGridViewTextBoxColumn.HeaderText = "mileage_in";
            this.mileageinDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.mileageinDataGridViewTextBoxColumn.Name = "mileageinDataGridViewTextBoxColumn";
            // 
            // mileageoutDataGridViewTextBoxColumn
            // 
            this.mileageoutDataGridViewTextBoxColumn.DataPropertyName = "mileage_out";
            this.mileageoutDataGridViewTextBoxColumn.HeaderText = "mileage_out";
            this.mileageoutDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.mileageoutDataGridViewTextBoxColumn.Name = "mileageoutDataGridViewTextBoxColumn";
            // 
            // fuelinDataGridViewTextBoxColumn
            // 
            this.fuelinDataGridViewTextBoxColumn.DataPropertyName = "fuel_in";
            this.fuelinDataGridViewTextBoxColumn.HeaderText = "fuel_in";
            this.fuelinDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.fuelinDataGridViewTextBoxColumn.Name = "fuelinDataGridViewTextBoxColumn";
            // 
            // vehiclesBindingSource
            // 
            this.vehiclesBindingSource.DataMember = "FK_Vehicles_Customers";
            this.vehiclesBindingSource.DataSource = this.customersBindingSource;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.transnational_Auto_3DataSet;
            // 
            // transnational_Auto_3DataSet
            // 
            this.transnational_Auto_3DataSet.DataSetName = "Transnational_Auto_3DataSet";
            this.transnational_Auto_3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customersBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(13, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(305, 266);
            this.dataGridView1.TabIndex = 16;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.tableAdapterManager.VehiclesTableAdapter = this.vehiclesTableAdapter;
            // 
            // vehiclesTableAdapter
            // 
            this.vehiclesTableAdapter.ClearBeforeFill = true;
            // 
            // vehicles_idTextBox
            // 
            this.vehicles_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "vehicles_id", true));
            this.vehicles_idTextBox.Location = new System.Drawing.Point(348, 63);
            this.vehicles_idTextBox.Name = "vehicles_idTextBox";
            this.vehicles_idTextBox.Size = new System.Drawing.Size(68, 25);
            this.vehicles_idTextBox.TabIndex = 19;
            // 
            // cust_idTextBox
            // 
            this.cust_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "cust_id", true));
            this.cust_idTextBox.Location = new System.Drawing.Point(455, 63);
            this.cust_idTextBox.Name = "cust_idTextBox";
            this.cust_idTextBox.Size = new System.Drawing.Size(66, 25);
            this.cust_idTextBox.TabIndex = 21;
            // 
            // reg_numberTextBox
            // 
            this.reg_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "reg_number", true));
            this.reg_numberTextBox.Location = new System.Drawing.Point(689, 103);
            this.reg_numberTextBox.Name = "reg_numberTextBox";
            this.reg_numberTextBox.Size = new System.Drawing.Size(129, 25);
            this.reg_numberTextBox.TabIndex = 23;
            // 
            // engine_numberTextBox
            // 
            this.engine_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "engine_number", true));
            this.engine_numberTextBox.Location = new System.Drawing.Point(455, 100);
            this.engine_numberTextBox.Name = "engine_numberTextBox";
            this.engine_numberTextBox.Size = new System.Drawing.Size(200, 25);
            this.engine_numberTextBox.TabIndex = 25;
            // 
            // chasis_numberTextBox
            // 
            this.chasis_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "chasis_number", true));
            this.chasis_numberTextBox.Location = new System.Drawing.Point(455, 131);
            this.chasis_numberTextBox.Name = "chasis_numberTextBox";
            this.chasis_numberTextBox.Size = new System.Drawing.Size(200, 25);
            this.chasis_numberTextBox.TabIndex = 27;
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "model", true));
            this.modelTextBox.Location = new System.Drawing.Point(455, 163);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(200, 25);
            this.modelTextBox.TabIndex = 29;
            // 
            // makeTextBox
            // 
            this.makeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "make", true));
            this.makeTextBox.Location = new System.Drawing.Point(455, 194);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(200, 25);
            this.makeTextBox.TabIndex = 31;
            // 
            // yearDateTimePicker
            // 
            this.yearDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vehiclesBindingSource, "year", true));
            this.yearDateTimePicker.Location = new System.Drawing.Point(455, 225);
            this.yearDateTimePicker.Name = "yearDateTimePicker";
            this.yearDateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.yearDateTimePicker.TabIndex = 33;
            // 
            // mileage_inTextBox
            // 
            this.mileage_inTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "mileage_in", true));
            this.mileage_inTextBox.Location = new System.Drawing.Point(689, 166);
            this.mileage_inTextBox.Name = "mileage_inTextBox";
            this.mileage_inTextBox.Size = new System.Drawing.Size(129, 25);
            this.mileage_inTextBox.TabIndex = 35;
            // 
            // mileage_outTextBox
            // 
            this.mileage_outTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "mileage_out", true));
            this.mileage_outTextBox.Location = new System.Drawing.Point(689, 225);
            this.mileage_outTextBox.Name = "mileage_outTextBox";
            this.mileage_outTextBox.Size = new System.Drawing.Size(129, 25);
            this.mileage_outTextBox.TabIndex = 37;
            // 
            // fuel_inTextBox
            // 
            this.fuel_inTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "fuel_in", true));
            this.fuel_inTextBox.Location = new System.Drawing.Point(455, 256);
            this.fuel_inTextBox.Name = "fuel_inTextBox";
            this.fuel_inTextBox.Size = new System.Drawing.Size(100, 25);
            this.fuel_inTextBox.TabIndex = 39;
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.imagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.vehiclesBindingSource, "image", true));
            this.imagePictureBox.Location = new System.Drawing.Point(850, 94);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(200, 205);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePictureBox.TabIndex = 41;
            this.imagePictureBox.TabStop = false;
            // 
            // btnimage_vehicle
            // 
            this.btnimage_vehicle.BackColor = System.Drawing.Color.White;
            this.btnimage_vehicle.FlatAppearance.BorderSize = 0;
            this.btnimage_vehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimage_vehicle.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.btnimage_vehicle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.btnimage_vehicle.Location = new System.Drawing.Point(870, 262);
            this.btnimage_vehicle.Name = "btnimage_vehicle";
            this.btnimage_vehicle.Size = new System.Drawing.Size(171, 25);
            this.btnimage_vehicle.TabIndex = 43;
            this.btnimage_vehicle.Text = "Add Image";
            this.btnimage_vehicle.UseVisualStyleBackColor = false;
            this.btnimage_vehicle.Click += new System.EventHandler(this.btnimage_vehicle_Click);
            // 
            // lblfoundnumber
            // 
            this.lblfoundnumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblfoundnumber.AutoSize = true;
            this.lblfoundnumber.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.lblfoundnumber.ForeColor = System.Drawing.Color.Black;
            this.lblfoundnumber.Location = new System.Drawing.Point(895, 41);
            this.lblfoundnumber.Name = "lblfoundnumber";
            this.lblfoundnumber.Size = new System.Drawing.Size(53, 15);
            this.lblfoundnumber.TabIndex = 44;
            this.lblfoundnumber.Text = "Found 0;";
            // 
            // btnnewvehicle
            // 
            this.btnnewvehicle.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnnewvehicle.FlatAppearance.BorderSize = 0;
            this.btnnewvehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnewvehicle.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.btnnewvehicle.ForeColor = System.Drawing.Color.White;
            this.btnnewvehicle.Location = new System.Drawing.Point(347, 11);
            this.btnnewvehicle.Name = "btnnewvehicle";
            this.btnnewvehicle.Size = new System.Drawing.Size(119, 25);
            this.btnnewvehicle.TabIndex = 14;
            this.btnnewvehicle.Text = "Add new vehicle";
            this.btnnewvehicle.UseVisualStyleBackColor = false;
            this.btnnewvehicle.Click += new System.EventHandler(this.newVehcile);
            // 
            // btnvehicles
            // 
            this.btnvehicles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnvehicles.BackColor = System.Drawing.SystemColors.Window;
            this.btnvehicles.FlatAppearance.BorderSize = 0;
            this.btnvehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvehicles.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.btnvehicles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.btnvehicles.Location = new System.Drawing.Point(12, 633);
            this.btnvehicles.Name = "btnvehicles";
            this.btnvehicles.Size = new System.Drawing.Size(122, 28);
            this.btnvehicles.TabIndex = 18;
            this.btnvehicles.Text = "All vehicles";
            this.btnvehicles.UseVisualStyleBackColor = false;
            this.btnvehicles.Click += new System.EventHandler(this.btnall_vehicles);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Customer_Vehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 673);
            this.Controls.Add(this.lblfoundnumber);
            this.Controls.Add(this.btnimage_vehicle);
            this.Controls.Add(label1);
            this.Controls.Add(vehicles_idLabel);
            this.Controls.Add(this.vehicles_idTextBox);
            this.Controls.Add(cust_idLabel);
            this.Controls.Add(this.cust_idTextBox);
            this.Controls.Add(reg_numberLabel);
            this.Controls.Add(this.reg_numberTextBox);
            this.Controls.Add(engine_numberLabel);
            this.Controls.Add(this.engine_numberTextBox);
            this.Controls.Add(chasis_numberLabel);
            this.Controls.Add(this.chasis_numberTextBox);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(makeLabel);
            this.Controls.Add(this.makeTextBox);
            this.Controls.Add(yearLabel);
            this.Controls.Add(this.yearDateTimePicker);
            this.Controls.Add(mileage_inLabel);
            this.Controls.Add(this.mileage_inTextBox);
            this.Controls.Add(mileage_outLabel);
            this.Controls.Add(this.mileage_outTextBox);
            this.Controls.Add(fuel_inLabel);
            this.Controls.Add(this.fuel_inTextBox);
            this.Controls.Add(imageLabel);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(this.btnvehicles);
            this.Controls.Add(this.btndeleteSelected);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnSaveSubCategories);
            this.Controls.Add(this.btnnewvehicle);
            this.Controls.Add(this.btnnewservice);
            this.Controls.Add(this.btnSearch_Service);
            this.Controls.Add(this.txtsearch_service);
            this.Controls.Add(this.servicesSubCategoriesDataGridView);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Customer_Vehicles";
            this.Text = "Vehicles Editing";
            this.Load += new System.EventHandler(this.Customer_Vehicles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servicesSubCategoriesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transnational_Auto_3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndeleteSelected;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnSaveSubCategories;
        private System.Windows.Forms.Button btnnewservice;
        private System.Windows.Forms.Button btnSearch_Service;
        private System.Windows.Forms.TextBox txtsearch_service;
        private System.Windows.Forms.DataGridView servicesSubCategoriesDataGridView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Transnational_Auto_3DataSet transnational_Auto_3DataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private Transnational_Auto_3DataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private Transnational_Auto_3DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private Transnational_Auto_3DataSetTableAdapters.VehiclesTableAdapter vehiclesTableAdapter;
        private System.Windows.Forms.BindingSource vehiclesBindingSource;
        private System.Windows.Forms.TextBox vehicles_idTextBox;
        private System.Windows.Forms.TextBox cust_idTextBox;
        private System.Windows.Forms.TextBox reg_numberTextBox;
        private System.Windows.Forms.TextBox engine_numberTextBox;
        private System.Windows.Forms.TextBox chasis_numberTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.DateTimePicker yearDateTimePicker;
        private System.Windows.Forms.TextBox mileage_inTextBox;
        private System.Windows.Forms.TextBox mileage_outTextBox;
        private System.Windows.Forms.TextBox fuel_inTextBox;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.Button btnimage_vehicle;
        private System.Windows.Forms.Label lblfoundnumber;
        private System.Windows.Forms.Button btnnewvehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehiclesidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enginenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chasisnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mileageinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mileageoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelinDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnvehicles;
        private System.Windows.Forms.Timer timer1;
    }
}