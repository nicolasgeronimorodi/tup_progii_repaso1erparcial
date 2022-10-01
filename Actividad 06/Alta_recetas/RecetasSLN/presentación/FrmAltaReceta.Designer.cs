namespace RecetasSLN.presentación
{
    partial class FrmAltaReceta
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
            this.lblRecetaNro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreReceta = new System.Windows.Forms.TextBox();
            this.txtChef = new System.Windows.Forms.TextBox();
            this.cboTipoReceta = new System.Windows.Forms.ComboBox();
            this.cboIngrediente = new System.Windows.Forms.ComboBox();
            this.npdCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIngrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCantidadIngredientes = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.npdCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecetaNro
            // 
            this.lblRecetaNro.AutoSize = true;
            this.lblRecetaNro.Location = new System.Drawing.Point(83, 29);
            this.lblRecetaNro.Name = "lblRecetaNro";
            this.lblRecetaNro.Size = new System.Drawing.Size(64, 13);
            this.lblRecetaNro.TabIndex = 0;
            this.lblRecetaNro.Text = "Receta n#: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chef";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo de receta";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNombreReceta
            // 
            this.txtNombreReceta.Location = new System.Drawing.Point(118, 69);
            this.txtNombreReceta.Name = "txtNombreReceta";
            this.txtNombreReceta.Size = new System.Drawing.Size(100, 20);
            this.txtNombreReceta.TabIndex = 0;
            // 
            // txtChef
            // 
            this.txtChef.Location = new System.Drawing.Point(118, 102);
            this.txtChef.Name = "txtChef";
            this.txtChef.Size = new System.Drawing.Size(100, 20);
            this.txtChef.TabIndex = 1;
            // 
            // cboTipoReceta
            // 
            this.cboTipoReceta.FormattingEnabled = true;
            this.cboTipoReceta.Items.AddRange(new object[] {
            "0-Desayuno",
            "1-Plato principal",
            "2-Vegana",
            "3-Reposteria"});
            this.cboTipoReceta.Location = new System.Drawing.Point(129, 139);
            this.cboTipoReceta.Name = "cboTipoReceta";
            this.cboTipoReceta.Size = new System.Drawing.Size(121, 21);
            this.cboTipoReceta.TabIndex = 2;
            // 
            // cboIngrediente
            // 
            this.cboIngrediente.FormattingEnabled = true;
            this.cboIngrediente.Location = new System.Drawing.Point(39, 197);
            this.cboIngrediente.Name = "cboIngrediente";
            this.cboIngrediente.Size = new System.Drawing.Size(121, 21);
            this.cboIngrediente.TabIndex = 3;
            // 
            // npdCantidad
            // 
            this.npdCantidad.Location = new System.Drawing.Point(166, 198);
            this.npdCantidad.Name = "npdCantidad";
            this.npdCantidad.Size = new System.Drawing.Size(120, 20);
            this.npdCantidad.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(292, 198);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColIngrediente,
            this.ColCantidad,
            this.ColAcciones});
            this.dgvDetalles.Location = new System.Drawing.Point(61, 256);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.Size = new System.Drawing.Size(371, 150);
            this.dgvDetalles.TabIndex = 10;
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            this.ColID.Visible = false;
            // 
            // ColIngrediente
            // 
            this.ColIngrediente.HeaderText = "Ingrediente";
            this.ColIngrediente.Name = "ColIngrediente";
            this.ColIngrediente.ReadOnly = true;
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "Cantidad";
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.ReadOnly = true;
            // 
            // ColAcciones
            // 
            this.ColAcciones.HeaderText = "Acciones";
            this.ColAcciones.Name = "ColAcciones";
            this.ColAcciones.ReadOnly = true;
            this.ColAcciones.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColAcciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColAcciones.Text = "Quitar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 11;
            // 
            // lblCantidadIngredientes
            // 
            this.lblCantidadIngredientes.AutoSize = true;
            this.lblCantidadIngredientes.Location = new System.Drawing.Point(87, 225);
            this.lblCantidadIngredientes.Name = "lblCantidadIngredientes";
            this.lblCantidadIngredientes.Size = new System.Drawing.Size(112, 13);
            this.lblCantidadIngredientes.TabIndex = 12;
            this.lblCantidadIngredientes.Text = "Cantidad ingredientes:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(530, 392);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(654, 392);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmAltaReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblCantidadIngredientes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.npdCantidad);
            this.Controls.Add(this.cboIngrediente);
            this.Controls.Add(this.cboTipoReceta);
            this.Controls.Add(this.txtChef);
            this.Controls.Add(this.txtNombreReceta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRecetaNro);
            this.Name = "FrmAltaReceta";
            this.Text = "FrmAltaReceta";
            this.Load += new System.EventHandler(this.FrmAltaReceta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.npdCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecetaNro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreReceta;
        private System.Windows.Forms.TextBox txtChef;
        private System.Windows.Forms.ComboBox cboTipoReceta;
        private System.Windows.Forms.ComboBox cboIngrediente;
        private System.Windows.Forms.NumericUpDown npdCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCantidadIngredientes;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIngrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewButtonColumn ColAcciones;
    }
}