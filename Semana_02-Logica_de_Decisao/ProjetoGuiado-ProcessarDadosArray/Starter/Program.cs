using System;

// initialize variables - graded assignments
int currentAssignments = 5;

string[] alunos = { "Sophia", "Andrew", "Emma", "Logan" };
int[] sophiaNotas = { 90, 86, 87, 98, 100 };
int[] andrewNotas = { 92, 89, 81, 96, 90 };
int[] emmaNotas = { 90, 85, 87, 98, 68 };
int[] loganNotas = { 90, 95, 87, 88, 96 };
int[] somaNotas = {0,0,0,0,0 };
decimal[] mediaAlunos = { 0, 0, 0, 0, 0 };

int somaAlunos = 0;
int numeroAluno = 0;

Console.WriteLine("Student\t\tGrade\n");

foreach (string aluno in alunos)
{
  if (aluno == "Sophia")
  {
    foreach (int notas in sophiaNotas)
    {
      somaAlunos += notas;
      somaNotas[numeroAluno] = somaAlunos;
    }
  }

  if (aluno == "Andrew")
  {
    foreach (int notas in andrewNotas)
    {
      somaAlunos += notas;
      somaNotas[numeroAluno] = somaAlunos;
    }
  }
  if (aluno == "Emma")
  {
    foreach (int notas in emmaNotas)
    {
      somaAlunos += notas;
      somaNotas[numeroAluno] = somaAlunos;
    }
  }
  if (aluno == "Logan")
  {
    foreach (int notas in loganNotas)
    {
      somaAlunos += notas;
      somaNotas[numeroAluno] = somaAlunos;
    }
  }


  mediaAlunos[numeroAluno] = (decimal)somaNotas[numeroAluno] / currentAssignments;
  somaAlunos = 0;

  Console.WriteLine($"{alunos[numeroAluno]}:\t\t{mediaAlunos[numeroAluno]}");
  numeroAluno++;
}

Console.ReadLine();
  /*
    foreach (int notas in andrew)
  {
    somaAlunos = somaAlunos + notas;
    soma[numeroAluno] = somaAlunos;
  }
    somaAlunos = 0;
    foreach (int notas in emma)
    {
      somaAlunos = somaAlunos + notas;
      soma[numeroAluno] = somaAlunos;
    }
    somaAlunos = 0;
    foreach (int notas in logan)
    {
      somaAlunos = somaAlunos + notas;
      soma[numeroAluno] = somaAlunos;
    }
    somaAlunos = 0;
*/
  //Console.WriteLine($"{turma[0]}, notas {sophia[0]}, {sophia[1]}, {sophia[2]}, {sophia[3]}, {sophia[4]}");

 //onsole.WriteLine($"{turma[numeroAluno]}, soma das notas {soma[numeroAluno]}");


/*
decimal sophiaMedia = 0;
decimal sophiaSum = 0;

decimal[] alunosMedia = { 0 };
decimal alunosSum = 0;
foreach (int notas in sophia)
{
  sophiaSum += notas;
}
Console.WriteLine($"a soma é {sophiaSum} a media é {sophiaMedia =  sophiaSum / currentAssignments }");

*/
/*
int sophia1 = 90;
int sophia2 = 86;
int sophia3 = 87;
int sophia4 = 98;
int sophia5 = 100;

int andrew1 = 92;
int andrew2 = 89;
int andrew3 = 81;
int andrew4 = 96;
int andrew5 = 90;

int emma1 = 90;
int emma2 = 85;
int emma3 = 87;
int emma4 = 98;
int emma5 = 68;

int logan1 = 90;
int logan2 = 95;
int logan3 = 87;
int logan4 = 88;
int logan5 = 96;

int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;

decimal sophiaScore;
decimal andrewScore;
decimal emmaScore;
decimal loganScore;

sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
loganSum = logan1 + logan2 + logan3 + logan4 + logan5;

sophiaScore = (decimal)sophiaSum / currentAssignments;
andrewScore = (decimal)andrewSum / currentAssignments;
emmaScore = (decimal)emmaSum / currentAssignments;
loganScore = (decimal)loganSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
*/


