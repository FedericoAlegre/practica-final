using System;
using System.Collections.Generic;
using System.Text;

namespace practica_final
{
    class Lista
    {
        Nodo primero;
        Nodo ultimo;

        public Lista()
        {
            primero = null;
            ultimo = null;
        }

        public void InsertarNodo(string ciudad, int par, int arr)
        {
            Nodo nuevo = new Nodo();
            nuevo.city = ciudad;

            if (primero == null)
            {
                if (par == 0) nuevo.cantArr = arr;
                else nuevo.cantPart = par;         
                
                primero = nuevo;
                primero.sig = null;
                ultimo = nuevo;
                ultimo.sig = null;                
            }
            else 
            {
                bool t = false;
                Nodo actual = new Nodo();
                actual = primero;
                Nodo anterior = new Nodo();
                anterior = null;
                Nodo y = new Nodo();
                while (actual != null)
                {
                    if (actual.city != ciudad)
                    {
                        actual = actual.sig;
                        anterior = actual;
                    }
                    else 
                    {
                        y = actual;
                        t = true;
                        break;
                    }
                }
                if (t == false)
                {
                    if (par == 0) nuevo.cantArr = arr;
                    else nuevo.cantPart = par;
                    ultimo.sig = nuevo;
                    ultimo = nuevo;
                }
                else 
                {
                    if (par == 0) y.cantArr += arr;
                    else y.cantPart += par;
                }


            }
        }

        public void RecorrerLista()
        {
            Nodo actual;
            actual = primero;

            if (primero != null)
            {
                while (actual != null)
                {
                    Console.WriteLine("Destino: "+actual.city);
                    Console.WriteLine("Cantidad de partidas: "+actual.cantPart);
                    Console.WriteLine("Cantidad de arribos: "+actual.cantArr+"\n");
                    actual = actual.sig;
                }
            }
            else Console.WriteLine("la lista esta vacia");
        }
    }
}
