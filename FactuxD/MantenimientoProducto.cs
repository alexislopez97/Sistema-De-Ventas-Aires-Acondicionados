using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiLibreria;

namespace FactuxD
{
    public partial class MantenimientoProducto : Mantenimiento
    {
        public MantenimientoProducto()
        {
            InitializeComponent();
        }

        

        public override Boolean Guardar()
        {

            if (Utilidades.ValidarFormulario(this,errorProvider1) == false)
            {
                try
                {

                    string cmd = string.Format("EXEC ActualizarArticulos '{0}', '{1}', '{2}', '{3}'", txtIdPro.Text.Trim(), txtNomPro.Text.Trim(), txtPrePro.Text.Trim(), txtCantiPro.Text.Trim());
                    Utilidades.Ejecutar(cmd);
                    Guardar gr = new Guardar();
                    gr.Show();
                    //MessageBox.Show("Se ha guardado correctamente!... ");
                    return true;
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error: " + error.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }

            
        }

        public override void Eliminar()
        {
            try
            {
                string cmd = string.Format("EXEC EliminarArticulo '{0}'", txtIdPro.Text.Trim());
                Utilidades.Ejecutar(cmd);
                Eliminar el = new Eliminar();
                el.Show();
                //MessageBox.Show("Se ha eliminado");
                ;            }
            catch(Exception error)
            {
                MessageBox.Show("Ha ocurrido un error: " + error.Message);
            }
        }

        public override void Nuevo()
        {
            txtIdPro.Text = "";
            txtNomPro.Text = "";
            txtPrePro.Text = "";
            txtCantiPro.Text = "";
            txtIdPro.Focus();
        }


        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void MantenimientoProducto_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdPro_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtNomPro_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultarProductos ConCli = new ConsultarProductos();
            ConCli.ShowDialog();

            if (ConCli.DialogResult == DialogResult.OK)
            {
                txtIdPro.Text = ConCli.dataGridView1.Rows[ConCli.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                txtNomPro.Text = ConCli.dataGridView1.Rows[ConCli.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                txtPrePro.Text = ConCli.dataGridView1.Rows[ConCli.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
