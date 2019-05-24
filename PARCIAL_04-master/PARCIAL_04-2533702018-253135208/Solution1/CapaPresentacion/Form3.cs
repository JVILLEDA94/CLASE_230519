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
    public partial class Form3 : Form
    {
        ManttHospital neg = new ManttHospital();

        ManttHospital enlc = new ManttHospital();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        public void limpiar()
        {

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
        }

        public void cargar()
        {
            neg.mostrarVendor();
            dataGridView1.DataSource = neg.dt;
        }
    }
}
