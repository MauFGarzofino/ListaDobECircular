using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrácticaLista1
{
    public partial class Form1 : Form
    {
        TListaAsig Lista1 = new TListaAsig();
        public Form1()
        {
            InitializeComponent();
        }

        private void insertar_Click(object sender, EventArgs e)
        {
            if (nombre.Text == string.Empty || cHoras.Text == string.Empty)
            {
                MessageBox.Show("Ingrese Los Datos");
            }
            else
            {
                Lista1.crearLista(nombre.Text, int.Parse(cHoras.Text));
                prueba.Text = nombre.Text + "    " + int.Parse(cHoras.Text);
                nombre.Text = "";
                cHoras.Text = "";
            }
        }
        
        private void siguiente_Click(object sender, EventArgs e)
        {
            if (Lista1.Vacio())
            {
                MessageBox.Show("Lista Vacía");
            }
            else
            {
                TNodo a;
                a = Lista1.getProxCursor();
                prueba.Text = ((TNodoAsig)a).dameNombre() + "  " + ((TNodoAsig)a).dameCantHoras();
                Lista1.cursor = a;
            }
        }

        private void anterior_Click(object sender, EventArgs e)
        {
            if (Lista1.Vacio())
            {
                MessageBox.Show("Lista Vacía");
            }
            else
            {
                TNodo a;
                a = Lista1.getAntCursor();
                prueba.Text = ((TNodoAsig)a).dameNombre() + "  " + ((TNodoAsig)a).dameCantHoras();
                Lista1.cursor = a;
            }
        }

        private void eliminarUltimo_Click(object sender, EventArgs e)
        {
            if (Lista1.Vacio())
            {
                    MessageBox.Show("Lista Vacía");
            }
            else
                Lista1.EliminarUltimo();
        }

        private void eliminarPrimero_Click(object sender, EventArgs e)
        {
            if (Lista1.Vacio())
            {
                    MessageBox.Show("Lista Vacía");
            }
            else
                Lista1.eliminarPrimero();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (Lista1.Vacio())
            {
                    MessageBox.Show("Lista Vacía");
            }
            else
                Lista1.eliminarLista(Convert.ToString(nombre));
        }

        private void eliminarL_Click(object sender, EventArgs e)
        {
            if (Lista1.Vacio())
            {
                MessageBox.Show("Lista Vacía");
            }else
            Lista1.inicializar();
        }

        private void pElemento_Click(object sender, EventArgs e)
        {
            if (!Lista1.Vacio())
            {
                TNodo a;
                a = Lista1.getPrimero();
                prueba.Text = ((TNodoAsig)a).dameNombre() + "  " + ((TNodoAsig)a).dameCantHoras();
            }
            else
            {
                MessageBox.Show("Lista Vacía", "Aviso");
            }
        
        }

        private void uElemento_Click(object sender, EventArgs e)
        {
            if (!Lista1.Vacio())
            {
                TNodo a;
                a = Lista1.getUltimo();
                prueba.Text = ((TNodoAsig)a).dameNombre() + "  " + ((TNodoAsig)a).dameCantHoras();
            }
            else
            {
                MessageBox.Show("Lista Vacía", "Aviso");
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
