
namespace Laboratorio_4
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buscar = new System.Windows.Forms.Button();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bienvenidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.haciaDelanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refrescarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(750, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(768, 25);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(102, 23);
            this.buscar.TabIndex = 2;
            this.buscar.Text = "BUSCAR";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(12, 54);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(870, 497);
            this.webView21.Source = new System.Uri("https://www.bing.com", System.UriKind.Absolute);
            this.webView21.TabIndex = 4;
            this.webView21.ZoomFactor = 1D;
            this.webView21.Click += new System.EventHandler(this.webView21_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bienvenidoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bienvenidoToolStripMenuItem
            // 
            this.bienvenidoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.regresarToolStripMenuItem,
            this.haciaDelanteToolStripMenuItem,
            this.refrescarToolStripMenuItem});
            this.bienvenidoToolStripMenuItem.Name = "bienvenidoToolStripMenuItem";
            this.bienvenidoToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.bienvenidoToolStripMenuItem.Text = "Bienvenido";
            this.bienvenidoToolStripMenuItem.Click += new System.EventHandler(this.bienvenidoToolStripMenuItem_Click);
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click_1);
            // 
            // regresarToolStripMenuItem
            // 
            this.regresarToolStripMenuItem.Name = "regresarToolStripMenuItem";
            this.regresarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.regresarToolStripMenuItem.Text = "Regresar";
            this.regresarToolStripMenuItem.Click += new System.EventHandler(this.regresarToolStripMenuItem_Click);
            // 
            // haciaDelanteToolStripMenuItem
            // 
            this.haciaDelanteToolStripMenuItem.Name = "haciaDelanteToolStripMenuItem";
            this.haciaDelanteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.haciaDelanteToolStripMenuItem.Text = "Hacia delante";
            this.haciaDelanteToolStripMenuItem.Click += new System.EventHandler(this.haciaDelanteToolStripMenuItem_Click);
            // 
            // refrescarToolStripMenuItem
            // 
            this.refrescarToolStripMenuItem.Name = "refrescarToolStripMenuItem";
            this.refrescarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refrescarToolStripMenuItem.Text = "Refrescar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 550);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Navegador Web";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buscar;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bienvenidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regresarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem haciaDelanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refrescarToolStripMenuItem;
    }
}

