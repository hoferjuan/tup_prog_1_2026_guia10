namespace Ejercicio3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbInvitaciones = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btnImprimirNombre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbInvitaciones
            // 
            this.lbInvitaciones.FormattingEnabled = true;
            this.lbInvitaciones.ItemHeight = 16;
            this.lbInvitaciones.Location = new System.Drawing.Point(63, 135);
            this.lbInvitaciones.Name = "lbInvitaciones";
            this.lbInvitaciones.Size = new System.Drawing.Size(369, 228);
            this.lbInvitaciones.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del Invitado";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(125, 85);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(153, 22);
            this.tbNombre.TabIndex = 2;
            // 
            // btnImprimirNombre
            // 
            this.btnImprimirNombre.Location = new System.Drawing.Point(316, 54);
            this.btnImprimirNombre.Name = "btnImprimirNombre";
            this.btnImprimirNombre.Size = new System.Drawing.Size(75, 53);
            this.btnImprimirNombre.TabIndex = 3;
            this.btnImprimirNombre.Text = "Imprimir Nombre";
            this.btnImprimirNombre.UseVisualStyleBackColor = true;
            this.btnImprimirNombre.Click += new System.EventHandler(this.btnImprimirNombre_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnImprimirNombre;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 390);
            this.Controls.Add(this.btnImprimirNombre);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbInvitaciones);
            this.Name = "Form1";
            this.Text = "Invitaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbInvitaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btnImprimirNombre;
    }
}

