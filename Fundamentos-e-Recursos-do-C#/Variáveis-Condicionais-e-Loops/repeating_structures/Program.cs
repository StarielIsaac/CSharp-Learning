﻿//while
var count = 0;
while (count <= 10)
    Console.WriteLine("count " + count);
    count++;

// A instrução de repetição do/while fará primeiro a execução de um bloco de 
// instruções para depois avaliar a expressão booleana especificada, e quando 
// essa expressão for verdadeira, voltará ao início do bloco.

//do/while
var counter = 0;
do
{
    Console.WriteLine("count " + counter);
    count++;
}
while (count < 10);

//For
for (int number = 0; count < 3; number++)
    Console.WriteLine("numero: " + number);



//Foreach
string[] heroes = { "Hulk", "Thor", "Loki" };
foreach (string hero in heroes)
    Console.WriteLine(hero);

