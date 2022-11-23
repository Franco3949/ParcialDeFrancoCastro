
namespace POOOrtoedros.Windows
{
    partial class frmPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.clmAristaA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAristaB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAristaC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmColorRelleno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmVolumen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbBorrar = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFiltrar = new System.Windows.Forms.ToolStripDropDownButton();
            this.sexoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masculinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.femeninoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tscboLocalidades = new System.Windows.Forms.ToolStripComboBox();
            this.comienzanConToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbRefrescar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbOrdenar = new System.Windows.Forms.ToolStripDropDownButton();
            this.aZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caracteresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDatos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 297);
            this.panel1.TabIndex = 15;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmAristaA,
            this.clmAristaB,
            this.clmAristaC,
            this.clmColorRelleno,
            this.clmArea,
            this.clmVolumen});
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(0, 0);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(779, 297);
            this.dgvDatos.TabIndex = 0;
            // 
            // clmAristaA
            // 
            this.clmAristaA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmAristaA.HeaderText = "Arista A";
            this.clmAristaA.Name = "clmAristaA";
            this.clmAristaA.ReadOnly = true;
            // 
            // clmAristaB
            // 
            this.clmAristaB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmAristaB.HeaderText = "Arista B";
            this.clmAristaB.Name = "clmAristaB";
            this.clmAristaB.ReadOnly = true;
            // 
            // clmAristaC
            // 
            this.clmAristaC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmAristaC.HeaderText = "Arista C";
            this.clmAristaC.Name = "clmAristaC";
            this.clmAristaC.ReadOnly = true;
            // 
            // clmColorRelleno
            // 
            this.clmColorRelleno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmColorRelleno.HeaderText = "Color Relleno";
            this.clmColorRelleno.Name = "clmColorRelleno";
            this.clmColorRelleno.ReadOnly = true;
            // 
            // clmArea
            // 
            this.clmArea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmArea.HeaderText = "Area";
            this.clmArea.Name = "clmArea";
            this.clmArea.ReadOnly = true;
            // 
            // clmVolumen
            // 
            this.clmVolumen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmVolumen.DefaultCellStyle = dataGridViewCellStyle8;
            this.clmVolumen.HeaderText = "Volumen";
            this.clmVolumen.Name = "clmVolumen";
            this.clmVolumen.ReadOnly = true;
            this.clmVolumen.Width = 73;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbBorrar,
            this.tsbEditar,
            this.toolStripSeparator1,
            this.tsbFiltrar,
            this.tsbRefrescar,
            this.toolStripSeparator2,
            this.tsbOrdenar,
            this.toolStripSeparator3,
            this.tsbSalir,
            this.toolStripSeparator4});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(779, 25);
            this.toolStrip2.TabIndex = 14;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(46, 22);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbBorrar
            // 
            this.tsbBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBorrar.Name = "tsbBorrar";
            this.tsbBorrar.Size = new System.Drawing.Size(43, 22);
            this.tsbBorrar.Text = "Borrar";
            this.tsbBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbBorrar.Click += new System.EventHandler(this.tsbBorrar_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(41, 22);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbFiltrar
            // 
            this.tsbFiltrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sexoToolStripMenuItem,
            this.localidadToolStripMenuItem,
            this.comienzanConToolStripMenuItem});
            this.tsbFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFiltrar.Name = "tsbFiltrar";
            this.tsbFiltrar.Size = new System.Drawing.Size(50, 22);
            this.tsbFiltrar.Text = "Filtrar";
            this.tsbFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // sexoToolStripMenuItem
            // 
            this.sexoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masculinoToolStripMenuItem,
            this.femeninoToolStripMenuItem});
            this.sexoToolStripMenuItem.Name = "sexoToolStripMenuItem";
            this.sexoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.sexoToolStripMenuItem.Text = "Sexo";
            // 
            // masculinoToolStripMenuItem
            // 
            this.masculinoToolStripMenuItem.Name = "masculinoToolStripMenuItem";
            this.masculinoToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.masculinoToolStripMenuItem.Text = "Masculino";
            // 
            // femeninoToolStripMenuItem
            // 
            this.femeninoToolStripMenuItem.Name = "femeninoToolStripMenuItem";
            this.femeninoToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.femeninoToolStripMenuItem.Text = "Femenino";
            // 
            // localidadToolStripMenuItem
            // 
            this.localidadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscboLocalidades});
            this.localidadToolStripMenuItem.Name = "localidadToolStripMenuItem";
            this.localidadToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.localidadToolStripMenuItem.Text = "Localidad";
            // 
            // tscboLocalidades
            // 
            this.tscboLocalidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscboLocalidades.Name = "tscboLocalidades";
            this.tscboLocalidades.Size = new System.Drawing.Size(121, 23);
            // 
            // comienzanConToolStripMenuItem
            // 
            this.comienzanConToolStripMenuItem.Name = "comienzanConToolStripMenuItem";
            this.comienzanConToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.comienzanConToolStripMenuItem.Text = "Comienzan con...";
            // 
            // tsbRefrescar
            // 
            this.tsbRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefrescar.Name = "tsbRefrescar";
            this.tsbRefrescar.Size = new System.Drawing.Size(59, 22);
            this.tsbRefrescar.Text = "Refrescar";
            this.tsbRefrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbRefrescar.Click += new System.EventHandler(this.tsbRefrescar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbOrdenar
            // 
            this.tsbOrdenar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aZToolStripMenuItem,
            this.zAToolStripMenuItem,
            this.caracteresToolStripMenuItem,
            this.edadToolStripMenuItem});
            this.tsbOrdenar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOrdenar.Name = "tsbOrdenar";
            this.tsbOrdenar.Size = new System.Drawing.Size(63, 22);
            this.tsbOrdenar.Text = "Ordenar";
            this.tsbOrdenar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // aZToolStripMenuItem
            // 
            this.aZToolStripMenuItem.Name = "aZToolStripMenuItem";
            this.aZToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.aZToolStripMenuItem.Text = "A-Z";
            // 
            // zAToolStripMenuItem
            // 
            this.zAToolStripMenuItem.Name = "zAToolStripMenuItem";
            this.zAToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.zAToolStripMenuItem.Text = "Z-A";
            // 
            // caracteresToolStripMenuItem
            // 
            this.caracteresToolStripMenuItem.Name = "caracteresToolStripMenuItem";
            this.caracteresToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.caracteresToolStripMenuItem.Text = "Caracteres";
            // 
            // edadToolStripMenuItem
            // 
            this.edadToolStripMenuItem.Name = "edadToolStripMenuItem";
            this.edadToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.edadToolStripMenuItem.Text = "Edad";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSalir
            // 
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(33, 22);
            this.tsbSalir.Text = "Salir";
            this.tsbSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(580, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cantidad Registros:";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 322);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "frmPrincipal";
            this.Text = "Menu Principal";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAristaA;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAristaB;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAristaC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmColorRelleno;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmVolumen;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbBorrar;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton tsbFiltrar;
        private System.Windows.Forms.ToolStripMenuItem sexoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masculinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem femeninoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox tscboLocalidades;
        private System.Windows.Forms.ToolStripMenuItem comienzanConToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbRefrescar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton tsbOrdenar;
        private System.Windows.Forms.ToolStripMenuItem aZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caracteresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Label label1;
    }
}

