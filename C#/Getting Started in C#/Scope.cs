using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Scope Test");

        int idade = 26;
        int quantidadePessoas = 8;
        bool acompanhado;
        if (quantidadePessoas >= 5)
        {
            acompanhado = true;
        }
        else
        {
            acompanhado = false;
        }
        if (idade >= 18 || acompanhado)
        {
            Console.WriteLine("Seja bem vindo");
        }
        else
        {
            Console.WriteLine("infelizmente voce nao pode entrar");
        }
    }
}
