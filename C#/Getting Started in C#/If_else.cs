using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Praticando condicionais");

        int idade = 32;
        int quantidadePessoas = 5;

        if (idade >= 18)
        {
            Console.WriteLine("Você tem mais de 18 anos");
            Console.WriteLine("Seja Bem vindo");
        }
        else
        {
            if (quantidadePessoas >= 4)
            {
                Console.WriteLine("Você não tem 18 anos, mas pode entrar, pois está com acompanhante.");
            }
            else
            {
                Console.WriteLine("Infelizmente você não pode entrar");
            }
        }
    }
}
