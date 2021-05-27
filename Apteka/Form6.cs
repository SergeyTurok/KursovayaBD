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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void RecipesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.recipesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.recipes". При необходимости она может быть перемещена или удалена.
            this.recipesTableAdapter.Fill(this.dataSet1.recipes);

        }

        private void Create_Click(object sender, EventArgs e)
        {
            recipesBindingSource.AddNew();
        }

        private void AddNEW_Click(object sender, EventArgs e)
        {
            recipesBindingSource.EndEdit();
            recipesTableAdapter.Update(dataSet1);
        }

        private void RecipesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RecipesDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void RecipesDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.Owner = this;
            sf.Show();
        }
    }
}
