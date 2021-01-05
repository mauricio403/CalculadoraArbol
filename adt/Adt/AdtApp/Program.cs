using Adt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AdtApp
{
    class Recursividad
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Arbol Binario");
            /* var raiz = new Nodo();
             raiz.Nombre = "1";*/

            /* var nodoDos = new Nodo();
             nodoDos.Nombre = "1.1";

             var nodoTres = new Nodo();
             nodoTres.Nombre = "1.2";

             var nodoCuatro = new Nodo();
             nodoCuatro.Nombre = "1.1.1";

             var nodoCinco = new Nodo();
             nodoCinco.Nombre = "1.1.2";

             var nodoSeis = new Nodo();
             nodoSeis.Nombre = "1.2.1";

             var nodoSiete = new Nodo();
             nodoSiete.Nombre = "1.2.2";


             raiz.Izquierdo = nodoDos;
             raiz.Izquierdo = nodoCuatro;
             raiz.Izquierdo = nodoCinco;

             raiz.Derecho = nodoTres;
             raiz.Derecho = nodoSeis;
             raiz.Derecho = nodoSiete;*/

            var raiz = new Nodo("1",
                new Nodo("1.1",
                  new Nodo("1.1.1"), new Nodo("1.1.2")),
                new Nodo("1.2",
                    new Nodo("1.2.1"), new Nodo("1.2.2"))
                );

            Administrador adm = new Administrador();
            adm.Recursividad(raiz);


            //5+6-2-1
            var arbolOperaciones = new Nodo("+",
                new Nodo("5"),
                new Nodo("-",
                 new Nodo("6"),
                 new Nodo("-"),
                 new Nodo("2"),
                 new Nodo("1"))
                );
            //Caracteres validos [0-9] numeros, separador decima;
            //+ - operadores, para el nombre prop


        }

    }
}
