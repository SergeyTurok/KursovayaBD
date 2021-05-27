using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apteka
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void MedicinesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medicinesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.medicines". При необходимости она может быть перемещена или удалена.
            this.medicinesTableAdapter.Fill(this.dataSet1.medicines);

        }

        private void MedicinesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Create_Click(object sender, EventArgs e)
        {
            medicinesBindingSource.AddNew();
        }

        private void AddNEW_Click(object sender, EventArgs e)
        {
            medicinesBindingSource.EndEdit();
            medicinesTableAdapter.Update(dataSet1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SearchMedicine med = new SearchMedicine();
            med.Owner = this;
            med.Show();
        }
    }
}
