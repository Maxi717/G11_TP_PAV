
namespace G11_TP_PAV.Formularios.CompraVenta
{
    partial class Frm_BuscarPropiedad
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
            this.gdr_Propiedades = new System.Windows.Forms.DataGridView();
            this.Design_Catastral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdr_Propiedades)).BeginInit();
            this.SuspendLayout();
            // 
            // gdr_Propiedades
            // 
            this.gdr_Propiedades.AllowUserToAddRows = false;
            this.gdr_Propiedades.AllowUserToDeleteRows = false;
            this.gdr_Propiedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdr_Propiedades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Design_Catastral,
            this.Tipo,
            this.Barrio,
            this.Calle,
            this.Numero});
            this.gdr_Propiedades.Location = new System.Drawing.Point(12, 12);
            this.gdr_Propiedades.Name = "gdr_Propiedades";
            this.gdr_Propiedades.ReadOnly = true;
            this.gdr_Propiedades.Size = new System.Drawing.Size(744, 244);
            this.gdr_Propiedades.TabIndex = 0;
            this.gdr_Propiedades.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdr_Propiedades_CellDoubleClick);
            // 
            // Design_Catastral
            // 
            this.Design_Catastral.HeaderText = "Design_Catastral";
            this.Design_Catastral.Name = "Design_Catastral";
            this.Design_Catastral.ReadOnly = true;
            this.Design_Catastral.Width = 150;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 150;
            // 
            // Barrio
            // 
            this.Barrio.HeaderText = "Barrio";
            this.Barrio.Name = "Barrio";
            this.Barrio.ReadOnly = true;
            this.Barrio.Width = 150;
            // 
            // Calle
            // 
            this.Calle.HeaderText = "Calle";
            this.Calle.Name = "Calle";
            this.Calle.ReadOnly = true;
            this.Calle.Width = 150;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Frm_BuscarPropiedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 270);
            this.Controls.Add(this.gdr_Propiedades);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_BuscarPropiedad";
            this.Text = "Seleccion de Propiedad";
            this.Load += new System.EventHandler(this.Frm_BuscarPropiedad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdr_Propiedades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gdr_Propiedades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Design_Catastral;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
    }
}