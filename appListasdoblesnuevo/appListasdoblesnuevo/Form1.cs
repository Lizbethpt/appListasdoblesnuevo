using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appListasdoblesnuevo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MiLista lista = new MiLista();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Nodo n = new Nodo();
            n.Dato = txtDato.Text;
            lista.Insertar(n.Dato);
            MessageBox.Show(txtDato+lista.ToString());
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            
            //Nodo h = head;
            lista.head = lista.primero;
            while (lista.head != null)
            {
                //MessageBox.Show(lista.head.Dato);
                lista.head = lista.head.Siguiente;
                lbxDato.Items.Add(Convert.ToString(lista.head.Dato));
            }
            lista.head = lista.ultimo;
            while (lista.head != null)
            {
                //MessageBox.Show(lista.head.Dato);
                lista.head = lista.head.Anterior;
                lbxDato.Items.Add(Convert.ToString(lista.head.Dato));
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (lista.Buscar(txtDato.Text))
            {
                MessageBox.Show("Encontrado");
            }
        }

        private void lbxDato_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
