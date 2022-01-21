/*// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");*/

using System;

namespace Revisao // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> alunos = new List<Aluno>();
            string opcaoUsuario = escolheOpcao().ToUpper();

            while(opcaoUsuario != "X"){
                switch(opcaoUsuario){
                    case "1":
                        Console.WriteLine("Informe o nome do Aluno");
                        Aluno aluno = new Aluno();
                        aluno.nome = Console.ReadLine();

                        Console.WriteLine("Informe o nota do Aluno");
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota)){
                            aluno.nota = nota;
                        }
                        else{
                            throw new ArgumentException("Nota tem que ser decimal");
                        }
                        alunos.Add(aluno);

                        break;
                    case "2":
                        foreach(var a in alunos){
                            Console.WriteLine($"Aluno: {a.nome} Nota: {a.nota}");
                        }
                        break;
                    case "3":
                        decimal soma = 0; 
                        foreach(var a in alunos){
                            soma += a.nota;
                        }
                        decimal media = soma/alunos.Count;
                        Console.WriteLine($"Média Geral: {media}");
                        break;
                    default:
                        Console.WriteLine(opcaoUsuario);
                        throw new ArgumentOutOfRangeException("Opção Inválida");
                }
                opcaoUsuario = escolheOpcao().ToUpper();
            }

            static string escolheOpcao(){
                Console.WriteLine();
                Console.WriteLine("Informe a opção desejada:");
                Console.WriteLine("1 - Inserir novo aluno");
                Console.WriteLine("2 - Listar alunos");
                Console.WriteLine("3 - Calcular média geral");
                Console.WriteLine("X - Sair");
                Console.WriteLine();

                return Console.ReadLine();
            }
        }
    }
}