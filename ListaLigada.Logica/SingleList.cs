using System.Reflection;

namespace ListaLigada.Logica
{
    //<T> Se declara la clase como generica para evitar problemas con los tipos de datos
    // Todos los datos tiene que ser <T>
    public class SingleList<T>
    {
        //Puntero del primer nodo
        private SingleNode<T>? _first;

        public SingleList() {
            _first = null;
        }

        //Para saber si esta vacia
        public bool isEmpty => _first == null;

        //Metodo para agregar nodo
        public void Add(T item) {

            //Crear objeto nodo e invocar a SingleNode

            var node  = new SingleNode<T>(item);

            if (isEmpty) 
            {
                _first = node;
            }
            else 
            {
                var pointer = _first;

                while (pointer!.Next != null) { 
                    
                    pointer = pointer.Next;
                
                }
                pointer!.Next = node;
                               
            }

        }

        public override string ToString() { 
            var cadenaLista = string.Empty;
            var pointer = _first;

            while (pointer != null) {
                cadenaLista += $"{pointer.Data}\n";
                pointer = pointer.Next;
                }
            return cadenaLista;
            }
        }

    }

