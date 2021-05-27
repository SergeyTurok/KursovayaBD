namespace Apteka
{
    partial class Form4
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
            System.Windows.Forms.Label patient_idLabel;
            System.Windows.Forms.Label patient_nameLabel;
            System.Windows.Forms.Label patient_surnameLabel;
            System.Windows.Forms.Label patient_birthdayLabel;
            System.Windows.Forms.Label patient_workexLabel;
            System.Windows.Forms.Label patient_adressLabel;
            System.Windows.Forms.Label patient_phoneLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.dataSet1 = new Apteka.DataSet1();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTableAdapter = new Apteka.DataSet1TableAdapters.patientsTableAdapter();
            this.tableAdapterManager = new Apteka.DataSet1TableAdapters.TableAdapterManager();
            this.patientsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.patientsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.patientsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patient_idTextBox = new System.Windows.Forms.TextBox();
            this.patient_nameTextBox = new System.Windows.Forms.TextBox();
            this.patient_surnameTextBox = new System.Windows.Forms.TextBox();
            this.patient_birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.patient_workexTextBox = new System.Windows.Forms.TextBox();
            this.patient_adressTextBox = new System.Windows.Forms.TextBox();
            this.patient_phoneTextBox = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.AddNEW = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            patient_idLabel = new System.Windows.Forms.Label();
            patient_nameLabel = new System.Windows.Forms.Label();
            patient_surnameLabel = new System.Windows.Forms.Label();
            patient_birthdayLabel = new System.Windows.Forms.Label();
            patient_workexLabel = new System.Windows.Forms.Label();
            patient_adressLabel = new System.Windows.Forms.Label();
            patient_phoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingNavigator)).BeginInit();
            this.patientsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // patient_idLabel
            // 
            patient_idLabel.AutoSize = true;
            patient_idLabel.Location = new System.Drawing.Point(21, 284);
            patient_idLabel.Name = "patient_idLabel";
            patient_idLabel.Size = new System.Drawing.Size(70, 17);
            patient_idLabel.TabIndex = 2;
            patient_idLabel.Text = "patient id:";
            // 
            // patient_nameLabel
            // 
            patient_nameLabel.AutoSize = true;
            patient_nameLabel.Location = new System.Drawing.Point(21, 312);
            patient_nameLabel.Name = "patient_nameLabel";
            patient_nameLabel.Size = new System.Drawing.Size(94, 17);
            patient_nameLabel.TabIndex = 4;
            patient_nameLabel.Text = "patient name:";
            // 
            // patient_surnameLabel
            // 
            patient_surnameLabel.AutoSize = true;
            patient_surnameLabel.Location = new System.Drawing.Point(21, 340);
            patient_surnameLabel.Name = "patient_surnameLabel";
            patient_surnameLabel.Size = new System.Drawing.Size(114, 17);
            patient_surnameLabel.TabIndex = 6;
            patient_surnameLabel.Text = "patient surname:";
            // 
            // patient_birthdayLabel
            // 
            patient_birthdayLabel.AutoSize = true;
            patient_birthdayLabel.Location = new System.Drawing.Point(21, 369);
            patient_birthdayLabel.Name = "patient_birthdayLabel";
            patient_birthdayLabel.Size = new System.Drawing.Size(110, 17);
            patient_birthdayLabel.TabIndex = 8;
            patient_birthdayLabel.Text = "patient birthday:";
            // 
            // patient_workexLabel
            // 
            patient_workexLabel.AutoSize = true;
            patient_workexLabel.Location = new System.Drawing.Point(21, 396);
            patient_workexLabel.Name = "patient_workexLabel";
            patient_workexLabel.Size = new System.Drawing.Size(102, 17);
            patient_workexLabel.TabIndex = 10;
            patient_workexLabel.Text = "patient workex:";
            // 
            // patient_adressLabel
            // 
            patient_adressLabel.AutoSize = true;
            patient_adressLabel.Location = new System.Drawing.Point(21, 424);
            patient_adressLabel.Name = "patient_adressLabel";
            patient_adressLabel.Size = new System.Drawing.Size(102, 17);
            patient_adressLabel.TabIndex = 12;
            patient_adressLabel.Text = "patient adress:";
            // 
            // patient_phoneLabel
            // 
            patient_phoneLabel.AutoSize = true;
            patient_phoneLabel.Location = new System.Drawing.Point(21, 452);
            patient_phoneLabel.Name = "patient_phoneLabel";
            patient_phoneLabel.Size = new System.Drawing.Size(99, 17);
            patient_phoneLabel.TabIndex = 14;
            patient_phoneLabel.Text = "patient phone:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "patients";
            this.patientsBindingSource.DataSource = this.dataSet1;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.doctorsTableAdapter = null;
            this.tableAdapterManager.medicinesTableAdapter = null;
            this.tableAdapterManager.patientsTableAdapter = this.patientsTableAdapter;
            this.tableAdapterManager.pharmacistsTableAdapter = null;
            this.tableAdapterManager.recipesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Apteka.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // patientsBindingNavigator
            // 
            this.patientsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.patientsBindingNavigator.BindingSource = this.patientsBindingSource;
            this.patientsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.patientsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.patientsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.patientsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.patientsBindingNavigatorSaveItem});
            this.patientsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.patientsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.patientsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.patientsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.patientsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.patientsBindingNavigator.Name = "patientsBindingNavigator";
            this.patientsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.patientsBindingNavigator.Size = new System.Drawing.Size(929, 27);
            this.patientsBindingNavigator.TabIndex = 0;
            this.patientsBindingNavigator.Text = "bindingNavigator1";
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
            // patientsBindingNavigatorSaveItem
            // 
            this.patientsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.patientsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("patientsBindingNavigatorSaveItem.Image")));
            this.patientsBindingNavigatorSaveItem.Name = "patientsBindingNavigatorSaveItem";
            this.patientsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.patientsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.patientsBindingNavigatorSaveItem.Click += new System.EventHandler(this.PatientsBindingNavigatorSaveItem_Click);
            // 
            // patientsDataGridView
            // 
            this.patientsDataGridView.AutoGenerateColumns = false;
            this.patientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.patientsDataGridView.DataSource = this.patientsBindingSource;
            this.patientsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.patientsDataGridView.Name = "patientsDataGridView";
            this.patientsDataGridView.RowHeadersWidth = 51;
            this.patientsDataGridView.RowTemplate.Height = 24;
            this.patientsDataGridView.Size = new System.Drawing.Size(928, 220);
            this.patientsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "patient_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "patient_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "patient_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "patient_name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "patient_surname";
            this.dataGridViewTextBoxColumn3.HeaderText = "patient_surname";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "patient_birthday";
            this.dataGridViewTextBoxColumn4.HeaderText = "patient_birthday";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "patient_workex";
            this.dataGridViewTextBoxColumn5.HeaderText = "patient_workex";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "patient_adress";
            this.dataGridViewTextBoxColumn6.HeaderText = "patient_adress";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "patient_phone";
            this.dataGridViewTextBoxColumn7.HeaderText = "patient_phone";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // patient_idTextBox
            // 
            this.patient_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "patient_id", true));
            this.patient_idTextBox.Location = new System.Drawing.Point(141, 281);
            this.patient_idTextBox.Name = "patient_idTextBox";
            this.patient_idTextBox.Size = new System.Drawing.Size(200, 22);
            this.patient_idTextBox.TabIndex = 3;
            // 
            // patient_nameTextBox
            // 
            this.patient_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "patient_name", true));
            this.patient_nameTextBox.Location = new System.Drawing.Point(141, 309);
            this.patient_nameTextBox.Name = "patient_nameTextBox";
            this.patient_nameTextBox.Size = new System.Drawing.Size(200, 22);
            this.patient_nameTextBox.TabIndex = 5;
            // 
            // patient_surnameTextBox
            // 
            this.patient_surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "patient_surname", true));
            this.patient_surnameTextBox.Location = new System.Drawing.Point(141, 337);
            this.patient_surnameTextBox.Name = "patient_surnameTextBox";
            this.patient_surnameTextBox.Size = new System.Drawing.Size(200, 22);
            this.patient_surnameTextBox.TabIndex = 7;
            // 
            // patient_birthdayDateTimePicker
            // 
            this.patient_birthdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientsBindingSource, "patient_birthday", true));
            this.patient_birthdayDateTimePicker.Location = new System.Drawing.Point(141, 365);
            this.patient_birthdayDateTimePicker.Name = "patient_birthdayDateTimePicker";
            this.patient_birthdayDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.patient_birthdayDateTimePicker.TabIndex = 9;
            // 
            // patient_workexTextBox
            // 
            this.patient_workexTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "patient_workex", true));
            this.patient_workexTextBox.Location = new System.Drawing.Point(141, 393);
            this.patient_workexTextBox.Name = "patient_workexTextBox";
            this.patient_workexTextBox.Size = new System.Drawing.Size(200, 22);
            this.patient_workexTextBox.TabIndex = 11;
            // 
            // patient_adressTextBox
            // 
            this.patient_adressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "patient_adress", true));
            this.patient_adressTextBox.Location = new System.Drawing.Point(141, 421);
            this.patient_adressTextBox.Name = "patient_adressTextBox";
            this.patient_adressTextBox.Size = new System.Drawing.Size(200, 22);
            this.patient_adressTextBox.TabIndex = 13;
            // 
            // patient_phoneTextBox
            // 
            this.patient_phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "patient_phone", true));
            this.patient_phoneTextBox.Location = new System.Drawing.Point(141, 449);
            this.patient_phoneTextBox.Name = "patient_phoneTextBox";
            this.patient_phoneTextBox.Size = new System.Drawing.Size(200, 22);
            this.patient_phoneTextBox.TabIndex = 15;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(24, 252);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(317, 23);
            this.Create.TabIndex = 16;
            this.Create.Text = "Создать свободное поле";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // AddNEW
            // 
            this.AddNEW.Location = new System.Drawing.Point(24, 477);
            this.AddNEW.Name = "AddNEW";
            this.AddNEW.Size = new System.Drawing.Size(317, 23);
            this.AddNEW.TabIndex = 17;
            this.AddNEW.Text = "Добавить запись";
            this.AddNEW.UseVisualStyleBackColor = true;
            this.AddNEW.Click += new System.EventHandler(this.AddNEW_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(629, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 52);
            this.button1.TabIndex = 18;
            this.button1.Text = "Найти запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 515);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddNEW);
            this.Controls.Add(this.Create);
            this.Controls.Add(patient_idLabel);
            this.Controls.Add(this.patient_idTextBox);
            this.Controls.Add(patient_nameLabel);
            this.Controls.Add(this.patient_nameTextBox);
            this.Controls.Add(patient_surnameLabel);
            this.Controls.Add(this.patient_surnameTextBox);
            this.Controls.Add(patient_birthdayLabel);
            this.Controls.Add(this.patient_birthdayDateTimePicker);
            this.Controls.Add(patient_workexLabel);
            this.Controls.Add(this.patient_workexTextBox);
            this.Controls.Add(patient_adressLabel);
            this.Controls.Add(this.patient_adressTextBox);
            this.Controls.Add(patient_phoneLabel);
            this.Controls.Add(this.patient_phoneTextBox);
            this.Controls.Add(this.patientsDataGridView);
            this.Controls.Add(this.patientsBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Patients";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingNavigator)).EndInit();
            this.patientsBindingNavigator.ResumeLayout(false);
            this.patientsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private DataSet1TableAdapters.patientsTableAdapter patientsTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator patientsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton patientsBindingNavigatorSaveItem;
        public System.Windows.Forms.DataGridView patientsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox patient_idTextBox;
        private System.Windows.Forms.TextBox patient_nameTextBox;
        private System.Windows.Forms.TextBox patient_surnameTextBox;
        private System.Windows.Forms.DateTimePicker patient_birthdayDateTimePicker;
        private System.Windows.Forms.TextBox patient_workexTextBox;
        private System.Windows.Forms.TextBox patient_adressTextBox;
        private System.Windows.Forms.TextBox patient_phoneTextBox;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button AddNEW;
        private System.Windows.Forms.Button button1;
    }
}