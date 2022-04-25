namespace Conecta4.Interfaz
{
    partial class VentanaInicio
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
            this.buttonJugar = new System.Windows.Forms.Button();
            this.labelTituloVentanaInicio = new System.Windows.Forms.Label();
            this.radioButtonRojo = new System.Windows.Forms.RadioButton();
            this.radioButtonAzul = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // buttonJugar
            // 
            this.buttonJugar.Location = new System.Drawing.Point(94, 132);
            this.buttonJugar.Name = "buttonJugar";
            this.buttonJugar.Size = new System.Drawing.Size(134, 37);
            this.buttonJugar.TabIndex = 0;
            this.buttonJugar.Text = "Jugar";
            this.buttonJugar.UseVisualStyleBackColor = true;
            this.buttonJugar.Click += new System.EventHandler(this.buttonJugar_Click);
            // 
            // labelTituloVentanaInicio
            // 
            this.labelTituloVentanaInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTituloVentanaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloVentanaInicio.Location = new System.Drawing.Point(0, 0);
            this.labelTituloVentanaInicio.Name = "labelTituloVentanaInicio";
            this.labelTituloVentanaInicio.Size = new System.Drawing.Size(334, 53);
            this.labelTituloVentanaInicio.TabIndex = 1;
            this.labelTituloVentanaInicio.Text = "Elija el color con el que jugará el jugador 1 \r\n";
            this.labelTituloVentanaInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTituloVentanaInicio.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButtonRojo
            // 
            this.radioButtonRojo.AutoSize = true;
            this.radioButtonRojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRojo.ForeColor = System.Drawing.Color.Red;
            this.radioButtonRojo.Location = new System.Drawing.Point(126, 65);
            this.radioButtonRojo.Name = "radioButtonRojo";
            this.radioButtonRojo.Size = new System.Drawing.Size(61, 20);
            this.radioButtonRojo.TabIndex = 2;
            this.radioButtonRojo.TabStop = true;
            this.radioButtonRojo.Text = "Rojo";
            this.radioButtonRojo.UseVisualStyleBackColor = true;
            // 
            // radioButtonAzul
            // 
            this.radioButtonAzul.AutoSize = true;
            this.radioButtonAzul.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAzul.ForeColor = System.Drawing.Color.Blue;
            this.radioButtonAzul.Location = new System.Drawing.Point(126, 91);
            this.radioButtonAzul.Name = "radioButtonAzul";
            this.radioButtonAzul.Size = new System.Drawing.Size(57, 20);
            this.radioButtonAzul.TabIndex = 3;
            this.radioButtonAzul.TabStop = true;
            this.radioButtonAzul.Text = "Azul";
            this.radioButtonAzul.UseVisualStyleBackColor = true;
            // 
            // VentanaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 181);
            this.Controls.Add(this.radioButtonAzul);
            this.Controls.Add(this.radioButtonRojo);
            this.Controls.Add(this.labelTituloVentanaInicio);
            this.Controls.Add(this.buttonJugar);
            this.Name = "VentanaInicio";
            this.Text = "VentanaInicio";
            this.Load += new System.EventHandler(this.VentanaInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonJugar;
        private System.Windows.Forms.Label labelTituloVentanaInicio;
        private System.Windows.Forms.RadioButton radioButtonRojo;
        private System.Windows.Forms.RadioButton radioButtonAzul;
    }
}