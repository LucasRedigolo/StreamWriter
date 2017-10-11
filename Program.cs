using System;
using System.IO;
namespace classesStream
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            StreamWriter sw = new StreamWriter("Arquivo.txt"); //Criar um arquivo novo na pasta do projeto ---- se eu incluir ", true" vai atualizando ao invés de sobreescrever

            sw.WriteLine("Teste"); // Usado para acrescentar algo no arquivo especificado na variavel acima
            sw.Write("teste2"); // escrever em uma linha separada 
            sw.Close();

            FileInfo fi= new FileInfo("Arquivo.txt"); // uma variavel para incluir os dados do arquivo
            System.Console.WriteLine("Tamanho " + fi.Length + " caracteres");
            System.Console.WriteLine("Criado em " + fi.CreationTime);
            System.Console.WriteLine("Extensão "+ fi.Extension);
                
        }
    }
}
