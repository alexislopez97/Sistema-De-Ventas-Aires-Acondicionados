﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactuxD
{
    public partial class OpcionesOperario : Form
    {
        public OpcionesOperario()
        {
            InitializeComponent();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void OpcionesOperario_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Operarios());
            panelSecundario.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ConsultarOperario());
            panelSecundario.Visible = false;
        }
    }
}
