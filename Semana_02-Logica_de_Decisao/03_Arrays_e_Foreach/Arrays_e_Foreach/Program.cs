// =========================================
// # Objetivos de aprendizagem
// - Criar e inicializar uma matriz
// - Iterar em cada elemento com foreach
// - Somar valores de uma matriz
// =========================================

// inicio comentário temporário
//NOTE: Matriz armazena diferentes tipos de dados em uma única variável, facilitando o acesso no código.

//criando uma instancia de uma matriz na memoria do computador

//string[] fraudulentOrderIDs = new string[3];

// atribuir valor a matriz
//fraudulentOrderIDs[0] = "A123";
//fraudulentOrderIDs[1] = "B1234";
//fraudulentOrderIDs[2] = "C7879";
//fraudulentOrderIDs[3] = "D009";

/*
#region //Inicializar uma matriz

string[] fraudulentOrderIDs = ["A123", "B1234","C789" ];
  forma mais moderna usada a partir do C#12, sintaxe mais antiga utiliza chaves {} para envolver os valores da matriz

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");
#endregion

fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reassing Firt: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent order to process.");
*/
//---//

//Fim do comentário

// #Implementar foreach

/*
string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names)
{
    Console.WriteLine(name);
}


 soma de itens em uma matriz

int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
  sum += items;
  bin++;
  Console.WriteLine($"{bin} = {items} items(Running total: {sum})");
}
  Console.WriteLine($"We have {sum} items in inventory.");

  Usar foreach para iterar sobre a matriz
  Quando usamos foreach é criada uma variável temporária que pode ser usada no bloco de código.
  usar o operador de incremento ++, aumenta em 1 o valor da variável
*/

