using System;

public class Program
{
    public static void Main()
    {
        string texto_propuesto = "Hola mundo";
        string solucion = InvertirTexto(texto_propuesto);

        Console.WriteLine("Texto propuesto: " + texto_propuesto);
        Console.WriteLine("Solución: " + solucion);
    }

    public static string InvertirTexto(string texto)
    {
        char[] caracteres = texto.ToCharArray();
        Array.Reverse(caracteres);
        return new string(caracteres);
    }
}
