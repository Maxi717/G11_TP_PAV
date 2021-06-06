
namespace G11_TP_PAV.Formularios.CompraVenta
{
    partial class Frm_BuscarEscribano
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
            this.gdr_Escribanos = new System.Windows.Forms.DataGridView();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdr_Escribanos)).BeginInit();
            this.SuspendLayout();
            // 
            // gdr_Escribanos
            // 
            this.gdr_Escribanos.AllowUserToAddRows = false;
            this.gdr_Escribanos.AllowUserToDeleteRows = false;
            this.gdr_Escribanos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdr_Escribanos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matricula,
            this.Nombre,
            this.Apellido});
            this.gdr_Escribanos.Location = new System.Drawing.Point(12, 12);
            this.gdr_Escribanos.Name = "gdr_Escribanos";
            this.gdr_Escribanos.ReadOnly = true;
            this.gdr_Escribanos.Size = new System.Drawing.Size(344, 237);
            this.gdr_Escribanos.TabIndex = 0;
            this.gdr_Escribanos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdr_Escribanos_CellDoubleClick);
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Frm_BuscarEscribano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 262);
            this.Controls.Add(this.gdr_Escribanos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_BuscarEscribano";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Escribano";
            this.Load += new System.EventHandler(this.Frm_BuscarEscribano_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdr_Escribanos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gdr_Escribanos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
    }
}