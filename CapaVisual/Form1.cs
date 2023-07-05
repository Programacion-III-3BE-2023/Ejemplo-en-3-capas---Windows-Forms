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
            HamburguesaController.Crear(
                TextBoxNombre.Text, 
                Int32.Parse(TextBoxPrecio.Text)
            );
            MessageBox.Show("Insertado");
            this.recargarDatagrid();
        }

        private void recargarDatagrid()
        {
            dataGridView1.Refresh();
            DataTable datos = HamburguesaController.ObtenerTodos();

            dataGridView1.DataSource = datos;
        }
        private void Listar_Click(object sender, EventArgs e)
        {
            this.recargarDatagrid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dataGridView1.SelectedRows[0].Cells["id"].Value.ToString());
            CapaLogica.HamburguesaController.Eliminar(id);
            MessageBox.Show("Eliminado");
            this.recargarDatagrid();
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            HamburguesaController.Modificar(
                Int32.Parse(TextBoxId.Text), 
                TextBoxNombre.Text, 
                Int32.Parse(TextBoxPrecio.Text)
            );
            MessageBox.Show("Modificado");
            this.recargarDatagrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { 
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.recargarDatagrid();
        }
    }
}
