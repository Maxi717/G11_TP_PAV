
namespace G11_TP_PAV.Formularios.CompraVenta
{
    partial class Frm_BuscarCliente
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
            this.gdr_Cliente = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nro_Doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Tipo_Doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdr_Cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // gdr_Cliente
            // 
            this.gdr_Cliente.AllowUserToAddRows = false;
            this.gdr_Cliente.AllowUserToDeleteRows = false;
            this.gdr_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdr_Cliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Tipo_Doc,
            this.Nro_Doc,
            this.Id_Tipo_Doc});
            this.gdr_Cliente.Location = new System.Drawing.Point(12, 12);
            this.gdr_Cliente.Name = "gdr_Cliente";
            this.gdr_Cliente.ReadOnly = true;
            this.gdr_Cliente.Size = new System.Drawing.Size(595, 224);
            this.gdr_Cliente.TabIndex = 0;
            this.gdr_Cliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdr_Cliente_CellDoubleClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // Tipo_Doc
            // 
            this.Tipo_Doc.HeaderText = "Tipo_Doc";
            this.Tipo_Doc.Name = "Tipo_Doc";
            this.Tipo_Doc.ReadOnly = true;
            this.Tipo_Doc.Width = 150;
            // 
            // Nro_Doc
            // 
            this.Nro_Doc.HeaderText = "Nro_Doc";
            this.Nro_Doc.Name = "Nro_Doc";
            this.Nro_Doc.ReadOnly = true;
            this.Nro_Doc.Width = 200;
            // 
            // Id_Tipo_Doc
            // 
            this.Id_Tipo_Doc.HeaderText = "Id_Tipo_Doc";
            this.Id_Tipo_Doc.Name = "Id_Tipo_Doc";
            this.Id_Tipo_Doc.ReadOnly = true;
            this.Id_Tipo_Doc.Visible = false;
            // 
            // Frm_BuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 253);
            this.Controls.Add(this.gdr_Cliente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_BuscarCliente";
            this.Text = "Busqueda de Cliente";
            this.Load += new System.EventHandler(this.Frm_BuscarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdr_Cliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gdr_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_Doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Tipo_Doc;
    }
}