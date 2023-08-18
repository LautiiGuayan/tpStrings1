namespace tpStrings1
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
            this.B2 = new System.Windows.Forms.Button();
            this.L1 = new System.Windows.Forms.Label();
            this.T2 = new System.Windows.Forms.TextBox();
            this.T3 = new System.Windows.Forms.TextBox();
            this.T1 = new System.Windows.Forms.TextBox();
            this.B1 = new System.Windows.Forms.Button();
            this.L2 = new System.Windows.Forms.Label();
            this.L3 = new System.Windows.Forms.Label();
            this.B3 = new System.Windows.Forms.Button();
            this.CERRAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LONGITUD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(463, 354);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(175, 61);
            this.B2.TabIndex = 1;
            this.B2.Text = "LIMPIAR";
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.B2_Click);
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Location = new System.Drawing.Point(14, 88);
            this.L1.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(120, 13);
            this.L1.TabIndex = 12;
            this.L1.Text = "INGRESAR FRASE (A):";
            // 
            // T2
            // 
            this.T2.Location = new System.Drawing.Point(157, 149);
            this.T2.Multiline = true;
            this.T2.Name = "T2";
            this.T2.Size = new System.Drawing.Size(384, 82);
            this.T2.TabIndex = 3;
            // 
            // T3
            // 
            this.T3.Location = new System.Drawing.Point(157, 237);
            this.T3.Multiline = true;
            this.T3.Name = "T3";
            this.T3.Size = new System.Drawing.Size(384, 82);
            this.T3.TabIndex = 6;
            this.T3.TextChanged += new System.EventHandler(this.T3_TextChanged);
            // 
            // T1
            // 
            this.T1.Location = new System.Drawing.Point(157, 55);
            this.T1.Multiline = true;
            this.T1.Name = "T1";
            this.T1.Size = new System.Drawing.Size(384, 82);
            this.T1.TabIndex = 7;
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(271, 354);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(175, 61);
            this.B1.TabIndex = 8;
            this.B1.Text = "LONGITUD";
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // L2
            // 
            this.L2.AutoSize = true;
            this.L2.Location = new System.Drawing.Point(14, 152);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(109, 13);
            this.L2.TabIndex = 13;
            this.L2.Text = "INGRESE FRASE(B):";
            // 
            // L3
            // 
            this.L3.AutoSize = true;
            this.L3.Location = new System.Drawing.Point(14, 240);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(76, 13);
            this.L3.TabIndex = 14;
            this.L3.Text = "RESULTADO:";
            // 
            // B3
            // 
            this.B3.Location = new System.Drawing.Point(75, 354);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(175, 61);
            this.B3.TabIndex = 15;
            this.B3.Text = "RESULTADO";
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.B3_Click);
            // 
            // CERRAR
            // 
            this.CERRAR.Location = new System.Drawing.Point(571, 172);
            this.CERRAR.Name = "CERRAR";
            this.CERRAR.Size = new System.Drawing.Size(195, 38);
            this.CERRAR.TabIndex = 16;
            this.CERRAR.Text = "CERRAR";
            this.CERRAR.UseVisualStyleBackColor = true;
            this.CERRAR.Click += new System.EventHandler(this.CERRAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "CONCATENAR FRASES";
            // 
            // LONGITUD
            // 
            this.LONGITUD.AutoSize = true;
            this.LONGITUD.Location = new System.Drawing.Point(577, 291);
            this.LONGITUD.Name = "LONGITUD";
            this.LONGITUD.Size = new System.Drawing.Size(123, 13);
            this.LONGITUD.TabIndex = 18;
            this.LONGITUD.Text = "VALOR DE LONGITUD:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 451);
            this.Controls.Add(this.LONGITUD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CERRAR);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.L3);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.T1);
            this.Controls.Add(this.T3);
            this.Controls.Add(this.T2);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.B2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.TextBox T2;
        private System.Windows.Forms.TextBox T3;
        private System.Windows.Forms.TextBox T1;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Label L2;
        private System.Windows.Forms.Label L3;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button CERRAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LONGITUD;
    }
}

