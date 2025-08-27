//============================
/*
Desafio de código – Aplicar as diretrizes de estilo para melhorar a legibilidade
*/
//=============================

/*
Inverte a mensagem e conta o numero de vezes que a letra 'o' aparace.
*/
string message = "The quick brown fox jumps over the lazy dog.";

char[] letterMessage = message.ToCharArray();
Array.Reverse(letterMessage);

int count = 0;
foreach (char letter in letterMessage)
{
  if (letter == 'o')
  {
    count++;
  }
}

string newMessage = new string(letterMessage);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appers {count} times.");
