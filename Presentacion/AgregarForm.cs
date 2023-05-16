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
using Dominio;
using Negocio;


namespace Presentacion
{
    public partial class AgregarForm : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;
        public AgregarForm()
        {
            InitializeComponent();
        }
        public AgregarForm(Articulo arti)
        {
            InitializeComponent();
            this.articulo = arti;
            Text = "Modificar Articulo";
        }

        private void BotonVolverAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BotonConfirmarAgregar_Click(object sender, EventArgs e)
        {
            Articulo arti = new Articulo();
            ArticuloNegocio negocio =new ArticuloNegocio();
            try
            {
                if (articulo == null)
                    articulo = new Articulo();
                articulo.Nombre = textNombre.Text;
                articulo.Codigo = textCodigo.Text;
                articulo.Descripcion = textDescripcion.Text;
                articulo.DescripcionM = (Marca)comboMarca.SelectedItem;
                articulo.DescripcionC = (Categoria)comboCategoria.SelectedItem;

                if (articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado Exitosamente");
                    Close();

                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado exitosamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

          
        }

        private void AgregarForm_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                comboMarca.DataSource = marcaNegocio.listarM();
                comboMarca.ValueMember = "Id";
                comboMarca.DisplayMember = "DescripcionM";

                comboCategoria.DataSource = categoriaNegocio.listarC();
                comboCategoria.ValueMember = "Id";
                comboCategoria.DisplayMember = "DescripcionC";

                if (articulo!= null)
                {
                    textCodigo.Text = articulo.Codigo;
                    textNombre.Text = articulo.Nombre;
                    textDescripcion.Text = articulo.Descripcion;
                    textImagen.Text = articulo.Imagen;
                    textPrecio.Text = articulo.Precio.ToString();
                    cargarImagen(articulo.Imagen);
                    comboMarca.SelectedValue = articulo.DescripcionM.Id;
                    comboCategoria.SelectedValue = articulo.DescripcionC.Id;
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
                pictureBoxImagenAgregar.Load(imagen);
                }
                catch (Exception ex)
                {
                pictureBoxImagenAgregar.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
                }
        }







        private void toolStripMenuItem4_Click(object sender, EventArgs e) // boton editar del menu desplegable
        {
            EditarForm editarVentana = new EditarForm();
            editarVentana.ShowDialog();
        }
        private void borrarToolStripMenuItem_Click(object sender, EventArgs e) // boton eliminar del menu desplegable
        {
            EliminarForm eliminarVentana = new EliminarForm();
            eliminarVentana.ShowDialog();
        }

        private void linkedInToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void instagramToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void miPortfolioToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void instagramToolStripMenuItem1_Click_1(object sender, EventArgs e)
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

        private void campusToolStripMenuItem_Click_1(object sender, EventArgs e)
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
    
    




