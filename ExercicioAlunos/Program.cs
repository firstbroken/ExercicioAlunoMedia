﻿namespace ExercicioAlunos;
class Program
{
    static void Main(string[] args)
    {

        Alunos aluno1 = new Alunos();
        aluno1.nome = "Outro aluno";
        aluno1.nota1 = 4;
        aluno1.nota2 = 5;
        aluno1.mensagem();

        Console.Write("Digite seu nome: ");
        string? nome = Console.ReadLine();
        Console.WriteLine("Seu nome é: " + nome);
        Console.Write("Digite a primeira nota: ");
        double nota1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("O número digitado foi: " + nota1);
        Console.Write("Digite a segunda nota: ");
        double nota2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("O número digitado foi: " + nota2);
        Console.WriteLine("O aluno " + nome + "está com a média de:" + (nota1+nota2)/2);
    }
}
