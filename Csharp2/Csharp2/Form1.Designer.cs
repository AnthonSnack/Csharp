namespace Csharp2
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
            this.lbl_user1 = new System.Windows.Forms.Label();
            this.lbl_password1 = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_ok1 = new System.Windows.Forms.Button();
            this.btn_close1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_user1
            // 
            this.lbl_user1.AutoSize = true;
            this.lbl_user1.Location = new System.Drawing.Point(48, 66);
            this.lbl_user1.Name = "lbl_user1";
            this.lbl_user1.Size = new System.Drawing.Size(39, 16);
            this.lbl_user1.TabIndex = 0;
            this.lbl_user1.Text = "User:";
            // 
            // lbl_password1
            // 
            this.lbl_password1.AutoSize = true;
            this.lbl_password1.Location = new System.Drawing.Point(48, 106);
            this.lbl_password1.Name = "lbl_password1";
            this.lbl_password1.Size = new System.Drawing.Size(70, 16);
            this.lbl_password1.TabIndex = 1;
            this.lbl_password1.Text = "Password:";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(93, 66);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(271, 22);
            this.txt_user.TabIndex = 2;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(124, 106);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(240, 22);
            this.txt_password.TabIndex = 3;
            // 
            // btn_ok1
            // 
            this.btn_ok1.Location = new System.Drawing.Point(93, 162);
            this.btn_ok1.Name = "btn_ok1";
            this.btn_ok1.Size = new System.Drawing.Size(94, 41);
            this.btn_ok1.TabIndex = 4;
            this.btn_ok1.Text = "Ok";
            this.btn_ok1.UseVisualStyleBackColor = true;
            this.btn_ok1.Click += new System.EventHandler(this.btn_ok1_Click);
            // 
            // btn_close1
            // 
            this.btn_close1.Location = new System.Drawing.Point(279, 173);
            this.btn_close1.Name = "btn_close1";
            this.btn_close1.Size = new System.Drawing.Size(84, 30);
            this.btn_close1.TabIndex = 5;
            this.btn_close1.Text = "Close";
            this.btn_close1.UseVisualStyleBackColor = true;
            this.btn_close1.Click += new System.EventHandler(this.btn_close1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 215);
            this.Controls.Add(this.btn_close1);
            this.Controls.Add(this.btn_ok1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.lbl_password1);
            this.Controls.Add(this.lbl_user1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_user1;
        private System.Windows.Forms.Label lbl_password1;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_ok1;
        private System.Windows.Forms.Button btn_close1;
    }
}

