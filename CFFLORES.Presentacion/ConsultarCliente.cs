using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CFFLORES.Presentacion
{
    public partial class ConsultarCliente : Form
    {
        public ConsultarCliente()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") && textBox2.Text.Equals(""))
            {
                MessageBox.Show("Debe llenar por lo menos una busqueda",
                "Adventencia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
                return;
            }

            if (textBox1.Text.Length != 8)
            {
                MessageBox.Show("El DNI debe contener 8 Caracteres",
                "Adventencia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
                return;
            }

            if (textBox1.Text.Equals("44745474"))
            {
                MessageBox.Show("El Cliente no Existe",
                "Adventencia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
                return;
            }

        }
    }
}
