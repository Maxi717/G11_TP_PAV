namespace G11_TP_PAV.Formularios.DepartamentosRepor
{
    partial class Frm_ListadoDepartamentos
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rv_deptos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.num_max = new G11_TP_PAV.Clases.NumericHeredada();
            this.num_min = new G11_TP_PAV.Clases.NumericHeredada();
            ((System.ComponentModel.ISupportInitialize)(this.num_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_min)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Búsqueda por superficie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Reporte de propiedades";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(805, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(693, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Máximo supeficie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mínimo superficie";
            // 
            // rv_deptos
            // 
            this.rv_deptos.Location = new System.Drawing.Point(12, 103);
            this.rv_deptos.Name = "rv_deptos";
            this.rv_deptos.ServerReport.BearerToken = null;
            this.rv_deptos.Size = new System.Drawing.Size(875, 382);
            this.rv_deptos.TabIndex = 16;
            // 
            // num_max
            // 
            this.num_max.Location = new System.Drawing.Point(455, 58);
            this.num_max.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.num_max.Name = "num_max";
            this.num_max.Pp_campo = null;
            this.num_max.Pp_MensajeError = null;
            this.num_max.Pp_tabla = null;
            this.num_max.Pp_Validable = false;
            this.num_max.Size = new System.Drawing.Size(120, 20);
            this.num_max.TabIndex = 15;
            // 
            // num_min
            // 
            this.num_min.Location = new System.Drawing.Point(455, 19);
            this.num_min.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.num_min.Name = "num_min";
            this.num_min.Pp_campo = null;
            this.num_min.Pp_MensajeError = null;
            this.num_min.Pp_tabla = null;
            this.num_min.Pp_Validable = false;
            this.num_min.Size = new System.Drawing.Size(120, 20);
            this.num_min.TabIndex = 14;
            // 
            // Frm_ListadoDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 497);
            this.ControlBox = false;
            this.Controls.Add(this.rv_deptos);
            this.Controls.Add(this.num_max);
            this.Controls.Add(this.num_min);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ListadoDepartamentos";
            this.Load += new System.EventHandler(this.Frm_ListadoDepartamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_min)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Clases.NumericHeredada num_min;
        private Clases.NumericHeredada num_max;
        private Microsoft.Reporting.WinForms.ReportViewer rv_deptos;
    }
}