namespace POO1
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
            this.Btn1_Llamar = new System.Windows.Forms.Button();
            this.TxtBox1_Entrada1 = new System.Windows.Forms.TextBox();
            this.Lbl1_Resultado1 = new System.Windows.Forms.Label();
            this.Btn1_Sumar = new System.Windows.Forms.Button();
            this.TxtBox2_Entrada2 = new System.Windows.Forms.TextBox();
            this.Btn3_Info = new System.Windows.Forms.Button();
            this.TxtBox_MensajeIn = new System.Windows.Forms.TextBox();
            this.TxtBox_AutorIn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ListBox_ListBoxMensajes = new System.Windows.Forms.ListBox();
            this.Btn_EnviarMensaje = new System.Windows.Forms.Button();
            this.Btn_LeerMensaje = new System.Windows.Forms.Button();
            this.TxtBox_EntradaMensajeIndex = new System.Windows.Forms.TextBox();
            this.Lbl_ShowMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn1_Llamar
            // 
            this.Btn1_Llamar.Location = new System.Drawing.Point(276, 143);
            this.Btn1_Llamar.Name = "Btn1_Llamar";
            this.Btn1_Llamar.Size = new System.Drawing.Size(262, 64);
            this.Btn1_Llamar.TabIndex = 0;
            this.Btn1_Llamar.Text = "Llamar";
            this.Btn1_Llamar.UseVisualStyleBackColor = true;
            this.Btn1_Llamar.Click += new System.EventHandler(this.Btn1_Llamar_Click);
            // 
            // TxtBox1_Entrada1
            // 
            this.TxtBox1_Entrada1.Location = new System.Drawing.Point(45, 39);
            this.TxtBox1_Entrada1.Name = "TxtBox1_Entrada1";
            this.TxtBox1_Entrada1.Size = new System.Drawing.Size(47, 22);
            this.TxtBox1_Entrada1.TabIndex = 1;
            // 
            // Lbl1_Resultado1
            // 
            this.Lbl1_Resultado1.AutoSize = true;
            this.Lbl1_Resultado1.Location = new System.Drawing.Point(151, 45);
            this.Lbl1_Resultado1.Name = "Lbl1_Resultado1";
            this.Lbl1_Resultado1.Size = new System.Drawing.Size(0, 16);
            this.Lbl1_Resultado1.TabIndex = 2;
            // 
            // Btn1_Sumar
            // 
            this.Btn1_Sumar.Location = new System.Drawing.Point(45, 80);
            this.Btn1_Sumar.Name = "Btn1_Sumar";
            this.Btn1_Sumar.Size = new System.Drawing.Size(106, 23);
            this.Btn1_Sumar.TabIndex = 3;
            this.Btn1_Sumar.Text = "Sumar";
            this.Btn1_Sumar.UseVisualStyleBackColor = true;
            this.Btn1_Sumar.Click += new System.EventHandler(this.Btn1_Sumar_Click);
            // 
            // TxtBox2_Entrada2
            // 
            this.TxtBox2_Entrada2.Location = new System.Drawing.Point(98, 39);
            this.TxtBox2_Entrada2.Name = "TxtBox2_Entrada2";
            this.TxtBox2_Entrada2.Size = new System.Drawing.Size(47, 22);
            this.TxtBox2_Entrada2.TabIndex = 4;
            // 
            // Btn3_Info
            // 
            this.Btn3_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3_Info.Location = new System.Drawing.Point(685, 401);
            this.Btn3_Info.Name = "Btn3_Info";
            this.Btn3_Info.Size = new System.Drawing.Size(103, 37);
            this.Btn3_Info.TabIndex = 5;
            this.Btn3_Info.Text = "Info del equipo";
            this.Btn3_Info.UseVisualStyleBackColor = true;
            this.Btn3_Info.Click += new System.EventHandler(this.Btn3_Info_Click);
            // 
            // TxtBox_MensajeIn
            // 
            this.TxtBox_MensajeIn.Location = new System.Drawing.Point(45, 256);
            this.TxtBox_MensajeIn.Multiline = true;
            this.TxtBox_MensajeIn.Name = "TxtBox_MensajeIn";
            this.TxtBox_MensajeIn.Size = new System.Drawing.Size(262, 74);
            this.TxtBox_MensajeIn.TabIndex = 6;
            this.TxtBox_MensajeIn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtBox_AutorIn
            // 
            this.TxtBox_AutorIn.Location = new System.Drawing.Point(176, 336);
            this.TxtBox_AutorIn.Name = "TxtBox_AutorIn";
            this.TxtBox_AutorIn.Size = new System.Drawing.Size(131, 22);
            this.TxtBox_AutorIn.TabIndex = 7;
            this.TxtBox_AutorIn.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mensaje:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Autor:";
            // 
            // ListBox_ListBoxMensajes
            // 
            this.ListBox_ListBoxMensajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox_ListBoxMensajes.FormattingEnabled = true;
            this.ListBox_ListBoxMensajes.ItemHeight = 15;
            this.ListBox_ListBoxMensajes.Location = new System.Drawing.Point(314, 234);
            this.ListBox_ListBoxMensajes.Name = "ListBox_ListBoxMensajes";
            this.ListBox_ListBoxMensajes.Size = new System.Drawing.Size(186, 154);
            this.ListBox_ListBoxMensajes.TabIndex = 10;
            // 
            // Btn_EnviarMensaje
            // 
            this.Btn_EnviarMensaje.Location = new System.Drawing.Point(48, 375);
            this.Btn_EnviarMensaje.Name = "Btn_EnviarMensaje";
            this.Btn_EnviarMensaje.Size = new System.Drawing.Size(75, 23);
            this.Btn_EnviarMensaje.TabIndex = 11;
            this.Btn_EnviarMensaje.Text = "Enviar mensaje";
            this.Btn_EnviarMensaje.UseVisualStyleBackColor = true;
            this.Btn_EnviarMensaje.Click += new System.EventHandler(this.Btn_EnviarMensaje_Click);
            // 
            // Btn_LeerMensaje
            // 
            this.Btn_LeerMensaje.Location = new System.Drawing.Point(349, 394);
            this.Btn_LeerMensaje.Name = "Btn_LeerMensaje";
            this.Btn_LeerMensaje.Size = new System.Drawing.Size(75, 23);
            this.Btn_LeerMensaje.TabIndex = 12;
            this.Btn_LeerMensaje.Text = "Leer:";
            this.Btn_LeerMensaje.UseVisualStyleBackColor = true;
            this.Btn_LeerMensaje.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtBox_EntradaMensajeIndex
            // 
            this.TxtBox_EntradaMensajeIndex.Location = new System.Drawing.Point(430, 394);
            this.TxtBox_EntradaMensajeIndex.Name = "TxtBox_EntradaMensajeIndex";
            this.TxtBox_EntradaMensajeIndex.Size = new System.Drawing.Size(32, 22);
            this.TxtBox_EntradaMensajeIndex.TabIndex = 13;
            this.TxtBox_EntradaMensajeIndex.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Lbl_ShowMensaje
            // 
            this.Lbl_ShowMensaje.AutoSize = true;
            this.Lbl_ShowMensaje.Location = new System.Drawing.Point(507, 234);
            this.Lbl_ShowMensaje.Name = "Lbl_ShowMensaje";
            this.Lbl_ShowMensaje.Size = new System.Drawing.Size(0, 16);
            this.Lbl_ShowMensaje.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_ShowMensaje);
            this.Controls.Add(this.TxtBox_EntradaMensajeIndex);
            this.Controls.Add(this.Btn_LeerMensaje);
            this.Controls.Add(this.Btn_EnviarMensaje);
            this.Controls.Add(this.ListBox_ListBoxMensajes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBox_AutorIn);
            this.Controls.Add(this.TxtBox_MensajeIn);
            this.Controls.Add(this.Btn3_Info);
            this.Controls.Add(this.TxtBox2_Entrada2);
            this.Controls.Add(this.Btn1_Sumar);
            this.Controls.Add(this.Lbl1_Resultado1);
            this.Controls.Add(this.TxtBox1_Entrada1);
            this.Controls.Add(this.Btn1_Llamar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn1_Llamar;
        private System.Windows.Forms.TextBox TxtBox1_Entrada1;
        private System.Windows.Forms.Label Lbl1_Resultado1;
        private System.Windows.Forms.Button Btn1_Sumar;
        private System.Windows.Forms.TextBox TxtBox2_Entrada2;
        private System.Windows.Forms.Button Btn3_Info;
        private System.Windows.Forms.TextBox TxtBox_MensajeIn;
        private System.Windows.Forms.TextBox TxtBox_AutorIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ListBox_ListBoxMensajes;
        private System.Windows.Forms.Button Btn_EnviarMensaje;
        private System.Windows.Forms.Button Btn_LeerMensaje;
        private System.Windows.Forms.TextBox TxtBox_EntradaMensajeIndex;
        private System.Windows.Forms.Label Lbl_ShowMensaje;
    }
}

