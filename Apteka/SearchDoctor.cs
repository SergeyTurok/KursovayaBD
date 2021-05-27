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
    public partial class SearchDoctor : Form
    {
        public SearchDoctor()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 doctors = this.Owner as Form1;
            if (doctors != null)
            {
                for (int i = 0; i < doctors.doctorsDataGridView.RowCount; i++)
                {
                    doctors.doctorsDataGridView.Rows[i].Selected = false;
                    for (int j = 0; j < doctors.doctorsDataGridView.ColumnCount; j++)
                        if (doctors.doctorsDataGridView.Rows[i].Cells[j].Value != null)
                            if (doctors.doctorsDataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                            {
                                doctors.doctorsDataGridView.Rows[i].Selected = true;
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
