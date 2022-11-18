using System;
class Programa
{
    static void Main(string[] args)
    {
        double salario = 9000.15;
        Console.WriteLine(salario);

        int salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);

        //O long é um tipo de variável de 64 bits
        long x = 5000000000000000000;
        Console.WriteLine(x);

        short y = 19000;
        Console.WriteLine(y);

        float altura = 6.22f;
        Console.WriteLine(altura);

        Console.WriteLine("Tecle enter para finalizar o programa.");
        Console.ReadLine();
    }
}
