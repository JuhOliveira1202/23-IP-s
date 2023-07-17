using Exercício_IP_s;
using System;

class Program
{
    public static void Main(string[] args)
    {
        int end = 4;

        Console.WriteLine("O seu endereço: ");
        int[] octUser = new int[end];
        Endereco.Ler(end, octUser);
        Console.WriteLine();
        Console.WriteLine("Endereço: ");
        Endereco.Mostrar(end, octUser);
        Console.WriteLine();
        Console.WriteLine("Classe");
        Endereco.Classe(octUser[0]);
        Console.WriteLine();
        Console.WriteLine("Endereço Público ou Privado");
        Endereco.TipoEnd(octUser);
        Console.WriteLine();
        Console.WriteLine("Endereço em númeração binária");
        Endereco.Binario(octUser);
    }


}
