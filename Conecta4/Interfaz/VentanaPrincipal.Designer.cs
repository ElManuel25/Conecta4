namespace Conecta4
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.panelAreaJuego = new System.Windows.Forms.Panel();
            this.splitContainerTableroEInfo = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanelTablero = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainerInstruccionesEImagen = new System.Windows.Forms.SplitContainer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelTituloInstrucciones = new System.Windows.Forms.Label();
            this.panelAreaJuego.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTableroEInfo)).BeginInit();
            this.splitContainerTableroEInfo.Panel1.SuspendLayout();
            this.splitContainerTableroEInfo.Panel2.SuspendLayout();
            this.splitContainerTableroEInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerInstruccionesEImagen)).BeginInit();
            this.splitContainerInstruccionesEImagen.Panel1.SuspendLayout();
            this.splitContainerInstruccionesEImagen.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAreaJuego
            // 
            this.panelAreaJuego.Controls.Add(this.splitContainerTableroEInfo);
            this.panelAreaJuego.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAreaJuego.Location = new System.Drawing.Point(0, 0);
            this.panelAreaJuego.Name = "panelAreaJuego";
            this.panelAreaJuego.Size = new System.Drawing.Size(1072, 517);
            this.panelAreaJuego.TabIndex = 0;
            this.panelAreaJuego.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // splitContainerTableroEInfo
            // 
            this.splitContainerTableroEInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerTableroEInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTableroEInfo.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerTableroEInfo.Location = new System.Drawing.Point(0, 0);
            this.splitContainerTableroEInfo.Name = "splitContainerTableroEInfo";
            // 
            // splitContainerTableroEInfo.Panel1
            // 
            this.splitContainerTableroEInfo.Panel1.Controls.Add(this.tableLayoutPanelTablero);
            this.splitContainerTableroEInfo.Panel1MinSize = 600;
            // 
            // splitContainerTableroEInfo.Panel2
            // 
            this.splitContainerTableroEInfo.Panel2.Controls.Add(this.splitContainerInstruccionesEImagen);
            this.splitContainerTableroEInfo.Panel2MinSize = 200;
            this.splitContainerTableroEInfo.Size = new System.Drawing.Size(1072, 517);
            this.splitContainerTableroEInfo.SplitterDistance = 710;
            this.splitContainerTableroEInfo.TabIndex = 0;
            // 
            // tableLayoutPanelTablero
            // 
            this.tableLayoutPanelTablero.ColumnCount = 7;
            this.tableLayoutPanelTablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelTablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanelTablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanelTablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanelTablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanelTablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanelTablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanelTablero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTablero.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanelTablero.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTablero.Name = "tableLayoutPanelTablero";
            this.tableLayoutPanelTablero.RowCount = 6;
            this.tableLayoutPanelTablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelTablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelTablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelTablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelTablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelTablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelTablero.Size = new System.Drawing.Size(708, 515);
            this.tableLayoutPanelTablero.TabIndex = 0;
            // 
            // splitContainerInstruccionesEImagen
            // 
            this.splitContainerInstruccionesEImagen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainerInstruccionesEImagen.Location = new System.Drawing.Point(0, 0);
            this.splitContainerInstruccionesEImagen.Name = "splitContainerInstruccionesEImagen";
            this.splitContainerInstruccionesEImagen.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerInstruccionesEImagen.Panel1
            // 
            this.splitContainerInstruccionesEImagen.Panel1.Controls.Add(this.textBox1);
            this.splitContainerInstruccionesEImagen.Panel1.Controls.Add(this.labelTituloInstrucciones);
            // 
            // splitContainerInstruccionesEImagen.Panel2
            // 
            this.splitContainerInstruccionesEImagen.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainerInstruccionesEImagen.Panel2.BackgroundImage = global::Conecta4.Properties.Resources._4;
            this.splitContainerInstruccionesEImagen.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splitContainerInstruccionesEImagen.Panel2.Font = new System.Drawing.Font("Microsoft Himalaya", 1.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainerInstruccionesEImagen.Panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitContainerInstruccionesEImagen.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainerInstruccionesEInfo_Panel2_Paint);
            this.splitContainerInstruccionesEImagen.Size = new System.Drawing.Size(356, 515);
            this.splitContainerInstruccionesEImagen.SplitterDistance = 226;
            this.splitContainerInstruccionesEImagen.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 36);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(356, 190);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // labelTituloInstrucciones
            // 
            this.labelTituloInstrucciones.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelTituloInstrucciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTituloInstrucciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTituloInstrucciones.Location = new System.Drawing.Point(0, 0);
            this.labelTituloInstrucciones.Name = "labelTituloInstrucciones";
            this.labelTituloInstrucciones.Size = new System.Drawing.Size(356, 36);
            this.labelTituloInstrucciones.TabIndex = 0;
            this.labelTituloInstrucciones.Text = "Instrucciones";
            this.labelTituloInstrucciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 517);
            this.Controls.Add(this.panelAreaJuego);
            this.IsMdiContainer = true;
            this.Name = "VentanaPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.panelAreaJuego.ResumeLayout(false);
            this.splitContainerTableroEInfo.Panel1.ResumeLayout(false);
            this.splitContainerTableroEInfo.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTableroEInfo)).EndInit();
            this.splitContainerTableroEInfo.ResumeLayout(false);
            this.splitContainerInstruccionesEImagen.Panel1.ResumeLayout(false);
            this.splitContainerInstruccionesEImagen.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerInstruccionesEImagen)).EndInit();
            this.splitContainerInstruccionesEImagen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAreaJuego;
        private System.Windows.Forms.SplitContainer splitContainerTableroEInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTablero;
        private System.Windows.Forms.SplitContainer splitContainerInstruccionesEImagen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelTituloInstrucciones;
    }
}

