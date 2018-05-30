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
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MantenimientoProducto ManPro = new MantenimientoProducto();
            //this.Hide();
            ManPro.Show();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            string cmd = "SELECT * FROM Usuarios WHERE Id_usuario=" + VentanaLogin.Codigo;
            DataSet DS = Utilidades.Ejecutar(cmd);

            lblNomAdm.Text = DS.Tables[0].Rows[0]["Nom_usu"].ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new OpcionesClientes());
            //ConsultarClientes ConClie = new ConsultarClientes();
            //ConClie.Show();
        }

        public void AbrirFormInPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            fh.FormBorderStyle = FormBorderStyle.None;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            AbrirFormInPanel(new btnPromocion());
            //btnPromocion Fac = new btnPromocion();
            //Fac.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            MantenimientoCliente ManCli = new MantenimientoCliente();
            //this.Hide();
            ManCli.Show();
        }

        private void btnProCon_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new OpcionesProductos());
            //ConsultarProductos ConPro = new ConsultarProductos();
            //ConPro.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnManOpe_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new OpcionesOperario());
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ConsultarOperario());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Promociones());
        }

        private void panelContenedor_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void lblNomAdm_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Soporte());
        }
    }
}
