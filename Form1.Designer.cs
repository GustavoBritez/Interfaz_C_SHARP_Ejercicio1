namespace Ejercicio1
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
            this.LB_ENUNCIADO = new System.Windows.Forms.Label();
            this.BTN_INGRESAR = new System.Windows.Forms.Button();
            this.TX_1 = new System.Windows.Forms.TextBox();
            this.LB_RESULTADO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LB_ENUNCIADO
            // 
            this.LB_ENUNCIADO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ENUNCIADO.Location = new System.Drawing.Point(12, 9);
            this.LB_ENUNCIADO.Name = "LB_ENUNCIADO";
            this.LB_ENUNCIADO.Size = new System.Drawing.Size(485, 55);
            this.LB_ENUNCIADO.TabIndex = 0;
            this.LB_ENUNCIADO.Text = "Desarrollar un programa que permita ingresar dos números por medio de inputbox y " +
    "retorne la suma de los mismos en un messagebox.";
            // 
            // BTN_INGRESAR
            // 
            this.BTN_INGRESAR.Location = new System.Drawing.Point(178, 67);
            this.BTN_INGRESAR.Name = "BTN_INGRESAR";
            this.BTN_INGRESAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_INGRESAR.TabIndex = 1;
            this.BTN_INGRESAR.Text = "Ingresar";
            this.BTN_INGRESAR.UseVisualStyleBackColor = true;
            this.BTN_INGRESAR.Click += new System.EventHandler(this.BTN_INGRESAR_Click);
            // 
            // TX_1
            // 
            this.TX_1.Location = new System.Drawing.Point(153, 126);
            this.TX_1.Name = "TX_1";
            this.TX_1.Size = new System.Drawing.Size(100, 20);
            this.TX_1.TabIndex = 2;
            // 
            // LB_RESULTADO
            // 
            this.LB_RESULTADO.AutoSize = true;
            this.LB_RESULTADO.Location = new System.Drawing.Point(92, 129);
            this.LB_RESULTADO.Name = "LB_RESULTADO";
            this.LB_RESULTADO.Size = new System.Drawing.Size(55, 13);
            this.LB_RESULTADO.TabIndex = 3;
            this.LB_RESULTADO.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 191);
            this.Controls.Add(this.LB_RESULTADO);
            this.Controls.Add(this.TX_1);
            this.Controls.Add(this.BTN_INGRESAR);
            this.Controls.Add(this.LB_ENUNCIADO);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_ENUNCIADO;
        private System.Windows.Forms.Button BTN_INGRESAR;
        private System.Windows.Forms.TextBox TX_1;
        private System.Windows.Forms.Label LB_RESULTADO;
    }
}

