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
    public partial class ConsultarOperario : Consultas
    {
        public ConsultarOperario()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds;
                string cmd = "Select * FROM Operario where Nom_Operario LIKE ('%" + textBox1.Text.Trim() + "%')";

                ds = Utilidades.Ejecutar(cmd);

                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error: No se encontró ningún operario con ese nombre vuelva a intentarlo. " + error.Message);
            }
        }

        private void ConsultarOperario_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LLenarDataGV("Operario").Tables[0];
        }
    }
}
