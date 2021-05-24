namespace G11_TP_PAV.Formularios
{
    partial class Frm_ABMC_Publicidad
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
            this.btn_iniciar_baja = new System.Windows.Forms.Button();
            this.btn_iniciar_update = new System.Windows.Forms.Button();
            this.btn_iniciar_alta = new System.Windows.Forms.Button();
            this.grid_publicidades = new System.Windows.Forms.DataGridView();
            this.id_publicidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publicado_en = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_publicidades)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_iniciar_baja
            // 
            this.btn_iniciar_baja.Enabled = false;
            this.btn_iniciar_baja.Location = new System.Drawing.Point(379, 210);
            this.btn_iniciar_baja.Name = "btn_iniciar_baja";
            this.btn_iniciar_baja.Size = new System.Drawing.Size(235, 59);
            this.btn_iniciar_baja.TabIndex = 8;
            this.btn_iniciar_baja.Text = "Borrar Seleccionada";
            this.btn_iniciar_baja.UseVisualStyleBackColor = true;
            // 
            // btn_iniciar_update
            // 
            this.btn_iniciar_update.Enabled = false;
            this.btn_iniciar_update.Location = new System.Drawing.Point(195, 210);
            this.btn_iniciar_update.Name = "btn_iniciar_update";
            this.btn_iniciar_update.Size = new System.Drawing.Size(178, 59);
            this.btn_iniciar_update.TabIndex = 7;
            this.btn_iniciar_update.Text = "Modificar Seleccionada";
            this.btn_iniciar_update.UseVisualStyleBackColor = true;
            // 
            // btn_iniciar_alta
            // 
            this.btn_iniciar_alta.Location = new System.Drawing.Point(12, 210);
            this.btn_iniciar_alta.Name = "btn_iniciar_alta";
            this.btn_iniciar_alta.Size = new System.Drawing.Size(177, 59);
            this.btn_iniciar_alta.TabIndex = 6;
            this.btn_iniciar_alta.Text = "Agregar Nueva Publicidad";
            this.btn_iniciar_alta.UseVisualStyleBackColor = true;
            this.btn_iniciar_alta.Click += new System.EventHandler(this.btn_iniciar_alta_Click);
            // 
            // grid_publicidades
            // 
            this.grid_publicidades.AllowUserToAddRows = false;
            this.grid_publicidades.AllowUserToDeleteRows = false;
            this.grid_publicidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_publicidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_publicidad,
            this.fecha,
            this.Costo,
            this.Precio,
            this.Descripcion,
            this.Publicado_en});
            this.grid_publicidades.Location = new System.Drawing.Point(12, 12);
            this.grid_publicidades.Name = "grid_publicidades";
            this.grid_publicidades.ReadOnly = true;
            this.grid_publicidades.RowTemplate.ReadOnly = true;
            this.grid_publicidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_publicidades.Size = new System.Drawing.Size(606, 191);
            this.grid_publicidades.TabIndex = 5;
            this.grid_publicidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_publicidades_CellContentClick);
            // 
            // id_publicidad
            // 
            this.id_publicidad.HeaderText = "id_publicidad";
            this.id_publicidad.Name = "id_publicidad";
            this.id_publicidad.ReadOnly = true;
            this.id_publicidad.Visible = false;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 70;
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 150;
            // 
            // Publicado_en
            // 
            this.Publicado_en.HeaderText = "Publicado en:";
            this.Publicado_en.Name = "Publicado_en";
            this.Publicado_en.ReadOnly = true;
            this.Publicado_en.Width = 120;
            // 
            // Frm_ABMC_Publicidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 285);
            this.Controls.Add(this.btn_iniciar_baja);
            this.Controls.Add(this.btn_iniciar_update);
            this.Controls.Add(this.btn_iniciar_alta);
            this.Controls.Add(this.grid_publicidades);
            this.Name = "Frm_ABMC_Publicidad";
            this.Text = "Frm_ABMC_Publicidad";
            this.Load += new System.EventHandler(this.Frm_ABMC_Publicidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_publicidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_iniciar_baja;
        private System.Windows.Forms.Button btn_iniciar_update;
        private System.Windows.Forms.Button btn_iniciar_alta;
        private System.Windows.Forms.DataGridView grid_publicidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_publicidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publicado_en;
    }
}