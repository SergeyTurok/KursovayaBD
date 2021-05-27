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
    public partial class SearchPharmacist : Form
    {
        public SearchPharmacist()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form5 pharmacists = this.Owner as Form5;
            if (pharmacists != null)
            {
                for (int i = 0; i < pharmacists.pharmacistsDataGridView.RowCount; i++)
                {
                    pharmacists.pharmacistsDataGridView.Rows[i].Selected = false;
                    for (int j = 0; j < pharmacists.pharmacistsDataGridView.ColumnCount; j++)
                        if (pharmacists.pharmacistsDataGridView.Rows[i].Cells[j].Value != null)
                            if (pharmacists.pharmacistsDataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                            {
                                pharmacists.pharmacistsDataGridView.Rows[i].Selected = true;
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
