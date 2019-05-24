using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocio;

namespace CapaPresentacion
{
    public partial class Form6 : Form
    {
        ManttHospital neg = new ManttHospital();
        ManttHospital enlc = new ManttHospital();

        public Form6()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            limpiar();
            cargar();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
        public void limpiar()
        {

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
        }

        public void cargar()
        {
            neg.mostrarHospital();
            dataGridView1.DataSource = neg.dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            neg.Cod1 = int.Parse(textBox1.Text);
            neg.Var1 = textBox2.Text;
            neg.Var2 = textBox3.Text;
            neg.Var3 = textBox4.Text;
            neg.Cod2 = int.Parse(textBox5.Text);
            neg.insertHospital();
        }
    }
}
