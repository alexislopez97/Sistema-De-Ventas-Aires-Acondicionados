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
    public partial class Promociones : Mantenimiento
    {
        public Promociones()
        {
            InitializeComponent();
        }

        public override Boolean Guardar()
        {

            string fecha_inicio = Convert.ToString(dateTimePicker1.Value.ToShortDateString());
            string fecha_final = Convert.ToString(dateTimePicker2.Value.ToShortDateString());

            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                try
                {

                    string cmd = string.Format("EXEC ActualizarPromocion '{0}', '{1}', '{2}', '{3}', '{4}'", txtIdpromo.Text.Trim(), txtNomPromo.Text.Trim(), comboBox1.Text.Trim(), fecha_inicio, fecha_final);
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
                string cmd = string.Format("EXEC EliminarPromocion '{0}'", txtIdpromo.Text.Trim());
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
            txtIdpromo.Text = "";
            txtNomPromo.Text = "";
            comboBox1.Text = "";
            txtIdpromo.Focus();
        }

        private void Promociones_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void errorTxtBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void errorTxtBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultarPromociones ConCli = new ConsultarPromociones();
            ConCli.ShowDialog();
            

            if (ConCli.DialogResult == DialogResult.OK)
            {
                txtIdpromo.Text = ConCli.dataGridView1.Rows[ConCli.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                txtNomPromo.Text = ConCli.dataGridView1.Rows[ConCli.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                comboBox1.Text = ConCli.dataGridView1.Rows[ConCli.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                //dateTimePicker1.Text = ConCli.dataGridView1.Rows[ConCli.dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                //dateTimePicker2.Text = ConCli.dataGridView1.Rows[ConCli.dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
