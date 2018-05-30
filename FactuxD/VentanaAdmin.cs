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
    public partial class VentanaAdmin : FormBase
    {
        public VentanaAdmin()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void VentanaAdmin_Load(object sender, EventArgs e)
        {

            string cmd = "SELECT * FROM Usuarios WHERE Id_usuario=" + VentanaLogin.Codigo;
            DataSet DS = Utilidades.Ejecutar(cmd);

            lblNomAdm.Text = DS.Tables[0].Rows[0]["Nom_usu"].ToString();
            lblUsAdm.Text = DS.Tables[0].Rows[0]["Account"].ToString();
            lblCodigo.Text = DS.Tables[0].Rows[0]["Id_usuario"].ToString();

            string url = DS.Tables[0].Rows[0]["Foto"].ToString();
            pictureBox1.Image = Image.FromFile(url);


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaPrincipal ConP = new VentanaPrincipal();
            this.Hide();
            ConP.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
