
using System;

class Program
{
    static void Main()
    {
        int idade = 18;

        if (idade < 12)
        {
            Console.WriteLine("Você é uma criança.");
        }
        else if (idade < 18)
        {
            Console.WriteLine("Você é um adolescente.");
        }
        else if (idade < 60)
        {
            Console.WriteLine("Você é um adulto.");
        }
        else
        {
            Console.WriteLine("Você é um idoso.");
        }

        // Exemplo com booleano
        bool temCarteiraDeMotorista = true;

        if (temCarteiraDeMotorista)
        {
            Console.WriteLine("Pode dirigir!");
        }
        else
        {
            Console.WriteLine("Não pode dirigir.");
        }
    }
}
