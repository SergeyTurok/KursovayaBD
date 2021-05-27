namespace Apteka
{
    partial class Form5
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
            System.Windows.Forms.Label pharmacist_idLabel;
            System.Windows.Forms.Label pharmacist_nameLabel;
            System.Windows.Forms.Label pharmacist_surnameLabel;
            System.Windows.Forms.Label pharmacist_birthdayLabel;
            System.Windows.Forms.Label pharmacist_positionLabel;
            System.Windows.Forms.Label pharmacist_adressLabel;
            System.Windows.Forms.Label pharmacist_phoneLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.dataSet1 = new Apteka.DataSet1();
            this.pharmacistsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacistsTableAdapter = new Apteka.DataSet1TableAdapters.pharmacistsTableAdapter();
            this.tableAdapterManager = new Apteka.DataSet1TableAdapters.TableAdapterManager();
            this.pharmacistsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pharmacistsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pharmacistsDataGridView = new System.Windows.Forms.DataGridView();
            this.pharmacist_idTextBox = new System.Windows.Forms.TextBox();
            this.pharmacist_nameTextBox = new System.Windows.Forms.TextBox();
            this.pharmacist_surnameTextBox = new System.Windows.Forms.TextBox();
            this.pharmacist_birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pharmacist_positionTextBox = new System.Windows.Forms.TextBox();
            this.pharmacist_adressTextBox = new System.Windows.Forms.TextBox();
            this.pharmacist_phoneTextBox = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.AddNEW = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            pharmacist_idLabel = new System.Windows.Forms.Label();
            pharmacist_nameLabel = new System.Windows.Forms.Label();
            pharmacist_surnameLabel = new System.Windows.Forms.Label();
            pharmacist_birthdayLabel = new System.Windows.Forms.Label();
            pharmacist_positionLabel = new System.Windows.Forms.Label();
            pharmacist_adressLabel = new System.Windows.Forms.Label();
            pharmacist_phoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacistsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacistsBindingNavigator)).BeginInit();
            this.pharmacistsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacistsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pharmacist_idLabel
            // 
            pharmacist_idLabel.AutoSize = true;
            pharmacist_idLabel.Location = new System.Drawing.Point(24, 299);
            pharmacist_idLabel.Name = "pharmacist_idLabel";
            pharmacist_idLabel.Size = new System.Drawing.Size(96, 17);
            pharmacist_idLabel.TabIndex = 2;
            pharmacist_idLabel.Text = "pharmacist id:";
            // 
            // pharmacist_nameLabel
            // 
            pharmacist_nameLabel.AutoSize = true;
            pharmacist_nameLabel.Location = new System.Drawing.Point(24, 327);
            pharmacist_nameLabel.Name = "pharmacist_nameLabel";
            pharmacist_nameLabel.Size = new System.Drawing.Size(120, 17);
            pharmacist_nameLabel.TabIndex = 4;
            pharmacist_nameLabel.Text = "pharmacist name:";
            // 
            // pharmacist_surnameLabel
            // 
            pharmacist_surnameLabel.AutoSize = true;
            pharmacist_surnameLabel.Location = new System.Drawing.Point(24, 355);
            pharmacist_surnameLabel.Name = "pharmacist_surnameLabel";
            pharmacist_surnameLabel.Size = new System.Drawing.Size(140, 17);
            pharmacist_surnameLabel.TabIndex = 6;
            pharmacist_surnameLabel.Text = "pharmacist surname:";
            // 
            // pharmacist_birthdayLabel
            // 
            pharmacist_birthdayLabel.AutoSize = true;
            pharmacist_birthdayLabel.Location = new System.Drawing.Point(24, 384);
            pharmacist_birthdayLabel.Name = "pharmacist_birthdayLabel";
            pharmacist_birthdayLabel.Size = new System.Drawing.Size(136, 17);
            pharmacist_birthdayLabel.TabIndex = 8;
            pharmacist_birthdayLabel.Text = "pharmacist birthday:";
            // 
            // pharmacist_positionLabel
            // 
            pharmacist_positionLabel.AutoSize = true;
            pharmacist_positionLabel.Location = new System.Drawing.Point(24, 411);
            pharmacist_positionLabel.Name = "pharmacist_positionLabel";
            pharmacist_positionLabel.Size = new System.Drawing.Size(134, 17);
            pharmacist_positionLabel.TabIndex = 10;
            pharmacist_positionLabel.Text = "pharmacist position:";
            // 
            // pharmacist_adressLabel
            // 
            pharmacist_adressLabel.AutoSize = true;
            pharmacist_adressLabel.Location = new System.Drawing.Point(24, 439);
            pharmacist_adressLabel.Name = "pharmacist_adressLabel";
            pharmacist_adressLabel.Size = new System.Drawing.Size(128, 17);
            pharmacist_adressLabel.TabIndex = 12;
            pharmacist_adressLabel.Text = "pharmacist adress:";
            // 
            // pharmacist_phoneLabel
            // 
            pharmacist_phoneLabel.AutoSize = true;
            pharmacist_phoneLabel.Location = new System.Drawing.Point(24, 467);
            pharmacist_phoneLabel.Name = "pharmacist_phoneLabel";
            pharmacist_phoneLabel.Size = new System.Drawing.Size(125, 17);
            pharmacist_phoneLabel.TabIndex = 14;
            pharmacist_phoneLabel.Text = "pharmacist phone:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pharmacistsBindingSource
            // 
            this.pharmacistsBindingSource.DataMember = "pharmacists";
            this.pharmacistsBindingSource.DataSource = this.dataSet1;
            // 
            // pharmacistsTableAdapter
            // 
            this.pharmacistsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.doctorsTableAdapter = null;
            this.tableAdapterManager.medicinesTableAdapter = null;
            this.tableAdapterManager.patientsTableAdapter = null;
            this.tableAdapterManager.pharmacistsTableAdapter = this.pharmacistsTableAdapter;
            this.tableAdapterManager.recipesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Apteka.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pharmacistsBindingNavigator
            // 
            this.pharmacistsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pharmacistsBindingNavigator.BindingSource = this.pharmacistsBindingSource;
            this.pharmacistsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pharmacistsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pharmacistsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pharmacistsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pharmacistsBindingNavigatorSaveItem});
            this.pharmacistsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pharmacistsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pharmacistsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pharmacistsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pharmacistsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pharmacistsBindingNavigator.Name = "pharmacistsBindingNavigator";
            this.pharmacistsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pharmacistsBindingNavigator.Size = new System.Drawing.Size(961, 27);
            this.pharmacistsBindingNavigator.TabIndex = 0;
            this.pharmacistsBindingNavigator.Text = "bindingNavigator1";
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
            // pharmacistsBindingNavigatorSaveItem
            // 
            this.pharmacistsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pharmacistsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pharmacistsBindingNavigatorSaveItem.Image")));
            this.pharmacistsBindingNavigatorSaveItem.Name = "pharmacistsBindingNavigatorSaveItem";
            this.pharmacistsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.pharmacistsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.pharmacistsBindingNavigatorSaveItem.Click += new System.EventHandler(this.PharmacistsBindingNavigatorSaveItem_Click);
            // 
            // pharmacistsDataGridView
            // 
            this.pharmacistsDataGridView.AutoGenerateColumns = false;
            this.pharmacistsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pharmacistsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.pharmacistsDataGridView.DataSource = this.pharmacistsBindingSource;
            this.pharmacistsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.pharmacistsDataGridView.Name = "pharmacistsDataGridView";
            this.pharmacistsDataGridView.RowHeadersWidth = 51;
            this.pharmacistsDataGridView.RowTemplate.Height = 24;
            this.pharmacistsDataGridView.Size = new System.Drawing.Size(959, 220);
            this.pharmacistsDataGridView.TabIndex = 1;
            // 
            // pharmacist_idTextBox
            // 
            this.pharmacist_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacistsBindingSource, "pharmacist_id", true));
            this.pharmacist_idTextBox.Location = new System.Drawing.Point(170, 296);
            this.pharmacist_idTextBox.Name = "pharmacist_idTextBox";
            this.pharmacist_idTextBox.Size = new System.Drawing.Size(200, 22);
            this.pharmacist_idTextBox.TabIndex = 3;
            // 
            // pharmacist_nameTextBox
            // 
            this.pharmacist_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacistsBindingSource, "pharmacist_name", true));
            this.pharmacist_nameTextBox.Location = new System.Drawing.Point(170, 324);
            this.pharmacist_nameTextBox.Name = "pharmacist_nameTextBox";
            this.pharmacist_nameTextBox.Size = new System.Drawing.Size(200, 22);
            this.pharmacist_nameTextBox.TabIndex = 5;
            // 
            // pharmacist_surnameTextBox
            // 
            this.pharmacist_surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacistsBindingSource, "pharmacist_surname", true));
            this.pharmacist_surnameTextBox.Location = new System.Drawing.Point(170, 352);
            this.pharmacist_surnameTextBox.Name = "pharmacist_surnameTextBox";
            this.pharmacist_surnameTextBox.Size = new System.Drawing.Size(200, 22);
            this.pharmacist_surnameTextBox.TabIndex = 7;
            // 
            // pharmacist_birthdayDateTimePicker
            // 
            this.pharmacist_birthdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pharmacistsBindingSource, "pharmacist_birthday", true));
            this.pharmacist_birthdayDateTimePicker.Location = new System.Drawing.Point(170, 380);
            this.pharmacist_birthdayDateTimePicker.Name = "pharmacist_birthdayDateTimePicker";
            this.pharmacist_birthdayDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.pharmacist_birthdayDateTimePicker.TabIndex = 9;
            // 
            // pharmacist_positionTextBox
            // 
            this.pharmacist_positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacistsBindingSource, "pharmacist_position", true));
            this.pharmacist_positionTextBox.Location = new System.Drawing.Point(170, 408);
            this.pharmacist_positionTextBox.Name = "pharmacist_positionTextBox";
            this.pharmacist_positionTextBox.Size = new System.Drawing.Size(200, 22);
            this.pharmacist_positionTextBox.TabIndex = 11;
            // 
            // pharmacist_adressTextBox
            // 
            this.pharmacist_adressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacistsBindingSource, "pharmacist_adress", true));
            this.pharmacist_adressTextBox.Location = new System.Drawing.Point(170, 436);
            this.pharmacist_adressTextBox.Name = "pharmacist_adressTextBox";
            this.pharmacist_adressTextBox.Size = new System.Drawing.Size(200, 22);
            this.pharmacist_adressTextBox.TabIndex = 13;
            // 
            // pharmacist_phoneTextBox
            // 
            this.pharmacist_phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacistsBindingSource, "pharmacist_phone", true));
            this.pharmacist_phoneTextBox.Location = new System.Drawing.Point(170, 464);
            this.pharmacist_phoneTextBox.Name = "pharmacist_phoneTextBox";
            this.pharmacist_phoneTextBox.Size = new System.Drawing.Size(200, 22);
            this.pharmacist_phoneTextBox.TabIndex = 15;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(27, 267);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(343, 23);
            this.Create.TabIndex = 16;
            this.Create.Text = "Создать свободное поле";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // AddNEW
            // 
            this.AddNEW.Location = new System.Drawing.Point(27, 492);
            this.AddNEW.Name = "AddNEW";
            this.AddNEW.Size = new System.Drawing.Size(343, 23);
            this.AddNEW.TabIndex = 17;
            this.AddNEW.Text = "Добавить запись";
            this.AddNEW.UseVisualStyleBackColor = true;
            this.AddNEW.Click += new System.EventHandler(this.AddNEW_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "pharmacist_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "pharmacist_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 160;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "pharmacist_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "pharmacist_name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "pharmacist_surname";
            this.dataGridViewTextBoxColumn3.HeaderText = "pharmacist_surname";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "pharmacist_birthday";
            this.dataGridViewTextBoxColumn4.HeaderText = "pharmacist_birthday";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "pharmacist_position";
            this.dataGridViewTextBoxColumn5.HeaderText = "pharmacist_position";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "pharmacist_adress";
            this.dataGridViewTextBoxColumn6.HeaderText = "pharmacist_adress";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "pharmacist_phone";
            this.dataGridViewTextBoxColumn7.HeaderText = "pharmacist_phone";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(707, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 53);
            this.button1.TabIndex = 18;
            this.button1.Text = "Найти запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 521);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddNEW);
            this.Controls.Add(this.Create);
            this.Controls.Add(pharmacist_idLabel);
            this.Controls.Add(this.pharmacist_idTextBox);
            this.Controls.Add(pharmacist_nameLabel);
            this.Controls.Add(this.pharmacist_nameTextBox);
            this.Controls.Add(pharmacist_surnameLabel);
            this.Controls.Add(this.pharmacist_surnameTextBox);
            this.Controls.Add(pharmacist_birthdayLabel);
            this.Controls.Add(this.pharmacist_birthdayDateTimePicker);
            this.Controls.Add(pharmacist_positionLabel);
            this.Controls.Add(this.pharmacist_positionTextBox);
            this.Controls.Add(pharmacist_adressLabel);
            this.Controls.Add(this.pharmacist_adressTextBox);
            this.Controls.Add(pharmacist_phoneLabel);
            this.Controls.Add(this.pharmacist_phoneTextBox);
            this.Controls.Add(this.pharmacistsDataGridView);
            this.Controls.Add(this.pharmacistsBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "Pharmacists";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacistsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacistsBindingNavigator)).EndInit();
            this.pharmacistsBindingNavigator.ResumeLayout(false);
            this.pharmacistsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacistsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pharmacistsBindingSource;
        private DataSet1TableAdapters.pharmacistsTableAdapter pharmacistsTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pharmacistsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pharmacistsBindingNavigatorSaveItem;
        public System.Windows.Forms.DataGridView pharmacistsDataGridView;
        private System.Windows.Forms.TextBox pharmacist_idTextBox;
        private System.Windows.Forms.TextBox pharmacist_nameTextBox;
        private System.Windows.Forms.TextBox pharmacist_surnameTextBox;
        private System.Windows.Forms.DateTimePicker pharmacist_birthdayDateTimePicker;
        private System.Windows.Forms.TextBox pharmacist_positionTextBox;
        private System.Windows.Forms.TextBox pharmacist_adressTextBox;
        private System.Windows.Forms.TextBox pharmacist_phoneTextBox;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button AddNEW;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button button1;
    }
}