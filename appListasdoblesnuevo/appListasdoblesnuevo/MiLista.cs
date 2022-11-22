using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appListasdoblesnuevo
{
    class MiLista
    {
        public string dato;
        public Nodo primero;
        public Nodo ultimo;
        public Nodo head;

        public String Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public Nodo Primero
        {
            get { return primero; }
            set { primero = value; }
        }
        public Nodo Ultimo
        {
            get { return ultimo; }
            set { ultimo = value; }
        }
        public Nodo Head
        {
            get { return head; }
            set { head = value; }
        }
        public MiLista()
        {
            dato = "";
            primero = null;
            ultimo = null;
            head = null;
        }
        public void Insertar(string dato)
        {
            Nodo h = head;
            if (head == null)
            {
                Nodo n = new Nodo();
                primero = n;
                ultimo = primero;
            }
            else
            {
                Nodo n = new Nodo();
                ultimo.Siguiente = n;
                n.Anterior = ultimo;
                ultimo = n;
            }
        }
        public override string ToString()
        {
            Nodo h = head;
            if (head != null)
            {
                while (h.Siguiente != null)
                {
                    dato += h.ToString();
                }
            }
            return dato;
        }
        public void Borrar(string dato)
        {
            if (head != null)
            {
                if (head.Dato == dato)
                {
                    head = head.Siguiente;
                    return;
                }
                Nodo h = head;
                while (h.Siguiente != null)
                {
                    if (h.Siguiente.Dato == dato)
                    {
                        h.Siguiente = h.Siguiente.Siguiente;
                        return;
                    }
                    h = h.Siguiente;
                }
            }
        }
        //public bool Buscar(string dato)
        //{
        //    Nodo h = head;
        //    if (dato == head.Dato)
        //    {
        //        return true;
        //    }

        //    if (dato = h.Siguiente)
        //    {
        //        return true;
        //    }
        //    if (dato = h.Anterior)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

    }
}
