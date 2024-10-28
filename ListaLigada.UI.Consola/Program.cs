using ListaLigada.Logica;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World! Lista ligada Simple");

        Console.WriteLine("");

        var singleList = new SingleList<string>();

        singleList.Add("Alondra");
        singleList.Add("Karla");
        singleList.Add("Jan");
        singleList.Add("Luis");
        singleList.Add("José");

        Console.WriteLine(singleList);



        Console.ReadKey();
    }
}