//#Exercício: Usar foreach e instruções de seleção

string[] fraudulentOrderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

//string fraudes = "";
foreach (string order in fraudulentOrderIDs)
{
  if (order.StartsWith("B"))
  {
 Console.WriteLine(order);
  }
}
//    Console.WriteLine($"Potencial fraude detectada: {fraudes}");