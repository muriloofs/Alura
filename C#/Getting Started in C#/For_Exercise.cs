using System;
class Program
{
    static void Main(string[] args)
    {
        for (int contador = 1; contador <= 100; contador++)
        {
            if (contador % 3 == 0)
            {
                Console.WriteLine(contador);
            }
        }
        Console.ReadKey();
    }
}
