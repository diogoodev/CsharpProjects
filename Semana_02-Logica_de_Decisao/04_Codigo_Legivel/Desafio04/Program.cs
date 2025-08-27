//============================
/*
Desafio de código – Aplicar as diretrizes de estilo para melhorar a legibilidade
*/
//=============================

string str = "The quick brown fox jumps over the lazy dog.";
char[] charMessage = str.ToCharArray();
Array.Reverse(charMessage);
int x = 0;
// count the o's
foreach (char i in charMessage) { if (i == 'o') { x++; } }
// convert it back to a string
string new_message = new string(charMessage);
// print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appers {x} times.");
