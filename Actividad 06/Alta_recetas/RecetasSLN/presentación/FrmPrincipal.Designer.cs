namespace RecetasSLN.presentación
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.recetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darDeAltaRecetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarRecetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recetasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // recetasToolStripMenuItem
            // 
            this.recetasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darDeAltaRecetaToolStripMenuItem,
            this.consultarRecetasToolStripMenuItem});
            this.recetasToolStripMenuItem.Name = "recetasToolStripMenuItem";
            this.recetasToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.recetasToolStripMenuItem.Text = "Recetas";
            // 
            // darDeAltaRecetaToolStripMenuItem
            // 
            this.darDeAltaRecetaToolStripMenuItem.Name = "darDeAltaRecetaToolStripMenuItem";
            this.darDeAltaRecetaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.darDeAltaRecetaToolStripMenuItem.Text = "Dar de alta receta";
            this.darDeAltaRecetaToolStripMenuItem.Click += new System.EventHandler(this.darDeAltaRecetaToolStripMenuItem_Click);
            // 
            // consultarRecetasToolStripMenuItem
            // 
            this.consultarRecetasToolStripMenuItem.Name = "consultarRecetasToolStripMenuItem";
            this.consultarRecetasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarRecetasToolStripMenuItem.Text = "Consultar recetas";
            this.consultarRecetasToolStripMenuItem.Click += new System.EventHandler(this.consultarRecetasToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem recetasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darDeAltaRecetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarRecetasToolStripMenuItem;
    }
}