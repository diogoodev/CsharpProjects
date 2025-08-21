//Objetivos
//----------
// Escrever um código que avalia condições usando as instruções if, else e else if.
// Criar expressões boolianas para avaliar uma condição.
// Combinar expressões boolianas usando operadores lógicos.
// Aninhar blocos de código dentro de outros blocos de código.
//-----------

Random dice = new Random();

int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

//teste
//roll1 = 3;
//roll2 = 3;
//roll3 = 1;
int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

//resultados duplicados
if ((roll1 == roll2) || (roll3 == roll2) || (roll1 == roll3))
{
  //resultados triplicados
  //5 == 5 &&        5    ==    5
  if ((roll1 == roll2) && (roll2 == roll3)) // if aninhado
  {
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
  }
  else
  {
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
  }
}

// if (total >= 15)
// {
//   Console.WriteLine("You Win!");
// }
// else
// {
//   Console.WriteLine("Sorry, you lose.");
// }
if (total >= 16)
{
  Console.WriteLine("You won a new car!");
}
else if (total >= 10)
{
  Console.WriteLine("You won a new laptop!");
}
else if (total == 7)
{
  Console.WriteLine("You won a trip!");
}
else
{
  Console.WriteLine("You won a Cat!");
}




// // Expressão booliana em métodos

/*  string message = "The quick brown foz jumps over the lazy fox.";

bool result = message.("dog");

 Console.WriteLine(result);

 if (message.Contains("fox"))
 {
     Console.WriteLine("What does the fox say?");
 }

 int num = 1;
 int num2 = 1;

 if (num.Contains){
     Console.WriteLine("Igual");
 }
 */
 // Bloco de Código

/*
 string dolar = "Nesse texto temos alguns sinal de $";

 bool price = dolar.Contains("$");

if (price) {
  Console.WriteLine("Dolar detectado");
 } */

/*#Exercício – Criar lógica de decisão aninhada com if, elseif e else
Concluido
*/

// #Exercício – Concluir uma atividade de desafio que aplica regras de negócios - Em andamento, bem no inicio.




