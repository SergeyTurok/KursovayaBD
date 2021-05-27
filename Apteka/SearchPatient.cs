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
    public partial class SearchPatient : Form
    {
        public SearchPatient()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form4 patients = this.Owner as Form4;
            if (patients != null)
            {
                for (int i = 0; i < patients.patientsDataGridView.RowCount; i++)
                {
                    patients.patientsDataGridView.Rows[i].Selected = false;
                    for (int j = 0; j < patients.patientsDataGridView.ColumnCount; j++)
                        if (patients.patientsDataGridView.Rows[i].Cells[j].Value != null)
                            if (patients.patientsDataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                            {
                                patients.patientsDataGridView.Rows[i].Selected = true;
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
