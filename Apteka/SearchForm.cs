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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
        
            
                Close();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form6 recipes = this.Owner as Form6;
            if (recipes != null)
            {
                for (int i = 0; i < recipes.recipesDataGridView.RowCount; i++)
                {
                    recipes.recipesDataGridView.Rows[i].Selected = false;
                    for (int j = 0; j < recipes.recipesDataGridView.ColumnCount; j++)
                        if (recipes.recipesDataGridView.Rows[i].Cells[j].Value != null)
                            if (recipes.recipesDataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                            {
                                recipes.recipesDataGridView.Rows[i].Selected = true;
                                break;
                            }
                }
            }   
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
