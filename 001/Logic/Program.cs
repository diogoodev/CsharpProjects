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

if ( total > 14)
{
    Console.WriteLine("You Win!");
}

if ( total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}

// // Expressão booliana em métodos

// string message = "The quick brown foz jumps over the lazy dog.";
// bool result = message.Contains("dog");
// Console.WriteLine(result);

// if (message.Contains("fox"))
// {
//     Console.WriteLine("What does the fox say?");
// }

// int num = 1;
// int num2 = 1;

// if (num == num2){
//     Console.WriteLine("Igual");
// }

// Bloco de Código

