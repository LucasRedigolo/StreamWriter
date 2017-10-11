using System;
using System.IO;
namespace classesStream
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            StreamWriter SW = new StreamWriter("Arquivo.txt"); //Criar um arquivo novo na pasta do projeto
        }
    }
}
