namespace POO2
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
            this.Btn_Llamar = new System.Windows.Forms.Button();
            this.TxtBox_PaisIn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Llamar
            // 
            this.Btn_Llamar.Location = new System.Drawing.Point(184, 156);
            this.Btn_Llamar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Llamar.Name = "Btn_Llamar";
            this.Btn_Llamar.Size = new System.Drawing.Size(155, 55);
            this.Btn_Llamar.TabIndex = 0;
            this.Btn_Llamar.Text = "Llamar";
            this.Btn_Llamar.UseVisualStyleBackColor = true;
            this.Btn_Llamar.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtBox_PaisIn
            // 
            this.TxtBox_PaisIn.Location = new System.Drawing.Point(184, 131);
            this.TxtBox_PaisIn.Name = "TxtBox_PaisIn";
            this.TxtBox_PaisIn.Size = new System.Drawing.Size(94, 20);
            this.TxtBox_PaisIn.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.TxtBox_PaisIn);
            this.Controls.Add(this.Btn_Llamar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Llamar;
        private System.Windows.Forms.TextBox TxtBox_PaisIn;
    }
}

