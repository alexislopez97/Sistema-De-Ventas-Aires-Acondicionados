namespace FactuxD
{
    partial class ConsultarOperario
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
            this.idclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apeclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // idclienteDataGridViewTextBoxColumn
            // 
            this.idclienteDataGridViewTextBoxColumn.DataPropertyName = "Id_cliente";
            this.idclienteDataGridViewTextBoxColumn.HeaderText = "Id_cliente";
            this.idclienteDataGridViewTextBoxColumn.Name = "idclienteDataGridViewTextBoxColumn";
            // 
            // nomclienteDataGridViewTextBoxColumn
            // 
            this.nomclienteDataGridViewTextBoxColumn.DataPropertyName = "Nom_cliente";
            this.nomclienteDataGridViewTextBoxColumn.HeaderText = "Nom_cliente";
            this.nomclienteDataGridViewTextBoxColumn.Name = "nomclienteDataGridViewTextBoxColumn";
            // 
            // apeclienteDataGridViewTextBoxColumn
            // 
            this.apeclienteDataGridViewTextBoxColumn.DataPropertyName = "Ape_cliente";
            this.apeclienteDataGridViewTextBoxColumn.HeaderText = "Ape_cliente";
            this.apeclienteDataGridViewTextBoxColumn.Name = "apeclienteDataGridViewTextBoxColumn";
            // 
            // ConsultarOperario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 528);
            this.Name = "ConsultarOperario";
            this.Text = "ConsultarOperario";
            this.Load += new System.EventHandler(this.ConsultarOperario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn idclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apeclienteDataGridViewTextBoxColumn;
    }
}