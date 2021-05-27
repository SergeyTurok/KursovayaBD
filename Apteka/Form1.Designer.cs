namespace Apteka
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
            System.Windows.Forms.Label doctor_idLabel;
            System.Windows.Forms.Label doctor_nameLabel;
            System.Windows.Forms.Label doctor_surnameLabel;
            System.Windows.Forms.Label doctor_workexLabel;
            System.Windows.Forms.Label doctor_positionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.doctorsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Apteka.DataSet1();
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
            this.doctorsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.doctorsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorsTableAdapter = new Apteka.DataSet1TableAdapters.doctorsTableAdapter();
            this.tableAdapterManager = new Apteka.DataSet1TableAdapters.TableAdapterManager();
            this.doctor_idTextBox = new System.Windows.Forms.TextBox();
            this.doctor_nameTextBox = new System.Windows.Forms.TextBox();
            this.doctor_surnameTextBox = new System.Windows.Forms.TextBox();
            this.doctor_workexTextBox = new System.Windows.Forms.TextBox();
            this.doctor_positionTextBox = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            doctor_idLabel = new System.Windows.Forms.Label();
            doctor_nameLabel = new System.Windows.Forms.Label();
            doctor_surnameLabel = new System.Windows.Forms.Label();
            doctor_workexLabel = new System.Windows.Forms.Label();
            doctor_positionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingNavigator)).BeginInit();
            this.doctorsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // doctor_idLabel
            // 
            doctor_idLabel.AutoSize = true;
            doctor_idLabel.Location = new System.Drawing.Point(121, 304);
            doctor_idLabel.Name = "doctor_idLabel";
            doctor_idLabel.Size = new System.Drawing.Size(67, 17);
            doctor_idLabel.TabIndex = 2;
            doctor_idLabel.Text = "doctor id:";
            // 
            // doctor_nameLabel
            // 
            doctor_nameLabel.AutoSize = true;
            doctor_nameLabel.Location = new System.Drawing.Point(121, 332);
            doctor_nameLabel.Name = "doctor_nameLabel";
            doctor_nameLabel.Size = new System.Drawing.Size(91, 17);
            doctor_nameLabel.TabIndex = 4;
            doctor_nameLabel.Text = "doctor name:";
            // 
            // doctor_surnameLabel
            // 
            doctor_surnameLabel.AutoSize = true;
            doctor_surnameLabel.Location = new System.Drawing.Point(121, 360);
            doctor_surnameLabel.Name = "doctor_surnameLabel";
            doctor_surnameLabel.Size = new System.Drawing.Size(111, 17);
            doctor_surnameLabel.TabIndex = 6;
            doctor_surnameLabel.Text = "doctor surname:";
            // 
            // doctor_workexLabel
            // 
            doctor_workexLabel.AutoSize = true;
            doctor_workexLabel.Location = new System.Drawing.Point(121, 388);
            doctor_workexLabel.Name = "doctor_workexLabel";
            doctor_workexLabel.Size = new System.Drawing.Size(99, 17);
            doctor_workexLabel.TabIndex = 8;
            doctor_workexLabel.Text = "doctor workex:";
            // 
            // doctor_positionLabel
            // 
            doctor_positionLabel.AutoSize = true;
            doctor_positionLabel.Location = new System.Drawing.Point(121, 416);
            doctor_positionLabel.Name = "doctor_positionLabel";
            doctor_positionLabel.Size = new System.Drawing.Size(105, 17);
            doctor_positionLabel.TabIndex = 10;
            doctor_positionLabel.Text = "doctor position:";
            // 
            // doctorsBindingNavigator
            // 
            this.doctorsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.doctorsBindingNavigator.BindingSource = this.doctorsBindingSource;
            this.doctorsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.doctorsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.doctorsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.doctorsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.doctorsBindingNavigatorSaveItem});
            this.doctorsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.doctorsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.doctorsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.doctorsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.doctorsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.doctorsBindingNavigator.Name = "doctorsBindingNavigator";
            this.doctorsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.doctorsBindingNavigator.Size = new System.Drawing.Size(683, 27);
            this.doctorsBindingNavigator.TabIndex = 0;
            this.doctorsBindingNavigator.Text = "bindingNavigator1";
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
            // doctorsBindingSource
            // 
            this.doctorsBindingSource.DataMember = "doctors";
            this.doctorsBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // doctorsBindingNavigatorSaveItem
            // 
            this.doctorsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.doctorsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("doctorsBindingNavigatorSaveItem.Image")));
            this.doctorsBindingNavigatorSaveItem.Name = "doctorsBindingNavigatorSaveItem";
            this.doctorsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.doctorsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.doctorsBindingNavigatorSaveItem.Click += new System.EventHandler(this.DoctorsBindingNavigatorSaveItem_Click);
            // 
            // doctorsDataGridView
            // 
            this.doctorsDataGridView.AutoGenerateColumns = false;
            this.doctorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.doctorsDataGridView.DataSource = this.doctorsBindingSource;
            this.doctorsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.doctorsDataGridView.Name = "doctorsDataGridView";
            this.doctorsDataGridView.RowHeadersWidth = 51;
            this.doctorsDataGridView.RowTemplate.Height = 24;
            this.doctorsDataGridView.Size = new System.Drawing.Size(681, 220);
            this.doctorsDataGridView.TabIndex = 1;
            this.doctorsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoctorsDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "doctor_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "doctor_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "doctor_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "doctor_name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "doctor_surname";
            this.dataGridViewTextBoxColumn3.HeaderText = "doctor_surname";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "doctor_workex";
            this.dataGridViewTextBoxColumn4.HeaderText = "doctor_workex";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "doctor_position";
            this.dataGridViewTextBoxColumn5.HeaderText = "doctor_position";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // doctorsTableAdapter
            // 
            this.doctorsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.doctorsTableAdapter = this.doctorsTableAdapter;
            this.tableAdapterManager.medicinesTableAdapter = null;
            this.tableAdapterManager.patientsTableAdapter = null;
            this.tableAdapterManager.pharmacistsTableAdapter = null;
            this.tableAdapterManager.recipesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Apteka.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // doctor_idTextBox
            // 
            this.doctor_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorsBindingSource, "doctor_id", true));
            this.doctor_idTextBox.Location = new System.Drawing.Point(238, 301);
            this.doctor_idTextBox.Name = "doctor_idTextBox";
            this.doctor_idTextBox.Size = new System.Drawing.Size(100, 22);
            this.doctor_idTextBox.TabIndex = 3;
            // 
            // doctor_nameTextBox
            // 
            this.doctor_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorsBindingSource, "doctor_name", true));
            this.doctor_nameTextBox.Location = new System.Drawing.Point(238, 329);
            this.doctor_nameTextBox.Name = "doctor_nameTextBox";
            this.doctor_nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.doctor_nameTextBox.TabIndex = 5;
            // 
            // doctor_surnameTextBox
            // 
            this.doctor_surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorsBindingSource, "doctor_surname", true));
            this.doctor_surnameTextBox.Location = new System.Drawing.Point(238, 357);
            this.doctor_surnameTextBox.Name = "doctor_surnameTextBox";
            this.doctor_surnameTextBox.Size = new System.Drawing.Size(100, 22);
            this.doctor_surnameTextBox.TabIndex = 7;
            // 
            // doctor_workexTextBox
            // 
            this.doctor_workexTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorsBindingSource, "doctor_workex", true));
            this.doctor_workexTextBox.Location = new System.Drawing.Point(238, 385);
            this.doctor_workexTextBox.Name = "doctor_workexTextBox";
            this.doctor_workexTextBox.Size = new System.Drawing.Size(100, 22);
            this.doctor_workexTextBox.TabIndex = 9;
            // 
            // doctor_positionTextBox
            // 
            this.doctor_positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorsBindingSource, "doctor_position", true));
            this.doctor_positionTextBox.Location = new System.Drawing.Point(238, 413);
            this.doctor_positionTextBox.Name = "doctor_positionTextBox";
            this.doctor_positionTextBox.Size = new System.Drawing.Size(100, 22);
            this.doctor_positionTextBox.TabIndex = 11;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(124, 256);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(214, 23);
            this.Create.TabIndex = 12;
            this.Create.Text = "Создать свободное поле";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(124, 441);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(214, 23);
            this.Update.TabIndex = 13;
            this.Update.Text = "Добавить запись";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(453, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 52);
            this.button1.TabIndex = 14;
            this.button1.Text = "Найти запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 504);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Create);
            this.Controls.Add(doctor_idLabel);
            this.Controls.Add(this.doctor_idTextBox);
            this.Controls.Add(doctor_nameLabel);
            this.Controls.Add(this.doctor_nameTextBox);
            this.Controls.Add(doctor_surnameLabel);
            this.Controls.Add(this.doctor_surnameTextBox);
            this.Controls.Add(doctor_workexLabel);
            this.Controls.Add(this.doctor_workexTextBox);
            this.Controls.Add(doctor_positionLabel);
            this.Controls.Add(this.doctor_positionTextBox);
            this.Controls.Add(this.doctorsDataGridView);
            this.Controls.Add(this.doctorsBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Doctors";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingNavigator)).EndInit();
            this.doctorsBindingNavigator.ResumeLayout(false);
            this.doctorsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private DataSet1TableAdapters.doctorsTableAdapter doctorsTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator doctorsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton doctorsBindingNavigatorSaveItem;
        public System.Windows.Forms.DataGridView doctorsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox doctor_idTextBox;
        private System.Windows.Forms.TextBox doctor_nameTextBox;
        private System.Windows.Forms.TextBox doctor_surnameTextBox;
        private System.Windows.Forms.TextBox doctor_workexTextBox;
        private System.Windows.Forms.TextBox doctor_positionTextBox;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button button1;
    }
}

