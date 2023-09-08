namespace POO1
{
    partial class Form2
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
            this.PictBox1_Image = new System.Windows.Forms.PictureBox();
            this.Lbl1_Llamada = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictBox1_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // PictBox1_Image
            // 
            this.PictBox1_Image.Location = new System.Drawing.Point(119, 25);
            this.PictBox1_Image.Name = "PictBox1_Image";
            this.PictBox1_Image.Size = new System.Drawing.Size(512, 305);
            this.PictBox1_Image.TabIndex = 0;
            this.PictBox1_Image.TabStop = false;
            this.PictBox1_Image.Click += new System.EventHandler(this.PictBox1_Image_Click);
            // 
            // Lbl1_Llamada
            // 
            this.Lbl1_Llamada.AutoSize = true;
            this.Lbl1_Llamada.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1_Llamada.Location = new System.Drawing.Point(324, 342);
            this.Lbl1_Llamada.Name = "Lbl1_Llamada";
            this.Lbl1_Llamada.Size = new System.Drawing.Size(86, 31);
            this.Lbl1_Llamada.TabIndex = 1;
            this.Lbl1_Llamada.Text = "label1";
            this.Lbl1_Llamada.Click += new System.EventHandler(this.Lbl1_Llamada_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl1_Llamada);
            this.Controls.Add(this.PictBox1_Image);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictBox1_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictBox1_Image;
        private System.Windows.Forms.Label Lbl1_Llamada;
    }
}