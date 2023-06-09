﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using System.IO;
using Dominio;
using Negocio;


namespace Presentacion
{
    public partial class PaginaPrincipal : Form
    {

        private List<Articulo> listaArticulo;
        private OpenFileDialog archivo;

        public PaginaPrincipal()
        {
            InitializeComponent();
        }


        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {
            cargar();
            MessageBox.Show("Bienvenido a la App..", "Mensaje Bienvenida");
            ArticuloNegocio negocio = new ArticuloNegocio();
          comboBoxCampo.Items.Add("Precio");
            comboBoxCampo.Items.Add("Marca");
            comboBoxCampo.Items.Add("Categoría");
            comboBoxCampo.Items.Add("Nombre");


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

        private void linkedInToolStripMenuItem_Click(object sender, EventArgs e) //Links
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
                AgregarForm editarVentana = new AgregarForm(seleccionado);
                editarVentana.ShowDialog();
                cargar();
            
            
              
            
          
        }

       

        private void button3_Click(object sender, EventArgs e) // boton eliminar
        {
            eliminar();
        }

     

        private void PaginaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Quiere cerrar el formulario?", "Mensaje de la App",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void eliminar(bool logico = false)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dataGridView1.CurrentRow.DataBoundItem;

                        negocio.eliminar(seleccionado.Id);
                   
                        
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        } 
     
      

        private void textFiltro_TextChanged(object sender, EventArgs e) //Text box de filtro rapido
        {
            List<Articulo> listaFiltrada;
            string filtro = textFiltro.Text;

            if (filtro.Length >= 3)
            {
                listaFiltrada = listaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Descripcion.ToUpper().Contains(filtro.ToUpper()));
           
            }
            else
            {
                listaFiltrada = listaArticulo;
                
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaFiltrada;
           
            ocultarColumnas();
        }

        private void comboBoxCampo_SelectedIndexChanged(object sender, EventArgs e) // combo box de campo 
        {
            string opcion = comboBoxCampo.SelectedItem.ToString();
            if(opcion == "Precio")
            {
                comboBoxCriterio.Items.Clear();
                comboBoxCriterio.Items.Add("Mayor a");
                comboBoxCriterio.Items.Add("Menor a");
                comboBoxCriterio.Items.Add("Igual a");
            }
            else 
            {
                 comboBoxCriterio.Items.Clear();
                 comboBoxCriterio.Items.Add("Comienza con");
                 comboBoxCriterio.Items.Add("Termina con");
                 comboBoxCriterio.Items.Add("Contiene");
                }
         
            }

       

        private void button2_Click_1(object sender, EventArgs e) //Boton Filtro Avanzado
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarFiltro())
                    return;

                string campo = comboBoxCampo.SelectedItem.ToString();
                string criterio = comboBoxCriterio.SelectedItem.ToString();
                string filtro = textFiltroA.Text;
                dataGridView1.DataSource = negocio.filtrar(campo, criterio, filtro);

            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private bool validarFiltro() 
        {
            if (comboBoxCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar.");
                return true;
            }
            if (comboBoxCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el criterio para filtrar.");
                return true;
            }
            if (comboBoxCampo.SelectedItem.ToString() == "Número")
            {
                if (string.IsNullOrEmpty(textFiltroA.Text))
                {
                    MessageBox.Show("Debes cargar el filtro para numéricos...");
                    return true;
                }
                if (!(soloNumeros(textFiltroA.Text)))
                {
                    MessageBox.Show("Solo nros para filtrar por un campo numérico...");
                    return true;
                }

            }

            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void textFiltroA_TextChanged(object sender, EventArgs e)  //Text box Filtro Avanzado
        {
            List<Articulo> listaFiltrada;
            string filtro = textFiltro.Text;

            if (filtro.Length >= 3)
            {
                listaFiltrada = listaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Descripcion.ToUpper().Contains(filtro.ToUpper()));

            }
            else
            {
                listaFiltrada = listaArticulo;
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaFiltrada;
            ocultarColumnas();
        }



    }



}







