namespace Csharp6
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
            this.Btn_Escribir = new System.Windows.Forms.Button();
            this.Btn_Leer = new System.Windows.Forms.Button();
            this.Btn_Abrir = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Lbl_1 = new System.Windows.Forms.Label();
            this.TxtBox_Direccion = new System.Windows.Forms.TextBox();
            this.RTxtBox_1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // Btn_Escribir
            // 
            this.Btn_Escribir.Location = new System.Drawing.Point(48, 233);
            this.Btn_Escribir.Name = "Btn_Escribir";
            this.Btn_Escribir.Size = new System.Drawing.Size(121, 56);
            this.Btn_Escribir.TabIndex = 0;
            this.Btn_Escribir.Text = "Escribir";
            this.Btn_Escribir.UseVisualStyleBackColor = true;
            this.Btn_Escribir.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Leer
            // 
            this.Btn_Leer.Location = new System.Drawing.Point(48, 346);
            this.Btn_Leer.Name = "Btn_Leer";
            this.Btn_Leer.Size = new System.Drawing.Size(121, 56);
            this.Btn_Leer.TabIndex = 1;
            this.Btn_Leer.Text = "Leer";
            this.Btn_Leer.UseVisualStyleBackColor = true;
            this.Btn_Leer.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_Abrir
            // 
            this.Btn_Abrir.Location = new System.Drawing.Point(48, 40);
            this.Btn_Abrir.Name = "Btn_Abrir";
            this.Btn_Abrir.Size = new System.Drawing.Size(121, 56);
            this.Btn_Abrir.TabIndex = 2;
            this.Btn_Abrir.Text = "Abrir";
            this.Btn_Abrir.UseVisualStyleBackColor = true;
            this.Btn_Abrir.Click += new System.EventHandler(this.Btn_Abrir_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(48, 153);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(121, 56);
            this.Btn_Guardar.TabIndex = 3;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Lbl_1
            // 
            this.Lbl_1.AutoSize = true;
            this.Lbl_1.Location = new System.Drawing.Point(195, 40);
            this.Lbl_1.Name = "Lbl_1";
            this.Lbl_1.Size = new System.Drawing.Size(55, 13);
            this.Lbl_1.TabIndex = 4;
            this.Lbl_1.Text = "Direccion:";
            this.Lbl_1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtBox_Direccion
            // 
            this.TxtBox_Direccion.Location = new System.Drawing.Point(256, 40);
            this.TxtBox_Direccion.Name = "TxtBox_Direccion";
            this.TxtBox_Direccion.Size = new System.Drawing.Size(260, 20);
            this.TxtBox_Direccion.TabIndex = 5;
            this.TxtBox_Direccion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // RTxtBox_1
            // 
            this.RTxtBox_1.Location = new System.Drawing.Point(188, 76);
            this.RTxtBox_1.Name = "RTxtBox_1";
            this.RTxtBox_1.Size = new System.Drawing.Size(328, 326);
            this.RTxtBox_1.TabIndex = 6;
            this.RTxtBox_1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 414);
            this.Controls.Add(this.RTxtBox_1);
            this.Controls.Add(this.TxtBox_Direccion);
            this.Controls.Add(this.Lbl_1);
            this.Controls.Add(this.Btn_Leer);
            this.Controls.Add(this.Btn_Escribir);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Btn_Abrir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Escribir;
        private System.Windows.Forms.Button Btn_Leer;
        private System.Windows.Forms.Button Btn_Abrir;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Label Lbl_1;
        private System.Windows.Forms.TextBox TxtBox_Direccion;
        private System.Windows.Forms.RichTextBox RTxtBox_1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

