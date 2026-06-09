namespace Ejercicio7
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.btnVotar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbExcelentes = new System.Windows.Forms.Label();
            this.lbBuenos = new System.Windows.Forms.Label();
            this.lbInsuficientes = new System.Windows.Forms.Label();
            this.lbBase = new System.Windows.Forms.Label();
            this.lbFULL = new System.Windows.Forms.Label();
            this.rbExcelente = new System.Windows.Forms.RadioButton();
            this.rbBueno = new System.Windows.Forms.RadioButton();
            this.rbInsuficiente = new System.Windows.Forms.RadioButton();
            this.rbBase = new System.Windows.Forms.RadioButton();
            this.rbFull = new System.Windows.Forms.RadioButton();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.rbInsuficiente);
            this.GroupBox1.Controls.Add(this.rbBueno);
            this.GroupBox1.Controls.Add(this.rbExcelente);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(29, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(177, 150);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Opinión";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.rbFull);
            this.GroupBox2.Controls.Add(this.rbBase);
            this.GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(29, 179);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(177, 109);
            this.GroupBox2.TabIndex = 1;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Tipo de producto";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.lbFULL);
            this.GroupBox3.Controls.Add(this.lbBase);
            this.GroupBox3.Controls.Add(this.lbInsuficientes);
            this.GroupBox3.Controls.Add(this.lbBuenos);
            this.GroupBox3.Controls.Add(this.lbExcelentes);
            this.GroupBox3.Controls.Add(this.lbTotal);
            this.GroupBox3.Controls.Add(this.label6);
            this.GroupBox3.Controls.Add(this.label5);
            this.GroupBox3.Controls.Add(this.label4);
            this.GroupBox3.Controls.Add(this.label3);
            this.GroupBox3.Controls.Add(this.label2);
            this.GroupBox3.Controls.Add(this.label1);
            this.GroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.Location = new System.Drawing.Point(29, 316);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(524, 379);
            this.GroupBox3.TabIndex = 2;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Resultados de la encuesta";
            // 
            // btnVotar
            // 
            this.btnVotar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVotar.Location = new System.Drawing.Point(267, 81);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(121, 43);
            this.btnVotar.TabIndex = 3;
            this.btnVotar.Text = "Votar";
            this.btnVotar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de Votaciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad de Excelentes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad de Buenos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad de Insuficientes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad de base";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cantidad de FULL";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(380, 57);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(53, 20);
            this.lbTotal.TabIndex = 6;
            this.lbTotal.Text = "label7";
            // 
            // lbExcelentes
            // 
            this.lbExcelentes.AutoSize = true;
            this.lbExcelentes.Location = new System.Drawing.Point(380, 113);
            this.lbExcelentes.Name = "lbExcelentes";
            this.lbExcelentes.Size = new System.Drawing.Size(53, 20);
            this.lbExcelentes.TabIndex = 7;
            this.lbExcelentes.Text = "label8";
            // 
            // lbBuenos
            // 
            this.lbBuenos.AutoSize = true;
            this.lbBuenos.Location = new System.Drawing.Point(380, 165);
            this.lbBuenos.Name = "lbBuenos";
            this.lbBuenos.Size = new System.Drawing.Size(53, 20);
            this.lbBuenos.TabIndex = 8;
            this.lbBuenos.Text = "label9";
            // 
            // lbInsuficientes
            // 
            this.lbInsuficientes.AutoSize = true;
            this.lbInsuficientes.Location = new System.Drawing.Point(380, 217);
            this.lbInsuficientes.Name = "lbInsuficientes";
            this.lbInsuficientes.Size = new System.Drawing.Size(62, 20);
            this.lbInsuficientes.TabIndex = 9;
            this.lbInsuficientes.Text = "label10";
            // 
            // lbBase
            // 
            this.lbBase.AutoSize = true;
            this.lbBase.Location = new System.Drawing.Point(380, 265);
            this.lbBase.Name = "lbBase";
            this.lbBase.Size = new System.Drawing.Size(62, 20);
            this.lbBase.TabIndex = 10;
            this.lbBase.Text = "label11";
            // 
            // lbFULL
            // 
            this.lbFULL.AutoSize = true;
            this.lbFULL.Location = new System.Drawing.Point(380, 323);
            this.lbFULL.Name = "lbFULL";
            this.lbFULL.Size = new System.Drawing.Size(62, 20);
            this.lbFULL.TabIndex = 11;
            this.lbFULL.Text = "label12";
            // 
            // rbExcelente
            // 
            this.rbExcelente.AutoSize = true;
            this.rbExcelente.Location = new System.Drawing.Point(29, 25);
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
            this.rbBueno.Location = new System.Drawing.Point(29, 70);
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
            this.rbInsuficiente.Location = new System.Drawing.Point(29, 109);
            this.rbInsuficiente.Name = "rbInsuficiente";
            this.rbInsuficiente.Size = new System.Drawing.Size(115, 24);
            this.rbInsuficiente.TabIndex = 2;
            this.rbInsuficiente.TabStop = true;
            this.rbInsuficiente.Text = "Insuficiente";
            this.rbInsuficiente.UseVisualStyleBackColor = true;
            // 
            // rbBase
            // 
            this.rbBase.AutoSize = true;
            this.rbBase.Location = new System.Drawing.Point(38, 33);
            this.rbBase.Name = "rbBase";
            this.rbBase.Size = new System.Drawing.Size(69, 24);
            this.rbBase.TabIndex = 0;
            this.rbBase.TabStop = true;
            this.rbBase.Text = "Base";
            this.rbBase.UseVisualStyleBackColor = true;
            // 
            // rbFull
            // 
            this.rbFull.AutoSize = true;
            this.rbFull.Location = new System.Drawing.Point(38, 68);
            this.rbFull.Name = "rbFull";
            this.rbFull.Size = new System.Drawing.Size(72, 24);
            this.rbFull.TabIndex = 1;
            this.rbFull.TabStop = true;
            this.rbFull.Text = "FULL";
            this.rbFull.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 707);
            this.Controls.Add(this.btnVotar);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.RadioButton rbInsuficiente;
        private System.Windows.Forms.RadioButton rbBueno;
        private System.Windows.Forms.RadioButton rbExcelente;
        private System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.RadioButton rbFull;
        private System.Windows.Forms.RadioButton rbBase;
        private System.Windows.Forms.GroupBox GroupBox3;
        private System.Windows.Forms.Label lbFULL;
        private System.Windows.Forms.Label lbBase;
        private System.Windows.Forms.Label lbInsuficientes;
        private System.Windows.Forms.Label lbBuenos;
        private System.Windows.Forms.Label lbExcelentes;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVotar;
    }
}

