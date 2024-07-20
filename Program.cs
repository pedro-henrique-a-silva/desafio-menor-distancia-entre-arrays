namespace ordenador;


public class MainClass 
{
    public static void Main(string[] args)
    {
        int[] arrayNumeros1 = {-5, 6, 14, 32, 27, 2};
        int[] arrayNumeros2 = {30, 40, 52, 9, 19};

        ArrayFunctions.Sort(arrayNumeros1); 
        ArrayFunctions.Sort(arrayNumeros2);

        int[] resultado = ArrayFunctions.LowerDistance(arrayNumeros1, arrayNumeros2);

        Console.WriteLine(string.Join(" ", arrayNumeros1));
        Console.WriteLine(string.Join(" ", arrayNumeros2));
        Console.WriteLine(string.Join(" ", resultado));
    } 
}
