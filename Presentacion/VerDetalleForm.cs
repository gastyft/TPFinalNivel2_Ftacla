using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using Negocio;

namespace Presentacion
{
    public partial class VerDetalleForm : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;
        public VerDetalleForm(Articulo arti)
        {
            InitializeComponent();
            this.articulo = arti;
            Text = "Ver Detalle";
        }

        private void VerDetalleForm_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                DetalleComboMarca.DataSource = marcaNegocio.listarM();
                DetalleComboMarca.ValueMember = "Id";
                DetalleComboMarca.DisplayMember = "DescripcionM";
               
                DetalleComboCategoria.DataSource = categoriaNegocio.listarC();
                DetalleComboCategoria.ValueMember = "Id";
                DetalleComboCategoria.DisplayMember = "DescripcionC";

                if (articulo != null)
                {
                    DetalleCodigo.Text = articulo.Codigo;
                    DetalleNombre.Text = articulo.Nombre;
                    DetalleDescripcion.Text = articulo.Descripcion;
                 
                    DetallePrecio.Text = articulo.Precio.ToString();
                    cargarImagen(articulo.Imagen);
                    DetalleComboMarca.SelectedValue = articulo.DescripcionM.Id;
                    DetalleComboCategoria.SelectedValue = articulo.DescripcionC.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBoxImagenDetalle.Load(imagen);
            }
            catch (Exception ex)
            {
                pictureBoxImagenDetalle.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void BotonVolverAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkedInToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                VisitLinkLinkedln();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }
        private void VisitLinkLinkedln()
        {

            System.Diagnostics.Process.Start("https://www.linkedin.com/in/gaston-manuel-ftacla-04b57b229/");

        }

        private void instagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                VisitLinkInstagram();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void VisitLinkInstagram()
        {

            System.Diagnostics.Process.Start("https://www.instagram.com/gastyftacla/");

        }

        private void miPortfolioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                VisitLinkPortfolio();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void VisitLinkPortfolio()
        {

            System.Diagnostics.Process.Start("https://portfolio-yo-programo.web.app/principal");

        }

        private void instagramToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                VisitLinkInstagramMaxi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }

        }
        private void VisitLinkInstagramMaxi()
        {

            System.Diagnostics.Process.Start("https://www.instagram.com/maxiprograma/");

        }

        private void campusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                VisitLinkCampus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }


        }

        private void VisitLinkCampus()
        {

            System.Diagnostics.Process.Start("https://campusmaxiprograma.com/");

        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                VisitLinkCursosMaxi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }

        }
        private void VisitLinkCursosMaxi()
        {

            System.Diagnostics.Process.Start("https://maxiprograma.com/");

        }
    }

    
    }



