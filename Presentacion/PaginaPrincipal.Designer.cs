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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaPrincipal));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
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
            this.botonEliminar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FiltroLabel = new System.Windows.Forms.Label();
            this.textFiltro = new System.Windows.Forms.TextBox();
            this.comboBoxCampo = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCriterio = new System.Windows.Forms.ComboBox();
            this.textFiltroA = new System.Windows.Forms.TextBox();
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
            this.aboutToolStripMenuItem,
            this.aboutMaxiToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1084, 28);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linkedInToolStripMenuItem,
            this.instagramToolStripMenuItem,
            this.miPortfolioToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
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
            this.aboutMaxiToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
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
            this.label1.Location = new System.Drawing.Point(40, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Productos";
            // 
            // EditarBoton
            // 
            this.EditarBoton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EditarBoton.Location = new System.Drawing.Point(386, 395);
            this.EditarBoton.Name = "EditarBoton";
            this.EditarBoton.Size = new System.Drawing.Size(159, 30);
            this.EditarBoton.TabIndex = 5;
            this.EditarBoton.Text = "Editar Producto ";
            this.EditarBoton.UseVisualStyleBackColor = true;
            this.EditarBoton.Click += new System.EventHandler(this.button2_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.botonEliminar.Location = new System.Drawing.Point(551, 395);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(144, 30);
            this.botonEliminar.TabIndex = 6;
            this.botonEliminar.Text = "Eliminar Producto";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(214, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Agregar Producto";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Location = new System.Drawing.Point(717, 48);
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
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(42, 164);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(653, 225);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged_1);
            // 
            // FiltroLabel
            // 
            this.FiltroLabel.AutoSize = true;
            this.FiltroLabel.Location = new System.Drawing.Point(374, 139);
            this.FiltroLabel.Name = "FiltroLabel";
            this.FiltroLabel.Size = new System.Drawing.Size(117, 16);
            this.FiltroLabel.TabIndex = 8;
            this.FiltroLabel.Text = "Busqueda Rapida";
            // 
            // textFiltro
            // 
            this.textFiltro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textFiltro.Location = new System.Drawing.Point(497, 136);
            this.textFiltro.Name = "textFiltro";
            this.textFiltro.Size = new System.Drawing.Size(198, 22);
            this.textFiltro.TabIndex = 9;
            this.textFiltro.TextChanged += new System.EventHandler(this.textFiltro_TextChanged);
            // 
            // comboBoxCampo
            // 
            this.comboBoxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCampo.FormattingEnabled = true;
            this.comboBoxCampo.Location = new System.Drawing.Point(109, 490);
            this.comboBoxCampo.Name = "comboBoxCampo";
            this.comboBoxCampo.Size = new System.Drawing.Size(168, 24);
            this.comboBoxCampo.TabIndex = 10;
            this.comboBoxCampo.SelectedIndexChanged += new System.EventHandler(this.comboBoxCampo_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(788, 490);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 25);
            this.button2.TabIndex = 11;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 494);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Filtro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Campo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 494);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Criterio";
            // 
            // comboBoxCriterio
            // 
            this.comboBoxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCriterio.FormattingEnabled = true;
            this.comboBoxCriterio.Location = new System.Drawing.Point(362, 490);
            this.comboBoxCriterio.Name = "comboBoxCriterio";
            this.comboBoxCriterio.Size = new System.Drawing.Size(168, 24);
            this.comboBoxCriterio.TabIndex = 16;
            // 
            // textFiltroA
            // 
            this.textFiltroA.Location = new System.Drawing.Point(602, 493);
            this.textFiltroA.Name = "textFiltroA";
            this.textFiltroA.Size = new System.Drawing.Size(156, 22);
            this.textFiltroA.TabIndex = 17;
            this.textFiltroA.TextChanged += new System.EventHandler(this.textFiltroA_TextChanged);
            // 
            // PaginaPrincipal
            // 
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1084, 609);
            this.Controls.Add(this.textFiltroA);
            this.Controls.Add(this.comboBoxCriterio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxCampo);
            this.Controls.Add(this.textFiltro);
            this.Controls.Add(this.FiltroLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botonEliminar);
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

  
        private System.Windows.Forms.ToolStripMenuItem aboutMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkedlnToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkedInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instagramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miPortfolioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMaxiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instagramToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem campusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EditarBoton;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label FiltroLabel;
        private System.Windows.Forms.TextBox textFiltro;
        private System.Windows.Forms.ComboBox comboBoxCampo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCriterio;
        private System.Windows.Forms.TextBox textFiltroA;
    }
}

