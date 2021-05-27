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
    public partial class SearchMedicine : Form
    {
        public SearchMedicine()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form3 medicines = this.Owner as Form3;
            if (medicines != null)
            {
                for (int i = 0; i < medicines.medicinesDataGridView.RowCount; i++)
                {
                    medicines.medicinesDataGridView.Rows[i].Selected = false;
                    for (int j = 0; j < medicines.medicinesDataGridView.ColumnCount; j++)
                        if (medicines.medicinesDataGridView.Rows[i].Cells[j].Value != null)
                            if (medicines.medicinesDataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                            {
                                medicines.medicinesDataGridView.Rows[i].Selected = true;
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
