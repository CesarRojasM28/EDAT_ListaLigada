using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaLigada.Logica
{
    internal class SingleNode <T> //Se crea clase generica acepta todo tipo de dato
    {
        //Se esta crenado un nodo
        public T? Data { get; set; }
        
        // Se esta creando un puntero para direccion de memoria
        public SingleNode <T>? Next { get; set; }

        //Cuando se invoque un nodo va a recibir un dato
        public SingleNode(T data) {
            Data = data;
            Next = null;    
        }
    }
}
