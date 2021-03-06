namespace G11_TP_PAV.Formularios
{
    partial class FRM_Alta_Propiedades
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_calle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_numero_documento = new System.Windows.Forms.MaskedTextBox();
            this.btn_sacar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grid_duenios = new System.Windows.Forms.DataGridView();
            this.numero_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tipo_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_verificarDesignacion = new System.Windows.Forms.Button();
            this.txt_departamento = new System.Windows.Forms.MaskedTextBox();
            this.txt_piso = new System.Windows.Forms.MaskedTextBox();
            this.txt_numero = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_designacion = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_localidad = new G11_TP_PAV.Clases.ComboBoxHeredada();
            this.cmb_provincia = new G11_TP_PAV.Clases.ComboBoxHeredada();
            this.cmb_tipo_documento = new G11_TP_PAV.Clases.ComboBoxHeredada();
            this.cmb_tipo_propiedad = new G11_TP_PAV.Clases.ComboBoxHeredada();
            this.cmb_barrio = new G11_TP_PAV.Clases.ComboBoxHeredada();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_duenios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta Propiedades";
            // 
            // txt_calle
            // 
            this.txt_calle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_calle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_calle.Location = new System.Drawing.Point(82, 117);
            this.txt_calle.Name = "txt_calle";
            this.txt_calle.ReadOnly = true;
            this.txt_calle.Size = new System.Drawing.Size(188, 26);
            this.txt_calle.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Designacion Catastral";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Calle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Numero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Barrio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(301, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tipo Propiedad";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Enabled = false;
            this.btn_aceptar.Location = new System.Drawing.Point(57, 536);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(181, 50);
            this.btn_aceptar.TabIndex = 15;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(422, 536);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(181, 50);
            this.btn_cancelar.TabIndex = 16;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_numero_documento);
            this.groupBox1.Controls.Add(this.btn_sacar);
            this.groupBox1.Controls.Add(this.btn_agregar);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmb_tipo_documento);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.grid_duenios);
            this.groupBox1.Location = new System.Drawing.Point(32, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 289);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dueños";
            // 
            // txt_numero_documento
            // 
            this.txt_numero_documento.Location = new System.Drawing.Point(25, 37);
            this.txt_numero_documento.Mask = "99999999";
            this.txt_numero_documento.Name = "txt_numero_documento";
            this.txt_numero_documento.ReadOnly = true;
            this.txt_numero_documento.Size = new System.Drawing.Size(169, 20);
            this.txt_numero_documento.TabIndex = 10;
            // 
            // btn_sacar
            // 
            this.btn_sacar.Enabled = false;
            this.btn_sacar.Location = new System.Drawing.Point(470, 63);
            this.btn_sacar.Name = "btn_sacar";
            this.btn_sacar.Size = new System.Drawing.Size(101, 21);
            this.btn_sacar.TabIndex = 5;
            this.btn_sacar.Text = "Sacar";
            this.btn_sacar.UseVisualStyleBackColor = true;
            this.btn_sacar.Click += new System.EventHandler(this.btn_sacar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Enabled = false;
            this.btn_agregar.Location = new System.Drawing.Point(303, 62);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(101, 21);
            this.btn_agregar.TabIndex = 4;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(25, 63);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.ReadOnly = true;
            this.txt_nombre.Size = new System.Drawing.Size(272, 20);
            this.txt_nombre.TabIndex = 3;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Enabled = false;
            this.btn_buscar.Location = new System.Drawing.Point(303, 36);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(101, 21);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(197, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tipo Documento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Numero de Documento";
            // 
            // grid_duenios
            // 
            this.grid_duenios.AllowUserToAddRows = false;
            this.grid_duenios.AllowUserToDeleteRows = false;
            this.grid_duenios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_duenios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero_documento,
            this.id_tipo_documento,
            this.tipo_documento,
            this.nombre,
            this.telefono,
            this.domicilio});
            this.grid_duenios.Location = new System.Drawing.Point(25, 99);
            this.grid_duenios.Name = "grid_duenios";
            this.grid_duenios.ReadOnly = true;
            this.grid_duenios.Size = new System.Drawing.Size(546, 166);
            this.grid_duenios.TabIndex = 6;
            // 
            // numero_documento
            // 
            this.numero_documento.HeaderText = "Documento";
            this.numero_documento.Name = "numero_documento";
            this.numero_documento.ReadOnly = true;
            // 
            // id_tipo_documento
            // 
            this.id_tipo_documento.HeaderText = "id_tipo_documento";
            this.id_tipo_documento.Name = "id_tipo_documento";
            this.id_tipo_documento.ReadOnly = true;
            this.id_tipo_documento.Visible = false;
            // 
            // tipo_documento
            // 
            this.tipo_documento.HeaderText = "Tipo Documento";
            this.tipo_documento.Name = "tipo_documento";
            this.tipo_documento.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // domicilio
            // 
            this.domicilio.HeaderText = "Domicilio";
            this.domicilio.Name = "domicilio";
            this.domicilio.ReadOnly = true;
            // 
            // btn_verificarDesignacion
            // 
            this.btn_verificarDesignacion.Location = new System.Drawing.Point(355, 85);
            this.btn_verificarDesignacion.Name = "btn_verificarDesignacion";
            this.btn_verificarDesignacion.Size = new System.Drawing.Size(101, 26);
            this.btn_verificarDesignacion.TabIndex = 19;
            this.btn_verificarDesignacion.Text = "Buscar";
            this.btn_verificarDesignacion.UseVisualStyleBackColor = true;
            this.btn_verificarDesignacion.Click += new System.EventHandler(this.btn_verificarDesignacion_Click);
            // 
            // txt_departamento
            // 
            this.txt_departamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_departamento.Location = new System.Drawing.Point(601, 117);
            this.txt_departamento.Mask = "999";
            this.txt_departamento.Name = "txt_departamento";
            this.txt_departamento.ReadOnly = true;
            this.txt_departamento.Size = new System.Drawing.Size(31, 26);
            this.txt_departamento.TabIndex = 25;
            this.txt_departamento.ValidatingType = typeof(int);
            // 
            // txt_piso
            // 
            this.txt_piso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_piso.Location = new System.Drawing.Point(496, 117);
            this.txt_piso.Mask = "999";
            this.txt_piso.Name = "txt_piso";
            this.txt_piso.ReadOnly = true;
            this.txt_piso.Size = new System.Drawing.Size(31, 26);
            this.txt_piso.TabIndex = 24;
            this.txt_piso.ValidatingType = typeof(int);
            // 
            // txt_numero
            // 
            this.txt_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero.Location = new System.Drawing.Point(349, 117);
            this.txt_numero.Mask = "99999999999";
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.ReadOnly = true;
            this.txt_numero.Size = new System.Drawing.Size(92, 26);
            this.txt_numero.TabIndex = 23;
            this.txt_numero.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(547, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Dpto.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(451, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Piso";
            // 
            // txt_designacion
            // 
            this.txt_designacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_designacion.Location = new System.Drawing.Point(193, 84);
            this.txt_designacion.Mask = "999999999999";
            this.txt_designacion.Name = "txt_designacion";
            this.txt_designacion.Size = new System.Drawing.Size(150, 26);
            this.txt_designacion.TabIndex = 26;
            this.txt_designacion.ValidatingType = typeof(int);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "Provincia";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(294, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 20);
            this.label12.TabIndex = 30;
            this.label12.Text = "Localidad";
            // 
            // cmb_localidad
            // 
            this.cmb_localidad.Enabled = false;
            this.cmb_localidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_localidad.FormattingEnabled = true;
            this.cmb_localidad.Location = new System.Drawing.Point(371, 149);
            this.cmb_localidad.Name = "cmb_localidad";
            this.cmb_localidad.Pp_combinada01 = null;
            this.cmb_localidad.Pp_combinada02 = null;
            this.cmb_localidad.Pp_descripcion = "nombre";
            this.cmb_localidad.Pp_Pk = "id_localidad";
            this.cmb_localidad.Pp_tabla_origen = "localidades";
            this.cmb_localidad.Size = new System.Drawing.Size(188, 28);
            this.cmb_localidad.TabIndex = 29;
            this.cmb_localidad.SelectedIndexChanged += new System.EventHandler(this.cmb_localidad_SelectedIndexChanged);
            // 
            // cmb_provincia
            // 
            this.cmb_provincia.Enabled = false;
            this.cmb_provincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_provincia.FormattingEnabled = true;
            this.cmb_provincia.Location = new System.Drawing.Point(106, 149);
            this.cmb_provincia.Name = "cmb_provincia";
            this.cmb_provincia.Pp_combinada01 = null;
            this.cmb_provincia.Pp_combinada02 = null;
            this.cmb_provincia.Pp_descripcion = "nombre";
            this.cmb_provincia.Pp_Pk = "id_provincia";
            this.cmb_provincia.Pp_tabla_origen = "provincias";
            this.cmb_provincia.Size = new System.Drawing.Size(167, 28);
            this.cmb_provincia.TabIndex = 27;
            this.cmb_provincia.SelectedIndexChanged += new System.EventHandler(this.cmb_provincia_SelectedIndexChanged);
            // 
            // cmb_tipo_documento
            // 
            this.cmb_tipo_documento.Enabled = false;
            this.cmb_tipo_documento.FormattingEnabled = true;
            this.cmb_tipo_documento.Location = new System.Drawing.Point(200, 37);
            this.cmb_tipo_documento.Name = "cmb_tipo_documento";
            this.cmb_tipo_documento.Pp_combinada01 = null;
            this.cmb_tipo_documento.Pp_combinada02 = null;
            this.cmb_tipo_documento.Pp_descripcion = "nombre_tipo_documento";
            this.cmb_tipo_documento.Pp_Pk = "id_tipo_documento";
            this.cmb_tipo_documento.Pp_tabla_origen = "tipo_documento";
            this.cmb_tipo_documento.Size = new System.Drawing.Size(97, 21);
            this.cmb_tipo_documento.TabIndex = 1;
            // 
            // cmb_tipo_propiedad
            // 
            this.cmb_tipo_propiedad.Enabled = false;
            this.cmb_tipo_propiedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipo_propiedad.FormattingEnabled = true;
            this.cmb_tipo_propiedad.Location = new System.Drawing.Point(422, 183);
            this.cmb_tipo_propiedad.Name = "cmb_tipo_propiedad";
            this.cmb_tipo_propiedad.Pp_combinada01 = null;
            this.cmb_tipo_propiedad.Pp_combinada02 = null;
            this.cmb_tipo_propiedad.Pp_descripcion = "nombre";
            this.cmb_tipo_propiedad.Pp_Pk = "id_tipo_propiedad";
            this.cmb_tipo_propiedad.Pp_tabla_origen = "tipo_propiedad";
            this.cmb_tipo_propiedad.Size = new System.Drawing.Size(137, 28);
            this.cmb_tipo_propiedad.TabIndex = 7;
            // 
            // cmb_barrio
            // 
            this.cmb_barrio.Enabled = false;
            this.cmb_barrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_barrio.FormattingEnabled = true;
            this.cmb_barrio.Location = new System.Drawing.Point(85, 183);
            this.cmb_barrio.Name = "cmb_barrio";
            this.cmb_barrio.Pp_combinada01 = null;
            this.cmb_barrio.Pp_combinada02 = null;
            this.cmb_barrio.Pp_descripcion = "nombre";
            this.cmb_barrio.Pp_Pk = "id_barrio";
            this.cmb_barrio.Pp_tabla_origen = "barrios";
            this.cmb_barrio.Size = new System.Drawing.Size(188, 28);
            this.cmb_barrio.TabIndex = 6;
            // 
            // FRM_Alta_Propiedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 611);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmb_localidad);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmb_provincia);
            this.Controls.Add(this.txt_designacion);
            this.Controls.Add(this.txt_departamento);
            this.Controls.Add(this.txt_piso);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_verificarDesignacion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_tipo_propiedad);
            this.Controls.Add(this.cmb_barrio);
            this.Controls.Add(this.txt_calle);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Alta_Propiedades";
            this.ShowIcon = false;
            this.Text = "Alta Propiedad";
            this.Load += new System.EventHandler(this.FRM_Alta_Propiedades_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_duenios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_calle;
        private Clases.ComboBoxHeredada cmb_barrio;
        private Clases.ComboBoxHeredada cmb_tipo_propiedad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grid_duenios;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tipo_documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilio;
        private System.Windows.Forms.Label label9;
        private Clases.ComboBoxHeredada cmb_tipo_documento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button btn_verificarDesignacion;
        private System.Windows.Forms.Button btn_sacar;
        private System.Windows.Forms.MaskedTextBox txt_departamento;
        private System.Windows.Forms.MaskedTextBox txt_piso;
        private System.Windows.Forms.MaskedTextBox txt_numero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txt_numero_documento;
        private System.Windows.Forms.MaskedTextBox txt_designacion;
        private System.Windows.Forms.Label label11;
        private Clases.ComboBoxHeredada cmb_provincia;
        private System.Windows.Forms.Label label12;
        private Clases.ComboBoxHeredada cmb_localidad;
    }
}