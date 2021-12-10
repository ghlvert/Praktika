
namespace Plumbing_shop
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label product_IDLabel;
            System.Windows.Forms.Label product_NameLabel;
            System.Windows.Forms.Label manufacturer_NameLabel;
            this.dataSet1 = new Plumbing_shop.dataSet1();
            this.manufacturer_Plumbing_productssBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufacturer_Plumbing_productssTableAdapter = new Plumbing_shop.dataSet1TableAdapters.Manufacturer_Plumbing_productssTableAdapter();
            this.tableAdapterManager = new Plumbing_shop.dataSet1TableAdapters.TableAdapterManager();
            this.manufacturer_Plumbing_productssBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.manufacturer_Plumbing_productssBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.manufacturer_Plumbing_productssDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_IDTextBox = new System.Windows.Forms.TextBox();
            this.product_NameTextBox = new System.Windows.Forms.TextBox();
            this.manufacturer_NameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            product_IDLabel = new System.Windows.Forms.Label();
            product_NameLabel = new System.Windows.Forms.Label();
            manufacturer_NameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturer_Plumbing_productssBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturer_Plumbing_productssBindingNavigator)).BeginInit();
            this.manufacturer_Plumbing_productssBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturer_Plumbing_productssDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "dataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // manufacturer_Plumbing_productssBindingSource
            // 
            this.manufacturer_Plumbing_productssBindingSource.DataMember = "Manufacturer_Plumbing_productss";
            this.manufacturer_Plumbing_productssBindingSource.DataSource = this.dataSet1;
            // 
            // manufacturer_Plumbing_productssTableAdapter
            // 
            this.manufacturer_Plumbing_productssTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Manufacturer_Plumbing_productssTableAdapter = this.manufacturer_Plumbing_productssTableAdapter;
            this.tableAdapterManager.Manufacturer_SupplierTableAdapter = null;
            this.tableAdapterManager.Manufacturer1TableAdapter = null;
            this.tableAdapterManager.Plumbing_products1TableAdapter = null;
            this.tableAdapterManager.PurchaseTableAdapter = null;
            this.tableAdapterManager.Sale_plumbing_productsTableAdapter = null;
            this.tableAdapterManager.Sale1TableAdapter = null;
            this.tableAdapterManager.Supplier_PurchaseTableAdapter = null;
            this.tableAdapterManager.supplierrTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Plumbing_shop.dataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WarehouseTableAdapter = null;
            // 
            // manufacturer_Plumbing_productssBindingNavigator
            // 
            this.manufacturer_Plumbing_productssBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.manufacturer_Plumbing_productssBindingNavigator.BindingSource = this.manufacturer_Plumbing_productssBindingSource;
            this.manufacturer_Plumbing_productssBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.manufacturer_Plumbing_productssBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.manufacturer_Plumbing_productssBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.manufacturer_Plumbing_productssBindingNavigatorSaveItem});
            this.manufacturer_Plumbing_productssBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.manufacturer_Plumbing_productssBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.manufacturer_Plumbing_productssBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.manufacturer_Plumbing_productssBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.manufacturer_Plumbing_productssBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.manufacturer_Plumbing_productssBindingNavigator.Name = "manufacturer_Plumbing_productssBindingNavigator";
            this.manufacturer_Plumbing_productssBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.manufacturer_Plumbing_productssBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.manufacturer_Plumbing_productssBindingNavigator.TabIndex = 0;
            this.manufacturer_Plumbing_productssBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // manufacturer_Plumbing_productssBindingNavigatorSaveItem
            // 
            this.manufacturer_Plumbing_productssBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.manufacturer_Plumbing_productssBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("manufacturer_Plumbing_productssBindingNavigatorSaveItem.Image")));
            this.manufacturer_Plumbing_productssBindingNavigatorSaveItem.Name = "manufacturer_Plumbing_productssBindingNavigatorSaveItem";
            this.manufacturer_Plumbing_productssBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.manufacturer_Plumbing_productssBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.manufacturer_Plumbing_productssBindingNavigatorSaveItem.Click += new System.EventHandler(this.manufacturer_Plumbing_productssBindingNavigatorSaveItem_Click);
            // 
            // manufacturer_Plumbing_productssDataGridView
            // 
            this.manufacturer_Plumbing_productssDataGridView.AutoGenerateColumns = false;
            this.manufacturer_Plumbing_productssDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manufacturer_Plumbing_productssDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.manufacturer_Plumbing_productssDataGridView.DataSource = this.manufacturer_Plumbing_productssBindingSource;
            this.manufacturer_Plumbing_productssDataGridView.Location = new System.Drawing.Point(66, 38);
            this.manufacturer_Plumbing_productssDataGridView.Name = "manufacturer_Plumbing_productssDataGridView";
            this.manufacturer_Plumbing_productssDataGridView.Size = new System.Drawing.Size(494, 220);
            this.manufacturer_Plumbing_productssDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Product_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Product_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Product_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Product_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Manufacturer_Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Manufacturer_Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // product_IDLabel
            // 
            product_IDLabel.AutoSize = true;
            product_IDLabel.Location = new System.Drawing.Point(80, 297);
            product_IDLabel.Name = "product_IDLabel";
            product_IDLabel.Size = new System.Drawing.Size(61, 13);
            product_IDLabel.TabIndex = 2;
            product_IDLabel.Text = "Product ID:";
            // 
            // product_IDTextBox
            // 
            this.product_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturer_Plumbing_productssBindingSource, "Product_ID", true));
            this.product_IDTextBox.Location = new System.Drawing.Point(190, 294);
            this.product_IDTextBox.Name = "product_IDTextBox";
            this.product_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.product_IDTextBox.TabIndex = 3;
            // 
            // product_NameLabel
            // 
            product_NameLabel.AutoSize = true;
            product_NameLabel.Location = new System.Drawing.Point(80, 323);
            product_NameLabel.Name = "product_NameLabel";
            product_NameLabel.Size = new System.Drawing.Size(78, 13);
            product_NameLabel.TabIndex = 4;
            product_NameLabel.Text = "Product Name:";
            // 
            // product_NameTextBox
            // 
            this.product_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturer_Plumbing_productssBindingSource, "Product_Name", true));
            this.product_NameTextBox.Location = new System.Drawing.Point(190, 320);
            this.product_NameTextBox.Name = "product_NameTextBox";
            this.product_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.product_NameTextBox.TabIndex = 5;
            // 
            // manufacturer_NameLabel
            // 
            manufacturer_NameLabel.AutoSize = true;
            manufacturer_NameLabel.Location = new System.Drawing.Point(80, 349);
            manufacturer_NameLabel.Name = "manufacturer_NameLabel";
            manufacturer_NameLabel.Size = new System.Drawing.Size(104, 13);
            manufacturer_NameLabel.TabIndex = 6;
            manufacturer_NameLabel.Text = "Manufacturer Name:";
            // 
            // manufacturer_NameTextBox
            // 
            this.manufacturer_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturer_Plumbing_productssBindingSource, "Manufacturer_Name", true));
            this.manufacturer_NameTextBox.Location = new System.Drawing.Point(190, 346);
            this.manufacturer_NameTextBox.Name = "manufacturer_NameTextBox";
            this.manufacturer_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.manufacturer_NameTextBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(647, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "new record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(647, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(product_IDLabel);
            this.Controls.Add(this.product_IDTextBox);
            this.Controls.Add(product_NameLabel);
            this.Controls.Add(this.product_NameTextBox);
            this.Controls.Add(manufacturer_NameLabel);
            this.Controls.Add(this.manufacturer_NameTextBox);
            this.Controls.Add(this.manufacturer_Plumbing_productssDataGridView);
            this.Controls.Add(this.manufacturer_Plumbing_productssBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturer_Plumbing_productssBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturer_Plumbing_productssBindingNavigator)).EndInit();
            this.manufacturer_Plumbing_productssBindingNavigator.ResumeLayout(false);
            this.manufacturer_Plumbing_productssBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturer_Plumbing_productssDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dataSet1 dataSet1;
        private System.Windows.Forms.BindingSource manufacturer_Plumbing_productssBindingSource;
        private dataSet1TableAdapters.Manufacturer_Plumbing_productssTableAdapter manufacturer_Plumbing_productssTableAdapter;
        private dataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator manufacturer_Plumbing_productssBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton manufacturer_Plumbing_productssBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView manufacturer_Plumbing_productssDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox product_IDTextBox;
        private System.Windows.Forms.TextBox product_NameTextBox;
        private System.Windows.Forms.TextBox manufacturer_NameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

