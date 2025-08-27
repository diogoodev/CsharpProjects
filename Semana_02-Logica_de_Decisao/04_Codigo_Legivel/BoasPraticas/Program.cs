//#region===========================
//Objetivos de aprendizagem
// - Definir bons nomes de variáveis
//- fazer o compilador ignorar linhas de código
// - Usar comentários que descrevem finalidade ou requisitos
// Usar espaços em branco de modo eficiente
//============================
/*
Escolher nomes de variável que sigam as regras e convenções

# regras para nomear variáveis
- Não pode usar #, - ou $  nem palavras reservadas do C#, exemplo string string
 - Pode iniciar com caracteres alfabéticos ou  sublinhados _ (esse normalmente  usado para instancia privada) e nao podem iniciar com números
 - As variáveis são case sensitive myArray != myarray

# Convenções de nome de variável

- camelCase
- Definir o nome pelo que é, e não pelo tipo de dado
- evitar resumir palavras nos nomes das variaveis aka decimal orderAmount é melhor que decimal odrAmt
- Não usar o tipo de dados no nome da variável string strMyName

*/
#region

/*
string firstName = "Bob";
int widgetsPurchased = 7;
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");
*/

/*
The following code creates five random OrderIDs to test the fraud detection process. OrderIDs consist of a letter from A to E, and three digit number. Ex. A123
*/


Random random = new Random();
string[] orderIDs = new string[5];
for (int i = 0; i < orderIDs.Length; i++)
{
  int prefixValue = random.Next(65, 70);
  string prefix = Convert.ToChar(prefixValue).ToString();
  string suffix = random.Next(1, 1000).ToString("000");
  orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
  Console.WriteLine(orderID);
}
#endregion

// Melhorar a legibilidade
/*
//exemplo 01
Console
.
WriteLine
(
  "Hello Exemplo 01!"
);

// Exemplo 02
string firstWord = "Hello";string lastWord = "Exemplo 02";Console.WriteLine(firstWord + " " + lastWord + "!");
*/

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
  if ((roll1 == roll2) && (roll2 == roll3))
  {
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
  }
  else
  {
    Console.WriteLine("You rolled doubles! +2 bonus to total");
    total += 2;
  }
}

// usar espaços para melhorar a legibilidade
// Separar o código usando um espaço em braco quando o código é semelhante ou quando as linhas representam uma mesma funcionalidade
// usar o tab para alinha blocos de código
// Usar o recuo para mostra a propriedade
