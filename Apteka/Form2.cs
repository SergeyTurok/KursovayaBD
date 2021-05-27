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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 doctors = new Form1();
            //this.Hide();
            doctors.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form3 medecines = new Form3();
            //this.Hide();
            medecines.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form4 patients = new Form4();
            //this.Hide();
            patients.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form5 pharmacists = new Form5();
            //this.Hide();
            pharmacists.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Form6 recipes = new Form6();
            //this.Hide();
            recipes.Show();
        }
    }
}
