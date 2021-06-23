namespace G11_TP_PAV.Formularios.EstadisticasGonza
{
    partial class EstadisticasProvincias
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.num_min = new G11_TP_PAV.Clases.NumericHeredada();
            this.num_max = new G11_TP_PAV.Clases.NumericHeredada();
            ((System.ComponentModel.ISupportInitialize)(this.num_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_max)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "por provincia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Estadísticas de departamentos ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(808, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(696, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Máximo de deptos por edificio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mínimo de deptos por edificio";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 111);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(881, 387);
            this.reportViewer1.TabIndex = 16;
            // 
            // num_min
            // 
            this.num_min.Location = new System.Drawing.Point(480, 24);
            this.num_min.Name = "num_min";
            this.num_min.Pp_campo = null;
            this.num_min.Pp_MensajeError = null;
            this.num_min.Pp_tabla = null;
            this.num_min.Pp_Validable = false;
            this.num_min.Size = new System.Drawing.Size(120, 20);
            this.num_min.TabIndex = 7;
            // 
            // num_max
            // 
            this.num_max.Location = new System.Drawing.Point(480, 68);
            this.num_max.Name = "num_max";
            this.num_max.Pp_campo = null;
            this.num_max.Pp_MensajeError = null;
            this.num_max.Pp_tabla = null;
            this.num_max.Pp_Validable = false;
            this.num_max.Size = new System.Drawing.Size(120, 20);
            this.num_max.TabIndex = 9;
            // 
            // EstadisticasProvincias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 510);
            this.ControlBox = false;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num_min);
            this.Controls.Add(this.num_max);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EstadisticasProvincias";
            this.Load += new System.EventHandler(this.EstadisticasProvincias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_max)).EndInit();
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
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}