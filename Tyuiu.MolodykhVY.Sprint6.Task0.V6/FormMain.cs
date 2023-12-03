using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MolodykhVY.Sprint6.Task0.V6.Lib;
namespace Tyuiu.MolodykhVY.Sprint6.Task0.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void b_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИИПБ-23-3, Молодых Владислав Юрьевич", "Сообщение");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            textBoxResult_MVY.Text = Convert.ToString(ds.Calculate(3));
        }

        private void textBoxResult_MVY_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

