namespace Apteka
{
    partial class Form3
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
            System.Windows.Forms.Label medicine_idLabel;
            System.Windows.Forms.Label medicine_nameLabel;
            System.Windows.Forms.Label medicine_groupLabel;
            System.Windows.Forms.Label medicine_arrivaldateLabel;
            System.Windows.Forms.Label medicine_priceLabel;
            System.Windows.Forms.Label medicine_expirationdateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dataSet1 = new Apteka.DataSet1();
            this.medicinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicinesTableAdapter = new Apteka.DataSet1TableAdapters.medicinesTableAdapter();
            this.tableAdapterManager = new Apteka.DataSet1TableAdapters.TableAdapterManager();
            this.medicinesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.medicinesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.medicinesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicine_idTextBox = new System.Windows.Forms.TextBox();
            this.medicine_nameTextBox = new System.Windows.Forms.TextBox();
            this.medicine_groupTextBox = new System.Windows.Forms.TextBox();
            this.medicine_arrivaldateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.medicine_priceTextBox = new System.Windows.Forms.TextBox();
            this.medicine_expirationdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Create = new System.Windows.Forms.Button();
            this.AddNEW = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            medicine_idLabel = new System.Windows.Forms.Label();
            medicine_nameLabel = new System.Windows.Forms.Label();
            medicine_groupLabel = new System.Windows.Forms.Label();
            medicine_arrivaldateLabel = new System.Windows.Forms.Label();
            medicine_priceLabel = new System.Windows.Forms.Label();
            medicine_expirationdateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingNavigator)).BeginInit();
            this.medicinesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // medicine_idLabel
            // 
            medicine_idLabel.AutoSize = true;
            medicine_idLabel.Location = new System.Drawing.Point(25, 288);
            medicine_idLabel.Name = "medicine_idLabel";
            medicine_idLabel.Size = new System.Drawing.Size(83, 17);
            medicine_idLabel.TabIndex = 2;
            medicine_idLabel.Text = "medicine id:";
            // 
            // medicine_nameLabel
            // 
            medicine_nameLabel.AutoSize = true;
            medicine_nameLabel.Location = new System.Drawing.Point(25, 316);
            medicine_nameLabel.Name = "medicine_nameLabel";
            medicine_nameLabel.Size = new System.Drawing.Size(107, 17);
            medicine_nameLabel.TabIndex = 4;
            medicine_nameLabel.Text = "medicine name:";
            // 
            // medicine_groupLabel
            // 
            medicine_groupLabel.AutoSize = true;
            medicine_groupLabel.Location = new System.Drawing.Point(25, 344);
            medicine_groupLabel.Name = "medicine_groupLabel";
            medicine_groupLabel.Size = new System.Drawing.Size(109, 17);
            medicine_groupLabel.TabIndex = 6;
            medicine_groupLabel.Text = "medicine group:";
            // 
            // medicine_arrivaldateLabel
            // 
            medicine_arrivaldateLabel.AutoSize = true;
            medicine_arrivaldateLabel.Location = new System.Drawing.Point(25, 373);
            medicine_arrivaldateLabel.Name = "medicine_arrivaldateLabel";
            medicine_arrivaldateLabel.Size = new System.Drawing.Size(139, 17);
            medicine_arrivaldateLabel.TabIndex = 8;
            medicine_arrivaldateLabel.Text = "medicine arrivaldate:";
            // 
            // medicine_priceLabel
            // 
            medicine_priceLabel.AutoSize = true;
            medicine_priceLabel.Location = new System.Drawing.Point(25, 400);
            medicine_priceLabel.Name = "medicine_priceLabel";
            medicine_priceLabel.Size = new System.Drawing.Size(103, 17);
            medicine_priceLabel.TabIndex = 10;
            medicine_priceLabel.Text = "medicine price:";
            // 
            // medicine_expirationdateLabel
            // 
            medicine_expirationdateLabel.AutoSize = true;
            medicine_expirationdateLabel.Location = new System.Drawing.Point(25, 429);
            medicine_expirationdateLabel.Name = "medicine_expirationdateLabel";
            medicine_expirationdateLabel.Size = new System.Drawing.Size(161, 17);
            medicine_expirationdateLabel.TabIndex = 12;
            medicine_expirationdateLabel.Text = "medicine expirationdate:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicinesBindingSource
            // 
            this.medicinesBindingSource.DataMember = "medicines";
            this.medicinesBindingSource.DataSource = this.dataSet1;
            // 
            // medicinesTableAdapter
            // 
            this.medicinesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.doctorsTableAdapter = null;
            this.tableAdapterManager.medicinesTableAdapter = this.medicinesTableAdapter;
            this.tableAdapterManager.patientsTableAdapter = null;
            this.tableAdapterManager.pharmacistsTableAdapter = null;
            this.tableAdapterManager.recipesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Apteka.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // medicinesBindingNavigator
            // 
            this.medicinesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.medicinesBindingNavigator.BindingSource = this.medicinesBindingSource;
            this.medicinesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.medicinesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.medicinesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.medicinesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.medicinesBindingNavigatorSaveItem});
            this.medicinesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.medicinesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.medicinesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.medicinesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.medicinesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.medicinesBindingNavigator.Name = "medicinesBindingNavigator";
            this.medicinesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.medicinesBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.medicinesBindingNavigator.TabIndex = 0;
            this.medicinesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // medicinesBindingNavigatorSaveItem
            // 
            this.medicinesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.medicinesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("medicinesBindingNavigatorSaveItem.Image")));
            this.medicinesBindingNavigatorSaveItem.Name = "medicinesBindingNavigatorSaveItem";
            this.medicinesBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.medicinesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.medicinesBindingNavigatorSaveItem.Click += new System.EventHandler(this.MedicinesBindingNavigatorSaveItem_Click);
            // 
            // medicinesDataGridView
            // 
            this.medicinesDataGridView.AutoGenerateColumns = false;
            this.medicinesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicinesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.medicinesDataGridView.DataSource = this.medicinesBindingSource;
            this.medicinesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.medicinesDataGridView.Name = "medicinesDataGridView";
            this.medicinesDataGridView.RowHeadersWidth = 51;
            this.medicinesDataGridView.RowTemplate.Height = 24;
            this.medicinesDataGridView.Size = new System.Drawing.Size(802, 220);
            this.medicinesDataGridView.TabIndex = 1;
            this.medicinesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MedicinesDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "medicine_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "medicine_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "medicine_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "medicine_name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "medicine_group";
            this.dataGridViewTextBoxColumn3.HeaderText = "medicine_group";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "medicine_arrivaldate";
            this.dataGridViewTextBoxColumn4.HeaderText = "medicine_arrivaldate";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "medicine_price";
            this.dataGridViewTextBoxColumn5.HeaderText = "medicine_price";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "medicine_expirationdate";
            this.dataGridViewTextBoxColumn6.HeaderText = "medicine_expirationdate";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // medicine_idTextBox
            // 
            this.medicine_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicinesBindingSource, "medicine_id", true));
            this.medicine_idTextBox.Location = new System.Drawing.Point(192, 285);
            this.medicine_idTextBox.Name = "medicine_idTextBox";
            this.medicine_idTextBox.Size = new System.Drawing.Size(200, 22);
            this.medicine_idTextBox.TabIndex = 3;
            // 
            // medicine_nameTextBox
            // 
            this.medicine_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicinesBindingSource, "medicine_name", true));
            this.medicine_nameTextBox.Location = new System.Drawing.Point(192, 313);
            this.medicine_nameTextBox.Name = "medicine_nameTextBox";
            this.medicine_nameTextBox.Size = new System.Drawing.Size(200, 22);
            this.medicine_nameTextBox.TabIndex = 5;
            // 
            // medicine_groupTextBox
            // 
            this.medicine_groupTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicinesBindingSource, "medicine_group", true));
            this.medicine_groupTextBox.Location = new System.Drawing.Point(192, 341);
            this.medicine_groupTextBox.Name = "medicine_groupTextBox";
            this.medicine_groupTextBox.Size = new System.Drawing.Size(200, 22);
            this.medicine_groupTextBox.TabIndex = 7;
            // 
            // medicine_arrivaldateDateTimePicker
            // 
            this.medicine_arrivaldateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.medicinesBindingSource, "medicine_arrivaldate", true));
            this.medicine_arrivaldateDateTimePicker.Location = new System.Drawing.Point(192, 369);
            this.medicine_arrivaldateDateTimePicker.Name = "medicine_arrivaldateDateTimePicker";
            this.medicine_arrivaldateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.medicine_arrivaldateDateTimePicker.TabIndex = 9;
            // 
            // medicine_priceTextBox
            // 
            this.medicine_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicinesBindingSource, "medicine_price", true));
            this.medicine_priceTextBox.Location = new System.Drawing.Point(192, 397);
            this.medicine_priceTextBox.Name = "medicine_priceTextBox";
            this.medicine_priceTextBox.Size = new System.Drawing.Size(200, 22);
            this.medicine_priceTextBox.TabIndex = 11;
            // 
            // medicine_expirationdateDateTimePicker
            // 
            this.medicine_expirationdateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.medicinesBindingSource, "medicine_expirationdate", true));
            this.medicine_expirationdateDateTimePicker.Location = new System.Drawing.Point(192, 425);
            this.medicine_expirationdateDateTimePicker.Name = "medicine_expirationdateDateTimePicker";
            this.medicine_expirationdateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.medicine_expirationdateDateTimePicker.TabIndex = 13;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(28, 243);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(364, 23);
            this.Create.TabIndex = 14;
            this.Create.Text = "Создать свободное поле";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // AddNEW
            // 
            this.AddNEW.Location = new System.Drawing.Point(28, 474);
            this.AddNEW.Name = "AddNEW";
            this.AddNEW.Size = new System.Drawing.Size(364, 23);
            this.AddNEW.TabIndex = 15;
            this.AddNEW.Text = "Добавить запись";
            this.AddNEW.UseVisualStyleBackColor = true;
            this.AddNEW.Click += new System.EventHandler(this.AddNEW_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(501, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 47);
            this.button1.TabIndex = 16;
            this.button1.Text = "Найти запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddNEW);
            this.Controls.Add(this.Create);
            this.Controls.Add(medicine_idLabel);
            this.Controls.Add(this.medicine_idTextBox);
            this.Controls.Add(medicine_nameLabel);
            this.Controls.Add(this.medicine_nameTextBox);
            this.Controls.Add(medicine_groupLabel);
            this.Controls.Add(this.medicine_groupTextBox);
            this.Controls.Add(medicine_arrivaldateLabel);
            this.Controls.Add(this.medicine_arrivaldateDateTimePicker);
            this.Controls.Add(medicine_priceLabel);
            this.Controls.Add(this.medicine_priceTextBox);
            this.Controls.Add(medicine_expirationdateLabel);
            this.Controls.Add(this.medicine_expirationdateDateTimePicker);
            this.Controls.Add(this.medicinesDataGridView);
            this.Controls.Add(this.medicinesBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = " Medicines";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingNavigator)).EndInit();
            this.medicinesBindingNavigator.ResumeLayout(false);
            this.medicinesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource medicinesBindingSource;
        private DataSet1TableAdapters.medicinesTableAdapter medicinesTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator medicinesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton medicinesBindingNavigatorSaveItem;
        public System.Windows.Forms.DataGridView medicinesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox medicine_idTextBox;
        private System.Windows.Forms.TextBox medicine_nameTextBox;
        private System.Windows.Forms.TextBox medicine_groupTextBox;
        private System.Windows.Forms.DateTimePicker medicine_arrivaldateDateTimePicker;
        private System.Windows.Forms.TextBox medicine_priceTextBox;
        private System.Windows.Forms.DateTimePicker medicine_expirationdateDateTimePicker;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button AddNEW;
        private System.Windows.Forms.Button button1;
    }
}