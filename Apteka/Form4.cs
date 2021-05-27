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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void PatientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.patients". При необходимости она может быть перемещена или удалена.
            this.patientsTableAdapter.Fill(this.dataSet1.patients);

        }

        private void Create_Click(object sender, EventArgs e)
        {
            patientsBindingSource.AddNew();
        }

        private void AddNEW_Click(object sender, EventArgs e)
        {
            patientsBindingSource.EndEdit();
            patientsTableAdapter.Update(dataSet1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SearchPatient spa = new SearchPatient();
            spa.Owner = this;
            spa.Show();
        }
    }
}
