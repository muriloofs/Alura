using System;

class Programa
{
    static void Main(String[] args)
    {
        Console.WriteLine("testando condicionais");

        int idade = 13;
        int quantidadePessoas = 6;
        bool acompanhado = quantidadePessoas >= 2;

        if (idade >= 18 && acompanhado)
        {
            Console.WriteLine("Seja bem vindo");
        }
        else
        {
            Console.WriteLine("infelizmente voce nao pode entrar");
        }
    }
}
