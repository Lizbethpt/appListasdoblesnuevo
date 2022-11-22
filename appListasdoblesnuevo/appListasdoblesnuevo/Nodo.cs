using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appListasdoblesnuevo
{
    class Nodo
    {
        private string dato;

        public string Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        private Nodo siguiente;

        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        private Nodo anterior;

        public Nodo Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }
        public Nodo()
        {
            dato = "";
            siguiente = null;
            anterior = null;
        }
        public Nodo(string dato, Nodo siguiente, Nodo anterior)
        {
            this.dato = dato;
            this.siguiente = siguiente;
            this.anterior = anterior;
        }
        public override string ToString()
        {
            return Dato.ToString();
        }
    }

}

