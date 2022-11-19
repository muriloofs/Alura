using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 3300.0;

        if (salario >= 1900.0 && salario <= 2800.0)
        {
            Console.WriteLine("A sua aliquota é de 7.5%");
            Console.WriteLine("Você pode deduzir o valor de R$ 142");
        }
        if (salario >= 2800.01 && salario <= 3751.0)
        {
            Console.WriteLine("A sua aliquota é de 15%");
            Console.WriteLine("Você pode deduzir o valor de R$ 350");
        }
        if (salario >= 3751.01 && salario <= 4664.0)
        {
            Console.WriteLine("A sua aliquota é de 22.5%");
            Console.WriteLine("Você pode deduzir o valor de R$ 636");
        }
    }
}
