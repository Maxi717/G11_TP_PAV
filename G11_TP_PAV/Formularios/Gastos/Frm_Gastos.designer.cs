namespace G11_TP_PAV.Formularios
{
    partial class Frm_Gastos
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
            this.num_importe = new G11_TP_PAV.Clases.NumericHeredada();
            this.label4 = new System.Windows.Forms.Label();
            this.num_comprobante = new G11_TP_PAV.Clases.NumericHeredada();
            this.btn_buscar_gastos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_proveedor = new G11_TP_PAV.Clases.TextBoxHeredada();
            this.chk_todos_gastos = new System.Windows.Forms.CheckBox();
            this.grid_gastos = new System.Windows.Forms.DataGridView();
            this.numero_comprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_edificio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_edificio = new G11_TP_PAV.Clases.ComboBoxHeredadaG();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_baja = new System.Windows.Forms.Button();
            this.btn_altas_gastos = new System.Windows.Forms.Button();
            this.btn_modificar_gastos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_importe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_comprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_gastos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.num_importe);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.num_comprobante);
            this.groupBox1.Controls.Add(this.btn_buscar_gastos);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt_proveedor);
            this.groupBox1.Controls.Add(this.chk_todos_gastos);
            this.groupBox1.Controls.Add(this.grid_gastos);
            this.groupBox1.Controls.Add(this.cmb_edificio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1078, 476);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // num_importe
            // 
            this.num_importe.Location = new System.Drawing.Point(640, 38);
            this.num_importe.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.num_importe.Name = "num_importe";
            this.num_importe.Pp_campo = "numero_comprobante";
            this.num_importe.Pp_MensajeError = null;
            this.num_importe.Pp_tabla = null;
            this.num_importe.Pp_Validable = false;
            this.num_importe.Size = new System.Drawing.Size(132, 22);
            this.num_importe.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Numero de comprobante";
            // 
            // num_comprobante
            // 
            this.num_comprobante.Location = new System.Drawing.Point(223, 38);
            this.num_comprobante.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.num_comprobante.Name = "num_comprobante";
            this.num_comprobante.Pp_campo = "importe";
            this.num_comprobante.Pp_MensajeError = null;
            this.num_comprobante.Pp_tabla = null;
            this.num_comprobante.Pp_Validable = false;
            this.num_comprobante.Size = new System.Drawing.Size(132, 22);
            this.num_comprobante.TabIndex = 0;
            // 
            // btn_buscar_gastos
            // 
            this.btn_buscar_gastos.Location = new System.Drawing.Point(939, 111);
            this.btn_buscar_gastos.Name = "btn_buscar_gastos";
            this.btn_buscar_gastos.Size = new System.Drawing.Size(132, 38);
            this.btn_buscar_gastos.TabIndex = 6;
            this.btn_buscar_gastos.Text = "Buscar";
            this.btn_buscar_gastos.UseVisualStyleBackColor = true;
            this.btn_buscar_gastos.Click += new System.EventHandler(this.btn_buscar_gastos_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::G11_TP_PAV.Properties.Resources._3puntos;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(361, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 24);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_proveedor
            // 
            this.txt_proveedor.Location = new System.Drawing.Point(223, 67);
            this.txt_proveedor.Name = "txt_proveedor";
            this.txt_proveedor.Pp_campo = "proveedor";
            this.txt_proveedor.Pp_MensajeError = null;
            this.txt_proveedor.Pp_tabla = null;
            this.txt_proveedor.Pp_Validable = false;
            this.txt_proveedor.Size = new System.Drawing.Size(132, 22);
            this.txt_proveedor.TabIndex = 1;
            // 
            // chk_todos_gastos
            // 
            this.chk_todos_gastos.AutoSize = true;
            this.chk_todos_gastos.Location = new System.Drawing.Point(223, 129);
            this.chk_todos_gastos.Name = "chk_todos_gastos";
            this.chk_todos_gastos.Size = new System.Drawing.Size(106, 20);
            this.chk_todos_gastos.TabIndex = 4;
            this.chk_todos_gastos.Text = "Buscar todos";
            this.chk_todos_gastos.UseVisualStyleBackColor = true;
            // 
            // grid_gastos
            // 
            this.grid_gastos.AllowUserToAddRows = false;
            this.grid_gastos.AllowUserToDeleteRows = false;
            this.grid_gastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_gastos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero_comprobante,
            this.fecha,
            this.concepto,
            this.proveedor,
            this.importe,
            this.id_edificio});
            this.grid_gastos.Location = new System.Drawing.Point(7, 165);
            this.grid_gastos.Name = "grid_gastos";
            this.grid_gastos.ReadOnly = true;
            this.grid_gastos.Size = new System.Drawing.Size(1064, 304);
            this.grid_gastos.TabIndex = 7;
            this.grid_gastos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_gastos_CellClick);
            // 
            // numero_comprobante
            // 
            this.numero_comprobante.HeaderText = "Numero de Comprobante";
            this.numero_comprobante.Name = "numero_comprobante";
            this.numero_comprobante.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha de transacción";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 125;
            // 
            // concepto
            // 
            this.concepto.HeaderText = "Concepto";
            this.concepto.Name = "concepto";
            this.concepto.ReadOnly = true;
            this.concepto.Width = 325;
            // 
            // proveedor
            // 
            this.proveedor.HeaderText = "Proveedor";
            this.proveedor.Name = "proveedor";
            this.proveedor.ReadOnly = true;
            this.proveedor.Width = 200;
            // 
            // importe
            // 
            this.importe.HeaderText = "Importe";
            this.importe.Name = "importe";
            this.importe.ReadOnly = true;
            // 
            // id_edificio
            // 
            this.id_edificio.HeaderText = "Edificio";
            this.id_edificio.Name = "id_edificio";
            this.id_edificio.ReadOnly = true;
            this.id_edificio.Width = 150;
            // 
            // cmb_edificio
            // 
            this.cmb_edificio.FormattingEnabled = true;
            this.cmb_edificio.Location = new System.Drawing.Point(223, 94);
            this.cmb_edificio.Name = "cmb_edificio";
            this.cmb_edificio.Pp_campo = "id_edificio";
            this.cmb_edificio.Pp_Conseleccion = false;
            this.cmb_edificio.Pp_descripcion = "domicilio";
            this.cmb_edificio.Pp_MensajeError = "";
            this.cmb_edificio.Pp_NombreTabla = null;
            this.cmb_edificio.Pp_Pk = "id";
            this.cmb_edificio.Pp_Tabla = "edificios";
            this.cmb_edificio.Pp_Validable = false;
            this.cmb_edificio.Size = new System.Drawing.Size(132, 24);
            this.cmb_edificio.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Edificio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Importe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proveedor";
            // 
            // btn_salir
            // 
            this.btn_salir.BackgroundImage = global::G11_TP_PAV.Properties.Resources.salir;
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salir.Location = new System.Drawing.Point(1033, 498);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(54, 48);
            this.btn_salir.TabIndex = 3;
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_baja
            // 
            this.btn_baja.BackgroundImage = global::G11_TP_PAV.Properties.Resources.eliminar;
            this.btn_baja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_baja.Location = new System.Drawing.Point(141, 494);
            this.btn_baja.Name = "btn_baja";
            this.btn_baja.Size = new System.Drawing.Size(54, 48);
            this.btn_baja.TabIndex = 2;
            this.btn_baja.UseVisualStyleBackColor = true;
            this.btn_baja.Click += new System.EventHandler(this.btn_baja_Click);
            // 
            // btn_altas_gastos
            // 
            this.btn_altas_gastos.BackgroundImage = global::G11_TP_PAV.Properties.Resources.nuevo1;
            this.btn_altas_gastos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_altas_gastos.Location = new System.Drawing.Point(21, 494);
            this.btn_altas_gastos.Name = "btn_altas_gastos";
            this.btn_altas_gastos.Size = new System.Drawing.Size(54, 48);
            this.btn_altas_gastos.TabIndex = 0;
            this.btn_altas_gastos.UseVisualStyleBackColor = true;
            this.btn_altas_gastos.Click += new System.EventHandler(this.btn_altas_gastos_Click);
            // 
            // btn_modificar_gastos
            // 
            this.btn_modificar_gastos.BackgroundImage = global::G11_TP_PAV.Properties.Resources.modificar01;
            this.btn_modificar_gastos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_modificar_gastos.Location = new System.Drawing.Point(81, 493);
            this.btn_modificar_gastos.Name = "btn_modificar_gastos";
            this.btn_modificar_gastos.Size = new System.Drawing.Size(54, 48);
            this.btn_modificar_gastos.TabIndex = 1;
            this.btn_modificar_gastos.UseVisualStyleBackColor = true;
            this.btn_modificar_gastos.Click += new System.EventHandler(this.btn_modificar_gastos_Click);
            // 
            // Frm_Gastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 554);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_baja);
            this.Controls.Add(this.btn_altas_gastos);
            this.Controls.Add(this.btn_modificar_gastos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Gastos";
            this.Text = "Gastos";
            this.Load += new System.EventHandler(this.Frm_Gastos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_importe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_comprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_gastos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Clases.ComboBoxHeredadaG cmb_edificio;
        private System.Windows.Forms.DataGridView grid_gastos;
        private Clases.TextBoxHeredada txt_proveedor;
        private System.Windows.Forms.CheckBox chk_todos_gastos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_baja;
        private System.Windows.Forms.Button btn_altas_gastos;
        private System.Windows.Forms.Button btn_modificar_gastos;
        private System.Windows.Forms.Button btn_buscar_gastos;
        private Clases.NumericHeredada num_comprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_comprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_edificio;
        private Clases.NumericHeredada num_importe;
        private System.Windows.Forms.Label label4;
    }
}