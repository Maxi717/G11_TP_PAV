namespace G11_TP_PAV.Formularios
{
    partial class Frm_Clientes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grid_clientes = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tipo_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_buscar_clientes = new System.Windows.Forms.Button();
            this.chk_todos_clientes = new System.Windows.Forms.CheckBox();
            this.num_dni = new System.Windows.Forms.NumericUpDown();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_baja = new System.Windows.Forms.Button();
            this.btn_altas_clientes = new System.Windows.Forms.Button();
            this.btn_modificar_cliente = new System.Windows.Forms.Button();
            this.cmb_tipo_dni = new G11_TP_PAV.Clases.ComboBoxHeredadaG();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_dni)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grid_clientes);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_buscar_clientes);
            this.groupBox1.Controls.Add(this.chk_todos_clientes);
            this.groupBox1.Controls.Add(this.cmb_tipo_dni);
            this.groupBox1.Controls.Add(this.num_dni);
            this.groupBox1.Controls.Add(this.txt_nombres);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(884, 471);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // grid_clientes
            // 
            this.grid_clientes.AllowUserToAddRows = false;
            this.grid_clientes.AllowUserToDeleteRows = false;
            this.grid_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.numero_documento,
            this.id_tipo_documento,
            this.telefono,
            this.direccion});
            this.grid_clientes.Location = new System.Drawing.Point(7, 185);
            this.grid_clientes.Name = "grid_clientes";
            this.grid_clientes.ReadOnly = true;
            this.grid_clientes.Size = new System.Drawing.Size(870, 279);
            this.grid_clientes.TabIndex = 6;
            this.grid_clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_clientes_CellClick);
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 200;
            // 
            // numero_documento
            // 
            this.numero_documento.HeaderText = "Número de documento";
            this.numero_documento.Name = "numero_documento";
            this.numero_documento.ReadOnly = true;
            this.numero_documento.Width = 150;
            // 
            // id_tipo_documento
            // 
            this.id_tipo_documento.HeaderText = "Tipo Documento";
            this.id_tipo_documento.Name = "id_tipo_documento";
            this.id_tipo_documento.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Teléfono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 150;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Dirección";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 200;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::G11_TP_PAV.Properties.Resources._3puntos;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(366, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 24);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_buscar_clientes
            // 
            this.btn_buscar_clientes.Location = new System.Drawing.Point(781, 134);
            this.btn_buscar_clientes.Name = "btn_buscar_clientes";
            this.btn_buscar_clientes.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar_clientes.TabIndex = 5;
            this.btn_buscar_clientes.Text = "Buscar";
            this.btn_buscar_clientes.UseVisualStyleBackColor = true;
            this.btn_buscar_clientes.Click += new System.EventHandler(this.btn_buscar_clientes_Click);
            // 
            // chk_todos_clientes
            // 
            this.chk_todos_clientes.AutoSize = true;
            this.chk_todos_clientes.Location = new System.Drawing.Point(227, 137);
            this.chk_todos_clientes.Name = "chk_todos_clientes";
            this.chk_todos_clientes.Size = new System.Drawing.Size(106, 20);
            this.chk_todos_clientes.TabIndex = 4;
            this.chk_todos_clientes.Text = "Buscar todos";
            this.chk_todos_clientes.UseVisualStyleBackColor = true;
            // 
            // num_dni
            // 
            this.num_dni.Location = new System.Drawing.Point(227, 79);
            this.num_dni.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.num_dni.Name = "num_dni";
            this.num_dni.Size = new System.Drawing.Size(132, 22);
            this.num_dni.TabIndex = 1;
            // 
            // txt_nombres
            // 
            this.txt_nombres.Location = new System.Drawing.Point(227, 50);
            this.txt_nombres.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(132, 22);
            this.txt_nombres.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo de documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número de documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // btn_salir
            // 
            this.btn_salir.BackgroundImage = global::G11_TP_PAV.Properties.Resources.salir;
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salir.Location = new System.Drawing.Point(839, 494);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(54, 48);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_baja
            // 
            this.btn_baja.BackgroundImage = global::G11_TP_PAV.Properties.Resources.eliminar;
            this.btn_baja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_baja.Location = new System.Drawing.Point(143, 494);
            this.btn_baja.Name = "btn_baja";
            this.btn_baja.Size = new System.Drawing.Size(54, 48);
            this.btn_baja.TabIndex = 3;
            this.btn_baja.UseVisualStyleBackColor = true;
            this.btn_baja.Click += new System.EventHandler(this.btn_baja_Click);
            // 
            // btn_altas_clientes
            // 
            this.btn_altas_clientes.BackgroundImage = global::G11_TP_PAV.Properties.Resources.nuevo1;
            this.btn_altas_clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_altas_clientes.Location = new System.Drawing.Point(23, 494);
            this.btn_altas_clientes.Name = "btn_altas_clientes";
            this.btn_altas_clientes.Size = new System.Drawing.Size(54, 48);
            this.btn_altas_clientes.TabIndex = 1;
            this.btn_altas_clientes.UseVisualStyleBackColor = true;
            this.btn_altas_clientes.Click += new System.EventHandler(this.btn_altas_clientes_Click);
            // 
            // btn_modificar_cliente
            // 
            this.btn_modificar_cliente.BackgroundImage = global::G11_TP_PAV.Properties.Resources.modificar01;
            this.btn_modificar_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_modificar_cliente.Location = new System.Drawing.Point(83, 493);
            this.btn_modificar_cliente.Name = "btn_modificar_cliente";
            this.btn_modificar_cliente.Size = new System.Drawing.Size(54, 48);
            this.btn_modificar_cliente.TabIndex = 2;
            this.btn_modificar_cliente.UseVisualStyleBackColor = true;
            this.btn_modificar_cliente.Click += new System.EventHandler(this.btn_modificar_cliente_Click);
            // 
            // cmb_tipo_dni
            // 
            this.cmb_tipo_dni.FormattingEnabled = true;
            this.cmb_tipo_dni.Location = new System.Drawing.Point(227, 107);
            this.cmb_tipo_dni.Name = "cmb_tipo_dni";
            this.cmb_tipo_dni.Pp_campo = null;
            this.cmb_tipo_dni.Pp_Conseleccion = false;
            this.cmb_tipo_dni.Pp_descripcion = "Nombre_tipo_documento";
            this.cmb_tipo_dni.Pp_MensajeError = null;
            this.cmb_tipo_dni.Pp_NombreTabla = null;
            this.cmb_tipo_dni.Pp_Pk = "Id_tipo_documento";
            this.cmb_tipo_dni.Pp_Tabla = "tipo_documento";
            this.cmb_tipo_dni.Pp_Validable = false;
            this.cmb_tipo_dni.Size = new System.Drawing.Size(132, 24);
            this.cmb_tipo_dni.TabIndex = 2;
            // 
            // Frm_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 554);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_baja);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_altas_clientes);
            this.Controls.Add(this.btn_modificar_cliente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Frm_Clientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_dni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown num_dni;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Clases.ComboBoxHeredadaG cmb_tipo_dni;
        private System.Windows.Forms.Button btn_buscar_clientes;
        private System.Windows.Forms.CheckBox chk_todos_clientes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grid_clientes;
        private System.Windows.Forms.Button btn_altas_clientes;
        private System.Windows.Forms.Button btn_baja;
        private System.Windows.Forms.Button btn_modificar_cliente;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tipo_documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
    }
}