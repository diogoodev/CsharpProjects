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

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

//resultados duplicados
if ((roll1 == roll2) || (roll3 == roll2) || (roll1 == roll3))
{
  Console.WriteLine("You rolled doubles! +2 bonus to total!");
  total += 2;
}

//resultados triplicados
//5 == 5 &&        5    ==    5
if ((roll1 == roll2) && (roll2 == roll3))
{
  Console.WriteLine("You rolled triples! +6 bonus to total!");
  total += 6;
}

if (total >= 15)
{
  Console.WriteLine("You Win!");
}

if ( total < 15)
{
    Console.WriteLine("Sorry, you lose.");
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



