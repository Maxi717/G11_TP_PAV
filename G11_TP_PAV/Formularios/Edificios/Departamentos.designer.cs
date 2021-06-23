namespace G11_TP_PAV.Formularios
{
    partial class Departamentos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Denominacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Superficie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dueño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.chk_edificio = new System.Windows.Forms.CheckBox();
            this.cmb_Edificio = new G11_TP_PAV.Clases.ComboBox1();
            this.cmb_Barrio = new G11_TP_PAV.Clases.ComboBox1();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_departamento,
            this.Piso,
            this.Denominacion,
            this.Superficie,
            this.Porcentaje,
            this.Dueño,
            this.Domicilio,
            this.Barrio});
            this.dataGridView1.Location = new System.Drawing.Point(13, 157);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(689, 185);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id_departamento
            // 
            this.id_departamento.HeaderText = "id_departamento";
            this.id_departamento.Name = "id_departamento";
            this.id_departamento.Visible = false;
            // 
            // Piso
            // 
            this.Piso.HeaderText = "Piso";
            this.Piso.Name = "Piso";
            this.Piso.Width = 40;
            // 
            // Denominacion
            // 
            this.Denominacion.HeaderText = "Denominacion";
            this.Denominacion.Name = "Denominacion";
            // 
            // Superficie
            // 
            this.Superficie.HeaderText = "Superficie";
            this.Superficie.Name = "Superficie";
            this.Superficie.Width = 80;
            // 
            // Porcentaje
            // 
            this.Porcentaje.HeaderText = "Porcentaje";
            this.Porcentaje.Name = "Porcentaje";
            this.Porcentaje.Width = 80;
            // 
            // Dueño
            // 
            this.Dueño.HeaderText = "Dueño";
            this.Dueño.Name = "Dueño";
            this.Dueño.Width = 120;
            // 
            // Domicilio
            // 
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.Name = "Domicilio";
            // 
            // Barrio
            // 
            this.Barrio.HeaderText = "Barrio";
            this.Barrio.Name = "Barrio";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 365);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "ALTA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(268, 365);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "MODIFICAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(513, 365);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 28);
            this.button3.TabIndex = 5;
            this.button3.Text = "BAJA";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Barrio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Edificio";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(374, 41);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(328, 93);
            this.button4.TabIndex = 8;
            this.button4.Text = "Mostrar Resultados";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Formulario ABM Departamentos";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(17, 110);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(204, 24);
            this.button5.TabIndex = 12;
            this.button5.Text = "Restablecer";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // chk_edificio
            // 
            this.chk_edificio.AutoSize = true;
            this.chk_edificio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_edificio.Location = new System.Drawing.Point(227, 113);
            this.chk_edificio.Name = "chk_edificio";
            this.chk_edificio.Size = new System.Drawing.Size(140, 21);
            this.chk_edificio.TabIndex = 13;
            this.chk_edificio.Text = "Seleccionar todos";
            this.chk_edificio.UseVisualStyleBackColor = true;
            this.chk_edificio.CheckedChanged += new System.EventHandler(this.chk_edificio_CheckedChanged);
            // 
            // cmb_Edificio
            // 
            this.cmb_Edificio.FormattingEnabled = true;
            this.cmb_Edificio.Location = new System.Drawing.Point(86, 71);
            this.cmb_Edificio.Name = "cmb_Edificio";
            this.cmb_Edificio.Pp_Conseleccion = false;
            this.cmb_Edificio.Pp_descripcion = "DOMICILIO";
            this.cmb_Edificio.Pp_descripcion2 = null;
            this.cmb_Edificio.Pp_Pk = "ID";
            this.cmb_Edificio.Pp_tabla = "edificios";
            this.cmb_Edificio.Size = new System.Drawing.Size(281, 24);
            this.cmb_Edificio.TabIndex = 11;
            // 
            // cmb_Barrio
            // 
            this.cmb_Barrio.FormattingEnabled = true;
            this.cmb_Barrio.Location = new System.Drawing.Point(86, 41);
            this.cmb_Barrio.Name = "cmb_Barrio";
            this.cmb_Barrio.Pp_Conseleccion = false;
            this.cmb_Barrio.Pp_descripcion = "nombre";
            this.cmb_Barrio.Pp_descripcion2 = null;
            this.cmb_Barrio.Pp_Pk = "id_barrio";
            this.cmb_Barrio.Pp_tabla = "barrios";
            this.cmb_Barrio.Size = new System.Drawing.Size(281, 24);
            this.cmb_Barrio.TabIndex = 10;
            // 
            // Departamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 488);
            this.Controls.Add(this.chk_edificio);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.cmb_Edificio);
            this.Controls.Add(this.cmb_Barrio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Departamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ABM Edificios";
            this.Load += new System.EventHandler(this.Departamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private G11_TP_PAV.Clases.ComboBox1 cmb_Barrio;
        private G11_TP_PAV.Clases.ComboBox1 cmb_Edificio;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox chk_edificio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Piso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Denominacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Superficie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dueño;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barrio;
    }
}