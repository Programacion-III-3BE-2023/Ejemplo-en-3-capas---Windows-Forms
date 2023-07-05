using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace CapaVisual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BotonInsertar_Click(object sender, EventArgs e)
        {
            HamburguesaController.Crear(TextBoxNombre.Text, Int32.Parse(TextBoxPrecio.Text));
            MessageBox.Show("Insertado");
        }

        private void Listar_Click(object sender, EventArgs e)
        {
            DataTable datos = HamburguesaController.Obtener();

            dataGridView1.DataSource = datos;
        }
    }
}
