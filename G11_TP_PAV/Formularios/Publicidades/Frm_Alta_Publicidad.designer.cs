namespace G11_TP_PAV.Formularios
{
    partial class Frm_Alta_Publicidad
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Alta_Public = new System.Windows.Forms.Button();
            this.txt_costo = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.date_public = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_borrar_todo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_secciones = new G11_TP_PAV.Clases.ComboBoxHeredada();
            this.cmb_propiedades = new G11_TP_PAV.Clases.ComboBoxHeredada();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Costo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fecha";
            // 
            // btn_Alta_Public
            // 
            this.btn_Alta_Public.Location = new System.Drawing.Point(203, 223);
            this.btn_Alta_Public.Name = "btn_Alta_Public";
            this.btn_Alta_Public.Size = new System.Drawing.Size(180, 67);
            this.btn_Alta_Public.TabIndex = 13;
            this.btn_Alta_Public.Text = "Agregar Publicidad";
            this.btn_Alta_Public.UseVisualStyleBackColor = true;
            this.btn_Alta_Public.Click += new System.EventHandler(this.btn_Alta_Public_Click);
            // 
            // txt_costo
            // 
            this.txt_costo.Location = new System.Drawing.Point(203, 42);
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.Size = new System.Drawing.Size(180, 20);
            this.txt_costo.TabIndex = 12;
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(203, 82);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(180, 20);
            this.txt_precio.TabIndex = 12;
            // 
            // date_public
            // 
            this.date_public.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_public.Location = new System.Drawing.Point(203, 11);
            this.date_public.Name = "date_public";
            this.date_public.Size = new System.Drawing.Size(180, 20);
            this.date_public.TabIndex = 20;
            this.date_public.Value = new System.DateTime(2021, 5, 12, 0, 0, 0, 0);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::G11_TP_PAV.Properties.Resources.blue_cross_icon_71;
            this.pictureBox2.Location = new System.Drawing.Point(100, 173);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // btn_borrar_todo
            // 
            this.btn_borrar_todo.BackgroundImage = global::G11_TP_PAV.Properties.Resources.Erase2;
            this.btn_borrar_todo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_borrar_todo.Location = new System.Drawing.Point(359, 191);
            this.btn_borrar_todo.Name = "btn_borrar_todo";
            this.btn_borrar_todo.Size = new System.Drawing.Size(30, 26);
            this.btn_borrar_todo.TabIndex = 18;
            this.btn_borrar_todo.UseVisualStyleBackColor = true;
            this.btn_borrar_todo.Click += new System.EventHandler(this.btn_borrar_todo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::G11_TP_PAV.Properties.Resources._11vo;
            this.pictureBox1.Location = new System.Drawing.Point(19, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(203, 122);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(180, 20);
            this.txt_descripcion.TabIndex = 12;
            this.txt_descripcion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Descripción";
            // 
            // cmb_secciones
            // 
            this.cmb_secciones.FormattingEnabled = true;
            this.cmb_secciones.Location = new System.Drawing.Point(203, 158);
            this.cmb_secciones.Name = "cmb_secciones";
            this.cmb_secciones.Pp_combinada01 = null;
            this.cmb_secciones.Pp_combinada02 = null;
            this.cmb_secciones.Pp_descripcion = "nombre";
            this.cmb_secciones.Pp_Pk = "id_seccion";
            this.cmb_secciones.Pp_tabla_origen = "secciones";
            this.cmb_secciones.Size = new System.Drawing.Size(180, 21);
            this.cmb_secciones.TabIndex = 22;
            // 
            // cmb_propiedades
            // 
            this.cmb_propiedades.FormattingEnabled = true;
            this.cmb_propiedades.Location = new System.Drawing.Point(203, 195);
            this.cmb_propiedades.Name = "cmb_propiedades";
            this.cmb_propiedades.Pp_combinada01 = null;
            this.cmb_propiedades.Pp_combinada02 = null;
            this.cmb_propiedades.Pp_descripcion = "designacion_catastral";
            this.cmb_propiedades.Pp_Pk = "designacion_catastral";
            this.cmb_propiedades.Pp_tabla_origen = "propiedades";
            this.cmb_propiedades.Size = new System.Drawing.Size(150, 21);
            this.cmb_propiedades.TabIndex = 22;
            // 
            // Frm_Alta_Publicidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 302);
            this.Controls.Add(this.cmb_propiedades);
            this.Controls.Add(this.cmb_secciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.date_public);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_borrar_todo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Alta_Public);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_costo);
            this.Name = "Frm_Alta_Publicidad";
            this.Text = "Agregar Publicidad";
            this.Load += new System.EventHandler(this.Frm_Alta_Publicidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_borrar_todo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Alta_Public;
        private System.Windows.Forms.TextBox txt_costo;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.DateTimePicker date_public;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label4;
        private Clases.ComboBoxHeredada cmb_secciones;
        private Clases.ComboBoxHeredada cmb_propiedades;
    }
}