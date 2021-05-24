namespace G11_TP_PAV.Formularios
{
    partial class Frm_Altas_Clientes
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(114, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Altas Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre completo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Número de dni";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tipo de documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Número de teléfono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Dirección";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(198, 306);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 5;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(307, 306);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // cmb_tipo_dni
            // 
            this.cmb_tipo_dni.FormattingEnabled = true;
            this.cmb_tipo_dni.Location = new System.Drawing.Point(198, 165);
            this.cmb_tipo_dni.Name = "cmb_tipo_dni";
            this.cmb_tipo_dni.Pp_campo = "id_tipo_documento";
            this.cmb_tipo_dni.Pp_Conseleccion = true;
            this.cmb_tipo_dni.Pp_descripcion = "Nombre_tipo_documento";
            this.cmb_tipo_dni.Pp_MensajeError = null;
            this.cmb_tipo_dni.Pp_NombreTabla = null;
            this.cmb_tipo_dni.Pp_Pk = "Id_tipo_documento";
            this.cmb_tipo_dni.Pp_Tabla = "tipo_documento";
            this.cmb_tipo_dni.Pp_Validable = false;
            this.cmb_tipo_dni.Size = new System.Drawing.Size(132, 23);
            this.cmb_tipo_dni.TabIndex = 2;
            // 
            // txt_dir
            // 
            this.txt_dir.Location = new System.Drawing.Point(198, 248);
            this.txt_dir.Name = "txt_dir";
            this.txt_dir.Pp_campo = "direccion";
            this.txt_dir.Pp_MensajeError = "Falta dirección";
            this.txt_dir.Pp_tabla = null;
            this.txt_dir.Pp_Validable = false;
            this.txt_dir.Size = new System.Drawing.Size(227, 21);
            this.txt_dir.TabIndex = 4;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(198, 87);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Pp_campo = "nombre";
            this.txt_nombre.Pp_MensajeError = "Falta nombre";
            this.txt_nombre.Pp_tabla = null;
            this.txt_nombre.Pp_Validable = false;
            this.txt_nombre.Size = new System.Drawing.Size(227, 21);
            this.txt_nombre.TabIndex = 0;
            // 
            // num_tel
            // 
            this.num_tel.Location = new System.Drawing.Point(198, 206);
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
            this.num_tel.Size = new System.Drawing.Size(132, 21);
            this.num_tel.TabIndex = 3;
            // 
            // num_dni
            // 
            this.num_dni.Location = new System.Drawing.Point(198, 125);
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
            this.num_dni.Size = new System.Drawing.Size(132, 21);
            this.num_dni.TabIndex = 1;
            // 
            // Frm_Altas_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 358);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Altas_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Altas_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_tel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_dni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Clases.NumericHeredada num_dni;
        private Clases.TextBoxHeredada txt_nombre;
        private Clases.ComboBoxHeredadaG cmb_tipo_dni;
        private Clases.NumericHeredada num_tel;
        private Clases.TextBoxHeredada txt_dir;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}