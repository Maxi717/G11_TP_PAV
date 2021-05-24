namespace G11_TP_PAV.Formularios
{
    partial class Frm_Modificar_Clientes
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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_tipo_dni = new G11_TP_PAV.Clases.ComboBoxHeredadaG();
            this.txt_dir = new G11_TP_PAV.Clases.TextBoxHeredada();
            this.txt_nombre = new G11_TP_PAV.Clases.TextBoxHeredada();
            this.num_tel = new G11_TP_PAV.Clases.NumericHeredada();
            this.num_dni = new G11_TP_PAV.Clases.NumericHeredada();
            ((System.ComponentModel.ISupportInitialize)(this.num_tel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_dni)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Modificar Clientes";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(306, 277);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(197, 277);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 5;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Número de teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tipo de documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Número de dni";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre completo";
            // 
            // cmb_tipo_dni
            // 
            this.cmb_tipo_dni.FormattingEnabled = true;
            this.cmb_tipo_dni.Location = new System.Drawing.Point(197, 136);
            this.cmb_tipo_dni.Name = "cmb_tipo_dni";
            this.cmb_tipo_dni.Pp_campo = "id_tipo_documento";
            this.cmb_tipo_dni.Pp_Conseleccion = true;
            this.cmb_tipo_dni.Pp_descripcion = "Nombre_tipo_documento";
            this.cmb_tipo_dni.Pp_MensajeError = null;
            this.cmb_tipo_dni.Pp_NombreTabla = null;
            this.cmb_tipo_dni.Pp_Pk = "Id_tipo_documento";
            this.cmb_tipo_dni.Pp_Tabla = "tipo_documento";
            this.cmb_tipo_dni.Pp_Validable = false;
            this.cmb_tipo_dni.Size = new System.Drawing.Size(132, 21);
            this.cmb_tipo_dni.TabIndex = 2;
            // 
            // txt_dir
            // 
            this.txt_dir.Location = new System.Drawing.Point(197, 219);
            this.txt_dir.Name = "txt_dir";
            this.txt_dir.Pp_campo = "direccion";
            this.txt_dir.Pp_MensajeError = "Falta dirección";
            this.txt_dir.Pp_tabla = null;
            this.txt_dir.Pp_Validable = false;
            this.txt_dir.Size = new System.Drawing.Size(227, 20);
            this.txt_dir.TabIndex = 4;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(197, 58);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Pp_campo = "nombre";
            this.txt_nombre.Pp_MensajeError = "Falta nombre";
            this.txt_nombre.Pp_tabla = null;
            this.txt_nombre.Pp_Validable = false;
            this.txt_nombre.Size = new System.Drawing.Size(227, 20);
            this.txt_nombre.TabIndex = 0;
            // 
            // num_tel
            // 
            this.num_tel.Location = new System.Drawing.Point(197, 177);
            this.num_tel.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.num_tel.Name = "num_tel";
            this.num_tel.Pp_campo = "telefono";
            this.num_tel.Pp_MensajeError = "Falta número de teléfono";
            this.num_tel.Pp_tabla = null;
            this.num_tel.Pp_Validable = false;
            this.num_tel.Size = new System.Drawing.Size(132, 20);
            this.num_tel.TabIndex = 3;
            // 
            // num_dni
            // 
            this.num_dni.Location = new System.Drawing.Point(197, 96);
            this.num_dni.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.num_dni.Name = "num_dni";
            this.num_dni.Pp_campo = "numero_documento";
            this.num_dni.Pp_MensajeError = "Falta dni";
            this.num_dni.Pp_tabla = null;
            this.num_dni.Pp_Validable = false;
            this.num_dni.Size = new System.Drawing.Size(132, 20);
            this.num_dni.TabIndex = 1;
            // 
            // Frm_Modificar_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 349);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.cmb_tipo_dni);
            this.Controls.Add(this.txt_dir);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.num_tel);
            this.Controls.Add(this.num_dni);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Modificar_Clientes";
            this.Load += new System.EventHandler(this.Frm_Modificar_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_tel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_dni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
        private G11_TP_PAV.Clases.ComboBoxHeredadaG cmb_tipo_dni;
        private G11_TP_PAV.Clases.TextBoxHeredada txt_dir;
        private G11_TP_PAV.Clases.TextBoxHeredada txt_nombre;
        private G11_TP_PAV.Clases.NumericHeredada num_tel;
        private G11_TP_PAV.Clases.NumericHeredada num_dni;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}