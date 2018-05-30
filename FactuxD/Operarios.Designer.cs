namespace FactuxD
{
    partial class Operarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdOpe = new MiLibreria.ErrorTxtBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtNomOpe = new MiLibreria.ErrorTxtBox();
            this.txtApeOpe = new MiLibreria.ErrorTxtBox();
            this.txtCelOpe = new MiLibreria.ErrorTxtBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(505, 308);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 308);
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(273, 308);
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(389, 308);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Operario:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellido:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cel:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtIdOpe
            // 
            this.txtIdOpe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdOpe.Location = new System.Drawing.Point(273, 117);
            this.txtIdOpe.Name = "txtIdOpe";
            this.txtIdOpe.Size = new System.Drawing.Size(342, 26);
            this.txtIdOpe.SoloNumeros = true;
            this.txtIdOpe.TabIndex = 19;
            this.txtIdOpe.Validar = true;
            this.txtIdOpe.TextChanged += new System.EventHandler(this.txtIdCli_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtNomOpe
            // 
            this.txtNomOpe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomOpe.Location = new System.Drawing.Point(273, 159);
            this.txtNomOpe.Name = "txtNomOpe";
            this.txtNomOpe.Size = new System.Drawing.Size(342, 26);
            this.txtNomOpe.SoloNumeros = false;
            this.txtNomOpe.TabIndex = 22;
            this.txtNomOpe.Validar = true;
            // 
            // txtApeOpe
            // 
            this.txtApeOpe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApeOpe.Location = new System.Drawing.Point(273, 204);
            this.txtApeOpe.Name = "txtApeOpe";
            this.txtApeOpe.Size = new System.Drawing.Size(342, 26);
            this.txtApeOpe.SoloNumeros = false;
            this.txtApeOpe.TabIndex = 23;
            this.txtApeOpe.Validar = true;
            // 
            // txtCelOpe
            // 
            this.txtCelOpe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelOpe.Location = new System.Drawing.Point(273, 242);
            this.txtCelOpe.Name = "txtCelOpe";
            this.txtCelOpe.Size = new System.Drawing.Size(342, 26);
            this.txtCelOpe.SoloNumeros = true;
            this.txtCelOpe.TabIndex = 24;
            this.txtCelOpe.Validar = true;
            // 
            // Operarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 468);
            this.Controls.Add(this.txtCelOpe);
            this.Controls.Add(this.txtApeOpe);
            this.Controls.Add(this.txtNomOpe);
            this.Controls.Add(this.txtIdOpe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Operarios";
            this.Text = "Operarios";
            this.Load += new System.EventHandler(this.Operarios_Load);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtIdOpe, 0);
            this.Controls.SetChildIndex(this.txtNomOpe, 0);
            this.Controls.SetChildIndex(this.txtApeOpe, 0);
            this.Controls.SetChildIndex(this.txtCelOpe, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MiLibreria.ErrorTxtBox txtIdOpe;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MiLibreria.ErrorTxtBox txtCelOpe;
        private MiLibreria.ErrorTxtBox txtApeOpe;
        private MiLibreria.ErrorTxtBox txtNomOpe;
    }
}