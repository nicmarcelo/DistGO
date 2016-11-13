using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CFFLORES.WebService.Persistencia;

namespace CFFLORES.Presentacion
{
    public partial class ConsultarProducto : Form
    {
        private DAOProducto daoproducto = new DAOProducto();

        public ConsultarProducto()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
    
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para Buscar Nombre o Tipo, no debe registrar Codigo de Barras",
                             "Errpr",
             MessageBoxButtons.OK,
             MessageBoxIcon.Error,
             MessageBoxDefaultButton.Button1);
            MessageBox.Show("El Producto <Nombre Producto> esta por agotarse.",
             "Adventencia",
             MessageBoxButtons.OK,
             MessageBoxIcon.Exclamation,
             MessageBoxDefaultButton.Button1);

            MessageBox.Show("El Producto <Nombre Producto> no cuenta con Stock Disponible.",
             "Adventencia",
             MessageBoxButtons.OK,
             MessageBoxIcon.Exclamation,
             MessageBoxDefaultButton.Button1);

            MessageBox.Show("El Producto no existe.",
             "Adventencia",
             MessageBoxButtons.OK,
             MessageBoxIcon.Exclamation,
             MessageBoxDefaultButton.Button1);

            MessageBox.Show("El Producto <Nombre Producto> esta Deshabilitado",
             "Adventencia",
             MessageBoxButtons.OK,
             MessageBoxIcon.Exclamation,
             MessageBoxDefaultButton.Button1);
        }

        private void ConsultarProducto_Load(object sender, EventArgs e)
        {
            dgvProducto.AutoGenerateColumns = false;
            dgvProducto.DataSource = daoproducto.ListarProducto();


        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
