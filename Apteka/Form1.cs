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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DoctorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.doctorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.doctors". При необходимости она может быть перемещена или удалена.
            this.doctorsTableAdapter.Fill(this.dataSet1.doctors);

        }

        private void DoctorsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Create_Click(object sender, EventArgs e)
        {
            doctorsBindingSource.AddNew();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            doctorsBindingSource.EndEdit();
            doctorsTableAdapter.Update(dataSet1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SearchDoctor doc = new SearchDoctor();
            doc.Owner = this;
            doc.Show();
        }
    }
}
