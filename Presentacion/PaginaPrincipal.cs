using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using Dominio;
using Negocio;
namespace Presentacion
{
    public partial class PaginaPrincipal : Form
    {

        private List<Articulo> listaArticulo;   
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {
            cargar();
            MessageBox.Show("Bienvenido a la App..", "Mensaje Bienvenida");
            ArticuloNegocio negocio = new ArticuloNegocio();
          
           


        }
        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dataGridView1.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.Imagen);
            }
       
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBox1.Load(imagen);
            }
            catch (Exception ex)
            {
                pictureBox1.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }
        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulo = negocio.listar();
                dataGridView1.DataSource = listaArticulo;
                ocultarColumnas();
                cargarImagen(listaArticulo[0].Imagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void ocultarColumnas()
        {
            dataGridView1.Columns["Imagen"].Visible = false;
            dataGridView1.Columns["Id"].Visible = false;
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

        private void button1_Click(object sender, EventArgs e) //boton agregar
        {
            AgregarForm agregarVentana = new AgregarForm();
            agregarVentana.ShowDialog();
            cargar();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e) // boton agregar del menu desplegable
        {
            AgregarForm agregarVentana = new AgregarForm();
            agregarVentana.ShowDialog();
            cargar();
        }

        private void button2_Click(object sender, EventArgs e) //boton editar
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dataGridView1.CurrentRow.DataBoundItem;
            EditarForm editarVentana = new EditarForm();
            editarVentana.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e) // boton editar del menu desplegable
        {
            EditarForm editarVentana = new EditarForm();
            editarVentana.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) // boton eliminar
        {
            EliminarForm eliminarVentana = new EliminarForm();
            eliminarVentana.ShowDialog();
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e) // boton eliminar del menu desplegable
        {
            EliminarForm eliminarVentana = new EliminarForm();
            eliminarVentana.ShowDialog();
        }

        private void PaginaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Quiere cerrar el formulario?", "Mensaje de la App",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        
    }



   


}


