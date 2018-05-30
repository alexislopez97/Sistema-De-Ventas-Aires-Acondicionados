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
    public partial class btnPromocion : Procesos
    {
        public btnPromocion()
        {
            InitializeComponent();
        }

        public static int cont_fila = 0;
        public static double total;
        public static string regresar;
        public static double descuento;

        private void button1_Click(object sender, EventArgs e)
        {
            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                bool existe = false;
                int num_fila = 0;
                
                if(cont_fila == 0)
                {
                    dataGridView1.Rows.Add(txtCodigoPro.Text, txtDescripcion.Text, txtPrecio.Text, txtCantidad.Text);
                    double importe = Convert.ToDouble(dataGridView1.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[cont_fila].Cells[3].Value);
                    dataGridView1.Rows[cont_fila].Cells[4].Value = importe;

                    cont_fila++;
                }
                else
                {
                    foreach(DataGridViewRow Fila in dataGridView1.Rows)
                    {
                        if(Fila.Cells[0].Value.ToString() == txtCodigoPro.Text)
                        {
                            existe = true;
                            num_fila = Fila.Index;
                        }
                    }

                    if (existe == true)
                    {
                        dataGridView1.Rows[num_fila].Cells[3].Value = (Convert.ToDouble(txtCantidad.Text) + Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[3].Value)).ToString();
                        double importe = Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[3].Value);

                        dataGridView1.Rows[num_fila].Cells[4].Value = importe;
                    }
                    else
                    {
                        dataGridView1.Rows.Add(txtCodigoPro.Text, txtDescripcion.Text, txtPrecio.Text, txtCantidad.Text);
                        double importe = Convert.ToDouble(dataGridView1.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[cont_fila].Cells[3].Value);
                        dataGridView1.Rows[cont_fila].Cells[4].Value = importe;

                        cont_fila++;
                    }

                }

                total = 0;
                if (string.IsNullOrEmpty(txtDescPromo.Text.Trim()))
                {
                    descuento = 1;
                }
                else
                {
                    descuento = (Convert.ToDouble(txtDescPromo.Text));
                }

                foreach (DataGridViewRow Fila in dataGridView1.Rows)
                {
                    total += Convert.ToDouble(Fila.Cells[4].Value);
                }

                //Eliminar del inventario la cantidad de productos vendidos 

                string cmdp = string.Format("EXEC ActualizarInventario '{0}', '{1}', '{2}', '{3}'", txtCodigoPro.Text.Trim(), txtDescripcion.Text.Trim(), txtPrecio.Text.Trim(), txtCantidad.Text.Trim());
                Utilidades.Ejecutar(cmdp);

                total = total - (total * descuento);
                lblTotal.Text = "$ " + total.ToString();
            }

            txtCantidad.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConsultarClientes ConCli = new ConsultarClientes();
            ConCli.ShowDialog();

            if (ConCli.DialogResult == DialogResult.OK)
            {
                txtCodigoCli.Text = ConCli.dataGridView1.Rows[ConCli.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                txtCliente.Text = ConCli.dataGridView1.Rows[ConCli.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();

                txtCodigoPro.Focus();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(cont_fila != 0)
            {
                try
                {
                    string cmd = string.Format("Exec ActualizaFacturas '{0}'", txtCodigoCli.Text.Trim());

                    DataSet ds = Utilidades.Ejecutar(cmd);

                    string Numfac = ds.Tables[0].Rows[0]["NumFac"].ToString().Trim();

                    foreach(DataGridViewRow Fila in dataGridView1.Rows)
                    {
                        cmd = string.Format("Exec ActualizaDetalles '{0}','{1}','{2}','{3}'", Numfac, Fila.Cells[0].Value.ToString(), Fila.Cells[2].Value.ToString(), Fila.Cells[3].Value.ToString());
                        ds = Utilidades.Ejecutar(cmd);
                    }

                    cmd = "Exec DatosFactura " + Numfac;
                    ds = Utilidades.Ejecutar(cmd);

                    //Eliminar del inventario la cantidad de productos vendidos 

                    string cmdp = string.Format("EXEC ActualizarInventario '{0}', '{1}', '{2}', '{3}'", txtCodigoPro.Text.Trim(), txtDescripcion.Text.Trim(), txtPrecio.Text.Trim(), txtCantidad.Text.Trim());
                    Utilidades.Ejecutar(cmdp);
                    //MessageBox.Show("Se ha guardado correctamente!... ");

                    //Ventana reporte
                    Reporte rp = new Reporte();
                    rp.reportViewer1.LocalReport.DataSources[0].Value = ds.Tables[0];
                    rp.ShowDialog();

                    Nuevo();


                }
                catch (Exception error)
                {
                    MessageBox.Show("Error: " + error.Message);
                }


            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void errorTxtBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void errorTxtBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void errorTxtBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void errorTxtBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void errorTxtBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void errorTxtBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            string cmd = "Select * from Usuarios where Id_usuario=" + VentanaLogin.Codigo;

            DataSet ds;

            ds = Utilidades.Ejecutar(cmd);

            lblLeAtiende.Text = ds.Tables[0].Rows[0]["Nom_usu"].ToString().Trim();

        }

        private void errorTxtBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCodigoCli.Text.Trim()) == false)
                {
                    string cmd = string.Format("SELECT Nom_cliente FROM cliente where Id_cliente='{0}'", txtCodigoCli.Text.Trim());

                    DataSet ds = Utilidades.Ejecutar(cmd);

                    txtCliente.Text = ds.Tables[0].Rows[0]["Nom_cliente"].ToString().Trim();

                    txtCodigoPro.Focus();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error: " + error.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cont_fila > 0)
            {
                total = total - (Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value));
                lblTotal.Text = "$ " + total.ToString();
                lblregresar.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value);

                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

                cont_fila--;
            }

            //regresar al inventario la cantidad de productos no vendidos 
            string cmdp = string.Format("EXEC ActualizarArticulos '{0}', '{1}', '{2}', '{3}'", txtCodigoPro.Text.Trim(), txtDescripcion.Text.Trim(), txtPrecio.Text.Trim(), lblregresar.Text.Trim());
            Utilidades.Ejecutar(cmdp);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ConsultarProductos ConPro = new ConsultarProductos();
            ConPro.ShowDialog();
            //double comparacion;
            //string extraer
            
      
            if(ConPro.DialogResult == DialogResult.OK)
            {
                double extraer = Convert.ToDouble(ConPro.dataGridView1.Rows[ConPro.dataGridView1.CurrentRow.Index].Cells[3].Value.ToString());
                if (extraer == 0)
                {
                    MessageBox.Show("No hay productos existentes");
                }
                else
                {
                    txtCodigoPro.Text = ConPro.dataGridView1.Rows[ConPro.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                    txtDescripcion.Text = ConPro.dataGridView1.Rows[ConPro.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                    txtPrecio.Text = ConPro.dataGridView1.Rows[ConPro.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                    txtCantidad.Focus();
                }
                
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        public override void Nuevo()
        {
            txtCodigoCli.Text = "";
            txtCliente.Text = "";
            txtCodigoPro.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            lblTotal.Text = "$ 0";
            dataGridView1.Rows.Clear();
            cont_fila = 0;
            total = 0;
            txtCodigoCli.Focus();
        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ConsultarPromociones ConPro = new ConsultarPromociones();
            ConPro.ShowDialog();

            if (ConPro.DialogResult == DialogResult.OK)
            {
                txtNompromo.Text = ConPro.dataGridView1.Rows[ConPro.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                txtDescPromo.Text = ConPro.dataGridView1.Rows[ConPro.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();

                //txtCodigoPro.Focus();
            }
        }
    }
}
