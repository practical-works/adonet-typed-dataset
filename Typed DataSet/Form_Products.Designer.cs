namespace GroceryManager
{
    partial class Form_Products
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
            System.Windows.Forms.Label upcLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label net_priceLabel;
            System.Windows.Forms.Label tax_percentLabel;
            System.Windows.Forms.Label discount_percentLabel;
            System.Windows.Forms.Label stock_quantityLabel;
            System.Windows.Forms.Label create_dateLabel;
            System.Windows.Forms.Label update_dateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Products));
            this.database = new GroceryManager.Database();
            this.bindingSource_product = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapter_product = new GroceryManager.DatabaseTableAdapters.productTableAdapter();
            this.tableAdapterManager = new GroceryManager.DatabaseTableAdapters.TableAdapterManager();
            this.dataGridView_product = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer_main = new System.Windows.Forms.SplitContainer();
            this.update_dateTextBox = new System.Windows.Forms.TextBox();
            this.create_dateTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.upcTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.net_priceTextBox = new System.Windows.Forms.TextBox();
            this.tax_percentTextBox = new System.Windows.Forms.TextBox();
            this.discount_percentTextBox = new System.Windows.Forms.TextBox();
            this.stock_quantityTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip_main = new System.Windows.Forms.ToolStrip();
            this.button_new = new System.Windows.Forms.ToolStripButton();
            this.button_delete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.button_save = new System.Windows.Forms.ToolStripButton();
            this.button_refresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.button_undo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.button_first = new System.Windows.Forms.ToolStripButton();
            this.button_previous = new System.Windows.Forms.ToolStripButton();
            this.textBox_position = new System.Windows.Forms.ToolStripTextBox();
            this.label_of = new System.Windows.Forms.ToolStripLabel();
            this.label_count = new System.Windows.Forms.ToolStripLabel();
            this.button_next = new System.Windows.Forms.ToolStripButton();
            this.button_last = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip_main = new System.Windows.Forms.MenuStrip();
            this.menuItem_file = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_new = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItem_save = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.menuItem_close = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_undo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItem_search = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_navigate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_next = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_previous = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItem_first = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_last = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_question = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_help = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip_main = new System.Windows.Forms.StatusStrip();
            this.statusLabel_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel_current = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel_positionAndCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripContainer_main = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip_search = new System.Windows.Forms.ToolStrip();
            this.textBox_search = new System.Windows.Forms.ToolStripTextBox();
            this.button_clearSearch = new System.Windows.Forms.ToolStripButton();
            this.button_search = new System.Windows.Forms.ToolStripButton();
            idLabel = new System.Windows.Forms.Label();
            upcLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            net_priceLabel = new System.Windows.Forms.Label();
            tax_percentLabel = new System.Windows.Forms.Label();
            discount_percentLabel = new System.Windows.Forms.Label();
            stock_quantityLabel = new System.Windows.Forms.Label();
            create_dateLabel = new System.Windows.Forms.Label();
            update_dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_main)).BeginInit();
            this.splitContainer_main.Panel1.SuspendLayout();
            this.splitContainer_main.Panel2.SuspendLayout();
            this.splitContainer_main.SuspendLayout();
            this.toolStrip_main.SuspendLayout();
            this.menuStrip_main.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip_main.SuspendLayout();
            this.toolStripContainer_main.ContentPanel.SuspendLayout();
            this.toolStripContainer_main.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer_main.SuspendLayout();
            this.toolStrip_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            idLabel.Image = global::GroceryManager.Properties.Resources.key;
            idLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            idLabel.Location = new System.Drawing.Point(19, 22);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(40, 16);
            idLabel.TabIndex = 0;
            idLabel.Text = "ID:";
            idLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // upcLabel
            // 
            upcLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            upcLabel.Image = global::GroceryManager.Properties.Resources.box;
            upcLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            upcLabel.Location = new System.Drawing.Point(19, 48);
            upcLabel.Name = "upcLabel";
            upcLabel.Size = new System.Drawing.Size(54, 16);
            upcLabel.TabIndex = 2;
            upcLabel.Text = "UPD:";
            upcLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(19, 83);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(31, 13);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "Title:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(19, 109);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(64, 13);
            descriptionLabel.TabIndex = 6;
            descriptionLabel.Text = "Description:";
            // 
            // net_priceLabel
            // 
            net_priceLabel.AutoSize = true;
            net_priceLabel.Location = new System.Drawing.Point(19, 148);
            net_priceLabel.Name = "net_priceLabel";
            net_priceLabel.Size = new System.Drawing.Size(54, 13);
            net_priceLabel.TabIndex = 8;
            net_priceLabel.Text = "Net Price:";
            // 
            // tax_percentLabel
            // 
            tax_percentLabel.AutoSize = true;
            tax_percentLabel.Location = new System.Drawing.Point(19, 174);
            tax_percentLabel.Name = "tax_percentLabel";
            tax_percentLabel.Size = new System.Drawing.Size(69, 13);
            tax_percentLabel.TabIndex = 10;
            tax_percentLabel.Text = "Tax Percent:";
            // 
            // discount_percentLabel
            // 
            discount_percentLabel.AutoSize = true;
            discount_percentLabel.Location = new System.Drawing.Point(19, 200);
            discount_percentLabel.Name = "discount_percentLabel";
            discount_percentLabel.Size = new System.Drawing.Size(92, 13);
            discount_percentLabel.TabIndex = 12;
            discount_percentLabel.Text = "Discount Percent:";
            // 
            // stock_quantityLabel
            // 
            stock_quantityLabel.AutoSize = true;
            stock_quantityLabel.Location = new System.Drawing.Point(19, 245);
            stock_quantityLabel.Name = "stock_quantityLabel";
            stock_quantityLabel.Size = new System.Drawing.Size(82, 13);
            stock_quantityLabel.TabIndex = 14;
            stock_quantityLabel.Text = "Stock Quantity:";
            // 
            // create_dateLabel
            // 
            create_dateLabel.AutoSize = true;
            create_dateLabel.Location = new System.Drawing.Point(19, 281);
            create_dateLabel.Name = "create_dateLabel";
            create_dateLabel.Size = new System.Drawing.Size(64, 13);
            create_dateLabel.TabIndex = 16;
            create_dateLabel.Text = "Created At:";
            // 
            // update_dateLabel
            // 
            update_dateLabel.AutoSize = true;
            update_dateLabel.Location = new System.Drawing.Point(19, 307);
            update_dateLabel.Name = "update_dateLabel";
            update_dateLabel.Size = new System.Drawing.Size(60, 13);
            update_dateLabel.TabIndex = 18;
            update_dateLabel.Text = "Update At:";
            // 
            // database
            // 
            this.database.DataSetName = "Database";
            this.database.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource_product
            // 
            this.bindingSource_product.DataMember = "product";
            this.bindingSource_product.DataSource = this.database;
            this.bindingSource_product.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.bindingSource_product_AddingNew);
            this.bindingSource_product.DataError += new System.Windows.Forms.BindingManagerDataErrorEventHandler(this.bindingSource_product_DataError);
            this.bindingSource_product.CurrentChanged += new System.EventHandler(this.bindingSource_product_CurrentChanged);
            this.bindingSource_product.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bindingSource_product_ListChanged);
            // 
            // tableAdapter_product
            // 
            this.tableAdapter_product.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.order_productTableAdapter = null;
            this.tableAdapterManager.orderTableAdapter = null;
            this.tableAdapterManager.productTableAdapter = this.tableAdapter_product;
            this.tableAdapterManager.UpdateOrder = GroceryManager.DatabaseTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridView_product
            // 
            this.dataGridView_product.AutoGenerateColumns = false;
            this.dataGridView_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dataGridView_product.DataSource = this.bindingSource_product;
            this.dataGridView_product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_product.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_product.Name = "dataGridView_product";
            this.dataGridView_product.Size = new System.Drawing.Size(704, 323);
            this.dataGridView_product.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "upc";
            this.dataGridViewTextBoxColumn2.HeaderText = "UPC";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ToolTipText = "Universal Product Code";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn3.HeaderText = "Title";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn4.HeaderText = "Description";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "net_price";
            this.dataGridViewTextBoxColumn5.HeaderText = "Net Price";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "tax_percent";
            this.dataGridViewTextBoxColumn6.HeaderText = "Tax Percent";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "discount_percent";
            this.dataGridViewTextBoxColumn7.HeaderText = "Discount Percent";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "stock_quantity";
            this.dataGridViewTextBoxColumn8.HeaderText = "Stock Quantity";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "create_date";
            this.dataGridViewTextBoxColumn9.HeaderText = "Created At";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "update_date";
            this.dataGridViewTextBoxColumn10.HeaderText = "Update At";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // splitContainer_main
            // 
            this.splitContainer_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_main.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_main.Name = "splitContainer_main";
            // 
            // splitContainer_main.Panel1
            // 
            this.splitContainer_main.Panel1.AutoScroll = true;
            this.splitContainer_main.Panel1.Controls.Add(this.update_dateTextBox);
            this.splitContainer_main.Panel1.Controls.Add(this.create_dateTextBox);
            this.splitContainer_main.Panel1.Controls.Add(idLabel);
            this.splitContainer_main.Panel1.Controls.Add(this.idTextBox);
            this.splitContainer_main.Panel1.Controls.Add(upcLabel);
            this.splitContainer_main.Panel1.Controls.Add(this.upcTextBox);
            this.splitContainer_main.Panel1.Controls.Add(titleLabel);
            this.splitContainer_main.Panel1.Controls.Add(this.titleTextBox);
            this.splitContainer_main.Panel1.Controls.Add(descriptionLabel);
            this.splitContainer_main.Panel1.Controls.Add(this.descriptionTextBox);
            this.splitContainer_main.Panel1.Controls.Add(net_priceLabel);
            this.splitContainer_main.Panel1.Controls.Add(this.net_priceTextBox);
            this.splitContainer_main.Panel1.Controls.Add(tax_percentLabel);
            this.splitContainer_main.Panel1.Controls.Add(this.tax_percentTextBox);
            this.splitContainer_main.Panel1.Controls.Add(discount_percentLabel);
            this.splitContainer_main.Panel1.Controls.Add(this.discount_percentTextBox);
            this.splitContainer_main.Panel1.Controls.Add(stock_quantityLabel);
            this.splitContainer_main.Panel1.Controls.Add(this.stock_quantityTextBox);
            this.splitContainer_main.Panel1.Controls.Add(create_dateLabel);
            this.splitContainer_main.Panel1.Controls.Add(update_dateLabel);
            // 
            // splitContainer_main.Panel2
            // 
            this.splitContainer_main.Panel2.Controls.Add(this.dataGridView_product);
            this.splitContainer_main.Size = new System.Drawing.Size(1061, 323);
            this.splitContainer_main.SplitterDistance = 353;
            this.splitContainer_main.TabIndex = 0;
            // 
            // update_dateTextBox
            // 
            this.update_dateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.update_dateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_product, "update_date", true));
            this.update_dateTextBox.Location = new System.Drawing.Point(116, 308);
            this.update_dateTextBox.Name = "update_dateTextBox";
            this.update_dateTextBox.ReadOnly = true;
            this.update_dateTextBox.Size = new System.Drawing.Size(200, 20);
            this.update_dateTextBox.TabIndex = 20;
            // 
            // create_dateTextBox
            // 
            this.create_dateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.create_dateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_product, "create_date", true));
            this.create_dateTextBox.Location = new System.Drawing.Point(116, 281);
            this.create_dateTextBox.Name = "create_dateTextBox";
            this.create_dateTextBox.ReadOnly = true;
            this.create_dateTextBox.Size = new System.Drawing.Size(200, 20);
            this.create_dateTextBox.TabIndex = 19;
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_product, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(116, 22);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // upcTextBox
            // 
            this.upcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.upcTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_product, "upc", true));
            this.upcTextBox.Location = new System.Drawing.Point(116, 48);
            this.upcTextBox.Name = "upcTextBox";
            this.upcTextBox.Size = new System.Drawing.Size(200, 20);
            this.upcTextBox.TabIndex = 3;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_product, "title", true));
            this.titleTextBox.Location = new System.Drawing.Point(116, 80);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(200, 20);
            this.titleTextBox.TabIndex = 5;
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_product, "description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(116, 106);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 20);
            this.descriptionTextBox.TabIndex = 7;
            // 
            // net_priceTextBox
            // 
            this.net_priceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.net_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_product, "net_price", true));
            this.net_priceTextBox.Location = new System.Drawing.Point(116, 145);
            this.net_priceTextBox.Name = "net_priceTextBox";
            this.net_priceTextBox.Size = new System.Drawing.Size(200, 20);
            this.net_priceTextBox.TabIndex = 9;
            // 
            // tax_percentTextBox
            // 
            this.tax_percentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tax_percentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_product, "tax_percent", true));
            this.tax_percentTextBox.Location = new System.Drawing.Point(116, 171);
            this.tax_percentTextBox.Name = "tax_percentTextBox";
            this.tax_percentTextBox.Size = new System.Drawing.Size(200, 20);
            this.tax_percentTextBox.TabIndex = 11;
            // 
            // discount_percentTextBox
            // 
            this.discount_percentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.discount_percentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_product, "discount_percent", true));
            this.discount_percentTextBox.Location = new System.Drawing.Point(116, 197);
            this.discount_percentTextBox.Name = "discount_percentTextBox";
            this.discount_percentTextBox.Size = new System.Drawing.Size(200, 20);
            this.discount_percentTextBox.TabIndex = 13;
            // 
            // stock_quantityTextBox
            // 
            this.stock_quantityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stock_quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_product, "stock_quantity", true));
            this.stock_quantityTextBox.Location = new System.Drawing.Point(116, 242);
            this.stock_quantityTextBox.Name = "stock_quantityTextBox";
            this.stock_quantityTextBox.Size = new System.Drawing.Size(200, 20);
            this.stock_quantityTextBox.TabIndex = 15;
            // 
            // toolStrip_main
            // 
            this.toolStrip_main.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button_new,
            this.button_delete,
            this.toolStripSeparator4,
            this.button_save,
            this.button_refresh,
            this.toolStripSeparator5,
            this.button_undo,
            this.toolStripSeparator7,
            this.button_first,
            this.button_previous,
            this.textBox_position,
            this.label_of,
            this.label_count,
            this.button_next,
            this.button_last,
            this.toolStripSeparator6});
            this.toolStrip_main.Location = new System.Drawing.Point(3, 24);
            this.toolStrip_main.Name = "toolStrip_main";
            this.toolStrip_main.Size = new System.Drawing.Size(326, 25);
            this.toolStrip_main.TabIndex = 1;
            this.toolStrip_main.Text = "toolStrip1";
            // 
            // button_new
            // 
            this.button_new.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_new.Image = global::GroceryManager.Properties.Resources.add;
            this.button_new.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(23, 22);
            this.button_new.Text = "New";
            this.button_new.Click += new System.EventHandler(this.menuItem_new_Click);
            // 
            // button_delete
            // 
            this.button_delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_delete.Image = global::GroceryManager.Properties.Resources.delete;
            this.button_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(23, 22);
            this.button_delete.Text = "Delete";
            this.button_delete.Click += new System.EventHandler(this.menuItem_delete_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // button_save
            // 
            this.button_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_save.Image = global::GroceryManager.Properties.Resources.diskette;
            this.button_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(23, 22);
            this.button_save.Text = "Save";
            this.button_save.Click += new System.EventHandler(this.menuItem_save_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_refresh.Image = global::GroceryManager.Properties.Resources.update;
            this.button_refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(23, 22);
            this.button_refresh.Text = "Refresh";
            this.button_refresh.Click += new System.EventHandler(this.menuItem_refresh_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // button_undo
            // 
            this.button_undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_undo.Image = global::GroceryManager.Properties.Resources.undo;
            this.button_undo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_undo.Name = "button_undo";
            this.button_undo.Size = new System.Drawing.Size(23, 22);
            this.button_undo.Text = "Undo";
            this.button_undo.Click += new System.EventHandler(this.menuItem_undo_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // button_first
            // 
            this.button_first.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_first.Image = global::GroceryManager.Properties.Resources.resultset_first;
            this.button_first.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_first.Name = "button_first";
            this.button_first.Size = new System.Drawing.Size(23, 22);
            this.button_first.Click += new System.EventHandler(this.menuItem_first_Click);
            // 
            // button_previous
            // 
            this.button_previous.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_previous.Image = global::GroceryManager.Properties.Resources.resultset_previous1;
            this.button_previous.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_previous.Name = "button_previous";
            this.button_previous.Size = new System.Drawing.Size(23, 22);
            this.button_previous.Click += new System.EventHandler(this.menuItem_previous_Click);
            // 
            // textBox_position
            // 
            this.textBox_position.Name = "textBox_position";
            this.textBox_position.Size = new System.Drawing.Size(50, 25);
            this.textBox_position.Text = "0";
            this.textBox_position.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_position.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_position_KeyDown);
            this.textBox_position.Validated += new System.EventHandler(this.textBox_position_Validated);
            // 
            // label_of
            // 
            this.label_of.Name = "label_of";
            this.label_of.Size = new System.Drawing.Size(18, 22);
            this.label_of.Text = "of";
            // 
            // label_count
            // 
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(13, 22);
            this.label_count.Text = "0";
            // 
            // button_next
            // 
            this.button_next.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_next.Image = global::GroceryManager.Properties.Resources.resultset_next;
            this.button_next.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(23, 22);
            this.button_next.Click += new System.EventHandler(this.menuItem_next_Click);
            // 
            // button_last
            // 
            this.button_last.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_last.Image = global::GroceryManager.Properties.Resources.resultset_last;
            this.button_last.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_last.Name = "button_last";
            this.button_last.Size = new System.Drawing.Size(23, 22);
            this.button_last.Click += new System.EventHandler(this.menuItem_last_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // menuStrip_main
            // 
            this.menuStrip_main.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip_main.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_file,
            this.menuItem_edit,
            this.menuItem_navigate,
            this.menuItem_question});
            this.menuStrip_main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_main.Name = "menuStrip_main";
            this.menuStrip_main.Size = new System.Drawing.Size(1061, 24);
            this.menuStrip_main.TabIndex = 0;
            this.menuStrip_main.Text = "menuStrip1";
            // 
            // menuItem_file
            // 
            this.menuItem_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_new,
            this.menuItem_delete,
            this.toolStripSeparator2,
            this.menuItem_save,
            this.menuItem_refresh,
            this.quitToolStripMenuItem,
            this.menuItem_close});
            this.menuItem_file.Name = "menuItem_file";
            this.menuItem_file.Size = new System.Drawing.Size(37, 20);
            this.menuItem_file.Text = "File";
            // 
            // menuItem_new
            // 
            this.menuItem_new.Image = global::GroceryManager.Properties.Resources.add;
            this.menuItem_new.Name = "menuItem_new";
            this.menuItem_new.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuItem_new.Size = new System.Drawing.Size(149, 22);
            this.menuItem_new.Text = "New";
            this.menuItem_new.Click += new System.EventHandler(this.menuItem_new_Click);
            // 
            // menuItem_delete
            // 
            this.menuItem_delete.Image = global::GroceryManager.Properties.Resources.delete;
            this.menuItem_delete.Name = "menuItem_delete";
            this.menuItem_delete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.menuItem_delete.Size = new System.Drawing.Size(149, 22);
            this.menuItem_delete.Text = "Delete";
            this.menuItem_delete.Click += new System.EventHandler(this.menuItem_delete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(146, 6);
            // 
            // menuItem_save
            // 
            this.menuItem_save.Image = global::GroceryManager.Properties.Resources.diskette;
            this.menuItem_save.Name = "menuItem_save";
            this.menuItem_save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuItem_save.Size = new System.Drawing.Size(149, 22);
            this.menuItem_save.Text = "Save";
            this.menuItem_save.Click += new System.EventHandler(this.menuItem_save_Click);
            // 
            // menuItem_refresh
            // 
            this.menuItem_refresh.Image = global::GroceryManager.Properties.Resources.update;
            this.menuItem_refresh.Name = "menuItem_refresh";
            this.menuItem_refresh.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.menuItem_refresh.Size = new System.Drawing.Size(149, 22);
            this.menuItem_refresh.Text = "Refresh";
            this.menuItem_refresh.Click += new System.EventHandler(this.menuItem_refresh_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(146, 6);
            // 
            // menuItem_close
            // 
            this.menuItem_close.Name = "menuItem_close";
            this.menuItem_close.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.menuItem_close.Size = new System.Drawing.Size(149, 22);
            this.menuItem_close.Text = "Close";
            this.menuItem_close.Click += new System.EventHandler(this.menuItem_close_Click);
            // 
            // menuItem_edit
            // 
            this.menuItem_edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_undo,
            this.toolStripSeparator1,
            this.menuItem_search});
            this.menuItem_edit.Name = "menuItem_edit";
            this.menuItem_edit.Size = new System.Drawing.Size(39, 20);
            this.menuItem_edit.Text = "Edit";
            // 
            // menuItem_undo
            // 
            this.menuItem_undo.Image = global::GroceryManager.Properties.Resources.undo;
            this.menuItem_undo.Name = "menuItem_undo";
            this.menuItem_undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.menuItem_undo.Size = new System.Drawing.Size(149, 22);
            this.menuItem_undo.Text = "Undo";
            this.menuItem_undo.Click += new System.EventHandler(this.menuItem_undo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(146, 6);
            // 
            // menuItem_search
            // 
            this.menuItem_search.Image = global::GroceryManager.Properties.Resources.magnifier;
            this.menuItem_search.Name = "menuItem_search";
            this.menuItem_search.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.menuItem_search.Size = new System.Drawing.Size(149, 22);
            this.menuItem_search.Text = "Search";
            this.menuItem_search.Click += new System.EventHandler(this.menuItem_search_Click);
            // 
            // menuItem_navigate
            // 
            this.menuItem_navigate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_next,
            this.menuItem_previous,
            this.toolStripSeparator3,
            this.menuItem_first,
            this.menuItem_last});
            this.menuItem_navigate.Name = "menuItem_navigate";
            this.menuItem_navigate.Size = new System.Drawing.Size(66, 20);
            this.menuItem_navigate.Text = "Navigate";
            // 
            // menuItem_next
            // 
            this.menuItem_next.Image = global::GroceryManager.Properties.Resources.resultset_next;
            this.menuItem_next.Name = "menuItem_next";
            this.menuItem_next.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.menuItem_next.Size = new System.Drawing.Size(168, 22);
            this.menuItem_next.Text = "Next";
            this.menuItem_next.Click += new System.EventHandler(this.menuItem_next_Click);
            // 
            // menuItem_previous
            // 
            this.menuItem_previous.Image = global::GroceryManager.Properties.Resources.resultset_previous;
            this.menuItem_previous.Name = "menuItem_previous";
            this.menuItem_previous.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.menuItem_previous.Size = new System.Drawing.Size(168, 22);
            this.menuItem_previous.Text = "Previous";
            this.menuItem_previous.Click += new System.EventHandler(this.menuItem_previous_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(165, 6);
            // 
            // menuItem_first
            // 
            this.menuItem_first.Image = global::GroceryManager.Properties.Resources.resultset_first;
            this.menuItem_first.Name = "menuItem_first";
            this.menuItem_first.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Home)));
            this.menuItem_first.Size = new System.Drawing.Size(168, 22);
            this.menuItem_first.Text = "First";
            this.menuItem_first.Click += new System.EventHandler(this.menuItem_first_Click);
            // 
            // menuItem_last
            // 
            this.menuItem_last.Image = global::GroceryManager.Properties.Resources.resultset_last;
            this.menuItem_last.Name = "menuItem_last";
            this.menuItem_last.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.End)));
            this.menuItem_last.Size = new System.Drawing.Size(168, 22);
            this.menuItem_last.Text = "Last";
            this.menuItem_last.Click += new System.EventHandler(this.menuItem_last_Click);
            // 
            // menuItem_question
            // 
            this.menuItem_question.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_help});
            this.menuItem_question.Name = "menuItem_question";
            this.menuItem_question.Size = new System.Drawing.Size(24, 20);
            this.menuItem_question.Text = "?";
            // 
            // menuItem_help
            // 
            this.menuItem_help.Image = global::GroceryManager.Properties.Resources.help;
            this.menuItem_help.Name = "menuItem_help";
            this.menuItem_help.Size = new System.Drawing.Size(99, 22);
            this.menuItem_help.Text = "Help";
            this.menuItem_help.Click += new System.EventHandler(this.menuItem_help_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer_main);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 323);
            this.panel1.TabIndex = 5;
            // 
            // statusStrip_main
            // 
            this.statusStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel_status,
            this.toolStripStatusLabel2,
            this.statusLabel_current,
            this.toolStripStatusLabel3,
            this.statusLabel_positionAndCount});
            this.statusStrip_main.Location = new System.Drawing.Point(0, 397);
            this.statusStrip_main.Name = "statusStrip_main";
            this.statusStrip_main.Size = new System.Drawing.Size(1061, 22);
            this.statusStrip_main.TabIndex = 0;
            this.statusStrip_main.Text = "statusStrip1";
            // 
            // statusLabel_status
            // 
            this.statusLabel_status.Name = "statusLabel_status";
            this.statusLabel_status.Size = new System.Drawing.Size(47, 17);
            this.statusLabel_status.Text = "{Status}";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(443, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // statusLabel_current
            // 
            this.statusLabel_current.Name = "statusLabel_current";
            this.statusLabel_current.Size = new System.Drawing.Size(76, 17);
            this.statusLabel_current.Text = "{Current}       ";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(443, 17);
            this.toolStripStatusLabel3.Spring = true;
            // 
            // statusLabel_positionAndCount
            // 
            this.statusLabel_positionAndCount.Name = "statusLabel_positionAndCount";
            this.statusLabel_positionAndCount.Size = new System.Drawing.Size(36, 17);
            this.statusLabel_positionAndCount.Text = "0 of 0";
            // 
            // toolStripContainer_main
            // 
            // 
            // toolStripContainer_main.ContentPanel
            // 
            this.toolStripContainer_main.ContentPanel.Controls.Add(this.panel1);
            this.toolStripContainer_main.ContentPanel.Size = new System.Drawing.Size(1061, 323);
            this.toolStripContainer_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer_main.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer_main.Name = "toolStripContainer_main";
            this.toolStripContainer_main.Size = new System.Drawing.Size(1061, 397);
            this.toolStripContainer_main.TabIndex = 7;
            this.toolStripContainer_main.Text = "toolStripContainer1";
            // 
            // toolStripContainer_main.TopToolStripPanel
            // 
            this.toolStripContainer_main.TopToolStripPanel.Controls.Add(this.menuStrip_main);
            this.toolStripContainer_main.TopToolStripPanel.Controls.Add(this.toolStrip_main);
            this.toolStripContainer_main.TopToolStripPanel.Controls.Add(this.toolStrip_search);
            // 
            // toolStrip_search
            // 
            this.toolStrip_search.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip_search.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textBox_search,
            this.button_clearSearch,
            this.button_search});
            this.toolStrip_search.Location = new System.Drawing.Point(3, 49);
            this.toolStrip_search.Name = "toolStrip_search";
            this.toolStrip_search.Size = new System.Drawing.Size(260, 25);
            this.toolStrip_search.TabIndex = 2;
            // 
            // textBox_search
            // 
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(200, 25);
            this.textBox_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_search_KeyDown);
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // button_clearSearch
            // 
            this.button_clearSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_clearSearch.Image = global::GroceryManager.Properties.Resources.cross;
            this.button_clearSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_clearSearch.Name = "button_clearSearch";
            this.button_clearSearch.Size = new System.Drawing.Size(23, 22);
            this.button_clearSearch.Text = "Clear";
            this.button_clearSearch.Click += new System.EventHandler(this.button_clearSearch_Click);
            // 
            // button_search
            // 
            this.button_search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_search.Image = global::GroceryManager.Properties.Resources.magnifier;
            this.button_search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(23, 22);
            this.button_search.Text = "Search";
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // Form_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 419);
            this.Controls.Add(this.toolStripContainer_main);
            this.Controls.Add(this.statusStrip_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Products";
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.database)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_product)).EndInit();
            this.splitContainer_main.Panel1.ResumeLayout(false);
            this.splitContainer_main.Panel1.PerformLayout();
            this.splitContainer_main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_main)).EndInit();
            this.splitContainer_main.ResumeLayout(false);
            this.toolStrip_main.ResumeLayout(false);
            this.toolStrip_main.PerformLayout();
            this.menuStrip_main.ResumeLayout(false);
            this.menuStrip_main.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.statusStrip_main.ResumeLayout(false);
            this.statusStrip_main.PerformLayout();
            this.toolStripContainer_main.ContentPanel.ResumeLayout(false);
            this.toolStripContainer_main.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer_main.TopToolStripPanel.PerformLayout();
            this.toolStripContainer_main.ResumeLayout(false);
            this.toolStripContainer_main.PerformLayout();
            this.toolStrip_search.ResumeLayout(false);
            this.toolStrip_search.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database database;
        private System.Windows.Forms.BindingSource bindingSource_product;
        private DatabaseTableAdapters.productTableAdapter tableAdapter_product;
        private DatabaseTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView_product;
        private System.Windows.Forms.SplitContainer splitContainer_main;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox upcTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox net_priceTextBox;
        private System.Windows.Forms.TextBox tax_percentTextBox;
        private System.Windows.Forms.TextBox discount_percentTextBox;
        private System.Windows.Forms.TextBox stock_quantityTextBox;
        private System.Windows.Forms.ToolStrip toolStrip_main;
        private System.Windows.Forms.ToolStripButton button_new;
        private System.Windows.Forms.MenuStrip menuStrip_main;
        private System.Windows.Forms.ToolStripMenuItem menuItem_file;
        private System.Windows.Forms.ToolStripMenuItem menuItem_edit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem menuItem_new;
        private System.Windows.Forms.ToolStripMenuItem menuItem_delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuItem_save;
        private System.Windows.Forms.ToolStripSeparator quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItem_close;
        private System.Windows.Forms.ToolStripMenuItem menuItem_undo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItem_navigate;
        private System.Windows.Forms.ToolStripMenuItem menuItem_next;
        private System.Windows.Forms.ToolStripMenuItem menuItem_previous;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuItem_first;
        private System.Windows.Forms.ToolStripMenuItem menuItem_last;
        private System.Windows.Forms.ToolStripMenuItem menuItem_question;
        private System.Windows.Forms.ToolStripMenuItem menuItem_refresh;
        private System.Windows.Forms.ToolStripMenuItem menuItem_help;
        private System.Windows.Forms.StatusStrip statusStrip_main;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_positionAndCount;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_current;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripButton button_delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton button_save;
        private System.Windows.Forms.ToolStripButton button_refresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton button_undo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton button_first;
        private System.Windows.Forms.ToolStripButton button_previous;
        private System.Windows.Forms.ToolStripButton button_next;
        private System.Windows.Forms.ToolStripButton button_last;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripContainer toolStripContainer_main;
        private System.Windows.Forms.ToolStrip toolStrip_search;
        private System.Windows.Forms.ToolStripTextBox textBox_search;
        private System.Windows.Forms.ToolStripButton button_search;
        private System.Windows.Forms.ToolStripButton button_clearSearch;
        private System.Windows.Forms.ToolStripTextBox textBox_position;
        private System.Windows.Forms.ToolStripLabel label_of;
        private System.Windows.Forms.ToolStripLabel label_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TextBox update_dateTextBox;
        private System.Windows.Forms.TextBox create_dateTextBox;
        private System.Windows.Forms.ToolStripMenuItem menuItem_search;
    }
}