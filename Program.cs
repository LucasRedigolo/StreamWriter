using System;
using System.IO;
namespace classesStream
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            StreamWriter sw = new StreamWriter("Arquivo.txt"); //Criar um arquivo novo na pasta do projeto
            
            sw.Write("Teste"); // Usado para acrescentar algo no arquivo especificado na variavel acima
            sw.Close();

        }
    }
}
