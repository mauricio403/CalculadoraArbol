using System;

namespace Adt
{
    public class Nodo
    {
        public string Nombre { get; set;  }
        //public  List <Nodo> Hijos { get; Set; }

        public Nodo Izquierdo { get; set; }
        
        public Nodo Derecho { get; set; }
    }
}
