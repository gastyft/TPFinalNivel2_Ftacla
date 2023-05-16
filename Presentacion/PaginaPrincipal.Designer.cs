namespace Presentacion
{
    partial class PaginaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verDetalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarArtículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkedInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instagramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miPortfolioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMaxiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instagramToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.campusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.EditarBoton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.Info;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.aboutToolStripMenuItem,
            this.aboutMaxiToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(873, 30);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.borrarToolStripMenuItem,
            this.verDetalleToolStripMenuItem,
            this.buscarArtículosToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(85, 26);
            this.toolStripMenuItem1.Text = "Opciones";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = global::Presentacion.Properties.Resources.png_transparent_white_and_green_cross_icon_computer_icons_apple_icon_format_free_icon_add_s_miscellaneous_computer_network_trademark_thumbnail;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(210, 26);
            this.toolStripMenuItem3.Text = "Agregar Producto";
            this.toolStripMenuItem3.ToolTipText = "Agregar Producto";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem4.Image")));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(210, 26);
            this.toolStripMenuItem4.Text = "Editar Producto";
            this.toolStripMenuItem4.ToolTipText = "Editar Producto";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Image = global::Presentacion.Properties.Resources.trash_solid;
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.borrarToolStripMenuItem.Text = "Borrar Producto";
            this.borrarToolStripMenuItem.ToolTipText = "Borrar Producto";
            this.borrarToolStripMenuItem.Click += new System.EventHandler(this.borrarToolStripMenuItem_Click);
            // 
            // verDetalleToolStripMenuItem
            // 
            this.verDetalleToolStripMenuItem.Image = global::Presentacion.Properties.Resources.ojo;
            this.verDetalleToolStripMenuItem.Name = "verDetalleToolStripMenuItem";
            this.verDetalleToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.verDetalleToolStripMenuItem.Text = "Ver Detalle";
            this.verDetalleToolStripMenuItem.ToolTipText = "Ver Detalle";
            // 
            // buscarArtículosToolStripMenuItem
            // 
            this.buscarArtículosToolStripMenuItem.Image = global::Presentacion.Properties.Resources.buscar;
            this.buscarArtículosToolStripMenuItem.Name = "buscarArtículosToolStripMenuItem";
            this.buscarArtículosToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.buscarArtículosToolStripMenuItem.Text = "Buscar artículos ";
            this.buscarArtículosToolStripMenuItem.ToolTipText = "Buscar";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linkedInToolStripMenuItem,
            this.instagramToolStripMenuItem,
            this.miPortfolioToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(89, 26);
            this.aboutToolStripMenuItem.Text = "About Me";
            // 
            // linkedInToolStripMenuItem
            // 
            this.linkedInToolStripMenuItem.Image = global::Presentacion.Properties.Resources._174857;
            this.linkedInToolStripMenuItem.Name = "linkedInToolStripMenuItem";
            this.linkedInToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.linkedInToolStripMenuItem.Text = "LinkedIn";
            this.linkedInToolStripMenuItem.ToolTipText = "Linkedln Gastón Ftacla";
            this.linkedInToolStripMenuItem.Click += new System.EventHandler(this.linkedInToolStripMenuItem_Click);
            // 
            // instagramToolStripMenuItem
            // 
            this.instagramToolStripMenuItem.Image = global::Presentacion.Properties.Resources.Instagram_logo_20221;
            this.instagramToolStripMenuItem.Name = "instagramToolStripMenuItem";
            this.instagramToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.instagramToolStripMenuItem.Text = "Instagram";
            this.instagramToolStripMenuItem.ToolTipText = "Instagram Gastón Ftacla";
            this.instagramToolStripMenuItem.Click += new System.EventHandler(this.instagramToolStripMenuItem_Click);
            // 
            // miPortfolioToolStripMenuItem
            // 
            this.miPortfolioToolStripMenuItem.Image = global::Presentacion.Properties.Resources.portfolio;
            this.miPortfolioToolStripMenuItem.Name = "miPortfolioToolStripMenuItem";
            this.miPortfolioToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.miPortfolioToolStripMenuItem.Text = "MiPortfolio";
            this.miPortfolioToolStripMenuItem.ToolTipText = "Portfolio Gastón Ftacla";
            this.miPortfolioToolStripMenuItem.Click += new System.EventHandler(this.miPortfolioToolStripMenuItem_Click);
            // 
            // aboutMaxiToolStripMenuItem
            // 
            this.aboutMaxiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instagramToolStripMenuItem1,
            this.campusToolStripMenuItem,
            this.cursosToolStripMenuItem});
            this.aboutMaxiToolStripMenuItem.Name = "aboutMaxiToolStripMenuItem";
            this.aboutMaxiToolStripMenuItem.Size = new System.Drawing.Size(100, 26);
            this.aboutMaxiToolStripMenuItem.Text = "About Maxi";
            // 
            // instagramToolStripMenuItem1
            // 
            this.instagramToolStripMenuItem1.Image = global::Presentacion.Properties.Resources.Instagram_logo_20221;
            this.instagramToolStripMenuItem1.Name = "instagramToolStripMenuItem1";
            this.instagramToolStripMenuItem1.Size = new System.Drawing.Size(158, 26);
            this.instagramToolStripMenuItem1.Text = "Instagram";
            this.instagramToolStripMenuItem1.ToolTipText = "Instagram de MaxiPrograma";
            this.instagramToolStripMenuItem1.Click += new System.EventHandler(this.instagramToolStripMenuItem1_Click);
            // 
            // campusToolStripMenuItem
            // 
            this.campusToolStripMenuItem.Image = global::Presentacion.Properties.Resources.png_clipart_moodle_android_educational_icon_text_orange;
            this.campusToolStripMenuItem.Name = "campusToolStripMenuItem";
            this.campusToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.campusToolStripMenuItem.Text = "Campus";
            this.campusToolStripMenuItem.ToolTipText = "Campus cursos de MaxiPrograma";
            this.campusToolStripMenuItem.Click += new System.EventHandler(this.campusToolStripMenuItem_Click);
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.Image = global::Presentacion.Properties.Resources.cursos;
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.cursosToolStripMenuItem.Text = "Cursos";
            this.cursosToolStripMenuItem.ToolTipText = "Lista de cursos disponibles de MaxiPrograma";
            this.cursosToolStripMenuItem.Click += new System.EventHandler(this.cursosToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Productos";
            // 
            // EditarBoton
            // 
            this.EditarBoton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EditarBoton.Location = new System.Drawing.Point(460, 539);
            this.EditarBoton.Name = "EditarBoton";
            this.EditarBoton.Size = new System.Drawing.Size(159, 30);
            this.EditarBoton.TabIndex = 5;
            this.EditarBoton.Text = "Editar Producto ";
            this.EditarBoton.UseVisualStyleBackColor = true;
            this.EditarBoton.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.Location = new System.Drawing.Point(625, 539);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 30);
            this.button3.TabIndex = 6;
            this.button3.Text = "Eliminar Producto";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(288, 539);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Agregar Producto";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Location = new System.Drawing.Point(264, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 341);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(116, 375);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(653, 158);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged_1);
            // 
            // PaginaPrincipal
            // 
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(873, 609);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.EditarBoton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "PaginaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracion de productos";
            this.TransparencyKey = System.Drawing.Color.Cyan;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PaginaPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.PaginaPrincipal_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkedlnToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkedInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instagramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miPortfolioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMaxiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instagramToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem campusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EditarBoton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem verDetalleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarArtículosToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

