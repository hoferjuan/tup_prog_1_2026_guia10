namespace Ejercicio5
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
            this.rbExcelente = new System.Windows.Forms.RadioButton();
            this.rbBueno = new System.Windows.Forms.RadioButton();
            this.rbInsuficiente = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbExcelentes = new System.Windows.Forms.Label();
            this.lbBuenos = new System.Windows.Forms.Label();
            this.lbInsuficientes = new System.Windows.Forms.Label();
            this.btnVotar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbExcelente
            // 
            this.rbExcelente.AutoSize = true;
            this.rbExcelente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbExcelente.Location = new System.Drawing.Point(45, 46);
            this.rbExcelente.Name = "rbExcelente";
            this.rbExcelente.Size = new System.Drawing.Size(103, 24);
            this.rbExcelente.TabIndex = 0;
            this.rbExcelente.TabStop = true;
            this.rbExcelente.Text = "Excelente";
            this.rbExcelente.UseVisualStyleBackColor = true;
            // 
            // rbBueno
            // 
            this.rbBueno.AutoSize = true;
            this.rbBueno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBueno.Location = new System.Drawing.Point(45, 92);
            this.rbBueno.Name = "rbBueno";
            this.rbBueno.Size = new System.Drawing.Size(78, 24);
            this.rbBueno.TabIndex = 1;
            this.rbBueno.TabStop = true;
            this.rbBueno.Text = "Bueno";
            this.rbBueno.UseVisualStyleBackColor = true;
            // 
            // rbInsuficiente
            // 
            this.rbInsuficiente.AutoSize = true;
            this.rbInsuficiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInsuficiente.Location = new System.Drawing.Point(45, 139);
            this.rbInsuficiente.Name = "rbInsuficiente";
            this.rbInsuficiente.Size = new System.Drawing.Size(115, 24);
            this.rbInsuficiente.TabIndex = 2;
            this.rbInsuficiente.TabStop = true;
            this.rbInsuficiente.Text = "Insuficiente";
            this.rbInsuficiente.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad de votaciones:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Excelentes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Buenos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Insuficientes:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(253, 191);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(53, 20);
            this.lbTotal.TabIndex = 7;
            this.lbTotal.Text = "label5";
            // 
            // lbExcelentes
            // 
            this.lbExcelentes.AutoSize = true;
            this.lbExcelentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExcelentes.Location = new System.Drawing.Point(162, 248);
            this.lbExcelentes.Name = "lbExcelentes";
            this.lbExcelentes.Size = new System.Drawing.Size(53, 20);
            this.lbExcelentes.TabIndex = 8;
            this.lbExcelentes.Text = "label6";
            // 
            // lbBuenos
            // 
            this.lbBuenos.AutoSize = true;
            this.lbBuenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuenos.Location = new System.Drawing.Point(162, 309);
            this.lbBuenos.Name = "lbBuenos";
            this.lbBuenos.Size = new System.Drawing.Size(53, 20);
            this.lbBuenos.TabIndex = 9;
            this.lbBuenos.Text = "label7";
            // 
            // lbInsuficientes
            // 
            this.lbInsuficientes.AutoSize = true;
            this.lbInsuficientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInsuficientes.Location = new System.Drawing.Point(162, 366);
            this.lbInsuficientes.Name = "lbInsuficientes";
            this.lbInsuficientes.Size = new System.Drawing.Size(53, 20);
            this.lbInsuficientes.TabIndex = 10;
            this.lbInsuficientes.Text = "label8";
            // 
            // btnVotar
            // 
            this.btnVotar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVotar.Location = new System.Drawing.Point(198, 91);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(108, 36);
            this.btnVotar.TabIndex = 11;
            this.btnVotar.Text = "Votar";
            this.btnVotar.UseVisualStyleBackColor = true;
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 450);
            this.Controls.Add(this.btnVotar);
            this.Controls.Add(this.lbInsuficientes);
            this.Controls.Add(this.lbBuenos);
            this.Controls.Add(this.lbExcelentes);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbInsuficiente);
            this.Controls.Add(this.rbBueno);
            this.Controls.Add(this.rbExcelente);
            this.Name = "Form1";
            this.Text = "Encuesta de Servicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbExcelente;
        private System.Windows.Forms.RadioButton rbBueno;
        private System.Windows.Forms.RadioButton rbInsuficiente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbExcelentes;
        private System.Windows.Forms.Label lbBuenos;
        private System.Windows.Forms.Label lbInsuficientes;
        private System.Windows.Forms.Button btnVotar;
    }
}

