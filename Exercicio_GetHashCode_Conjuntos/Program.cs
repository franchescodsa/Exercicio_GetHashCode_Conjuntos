using Exercicio_GetHashCode_Conjuntos.Entities;
using Microsoft.Win32;
using System;

namespace Exercicio_GetHashCode_Conjuntos
{
    internal class Program
        /*Problema exemplo
Um site de internet registra um log de acessos dos usuários.Um
registro de log consiste no nome de usuário e o instante em que o
usuário acessou o site no padrão ISO 8601, separados por espaço,
conforme exemplo.Fazer um programa que leia o log de acessos a
partir de um arquivo, e daí informe quantos usuários distintos
acessaram o site.
*/
    {
        static void Main(string[] args)
        {

            HashSet<LogRecord> set = new HashSet<LogRecord> ();
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string [] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord(name, instant));
                        
                    }

                    Console.WriteLine("Total users: " + set.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
                    }
    }
}
