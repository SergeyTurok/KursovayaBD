namespace Apteka
{
    partial class Form6
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
            System.Windows.Forms.Label recipe_idLabel;
            System.Windows.Forms.Label recipe_dateLabel;
            System.Windows.Forms.Label recipe_expirationdateLabel;
            System.Windows.Forms.Label doctorLabel;
            System.Windows.Forms.Label medicineLabel;
            System.Windows.Forms.Label patientLabel;
            System.Windows.Forms.Label pharmacistLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.dataSet1 = new Apteka.DataSet1();
            this.recipesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipesTableAdapter = new Apteka.DataSet1TableAdapters.recipesTableAdapter();
            this.tableAdapterManager = new Apteka.DataSet1TableAdapters.TableAdapterManager();
            this.recipesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.recipesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.recipesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recipe_idTextBox = new System.Windows.Forms.TextBox();
            this.recipe_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.recipe_expirationdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.doctorTextBox = new System.Windows.Forms.TextBox();
            this.medicineTextBox = new System.Windows.Forms.TextBox();
            this.patientTextBox = new System.Windows.Forms.TextBox();
            this.pharmacistTextBox = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.AddNEW = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            recipe_idLabel = new System.Windows.Forms.Label();
            recipe_dateLabel = new System.Windows.Forms.Label();
            recipe_expirationdateLabel = new System.Windows.Forms.Label();
            doctorLabel = new System.Windows.Forms.Label();
            medicineLabel = new System.Windows.Forms.Label();
            patientLabel = new System.Windows.Forms.Label();
            pharmacistLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingNavigator)).BeginInit();
            this.recipesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // recipe_idLabel
            // 
            recipe_idLabel.AutoSize = true;
            recipe_idLabel.Location = new System.Drawing.Point(33, 291);
            recipe_idLabel.Name = "recipe_idLabel";
            recipe_idLabel.Size = new System.Drawing.Size(66, 17);
            recipe_idLabel.TabIndex = 2;
            recipe_idLabel.Text = "recipe id:";
            // 
            // recipe_dateLabel
            // 
            recipe_dateLabel.AutoSize = true;
            recipe_dateLabel.Location = new System.Drawing.Point(33, 320);
            recipe_dateLabel.Name = "recipe_dateLabel";
            recipe_dateLabel.Size = new System.Drawing.Size(83, 17);
            recipe_dateLabel.TabIndex = 4;
            recipe_dateLabel.Text = "recipe date:";
            // 
            // recipe_expirationdateLabel
            // 
            recipe_expirationdateLabel.AutoSize = true;
            recipe_expirationdateLabel.Location = new System.Drawing.Point(33, 348);
            recipe_expirationdateLabel.Name = "recipe_expirationdateLabel";
            recipe_expirationdateLabel.Size = new System.Drawing.Size(144, 17);
            recipe_expirationdateLabel.TabIndex = 6;
            recipe_expirationdateLabel.Text = "recipe expirationdate:";
            // 
            // doctorLabel
            // 
            doctorLabel.AutoSize = true;
            doctorLabel.Location = new System.Drawing.Point(33, 375);
            doctorLabel.Name = "doctorLabel";
            doctorLabel.Size = new System.Drawing.Size(52, 17);
            doctorLabel.TabIndex = 8;
            doctorLabel.Text = "doctor:";
            // 
            // medicineLabel
            // 
            medicineLabel.AutoSize = true;
            medicineLabel.Location = new System.Drawing.Point(33, 403);
            medicineLabel.Name = "medicineLabel";
            medicineLabel.Size = new System.Drawing.Size(68, 17);
            medicineLabel.TabIndex = 10;
            medicineLabel.Text = "medicine:";
            // 
            // patientLabel
            // 
            patientLabel.AutoSize = true;
            patientLabel.Location = new System.Drawing.Point(33, 431);
            patientLabel.Name = "patientLabel";
            patientLabel.Size = new System.Drawing.Size(55, 17);
            patientLabel.TabIndex = 12;
            patientLabel.Text = "patient:";
            // 
            // pharmacistLabel
            // 
            pharmacistLabel.AutoSize = true;
            pharmacistLabel.Location = new System.Drawing.Point(33, 459);
            pharmacistLabel.Name = "pharmacistLabel";
            pharmacistLabel.Size = new System.Drawing.Size(81, 17);
            pharmacistLabel.TabIndex = 14;
            pharmacistLabel.Text = "pharmacist:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recipesBindingSource
            // 
            this.recipesBindingSource.DataMember = "recipes";
            this.recipesBindingSource.DataSource = this.dataSet1;
            // 
            // recipesTableAdapter
            // 
            this.recipesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.doctorsTableAdapter = null;
            this.tableAdapterManager.medicinesTableAdapter = null;
            this.tableAdapterManager.patientsTableAdapter = null;
            this.tableAdapterManager.pharmacistsTableAdapter = null;
            this.tableAdapterManager.recipesTableAdapter = this.recipesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Apteka.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // recipesBindingNavigator
            // 
            this.recipesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.recipesBindingNavigator.BindingSource = this.recipesBindingSource;
            this.recipesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.recipesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.recipesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.recipesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.recipesBindingNavigatorSaveItem});
            this.recipesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.recipesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.recipesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.recipesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.recipesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.recipesBindingNavigator.Name = "recipesBindingNavigator";
            this.recipesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.recipesBindingNavigator.Size = new System.Drawing.Size(932, 27);
            this.recipesBindingNavigator.TabIndex = 0;
            this.recipesBindingNavigator.Text = "bindingNavigator1";
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
            // recipesBindingNavigatorSaveItem
            // 
            this.recipesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.recipesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("recipesBindingNavigatorSaveItem.Image")));
            this.recipesBindingNavigatorSaveItem.Name = "recipesBindingNavigatorSaveItem";
            this.recipesBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.recipesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.recipesBindingNavigatorSaveItem.Click += new System.EventHandler(this.RecipesBindingNavigatorSaveItem_Click);
            // 
            // recipesDataGridView
            // 
            this.recipesDataGridView.AutoGenerateColumns = false;
            this.recipesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recipesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.recipesDataGridView.DataSource = this.recipesBindingSource;
            this.recipesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.recipesDataGridView.Name = "recipesDataGridView";
            this.recipesDataGridView.RowHeadersWidth = 51;
            this.recipesDataGridView.RowTemplate.Height = 24;
            this.recipesDataGridView.Size = new System.Drawing.Size(929, 220);
            this.recipesDataGridView.TabIndex = 1;
            this.recipesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RecipesDataGridView_CellContentClick);
            this.recipesDataGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.RecipesDataGridView_UserDeletedRow);
            this.recipesDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.RecipesDataGridView_UserDeletingRow);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "recipe_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "recipe_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "recipe_date";
            this.dataGridViewTextBoxColumn2.HeaderText = "recipe_date";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "recipe_expirationdate";
            this.dataGridViewTextBoxColumn3.HeaderText = "recipe_expirationdate";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "doctor";
            this.dataGridViewTextBoxColumn4.HeaderText = "doctor";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "medicine";
            this.dataGridViewTextBoxColumn5.HeaderText = "medicine";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "patient";
            this.dataGridViewTextBoxColumn6.HeaderText = "patient";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "pharmacist";
            this.dataGridViewTextBoxColumn7.HeaderText = "pharmacist";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // recipe_idTextBox
            // 
            this.recipe_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recipesBindingSource, "recipe_id", true));
            this.recipe_idTextBox.Location = new System.Drawing.Point(183, 288);
            this.recipe_idTextBox.Name = "recipe_idTextBox";
            this.recipe_idTextBox.Size = new System.Drawing.Size(200, 22);
            this.recipe_idTextBox.TabIndex = 3;
            // 
            // recipe_dateDateTimePicker
            // 
            this.recipe_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.recipesBindingSource, "recipe_date", true));
            this.recipe_dateDateTimePicker.Location = new System.Drawing.Point(183, 316);
            this.recipe_dateDateTimePicker.Name = "recipe_dateDateTimePicker";
            this.recipe_dateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.recipe_dateDateTimePicker.TabIndex = 5;
            // 
            // recipe_expirationdateDateTimePicker
            // 
            this.recipe_expirationdateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.recipesBindingSource, "recipe_expirationdate", true));
            this.recipe_expirationdateDateTimePicker.Location = new System.Drawing.Point(183, 344);
            this.recipe_expirationdateDateTimePicker.Name = "recipe_expirationdateDateTimePicker";
            this.recipe_expirationdateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.recipe_expirationdateDateTimePicker.TabIndex = 7;
            // 
            // doctorTextBox
            // 
            this.doctorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recipesBindingSource, "doctor", true));
            this.doctorTextBox.Location = new System.Drawing.Point(183, 372);
            this.doctorTextBox.Name = "doctorTextBox";
            this.doctorTextBox.Size = new System.Drawing.Size(200, 22);
            this.doctorTextBox.TabIndex = 9;
            // 
            // medicineTextBox
            // 
            this.medicineTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recipesBindingSource, "medicine", true));
            this.medicineTextBox.Location = new System.Drawing.Point(183, 400);
            this.medicineTextBox.Name = "medicineTextBox";
            this.medicineTextBox.Size = new System.Drawing.Size(200, 22);
            this.medicineTextBox.TabIndex = 11;
            // 
            // patientTextBox
            // 
            this.patientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recipesBindingSource, "patient", true));
            this.patientTextBox.Location = new System.Drawing.Point(183, 428);
            this.patientTextBox.Name = "patientTextBox";
            this.patientTextBox.Size = new System.Drawing.Size(200, 22);
            this.patientTextBox.TabIndex = 13;
            // 
            // pharmacistTextBox
            // 
            this.pharmacistTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recipesBindingSource, "pharmacist", true));
            this.pharmacistTextBox.Location = new System.Drawing.Point(183, 456);
            this.pharmacistTextBox.Name = "pharmacistTextBox";
            this.pharmacistTextBox.Size = new System.Drawing.Size(200, 22);
            this.pharmacistTextBox.TabIndex = 15;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(36, 258);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(347, 23);
            this.Create.TabIndex = 16;
            this.Create.Text = "Создать свободное поле";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // AddNEW
            // 
            this.AddNEW.Location = new System.Drawing.Point(36, 484);
            this.AddNEW.Name = "AddNEW";
            this.AddNEW.Size = new System.Drawing.Size(347, 23);
            this.AddNEW.TabIndex = 17;
            this.AddNEW.Text = "Добавить запись";
            this.AddNEW.UseVisualStyleBackColor = true;
            this.AddNEW.Click += new System.EventHandler(this.AddNEW_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(634, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 59);
            this.button1.TabIndex = 18;
            this.button1.Text = "Найти запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 512);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddNEW);
            this.Controls.Add(this.Create);
            this.Controls.Add(recipe_idLabel);
            this.Controls.Add(this.recipe_idTextBox);
            this.Controls.Add(recipe_dateLabel);
            this.Controls.Add(this.recipe_dateDateTimePicker);
            this.Controls.Add(recipe_expirationdateLabel);
            this.Controls.Add(this.recipe_expirationdateDateTimePicker);
            this.Controls.Add(doctorLabel);
            this.Controls.Add(this.doctorTextBox);
            this.Controls.Add(medicineLabel);
            this.Controls.Add(this.medicineTextBox);
            this.Controls.Add(patientLabel);
            this.Controls.Add(this.patientTextBox);
            this.Controls.Add(pharmacistLabel);
            this.Controls.Add(this.pharmacistTextBox);
            this.Controls.Add(this.recipesDataGridView);
            this.Controls.Add(this.recipesBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.Text = "Recipes";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingNavigator)).EndInit();
            this.recipesBindingNavigator.ResumeLayout(false);
            this.recipesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource recipesBindingSource;
        private DataSet1TableAdapters.recipesTableAdapter recipesTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator recipesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton recipesBindingNavigatorSaveItem;
        public System.Windows.Forms.DataGridView recipesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox recipe_idTextBox;
        private System.Windows.Forms.DateTimePicker recipe_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker recipe_expirationdateDateTimePicker;
        private System.Windows.Forms.TextBox doctorTextBox;
        private System.Windows.Forms.TextBox medicineTextBox;
        private System.Windows.Forms.TextBox patientTextBox;
        private System.Windows.Forms.TextBox pharmacistTextBox;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button AddNEW;
        private System.Windows.Forms.Button button1;
    }
}