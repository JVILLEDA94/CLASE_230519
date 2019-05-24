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
    public partial class Form1 : Form
    {

        ManttHospital neg = new ManttHospital();

        ManttHospital enlc = new ManttHospital();

        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(enlc.prueba());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            neg.Cod1 = int.Parse(textBox1.Text);
            neg.Cod2 = int.Parse(textBox2.Text);
            neg.Var1 = textBox3.Text;
            neg.Var2 = textBox4.Text;
            neg.insertDoctor();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            neg.Cod1 = int.Parse(textBox1.Text);
            neg.Cod2 = int.Parse(textBox2.Text);
            neg.Var2 = textBox3.Text;
            neg.Var3 = textBox4.Text;
            neg.updateDoctor();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            neg.Cod1 = int.Parse(textBox1.Text);
            neg.deleteDoctor();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            limpiar();
            cargar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void limpiar()
        {

            dataGridView1.DataSource = null;
            //dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }

        public void cargar()
        {
            neg.mostrarDoctor();
            dataGridView1.DataSource = neg.dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void limpiar2()
        {

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
        }

        public void cargar2()
        {
            neg.mostrarDoctor();
            dataGridView1.DataSource = neg.dt;
        }

    }
}
