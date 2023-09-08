namespace Csharp_1
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
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_text = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(311, 353);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(97, 48);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(574, 353);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(97, 48);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_text
            // 
            this.lbl_text.AutoSize = true;
            this.lbl_text.Location = new System.Drawing.Point(124, 78);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(68, 16);
            this.lbl_text.TabIndex = 2;
            this.lbl_text.Text = "Welcome:";
            this.lbl_text.Click += new System.EventHandler(this.lbl_text1);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(227, 97);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(318, 22);
            this.txt_name.TabIndex = 3;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_text);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_ok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_text;
        private System.Windows.Forms.TextBox txt_name;
    }
}

