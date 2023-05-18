namespace Presentacion
{
    partial class VerDetalleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerDetalleForm));
            this.pictureBoxImagenDetalle = new System.Windows.Forms.PictureBox();
            this.BotonVolverAtras = new System.Windows.Forms.Button();
            this.DetalleComboCategoria = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DetallePrecio = new System.Windows.Forms.TextBox();
            this.DetalleDescripcion = new System.Windows.Forms.TextBox();
            this.DetalleCodigo = new System.Windows.Forms.TextBox();
            this.DetalleComboMarca = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DetalleNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkedInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instagramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miPortfolioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMaxiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instagramToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.campusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenDetalle)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxImagenDetalle
            // 
            this.pictureBoxImagenDetalle.Location = new System.Drawing.Point(598, 34);
            this.pictureBoxImagenDetalle.Name = "pictureBoxImagenDetalle";
            this.pictureBoxImagenDetalle.Size = new System.Drawing.Size(350, 350);
            this.pictureBoxImagenDetalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagenDetalle.TabIndex = 36;
            this.pictureBoxImagenDetalle.TabStop = false;
            // 
            // BotonVolverAtras
            // 
            this.BotonVolverAtras.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BotonVolverAtras.Location = new System.Drawing.Point(320, 404);
            this.BotonVolverAtras.Name = "BotonVolverAtras";
            this.BotonVolverAtras.Size = new System.Drawing.Size(171, 49);
            this.BotonVolverAtras.TabIndex = 33;
            this.BotonVolverAtras.Text = "Volver atrás";
            this.BotonVolverAtras.UseVisualStyleBackColor = true;
            this.BotonVolverAtras.Click += new System.EventHandler(this.BotonVolverAtras_Click);
            // 
            // DetalleComboCategoria
            // 
            this.DetalleComboCategoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DetalleComboCategoria.BackColor = System.Drawing.SystemColors.Info;
            this.DetalleComboCategoria.Cursor = System.Windows.Forms.Cursors.Default;
            this.DetalleComboCategoria.Enabled = false;
            this.DetalleComboCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetalleComboCategoria.ForeColor = System.Drawing.SystemColors.Info;
            this.DetalleComboCategoria.FormattingEnabled = true;
            this.DetalleComboCategoria.Location = new System.Drawing.Point(261, 357);
            this.DetalleComboCategoria.Name = "DetalleComboCategoria";
            this.DetalleComboCategoria.Size = new System.Drawing.Size(293, 26);
            this.DetalleComboCategoria.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(116, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "Categoria";
            // 
            // DetallePrecio
            // 
            this.DetallePrecio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DetallePrecio.BackColor = System.Drawing.SystemColors.Info;
            this.DetallePrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetallePrecio.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DetallePrecio.Location = new System.Drawing.Point(261, 283);
            this.DetallePrecio.Name = "DetallePrecio";
            this.DetallePrecio.ReadOnly = true;
            this.DetallePrecio.Size = new System.Drawing.Size(293, 24);
            this.DetallePrecio.TabIndex = 25;
            // 
            // DetalleDescripcion
            // 
            this.DetalleDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DetalleDescripcion.BackColor = System.Drawing.SystemColors.Info;
            this.DetalleDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetalleDescripcion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DetalleDescripcion.Location = new System.Drawing.Point(261, 114);
            this.DetalleDescripcion.Multiline = true;
            this.DetalleDescripcion.Name = "DetalleDescripcion";
            this.DetalleDescripcion.ReadOnly = true;
            this.DetalleDescripcion.Size = new System.Drawing.Size(293, 115);
            this.DetalleDescripcion.TabIndex = 22;
            // 
            // DetalleCodigo
            // 
            this.DetalleCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DetalleCodigo.BackColor = System.Drawing.SystemColors.Info;
            this.DetalleCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetalleCodigo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DetalleCodigo.Location = new System.Drawing.Point(261, 73);
            this.DetalleCodigo.Name = "DetalleCodigo";
            this.DetalleCodigo.ReadOnly = true;
            this.DetalleCodigo.Size = new System.Drawing.Size(293, 24);
            this.DetalleCodigo.TabIndex = 21;
            // 
            // DetalleComboMarca
            // 
            this.DetalleComboMarca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DetalleComboMarca.BackColor = System.Drawing.SystemColors.Info;
            this.DetalleComboMarca.Cursor = System.Windows.Forms.Cursors.Default;
            this.DetalleComboMarca.Enabled = false;
            this.DetalleComboMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetalleComboMarca.ForeColor = System.Drawing.SystemColors.Info;
            this.DetalleComboMarca.FormattingEnabled = true;
            this.DetalleComboMarca.Location = new System.Drawing.Point(261, 314);
            this.DetalleComboMarca.Name = "DetalleComboMarca";
            this.DetalleComboMarca.Size = new System.Drawing.Size(293, 26);
            this.DetalleComboMarca.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "Marca:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Codigo Articulo:";
            // 
            // DetalleNombre
            // 
            this.DetalleNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DetalleNombre.BackColor = System.Drawing.SystemColors.Info;
            this.DetalleNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetalleNombre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DetalleNombre.HideSelection = false;
            this.DetalleNombre.Location = new System.Drawing.Point(261, 34);
            this.DetalleNombre.Name = "DetalleNombre";
            this.DetalleNombre.ReadOnly = true;
            this.DetalleNombre.Size = new System.Drawing.Size(293, 24);
            this.DetalleNombre.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nombre Articulo:";
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
            this.menuStrip2.Size = new System.Drawing.Size(1008, 28);
            this.menuStrip2.TabIndex = 37;
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
            this.linkedInToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.linkedInToolStripMenuItem.Text = "LinkedIn";
            this.linkedInToolStripMenuItem.ToolTipText = "Linkedln Gastón Ftacla";
            this.linkedInToolStripMenuItem.Click += new System.EventHandler(this.linkedInToolStripMenuItem_Click);
            // 
            // instagramToolStripMenuItem
            // 
            this.instagramToolStripMenuItem.Image = global::Presentacion.Properties.Resources.Instagram_logo_20221;
            this.instagramToolStripMenuItem.Name = "instagramToolStripMenuItem";
            this.instagramToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.instagramToolStripMenuItem.Text = "Instagram";
            this.instagramToolStripMenuItem.ToolTipText = "Instagram Gastón Ftacla";
            this.instagramToolStripMenuItem.Click += new System.EventHandler(this.instagramToolStripMenuItem_Click);
            // 
            // miPortfolioToolStripMenuItem
            // 
            this.miPortfolioToolStripMenuItem.Image = global::Presentacion.Properties.Resources.portfolio;
            this.miPortfolioToolStripMenuItem.Name = "miPortfolioToolStripMenuItem";
            this.miPortfolioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
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
            this.instagramToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.instagramToolStripMenuItem1.Text = "Instagram";
            this.instagramToolStripMenuItem1.ToolTipText = "Instagram de MaxiPrograma";
            this.instagramToolStripMenuItem1.Click += new System.EventHandler(this.instagramToolStripMenuItem1_Click);
            // 
            // campusToolStripMenuItem
            // 
            this.campusToolStripMenuItem.Image = global::Presentacion.Properties.Resources.png_clipart_moodle_android_educational_icon_text_orange;
            this.campusToolStripMenuItem.Name = "campusToolStripMenuItem";
            this.campusToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.campusToolStripMenuItem.Text = "Campus";
            this.campusToolStripMenuItem.ToolTipText = "Campus cursos de MaxiPrograma";
            this.campusToolStripMenuItem.Click += new System.EventHandler(this.campusToolStripMenuItem_Click);
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.Image = global::Presentacion.Properties.Resources.cursos;
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cursosToolStripMenuItem.Text = "Cursos";
            this.cursosToolStripMenuItem.ToolTipText = "Lista de cursos disponibles de MaxiPrograma";
            this.cursosToolStripMenuItem.Click += new System.EventHandler(this.cursosToolStripMenuItem_Click);
            // 
            // VerDetalleForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1008, 497);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.pictureBoxImagenDetalle);
            this.Controls.Add(this.BotonVolverAtras);
            this.Controls.Add(this.DetalleComboCategoria);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DetallePrecio);
            this.Controls.Add(this.DetalleDescripcion);
            this.Controls.Add(this.DetalleCodigo);
            this.Controls.Add(this.DetalleComboMarca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DetalleNombre);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VerDetalleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerDetalleForm";
            this.Load += new System.EventHandler(this.VerDetalleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenDetalle)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImagenDetalle;
        private System.Windows.Forms.Button BotonVolverAtras;
        private System.Windows.Forms.ComboBox DetalleComboCategoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DetallePrecio;
        private System.Windows.Forms.TextBox DetalleDescripcion;
        private System.Windows.Forms.TextBox DetalleCodigo;
        private System.Windows.Forms.ComboBox DetalleComboMarca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DetalleNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkedInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instagramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miPortfolioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMaxiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instagramToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem campusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
    }
}