using ListaLigada.Logica;
using System.ComponentModel.Design;
using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World! Lista ligada Simple");

        Console.WriteLine("");

        var singleList = new SingleList<string>();

        int opcion = 0;
        do 
        {
            opcion = Menu();

            switch (opcion) {
                case 1: AgregarElemento(); break;
                case 2: MostrarLista(); break;
                case 0: break;

                default: Console.WriteLine("Esta opcion no existe"); break;
            }



        } while (opcion != 0);

        void AgregarElemento()
        {
            Console.WriteLine("Escribe el nombre del nodo\n");
            var data = Console.ReadLine();
            singleList.Add(data);
        }

        void MostrarLista()
        {
            Console.WriteLine("la lista es:\n");
            Console.WriteLine(singleList);
        }


        Console.ReadKey();
    }

    



    private static int Menu()
    {
        Console.WriteLine("Menú:\n");
        Console.WriteLine("1. Agregar Elemento");
        Console.WriteLine("2. Mostrar Lista");
        Console.WriteLine("0. Salir\n");

        bool esValido = false;

        int opcion = 0;

        do {
            Console.Write("Elige una opcion  del menú:   ");
            var opcionCapturada = Console.ReadLine();
            if (!int.TryParse(opcionCapturada, out opcion) || opcion < 0 || opcion > 2)
            {
                Console.WriteLine("Ingresa una opcion válida");
                esValido = false;
            }
            else
            {
                esValido = true;
            }



        } while (esValido == false);

        return opcion;
    }
}