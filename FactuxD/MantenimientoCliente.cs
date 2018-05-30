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
    public partial class MantenimientoCliente : Mantenimiento
    {
        public MantenimientoCliente()
        {
            InitializeComponent();
        }


        public override Boolean Guardar()
        {
            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                try
                {
                    string cmd = string.Format("EXEC ActualizarClientes '{0}', '{1}', '{2}'", txtIdCli.Text.Trim(), txtNomCli.Text.Trim(), txtApeCli.Text.Trim());
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
                string cmd = string.Format("EXEC EliminarClientes '{0}'", txtIdCli.Text.Trim());
                Utilidades.Ejecutar(cmd);
                Eliminar el = new Eliminar();
                el.Show();
                //MessageBox.Show("Se ha eliminado");
                ;
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error: " + error.Message);
            }
        }


        public override void Nuevo()
        {
            txtIdCli.Text = "";
            txtNomCli.Text = "";
            txtApeCli.Text = "";
            txtIdCli.Focus();
        }

        private void MantenimientoCliente_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultarClientes ConCli = new ConsultarClientes();
            ConCli.ShowDialog();

            if (ConCli.DialogResult == DialogResult.OK)
            {
                txtIdCli.Text = ConCli.dataGridView1.Rows[ConCli.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                txtNomCli.Text = ConCli.dataGridView1.Rows[ConCli.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                txtApeCli.Text = ConCli.dataGridView1.Rows[ConCli.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void txtNomCli_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void txtIdpromo_TextChanged(object sender, EventArgs e)
        {

        }

        private void errorTxtBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void errorTxtBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
