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
    public partial class RegistrarVenta : Form
    {
        public RegistrarVenta()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConsultarProducto frmProducto = new ConsultarProducto();
            frmProducto.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.tabControl1.TabPages.Add(this.tabPage2);

           tabControl1.SelectedIndex = 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {


            int count = 0;

            for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["Column1"].Value) == true)
                {
                    ++count;
                }
            }


            if (count == 0)
            {
                MessageBox.Show("Debe seleccionar por lo menos una Venta",
                "Adventencia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
                return;
            }
            this.tabControl1.TabPages.Add(this.tabPage2);

            tabControl1.SelectedIndex = 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se realizo la Venta.",
            "EXITO",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1);
            tabControl1.SelectedIndex = 0;
            this.tabControl1.TabPages.Remove(this.tabPage2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta Seguro que desea cancelar la Venta?",
            "Atencion",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.tabControl1.TabPages.Remove(this.tabPage2);
                tabControl1.SelectedIndex = 0;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {

            int count = 0;
            for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["Column1"].Value) == true)
                {
                    ++count;
                }
            }


            if (count == 0)
            {
                MessageBox.Show("Debe seleccionar por lo menos una Venta",
                "Adventencia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
                return;
            }
            

            DialogResult result = MessageBox.Show("¿Esta Seguro que desea Anular la Venta?",
            "Atencion",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Se realizo la Anulación",
                "EXITO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

            int count = 0;
            for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["Column1"].Value) == true)
                {
                    ++count;
                }
            }


            if (count == 0)
            {
                MessageBox.Show("Debe seleccionar por lo menos una Venta",
                "Adventencia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
                return;
            }

            DialogResult result = MessageBox.Show("¿Esta Seguro que desea Imprimir la Venta?",
            "Atencion",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Imprimiendo....");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultarCliente frmCliente = new ConsultarCliente();
            frmCliente.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConsultarCliente frmCliente = new ConsultarCliente();
            frmCliente.ShowDialog();
        }

        private void RegistrarVenta_Load(object sender, EventArgs e)
        {

            if (this.tabControl1.TabPages.Contains(this.tabPage2))
                this.tabControl1.TabPages.Remove(this.tabPage2);
            else
                this.tabControl1.TabPages.Add(this.tabPage2);
  
        }

   

        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (this.tabControl1.TabPages.Contains(this.tabPage2))
                this.tabControl1.TabPages.Remove(this.tabPage2);
            else
                this.tabControl1.TabPages.Add(this.tabPage2);
        }



    }
}
