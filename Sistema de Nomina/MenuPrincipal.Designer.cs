namespace Sistema_de_Nomina
{
    partial class MenuPrincipal
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
            this.btnConsultaAsientosC = new System.Windows.Forms.Button();
            this.btnConsultaTransacciones = new System.Windows.Forms.Button();
            this.btnGestionarTiposDeIngr = new System.Windows.Forms.Button();
            this.btnGestionarEmpleados = new System.Windows.Forms.Button();
            this.btnGesionarDeducciones = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConsultaAsientosC
            // 
            this.btnConsultaAsientosC.Location = new System.Drawing.Point(38, 113);
            this.btnConsultaAsientosC.Name = "btnConsultaAsientosC";
            this.btnConsultaAsientosC.Size = new System.Drawing.Size(96, 85);
            this.btnConsultaAsientosC.TabIndex = 0;
            this.btnConsultaAsientosC.Text = "Consultar asientos contables";
            this.btnConsultaAsientosC.UseVisualStyleBackColor = true;
            this.btnConsultaAsientosC.Click += new System.EventHandler(this.btnConsultaAsientosC_Click);
            // 
            // btnConsultaTransacciones
            // 
            this.btnConsultaTransacciones.Location = new System.Drawing.Point(157, 113);
            this.btnConsultaTransacciones.Name = "btnConsultaTransacciones";
            this.btnConsultaTransacciones.Size = new System.Drawing.Size(94, 85);
            this.btnConsultaTransacciones.TabIndex = 1;
            this.btnConsultaTransacciones.Text = "Consultar Transacciones";
            this.btnConsultaTransacciones.UseVisualStyleBackColor = true;
            this.btnConsultaTransacciones.Click += new System.EventHandler(this.btnConsultaTransacciones_Click);
            // 
            // btnGestionarTiposDeIngr
            // 
            this.btnGestionarTiposDeIngr.Location = new System.Drawing.Point(520, 114);
            this.btnGestionarTiposDeIngr.Name = "btnGestionarTiposDeIngr";
            this.btnGestionarTiposDeIngr.Size = new System.Drawing.Size(96, 86);
            this.btnGestionarTiposDeIngr.TabIndex = 2;
            this.btnGestionarTiposDeIngr.Text = "Gestionar tipos de ingresos";
            this.btnGestionarTiposDeIngr.UseVisualStyleBackColor = true;
            this.btnGestionarTiposDeIngr.Click += new System.EventHandler(this.btnGestionarTiposDeIngr_Click);
            // 
            // btnGestionarEmpleados
            // 
            this.btnGestionarEmpleados.Location = new System.Drawing.Point(278, 113);
            this.btnGestionarEmpleados.Name = "btnGestionarEmpleados";
            this.btnGestionarEmpleados.Size = new System.Drawing.Size(100, 85);
            this.btnGestionarEmpleados.TabIndex = 3;
            this.btnGestionarEmpleados.Text = "Gestionar Empleados";
            this.btnGestionarEmpleados.UseVisualStyleBackColor = true;
            this.btnGestionarEmpleados.Click += new System.EventHandler(this.btnGestionarEmpleados_Click);
            // 
            // btnGesionarDeducciones
            // 
            this.btnGesionarDeducciones.Location = new System.Drawing.Point(406, 114);
            this.btnGesionarDeducciones.Name = "btnGesionarDeducciones";
            this.btnGesionarDeducciones.Size = new System.Drawing.Size(88, 85);
            this.btnGesionarDeducciones.TabIndex = 4;
            this.btnGesionarDeducciones.Text = "Gestionar tipos de deducciones";
            this.btnGesionarDeducciones.UseVisualStyleBackColor = true;
            this.btnGesionarDeducciones.Click += new System.EventHandler(this.btnGesionarDeducciones_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sistema de nominas";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 229);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGesionarDeducciones);
            this.Controls.Add(this.btnGestionarEmpleados);
            this.Controls.Add(this.btnGestionarTiposDeIngr);
            this.Controls.Add(this.btnConsultaTransacciones);
            this.Controls.Add(this.btnConsultaAsientosC);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultaAsientosC;
        private System.Windows.Forms.Button btnConsultaTransacciones;
        private System.Windows.Forms.Button btnGestionarTiposDeIngr;
        private System.Windows.Forms.Button btnGestionarEmpleados;
        private System.Windows.Forms.Button btnGesionarDeducciones;
        private System.Windows.Forms.Label label1;
    }
}