using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_IP_s
{
    internal class Endereco
    {
        public static void Ler(int n, int[] oct)
        {
            for (int i = 0; i < n; i++)
            {
                bool val = false;

                do
                {
                    Console.Write("Qual o octeto " + i + "? ");
                    oct[i] = Convert.ToInt32(Console.ReadLine());

                    if (n < 0 || n > 255)
                    {
                        Console.WriteLine("Digite um endereço válido!");
                    }
                } while (val);
            }
        }

        public static void Mostrar(int n, int[] oct)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(oct[i] + " ");
            }
            Console.WriteLine();
        }

        public static void Classe(int n)
        {
            if (n >= 1 && n <= 127)
            {
                Console.WriteLine("O seu Endereço de IPv4 é de Classe A");
            }
            else if (n >= 128 && n <= 191)
            {
                Console.WriteLine("O seu Endereço IPv4 é de Classe B");
            }
            else if (n >= 192 && n <= 223)
            {
                Console.WriteLine("O seu Endereço IPv4 é de Classe C");
            }
            else if (n >= 224 && n <= 239)
            {
                Console.WriteLine("O seu Endereço IPv4 é de Classe D");
            }
            else
            {
                Console.WriteLine("O seu Endereço IPv4 é de Classe E");
            }
        }

        public static void TipoEnd(int[] n)
        {
            bool privado = false;

            if (n[0] == 10)
            {
                privado = true;
            }
            else if (n[0] == 172)
            {
                if (n[1] >= 16 && n[1] <= 31)
                {
                    privado = true;
                }
            }
            else if (n[0] == 192)
            {
                if (n[1] == 168)
                {
                    privado = true;
                }
            }

            if (privado==false)
            {
                Console.WriteLine("O seu Endereço é PÚBLICO");
            }
            else
            {
                Console.WriteLine("O seu Endereço é PRIVADO");
            }
        }

        public static void Binario(int[] n)
        {
            string numBinario = " ";

            while (n[0] / 2 >= 1) 
            {
                numBinario = Convert.ToString(n[0] % 2) + numBinario;
                n[0] = (n[0] / 2);
            }
            numBinario = (n[0] + numBinario);
            Console.WriteLine(numBinario);

            while (n[1] / 2 >= 1) 
            {
                numBinario = Convert.ToString(n[1] % 2) + numBinario;
                n[1] = (n[1] / 2);
            }
            numBinario = (n[1] + numBinario);
            Console.WriteLine(numBinario);

            while (n[2] / 2 >= 1)
            {
                numBinario = Convert.ToString(n[2] % 2) + numBinario;
                n[2] = (n[2] / 2);
            }
            numBinario = (n[2] + numBinario);
            Console.WriteLine(numBinario);

            while (n[3] / 2 >= 1)
            {
                numBinario = Convert.ToString(n[3] % 2) + numBinario;
                n[3] = (n[3] / 2);
            }
            numBinario = (n[3] + numBinario);
            Console.WriteLine(numBinario);
        }
    
    }
}
