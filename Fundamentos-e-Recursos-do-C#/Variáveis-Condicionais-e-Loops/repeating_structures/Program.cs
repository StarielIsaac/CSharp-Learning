var count = 0;
while (count <= 10)
{
    Console.WriteLine("count " + count);
    count++;
}

// A instrução de repetição do/while fará primeiro a execução de um bloco de 
// instruções para depois avaliar a expressão booleana especificada, e quando 
// essa expressão for verdadeira, voltará ao início do bloco.
var counter = 0;
do
{
    Console.WriteLine("count " + counter);
    count++;
}
while (count < 10);