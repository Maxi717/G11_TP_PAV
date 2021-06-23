﻿
namespace G11_TP_PAV.Formularios.Escribanos
{
    partial class Frm_Info_Escribano
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
            this.txt_Matricula = new G11_TP_PAV.Clases.TextBoxHeredado();
            this.cmb_TipoDoc = new G11_TP_PAV.Clases.ComboBoxHeredadaE();
            this.txt_NroDoc = new G11_TP_PAV.Clases.TextBoxHeredado();
            this.txt_Apellido = new G11_TP_PAV.Clases.TextBoxHeredado();
            this.txt_Nombre = new G11_TP_PAV.Clases.TextBoxHeredado();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Matricula
            // 
            this.txt_Matricula.Enabled = false;
            this.txt_Matricula.Location = new System.Drawing.Point(165, 35);
            this.txt_Matricula.Name = "txt_Matricula";
            this.txt_Matricula.Pp_MensajeError = "\"Matricula\" se encuentra vacio";
            this.txt_Matricula.Pp_NombreCampo = "Matricula";
            this.txt_Matricula.Pp_NombreTabla = null;
            this.txt_Matricula.Pp_Validable = false;
            this.txt_Matricula.Size = new System.Drawing.Size(121, 23);
            this.txt_Matricula.TabIndex = 0;
            // 
            // cmb_TipoDoc
            // 
            this.cmb_TipoDoc.Enabled = false;
            this.cmb_TipoDoc.FormattingEnabled = true;
            this.cmb_TipoDoc.Location = new System.Drawing.Point(165, 122);
            this.cmb_TipoDoc.Name = "cmb_TipoDoc";
            this.cmb_TipoDoc.Pp_Conseleccion = false;
            this.cmb_TipoDoc.Pp_descripcion = "Nombre_tipo_documento";
            this.cmb_TipoDoc.Pp_MensajeError = "\"Tipo de documento\" se encuentra vacio";
            this.cmb_TipoDoc.Pp_NombreCampo = "IdDocumento";
            this.cmb_TipoDoc.Pp_NombreTabla = null;
            this.cmb_TipoDoc.Pp_Pk = "Id_tipo_documento";
            this.cmb_TipoDoc.Pp_tabla_origen = "tipo_documento";
            this.cmb_TipoDoc.Pp_Validable = false;
            this.cmb_TipoDoc.Size = new System.Drawing.Size(121, 24);
            this.cmb_TipoDoc.TabIndex = 3;
            // 
            // txt_NroDoc
            // 
            this.txt_NroDoc.Enabled = false;
            this.txt_NroDoc.Location = new System.Drawing.Point(165, 152);
            this.txt_NroDoc.Name = "txt_NroDoc";
            this.txt_NroDoc.Pp_MensajeError = "\"Numero de documento\" se encuentra vacio";
            this.txt_NroDoc.Pp_NombreCampo = "Documento";
            this.txt_NroDoc.Pp_NombreTabla = null;
            this.txt_NroDoc.Pp_Validable = false;
            this.txt_NroDoc.Size = new System.Drawing.Size(121, 23);
            this.txt_NroDoc.TabIndex = 4;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Enabled = false;
            this.txt_Apellido.Location = new System.Drawing.Point(165, 93);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Pp_MensajeError = "\"Apellido\" se encuentra vacio";
            this.txt_Apellido.Pp_NombreCampo = "Apellido";
            this.txt_Apellido.Pp_NombreTabla = null;
            this.txt_Apellido.Pp_Validable = false;
            this.txt_Apellido.Size = new System.Drawing.Size(121, 23);
            this.txt_Apellido.TabIndex = 2;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Enabled = false;
            this.txt_Nombre.Location = new System.Drawing.Point(165, 64);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Pp_MensajeError = "\"Nombre\" se encuentra vacio";
            this.txt_Nombre.Pp_NombreCampo = "Nombre";
            this.txt_Nombre.Pp_NombreTabla = null;
            this.txt_Nombre.Pp_Validable = false;
            this.txt_Nombre.Size = new System.Drawing.Size(121, 23);
            this.txt_Nombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Matricula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo de documento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Numero de documento";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_Matricula);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_NroDoc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_TipoDoc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Apellido);
            this.groupBox1.Controls.Add(this.txt_Nombre);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Escribano";
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(102, 210);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 1;
            this.btn_Ok.Text = "Cerrar";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // Frm_Info_Escribano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 243);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Info_Escribano";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informacion del Escribano";
            this.Load += new System.EventHandler(this.Frm_Info_Escribano_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Clases.TextBoxHeredado txt_Matricula;
        private Clases.ComboBoxHeredadaE cmb_TipoDoc;
        private Clases.TextBoxHeredado txt_NroDoc;
        private Clases.TextBoxHeredado txt_Apellido;
        private Clases.TextBoxHeredado txt_Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Ok;
    }
}