using Adt;
using System;

namespace AdtApp
{
    internal class Administrador
    {


        public void Recursividad(Nodo Nodo)
        {
            if (Nodo == null) return;

            Console.WriteLine(Nodo.Nombre);
            Recursividad(Nodo.Izquierdo);
            Recursividad(Nodo.Derecho);
        }
    }
}