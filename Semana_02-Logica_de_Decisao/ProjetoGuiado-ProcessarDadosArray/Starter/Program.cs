using System;

// initialize variables - graded assignments
int currentAssignments = 5;

string[] alunos = { "Sophia", "Andrew", "Emma", "Logan" };
int[] notasAlunos = new int[10];

int[] sophiaNotas = { 90, 86, 87, 98, 100 };
int[] andrewNotas = { 92, 89, 81, 96, 90 };
int[] emmaNotas = { 90, 85, 87, 98, 68 };
int[] loganNotas = { 90, 95, 87, 88, 96 };

string atualNotaLetraAluno="";

Console.WriteLine("Student\t\tGrade\n");

foreach (string aluno in alunos)
{
  string alunoAtual = aluno;

  if (alunoAtual == "Sophia")
    notasAlunos = sophiaNotas;

  else if (aluno == "Andrew")
    notasAlunos = andrewNotas;

  else if (aluno == "Emma")
    notasAlunos = emmaNotas;

  else if (aluno == "Logan")
    notasAlunos = loganNotas;

  int somaNotasAlunos = 0;
  decimal notaAlunoAtual = 0;

  foreach (int notas in notasAlunos)
  {
    somaNotasAlunos += notas;
  }

  notaAlunoAtual = (decimal) somaNotasAlunos / currentAssignments;

    if (notaAlunoAtual > 90)
    {
      atualNotaLetraAluno= "A";
    } else
    {
      atualNotaLetraAluno = "B";
    }

 Console.WriteLine($"{alunoAtual}:\t\t{notaAlunoAtual}\t{atualNotaLetraAluno}");
}

Console.WriteLine("Pressione Enter para continuar... ");
Console.ReadLine();
  /*
 Continuar na unidade 5: Atribuir notas em letra usando um constructo if-elseif-else
 */


