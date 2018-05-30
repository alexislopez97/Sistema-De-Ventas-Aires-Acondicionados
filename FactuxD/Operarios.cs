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
    public partial class Operarios : Mantenimiento
    {
        public Operarios()
        {
            InitializeComponent();
        }

        public override Boolean Guardar()
        {
            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                try
                {
                    string cmd = string.Format("EXEC ActualizarOperarios '{0}', '{1}', '{2}', '{3}'", txtIdOpe.Text.Trim(), txtNomOpe.Text.Trim(), txtApeOpe.Text.Trim(), txtCelOpe.Text.Trim());
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
                string cmd = string.Format("EXEC EliminarOperario '{0}'", txtIdOpe.Text.Trim());
                Utilidades.Ejecutar(cmd);
                //MessageBox.Show("Se ha eliminado");
                Eliminar el = new Eliminar();
                el.Show();
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error: " + error.Message);
            }
        }

        public override void Nuevo()
        {
            txtIdOpe.Text = "";
            txtNomOpe.Text = "";
            txtApeOpe.Text = "";
            txtCelOpe.Text = "";
            txtIdOpe.Focus();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Operarios_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultarOperario ConCli = new ConsultarOperario();
            ConCli.ShowDialog();

            if (ConCli.DialogResult == DialogResult.OK)
            {
                txtIdOpe.Text = ConCli.dataGridView1.Rows[ConCli.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                txtNomOpe.Text = ConCli.dataGridView1.Rows[ConCli.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                txtApeOpe.Text = ConCli.dataGridView1.Rows[ConCli.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                txtCelOpe.Text = ConCli.dataGridView1.Rows[ConCli.dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();

            }
        }

        private void txtIdOpe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApeOpe_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void txtIdCli_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
