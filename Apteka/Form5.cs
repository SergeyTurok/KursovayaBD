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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void PharmacistsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pharmacistsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.pharmacists". При необходимости она может быть перемещена или удалена.
            this.pharmacistsTableAdapter.Fill(this.dataSet1.pharmacists);

        }

        private void Create_Click(object sender, EventArgs e)
        {
            pharmacistsBindingSource.AddNew();
        }

        private void AddNEW_Click(object sender, EventArgs e)
        {
            pharmacistsBindingSource.EndEdit();
            pharmacistsTableAdapter.Update(dataSet1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SearchPharmacist sph = new SearchPharmacist();
            sph.Owner = this;
            sph.Show();
        }
    }
}
