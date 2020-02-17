namespace qvogl2Project3FormsDatabase
{
    partial class updateInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateInventory));
            System.Windows.Forms.Label sizeLabel;
            System.Windows.Forms.Label itemLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label item_idLabel;
            this.inventoryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboDBDataSet = new qvogl2Project3FormsDatabase.comboDBDataSet();
            this.inventoryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.inventoryTableAdapter = new qvogl2Project3FormsDatabase.comboDBDataSetTableAdapters.inventoryTableAdapter();
            this.tableAdapterManager = new qvogl2Project3FormsDatabase.comboDBDataSetTableAdapters.TableAdapterManager();
            this.inventoryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.itemTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.item_idTextBox = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            sizeLabel = new System.Windows.Forms.Label();
            itemLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            item_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingNavigator)).BeginInit();
            this.inventoryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryBindingNavigator
            // 
            this.inventoryBindingNavigator.AddNewItem = null;
            this.inventoryBindingNavigator.BindingSource = this.inventoryBindingSource;
            this.inventoryBindingNavigator.CountItem = null;
            this.inventoryBindingNavigator.DeleteItem = null;
            this.inventoryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventoryBindingNavigatorSaveItem});
            this.inventoryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.inventoryBindingNavigator.MoveFirstItem = null;
            this.inventoryBindingNavigator.MoveLastItem = null;
            this.inventoryBindingNavigator.MoveNextItem = null;
            this.inventoryBindingNavigator.MovePreviousItem = null;
            this.inventoryBindingNavigator.Name = "inventoryBindingNavigator";
            this.inventoryBindingNavigator.PositionItem = null;
            this.inventoryBindingNavigator.Size = new System.Drawing.Size(473, 25);
            this.inventoryBindingNavigator.TabIndex = 0;
            this.inventoryBindingNavigator.Text = "bindingNavigator1";
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "inventory";
            this.inventoryBindingSource.DataSource = this.comboDBDataSet;
            // 
            // comboDBDataSet
            // 
            this.comboDBDataSet.DataSetName = "comboDBDataSet";
            this.comboDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryBindingNavigatorSaveItem
            // 
            this.inventoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.inventoryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("inventoryBindingNavigatorSaveItem.Image")));
            this.inventoryBindingNavigatorSaveItem.Name = "inventoryBindingNavigatorSaveItem";
            this.inventoryBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.inventoryBindingNavigatorSaveItem.Text = "Save Data";
            this.inventoryBindingNavigatorSaveItem.Click += new System.EventHandler(this.inventoryBindingNavigatorSaveItem_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(358, 122);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.combosTableAdapter = null;
            this.tableAdapterManager.inventoryTableAdapter = this.inventoryTableAdapter;
            this.tableAdapterManager.SalesTableAdapter = null;
            this.tableAdapterManager.size_priceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = qvogl2Project3FormsDatabase.comboDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // inventoryDataGridView
            // 
            this.inventoryDataGridView.AllowUserToAddRows = false;
            this.inventoryDataGridView.AllowUserToDeleteRows = false;
            this.inventoryDataGridView.AutoGenerateColumns = false;
            this.inventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.inventoryDataGridView.DataSource = this.inventoryBindingSource;
            this.inventoryDataGridView.Location = new System.Drawing.Point(12, 28);
            this.inventoryDataGridView.Name = "inventoryDataGridView";
            this.inventoryDataGridView.ReadOnly = true;
            this.inventoryDataGridView.Size = new System.Drawing.Size(295, 316);
            this.inventoryDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "size";
            this.dataGridViewTextBoxColumn1.HeaderText = "size";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "item";
            this.dataGridViewTextBoxColumn2.HeaderText = "item";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "quantity";
            this.dataGridViewTextBoxColumn3.HeaderText = "quantity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "item_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "item_id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "size:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "qty:";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(358, 70);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(100, 20);
            this.txtItem.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "item:";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(358, 44);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 20);
            this.txtSize.TabIndex = 2;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(358, 96);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 4;
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Location = new System.Drawing.Point(313, 199);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new System.Drawing.Size(28, 13);
            sizeLabel.TabIndex = 9;
            sizeLabel.Text = "size:";
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "size", true));
            this.sizeTextBox.Location = new System.Drawing.Point(358, 196);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.ReadOnly = true;
            this.sizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.sizeTextBox.TabIndex = 10;
            // 
            // itemLabel
            // 
            itemLabel.AutoSize = true;
            itemLabel.Location = new System.Drawing.Point(313, 225);
            itemLabel.Name = "itemLabel";
            itemLabel.Size = new System.Drawing.Size(29, 13);
            itemLabel.TabIndex = 11;
            itemLabel.Text = "item:";
            // 
            // itemTextBox
            // 
            this.itemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "item", true));
            this.itemTextBox.Location = new System.Drawing.Point(358, 222);
            this.itemTextBox.Name = "itemTextBox";
            this.itemTextBox.ReadOnly = true;
            this.itemTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemTextBox.TabIndex = 12;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(313, 251);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(24, 13);
            quantityLabel.TabIndex = 13;
            quantityLabel.Text = "qty:";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(358, 248);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 14;
            // 
            // item_idLabel
            // 
            item_idLabel.AutoSize = true;
            item_idLabel.Location = new System.Drawing.Point(313, 277);
            item_idLabel.Name = "item_idLabel";
            item_idLabel.Size = new System.Drawing.Size(40, 13);
            item_idLabel.TabIndex = 15;
            item_idLabel.Text = "item id:";
            // 
            // item_idTextBox
            // 
            this.item_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "item_id", true));
            this.item_idTextBox.Location = new System.Drawing.Point(359, 274);
            this.item_idTextBox.Name = "item_idTextBox";
            this.item_idTextBox.ReadOnly = true;
            this.item_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.item_idTextBox.TabIndex = 16;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(359, 300);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 23);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update Inventory";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // updateInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 364);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(sizeLabel);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(itemLabel);
            this.Controls.Add(this.itemTextBox);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(item_idLabel);
            this.Controls.Add(this.item_idTextBox);
            this.Controls.Add(this.inventoryDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.inventoryBindingNavigator);
            this.Name = "updateInventory";
            this.Text = "Update Inventory";
            this.Load += new System.EventHandler(this.updateInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingNavigator)).EndInit();
            this.inventoryBindingNavigator.ResumeLayout(false);
            this.inventoryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private comboDBDataSet comboDBDataSet;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private comboDBDataSetTableAdapters.inventoryTableAdapter inventoryTableAdapter;
        private comboDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator inventoryBindingNavigator;
        private System.Windows.Forms.ToolStripButton inventoryBindingNavigatorSaveItem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView inventoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.TextBox itemTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox item_idTextBox;
        private System.Windows.Forms.Button btnUpdate;
    }
}