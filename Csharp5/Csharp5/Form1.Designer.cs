namespace Csharp5
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
            this.Lbl_Tittle = new System.Windows.Forms.Label();
            this.TxtBox_Names = new System.Windows.Forms.TextBox();
            this.ListBox_Names = new System.Windows.Forms.ListBox();
            this.Btn_Ok = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Modify = new System.Windows.Forms.Button();
            this.TxtBox_SelectToModify = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lbl_Tittle
            // 
            this.Lbl_Tittle.AutoSize = true;
            this.Lbl_Tittle.Location = new System.Drawing.Point(13, 13);
            this.Lbl_Tittle.Name = "Lbl_Tittle";
            this.Lbl_Tittle.Size = new System.Drawing.Size(66, 16);
            this.Lbl_Tittle.TabIndex = 0;
            this.Lbl_Tittle.Text = "Nombres:";
            // 
            // TxtBox_Names
            // 
            this.TxtBox_Names.Location = new System.Drawing.Point(44, 32);
            this.TxtBox_Names.Name = "TxtBox_Names";
            this.TxtBox_Names.Size = new System.Drawing.Size(136, 22);
            this.TxtBox_Names.TabIndex = 1;
            // 
            // ListBox_Names
            // 
            this.ListBox_Names.FormattingEnabled = true;
            this.ListBox_Names.ItemHeight = 16;
            this.ListBox_Names.Location = new System.Drawing.Point(44, 70);
            this.ListBox_Names.Name = "ListBox_Names";
            this.ListBox_Names.Size = new System.Drawing.Size(226, 100);
            this.ListBox_Names.TabIndex = 2;
            this.ListBox_Names.Tag = "g";
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.Location = new System.Drawing.Point(60, 203);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(75, 38);
            this.Btn_Ok.TabIndex = 3;
            this.Btn_Ok.Text = "Ok";
            this.Btn_Ok.UseVisualStyleBackColor = true;
            this.Btn_Ok.Click += new System.EventHandler(this.btn1ok_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Location = new System.Drawing.Point(286, 203);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(75, 38);
            this.Btn_Close.TabIndex = 4;
            this.Btn_Close.Tag = "g";
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Location = new System.Drawing.Point(286, 147);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.Btn_Delete.TabIndex = 5;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Modify
            // 
            this.Btn_Modify.Location = new System.Drawing.Point(286, 60);
            this.Btn_Modify.Name = "Btn_Modify";
            this.Btn_Modify.Size = new System.Drawing.Size(75, 23);
            this.Btn_Modify.TabIndex = 6;
            this.Btn_Modify.Text = "Modify";
            this.Btn_Modify.UseVisualStyleBackColor = true;
            this.Btn_Modify.Click += new System.EventHandler(this.Btn_Modify_Click);
            // 
            // TxtBox_SelectToModify
            // 
            this.TxtBox_SelectToModify.Location = new System.Drawing.Point(251, 32);
            this.TxtBox_SelectToModify.Name = "TxtBox_SelectToModify";
            this.TxtBox_SelectToModify.Size = new System.Drawing.Size(136, 22);
            this.TxtBox_SelectToModify.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 264);
            this.Controls.Add(this.TxtBox_SelectToModify);
            this.Controls.Add(this.Btn_Modify);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Btn_Ok);
            this.Controls.Add(this.ListBox_Names);
            this.Controls.Add(this.TxtBox_Names);
            this.Controls.Add(this.Lbl_Tittle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Tittle;
        private System.Windows.Forms.TextBox TxtBox_Names;
        private System.Windows.Forms.ListBox ListBox_Names;
        private System.Windows.Forms.Button Btn_Ok;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Modify;
        private System.Windows.Forms.TextBox TxtBox_SelectToModify;
    }
}

