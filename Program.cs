using System;

namespace InstrucaoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;

            while(contador <= 10)
            {
                Console.WriteLine(contador);
                contador = contador + 1;        
            }
        }
    }
}
