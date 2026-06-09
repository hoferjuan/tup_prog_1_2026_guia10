namespace Ejercicio6
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.chbOpcion1 = new System.Windows.Forms.CheckBox();
            this.chbOpcion2 = new System.Windows.Forms.CheckBox();
            this.chbOpcion3 = new System.Windows.Forms.CheckBox();
            this.btnResponder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Una variable local";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resultado:";
            // 
            // lbResultado
            // 
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(149, 309);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(450, 115);
            this.lbResultado.TabIndex = 2;
            this.lbResultado.Text = "label3";
            // 
            // chbOpcion1
            // 
            this.chbOpcion1.AutoSize = true;
            this.chbOpcion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbOpcion1.Location = new System.Drawing.Point(46, 94);
            this.chbOpcion1.Name = "chbOpcion1";
            this.chbOpcion1.Size = new System.Drawing.Size(252, 24);
            this.chbOpcion1.TabIndex = 3;
            this.chbOpcion1.Text = "No siempre debe inicializarse";
            this.chbOpcion1.UseVisualStyleBackColor = true;
            // 
            // chbOpcion2
            // 
            this.chbOpcion2.AutoSize = true;
            this.chbOpcion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbOpcion2.Location = new System.Drawing.Point(46, 148);
            this.chbOpcion2.Name = "chbOpcion2";
            this.chbOpcion2.Size = new System.Drawing.Size(214, 24);
            this.chbOpcion2.TabIndex = 4;
            this.chbOpcion2.Text = "Nunca debe inicializarse";
            this.chbOpcion2.UseVisualStyleBackColor = true;
            // 
            // chbOpcion3
            // 
            this.chbOpcion3.AutoSize = true;
            this.chbOpcion3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbOpcion3.Location = new System.Drawing.Point(46, 198);
            this.chbOpcion3.Name = "chbOpcion3";
            this.chbOpcion3.Size = new System.Drawing.Size(228, 24);
            this.chbOpcion3.TabIndex = 5;
            this.chbOpcion3.Text = "Siempre debe inicializarse";
            this.chbOpcion3.UseVisualStyleBackColor = true;
            // 
            // btnResponder
            // 
            this.btnResponder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResponder.Location = new System.Drawing.Point(301, 143);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(109, 32);
            this.btnResponder.TabIndex = 6;
            this.btnResponder.Text = "Responder";
            this.btnResponder.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.btnResponder);
            this.Controls.Add(this.chbOpcion3);
            this.Controls.Add(this.chbOpcion2);
            this.Controls.Add(this.chbOpcion1);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Examen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.CheckBox chbOpcion1;
        private System.Windows.Forms.CheckBox chbOpcion2;
        private System.Windows.Forms.CheckBox chbOpcion3;
        private System.Windows.Forms.Button btnResponder;
    }
}

