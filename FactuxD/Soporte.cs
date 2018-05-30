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
    public partial class Soporte : Consultas1
    {
        public Soporte()
        {
            InitializeComponent();
        }

        private void Soporte_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LLenarDataGV("Servicio").Tables[0];
            lblNomAdm.Text = Convert.ToString(Num_servicio);
        }

        public int Num_servicio = 1;
        public float precio = 550;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDescPromo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtNompromo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lblLeAtiende_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigoCli_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click_1(object sender, EventArgs e)
        {
            ConsultarClientes ConCli = new ConsultarClientes();
            ConCli.ShowDialog();

            if (ConCli.DialogResult == DialogResult.OK)
            {
                txtCodigoCli.Text = ConCli.dataGridView1.Rows[ConCli.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                txtCliente.Text = ConCli.dataGridView1.Rows[ConCli.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();

                btnTecnico.Focus();
            }
            dataGridView1.DataSource = LLenarDataGV("Servicio").Tables[0];
            
        }

        private void btnTecnico_Click(object sender, EventArgs e)
        {
            ConsultarOperario ConCli = new ConsultarOperario();
            ConCli.ShowDialog();

            if (ConCli.DialogResult == DialogResult.OK)
            {
                txttecnico.Text = ConCli.dataGridView1.Rows[ConCli.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();

                dateTimePicker1.Focus();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string fecha = Convert.ToString(dateTimePicker1.Value.ToShortDateString());

            try
            {
                string cmd = string.Format("EXEC ActualizarServicio '{0}', '{1}', '{2}', '{3}', '{4}','{5}', '{6}'", lblNomAdm.Text.Trim(), txtCodigoCli.Text.Trim(), txtCliente.Text.Trim(), txttecnico.Text.Trim(), fecha, comboservicio.Text.Trim(), precio);
                Utilidades.Ejecutar(cmd);
                Guardar gr = new Guardar();
                gr.Show();
                Num_servicio = Num_servicio + 1;
                lblNomAdm.Text = Convert.ToString(Num_servicio);
                //MessageBox.Show("Se ha guardado correctamente!... ");
                //return true;
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error: " + error.Message);
                //return false;
            }
            dataGridView1.DataSource = LLenarDataGV("Servicio").Tables[0];
            

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            lblNomAdm.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            txtCodigoCli.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            txtCliente.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            txttecnico.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
            comboservicio.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
            

            dataGridView1.DataSource = LLenarDataGV("Servicio").Tables[0];
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string eliminar = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            try
            {
                string cmd = string.Format("EXEC EliminarServicio '{0}'", eliminar);
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("Se ha eliminado");

            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error: " + error.Message);
            }

            dataGridView1.DataSource = LLenarDataGV("Servicio").Tables[0];
            
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            txtCodigoCli.Text = "";
            txtCliente.Text = "";
            txttecnico.Text = "";
            comboservicio.Text = "";
            btnCliente.Focus();
            dataGridView1.DataSource = LLenarDataGV("Servicio").Tables[0];
            Num_servicio = Num_servicio + 1;
            lblNomAdm.Text = Convert.ToString(Num_servicio); 



        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click_2(object sender, EventArgs e)
        {

        }

        private void label13_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }
    }
}
