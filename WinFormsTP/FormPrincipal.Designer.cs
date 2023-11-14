namespace WinFormsTP
{
    partial class FormPrincipal
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
            panel1 = new Panel();
            txtCantidad = new TextBox();
            Cantidad = new Label();
            toolStrip1 = new ToolStrip();
            TsbNuevo = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            TsbBorrar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            TsbEditar = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            TsbFiltrar = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            TsbRefrescar = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            tsbOrdenar = new ToolStripDropDownButton();
            Lado1ToolStripMenuItem = new ToolStripMenuItem();
            ascendenteL1ToolStripMenuItem1 = new ToolStripMenuItem();
            descendenteL1ToolStripMenuItem1 = new ToolStripMenuItem();
            Lado2ToolStripMenuItem = new ToolStripMenuItem();
            ascendenteL2ToolStripMenuItem2 = new ToolStripMenuItem();
            descendenteL2ToolStripMenuItem2 = new ToolStripMenuItem();
            panel2 = new Panel();
            dgvDatos = new DataGridView();
            colRadio = new DataGridViewTextBoxColumn();
            colBorde = new DataGridViewTextBoxColumn();
            colColor = new DataGridViewTextBoxColumn();
            ColArea = new DataGridViewTextBoxColumn();
            ColVolumen = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtCantidad);
            panel1.Controls.Add(Cantidad);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 391);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 59);
            panel1.TabIndex = 0;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(105, 20);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.ReadOnly = true;
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 2;
            txtCantidad.TextAlign = HorizontalAlignment.Right;
            // 
            // Cantidad
            // 
            Cantidad.AutoSize = true;
            Cantidad.Location = new Point(24, 23);
            Cantidad.Name = "Cantidad";
            Cantidad.Size = new Size(58, 15);
            Cantidad.TabIndex = 1;
            Cantidad.Text = "Cantidad:";
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { TsbNuevo, toolStripSeparator1, TsbBorrar, toolStripSeparator2, TsbEditar, toolStripSeparator3, TsbFiltrar, toolStripSeparator4, TsbRefrescar, toolStripSeparator5, tsbOrdenar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 54);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // TsbNuevo
            // 
            TsbNuevo.Image = Properties.Resources.NewCopy;
            TsbNuevo.ImageAlign = ContentAlignment.TopCenter;
            TsbNuevo.ImageScaling = ToolStripItemImageScaling.None;
            TsbNuevo.ImageTransparentColor = Color.Magenta;
            TsbNuevo.Name = "TsbNuevo";
            TsbNuevo.Size = new Size(53, 51);
            TsbNuevo.Text = "Agregar";
            TsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbNuevo.Click += TsbNuevo_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 54);
            // 
            // TsbBorrar
            // 
            TsbBorrar.Image = Properties.Resources.Delete;
            TsbBorrar.ImageAlign = ContentAlignment.TopCenter;
            TsbBorrar.ImageScaling = ToolStripItemImageScaling.None;
            TsbBorrar.ImageTransparentColor = Color.Magenta;
            TsbBorrar.Name = "TsbBorrar";
            TsbBorrar.Size = new Size(54, 51);
            TsbBorrar.Text = "Eliminar";
            TsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbBorrar.Click += TsbBorrar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 54);
            // 
            // TsbEditar
            // 
            TsbEditar.Image = Properties.Resources.Edit;
            TsbEditar.ImageAlign = ContentAlignment.TopCenter;
            TsbEditar.ImageScaling = ToolStripItemImageScaling.None;
            TsbEditar.ImageTransparentColor = Color.Magenta;
            TsbEditar.Name = "TsbEditar";
            TsbEditar.Size = new Size(41, 51);
            TsbEditar.Text = "Editar";
            TsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbEditar.Click += TsbEditar_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 54);
            // 
            // TsbFiltrar
            // 
            TsbFiltrar.Image = Properties.Resources.Filter;
            TsbFiltrar.ImageAlign = ContentAlignment.TopCenter;
            TsbFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            TsbFiltrar.ImageTransparentColor = Color.Magenta;
            TsbFiltrar.Name = "TsbFiltrar";
            TsbFiltrar.Size = new Size(41, 51);
            TsbFiltrar.Text = "Filtrar";
            TsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbFiltrar.Click += TsbFiltrar_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 54);
            // 
            // TsbRefrescar
            // 
            TsbRefrescar.Image = Properties.Resources.Refresh;
            TsbRefrescar.ImageAlign = ContentAlignment.TopCenter;
            TsbRefrescar.ImageScaling = ToolStripItemImageScaling.None;
            TsbRefrescar.ImageTransparentColor = Color.Magenta;
            TsbRefrescar.Name = "TsbRefrescar";
            TsbRefrescar.Size = new Size(59, 51);
            TsbRefrescar.Text = "Refrescar";
            TsbRefrescar.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbRefrescar.Click += TsbRefrescar_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 54);
            // 
            // tsbOrdenar
            // 
            tsbOrdenar.DropDownItems.AddRange(new ToolStripItem[] { Lado1ToolStripMenuItem, Lado2ToolStripMenuItem });
            tsbOrdenar.Image = Properties.Resources.Sort;
            tsbOrdenar.ImageAlign = ContentAlignment.TopCenter;
            tsbOrdenar.ImageScaling = ToolStripItemImageScaling.None;
            tsbOrdenar.ImageTransparentColor = Color.Magenta;
            tsbOrdenar.Name = "tsbOrdenar";
            tsbOrdenar.Size = new Size(63, 51);
            tsbOrdenar.Text = "Ordenar";
            tsbOrdenar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // Lado1ToolStripMenuItem
            // 
            Lado1ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ascendenteL1ToolStripMenuItem1, descendenteL1ToolStripMenuItem1 });
            Lado1ToolStripMenuItem.Image = Properties.Resources.MenorAMayor;
            Lado1ToolStripMenuItem.Name = "Lado1ToolStripMenuItem";
            Lado1ToolStripMenuItem.Size = new Size(109, 22);
            Lado1ToolStripMenuItem.Text = "Lado 1";
            // 
            // ascendenteL1ToolStripMenuItem1
            // 
            ascendenteL1ToolStripMenuItem1.Name = "ascendenteL1ToolStripMenuItem1";
            ascendenteL1ToolStripMenuItem1.Size = new Size(142, 22);
            ascendenteL1ToolStripMenuItem1.Text = "Ascendente";
            ascendenteL1ToolStripMenuItem1.Click += ascendenteL1ToolStripMenuItem1_Click;
            // 
            // descendenteL1ToolStripMenuItem1
            // 
            descendenteL1ToolStripMenuItem1.Name = "descendenteL1ToolStripMenuItem1";
            descendenteL1ToolStripMenuItem1.Size = new Size(142, 22);
            descendenteL1ToolStripMenuItem1.Text = "Descendente";
            descendenteL1ToolStripMenuItem1.Click += descendenteL1ToolStripMenuItem1_Click;
            // 
            // Lado2ToolStripMenuItem
            // 
            Lado2ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ascendenteL2ToolStripMenuItem2, descendenteL2ToolStripMenuItem2 });
            Lado2ToolStripMenuItem.Image = Properties.Resources.MayorAMenor;
            Lado2ToolStripMenuItem.Name = "Lado2ToolStripMenuItem";
            Lado2ToolStripMenuItem.Size = new Size(109, 22);
            Lado2ToolStripMenuItem.Text = "Lado 2";
            // 
            // ascendenteL2ToolStripMenuItem2
            // 
            ascendenteL2ToolStripMenuItem2.Name = "ascendenteL2ToolStripMenuItem2";
            ascendenteL2ToolStripMenuItem2.Size = new Size(142, 22);
            ascendenteL2ToolStripMenuItem2.Text = "Ascendente";
            ascendenteL2ToolStripMenuItem2.Click += ascendenteL2ToolStripMenuItem2_Click;
            // 
            // descendenteL2ToolStripMenuItem2
            // 
            descendenteL2ToolStripMenuItem2.Name = "descendenteL2ToolStripMenuItem2";
            descendenteL2ToolStripMenuItem2.Size = new Size(142, 22);
            descendenteL2ToolStripMenuItem2.Text = "Descendente";
            descendenteL2ToolStripMenuItem2.Click += descendenteL2ToolStripMenuItem2_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvDatos);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 54);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 337);
            panel2.TabIndex = 2;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.BackgroundColor = SystemColors.ButtonFace;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colRadio, colBorde, colColor, ColArea, ColVolumen });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.GridColor = SystemColors.ButtonFace;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(800, 337);
            dgvDatos.TabIndex = 0;
            // 
            // colRadio
            // 
            colRadio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colRadio.HeaderText = "Radio";
            colRadio.Name = "colRadio";
            colRadio.ReadOnly = true;
            colRadio.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colBorde
            // 
            colBorde.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colBorde.HeaderText = "Borde";
            colBorde.Name = "colBorde";
            colBorde.ReadOnly = true;
            colBorde.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colColor
            // 
            colColor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colColor.HeaderText = "Color";
            colColor.Name = "colColor";
            colColor.ReadOnly = true;
            // 
            // ColArea
            // 
            ColArea.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColArea.HeaderText = "Área";
            ColArea.Name = "ColArea";
            ColArea.ReadOnly = true;
            ColArea.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColVolumen
            // 
            ColVolumen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColVolumen.HeaderText = "Perímetro";
            ColVolumen.Name = "ColVolumen";
            ColVolumen.ReadOnly = true;
            ColVolumen.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(toolStrip1);
            Controls.Add(panel1);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            FormClosing += SalirPrograma;
            Load += FormPrincipal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private ToolStrip toolStrip1;
        private ToolStripButton TsbNuevo;
        private Panel panel2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton TsbBorrar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton TsbEditar;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton TsbFiltrar;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton TsbRefrescar;
        private DataGridView dgvDatos;
        private TextBox txtCantidad;
        private Label Cantidad;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripDropDownButton tsbOrdenar;
        private ToolStripMenuItem Lado1ToolStripMenuItem;
        private ToolStripMenuItem Lado2ToolStripMenuItem;
        private ToolStripMenuItem ascendenteL1ToolStripMenuItem1;
        private ToolStripMenuItem descendenteL1ToolStripMenuItem1;
        private ToolStripMenuItem ascendenteL2ToolStripMenuItem2;
        private ToolStripMenuItem descendenteL2ToolStripMenuItem2;
        private DataGridViewTextBoxColumn colRadio;
        private DataGridViewTextBoxColumn colBorde;
        private DataGridViewTextBoxColumn colColor;
        private DataGridViewTextBoxColumn ColArea;
        private DataGridViewTextBoxColumn ColVolumen;
    }
}