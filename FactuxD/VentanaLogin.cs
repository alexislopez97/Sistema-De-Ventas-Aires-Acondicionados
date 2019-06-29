using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MiLibreria;


namespace FactuxD
{
    public partial class VentanaLogin : FormBase
    {
        public VentanaLogin()
        {
            InitializeComponent();
        }

        public static String Codigo = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Utilidades.Ejecutar("Selec * FROM Clientes Where id=1");

            try
            {
                string CMD = string.Format("Select * FROM Usuarios WHERE account='{0}' AND password='{1}'", txtNomAcc.Text.Trim(), txtCont.Text.Trim());
                DataSet ds = Utilidades.Ejecutar(CMD);

                Codigo = ds.Tables[0].Rows[0]["Id_usuario"].ToString().Trim();

                string cuenta = ds.Tables[0].Rows[0]["account"].ToString().Trim();
                string contra = ds.Tables[0].Rows[0]["password"].ToString().Trim();

                if(cuenta == bunifuMaterialTextbox3.Text.Trim() && contra == bunifuMaterialTextbox4.Text.Trim())
                {
                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["Status_admin"]) == true)
                    {
                        VentanaPrincipal venp = new VentanaPrincipal();
                        this.Hide();
                        venp.Show();
                        //VentanaAdmin VenAd = new VentanaAdmin();
                        //this.Hide();
                        //VenAd.Show();
                    }
                    else
                    {
                        VentanaPrincipal venp = new VentanaPrincipal();
                        this.Hide();
                        venp.Show();
                        //VentanaUser VenUs = new VentanaUser();
                        //this.Hide();
                        //VenUs.Show();

                    }
                }

            }
            catch (Exception )
            {
                MessageBox.Show("La contraseña o el usuario son incorrectos...");
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            //Utilidades.Ejecutar("Selec * FROM Clientes Where id=1");

            try
            {
                string CMD = string.Format("Select * FROM Usuarios WHERE account='{0}' AND password='{1}'", bunifuMaterialTextbox3.Text.Trim(), bunifuMaterialTextbox4.Text.Trim());
                DataSet ds = Utilidades.Ejecutar(CMD);

                Codigo = ds.Tables[0].Rows[0]["Id_usuario"].ToString().Trim();

                string cuenta = ds.Tables[0].Rows[0]["account"].ToString().Trim();
                string contra = ds.Tables[0].Rows[0]["password"].ToString().Trim();

                if (cuenta == bunifuMaterialTextbox3.Text.Trim() && contra == bunifuMaterialTextbox4.Text.Trim())
                {
                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["Status_admin"]) == true)
                    {
                        VentanaPrincipal venp = new VentanaPrincipal();
                        this.Hide();
                        venp.Show();
                        //VentanaAdmin VenAd = new VentanaAdmin();
                        //this.Hide();
                        //VenAd.Show();
                    }
                    else
                    {
                        VentanaPrincipal venp = new VentanaPrincipal();
                        this.Hide();
                        venp.Show();
                        //VentanaUser VenUs = new VentanaUser();
                        //this.Hide();
                        //VenUs.Show();

                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("La contraseña o el usuario son incorrectos...");
            }


        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
        }

        private void BunifuMaterialTextbox3_OnValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}
