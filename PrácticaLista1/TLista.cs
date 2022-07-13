using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrácticaLista1
{
    class TNodo
    {
        public TNodo pSiguiente;
       public TNodo pAnterior;
        public TNodo()
        {
            pSiguiente = null;

            pAnterior = null;
        }
    }
    class TLista
    {
        public TNodo primero;
        public TNodo cursor;
        public TNodo ultimo;
        int numDatos;
        public TLista()
        {
            primero = null;
            cursor = null;
            ultimo = null;
            numDatos = 0;
        }
        public void inicializar()
        {
            primero = null;
            cursor = null;
            ultimo = null;
            numDatos = 0;
        }
        public bool Vacio()
        {
            if (primero == null && ultimo == null)
                return true;
            else
                return false;
        }
        public void Insertar(TNodo a)
        {
            if (Vacio())
            {
                primero = a;
                ultimo = a;
                cursor = a;
                a.pSiguiente = primero;
                a.pAnterior = ultimo;
            }
            else
            {
                ultimo.pSiguiente = a;
                primero.pAnterior = a;

                a.pAnterior = ultimo;
                a.pSiguiente = primero;
                ultimo = a;
                cursor = a;

            }
            numDatos++;
        }
       
        public TNodo eliminarPrimero()
        {
            if (Vacio())
            {
                return null;
            }
            else {
                if (primero == ultimo)
                {
                    inicializar();
                }
                else
                {
                    if(cursor == primero)
                    {
                        cursor = primero.pSiguiente;
                        primero = primero.pSiguiente;
                        primero.pAnterior = ultimo;
                        // 
                        primero.pSiguiente = cursor.pSiguiente;
                        //
                        ultimo.pSiguiente = primero;
                    }
                    else
                    {
                        primero = primero.pSiguiente;
                        primero.pAnterior = ultimo;
                        ultimo.pSiguiente = primero;

                    }
                }
            }
            return primero;
        }
        public TNodo eliminar(string a)
        {
            TNodo n1;
            TNodo n2;
            if (cursor == primero)
                return eliminarPrimero();
            else
            {
                n1 = getAntCursor();
                n2 = getProxCursor();
                n1.pSiguiente = n2;
                n2.pAnterior = n1;
                if (cursor == ultimo)
                {
                    ultimo = n1;
                }
                cursor = n1.pSiguiente;
                return cursor;
            }
        }
        public TNodo EliminarUltimo()
        {
 
            if (Vacio())
                return null;
            else
            {
                if (primero == ultimo)
                    inicializar();
                else
                {
                    if (cursor == ultimo)
                    {
                        ultimo = cursor.pAnterior;
                        cursor = primero;
                        primero.pAnterior = ultimo;
                        ultimo.pSiguiente = primero;   
                    }
                    else
                    {
                        ultimo = ultimo.pAnterior;
                        ultimo.pSiguiente = primero;
                        primero.pAnterior = ultimo;
                    }

                }
                return ultimo;
            }
        }
        public TNodo getProxCursor()
        {
            if (cursor == ultimo)
            {
                return primero;
            }
            else
                return cursor.pSiguiente;
        }
        public TNodo getAntCursor()
        {
            if (cursor == primero)
            {
                return ultimo;
            }
            else
                return cursor.pAnterior;
        }
        public TNodo getPrimero()
        {
            return primero;
        }
        public TNodo getUltimo()
        {
            return ultimo;
        }
    }

}
