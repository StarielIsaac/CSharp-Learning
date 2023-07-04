// Os Arrays em C# são parecidos com os Arrays em Javascript. O que os diferencia é que, em C#, 
//por se tratar de uma linguagem Fortemente Tipada, os dados são armazenados de apenas um tipo
// definido previamente. A vantagem disso é a confiabilidade dos dados no sistema.

//Outro detalhe importante é que o tamanho de um Array em C# é imutável, ou seja,
// assim que a instância de um Array é criada, o seu tamanho não pode ser alterado.

int[] myFirstArray = {1, 2, 3, 4, 5};
string[] mySecondArray = {"test1", "test2", "test3"};
double[] myThirdArray = {123.43, 123.44, 123.45};

Console.WriteLine(myFirstArray[0]);
Console.WriteLine(mySecondArray[0]);
Console.WriteLine(myThirdArray[0]);


//Para declarar e criar um Array multidimensional:
class PlayingWithArrays
{
  public static void muldiDimArrays()
  {
    int[,] multiDimensionalArray = { { 1, 2, 3 }, { 4, 5, 6 } };
  }
}


