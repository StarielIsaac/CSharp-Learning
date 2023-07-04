// Os Arrays em C# são parecidos com os Arrays em Javascript. O que os diferencia é que, em C#, 
//por se tratar de uma linguagem Fortemente Tipada, os dados são armazenados de apenas um tipo
// definido previamente. A vantagem disso é a confiabilidade dos dados no sistema.

//Outro detalhe importante é que o tamanho de um Array em C# é imutável, ou seja,
// assim que a instância de um Array é criada, o seu tamanho não pode ser alterado.

int[] myFirstArray = { 1, 2, 3, 4, 5 };
string[] mySecondArray = { "test1", "test2", "test3" };
double[] myThirdArray = { 123.43, 123.44, 123.45 };

Console.WriteLine(myFirstArray[0]);
Console.WriteLine(mySecondArray[0]);
Console.WriteLine(myThirdArray[0]);


//Para declarar e criar um Array multidimensional:
class arrayTwoDimensional
{
  public static void muldiDimArrays()
  {
    int[,] multiDimensionalArray = { { 1, 2, 3 }, { 4, 5, 6 } };
  }
}

//Existe também outra categoria de Array multidimensional, conhecido por dentado.
class ArraysJagged
{
  public static void muldiDimArrays()
  {
    //somente instanciamos o array mais externo neste primeiro passo
    int[][] jaggedArray = new int[4][];

    //instanciando um novo array para cada posição do array mais externo
    jaggedArray[0] = new int[4] { 6, 6, 6, 6 };
    jaggedArray[1] = new int[3] { 6, 6, 6 };
    jaggedArray[2] = new int[5] { 6, 6, 6, 6, 6 };
    jaggedArray[3] = new int[2] { 6, 6 };
  }
}

//Uma função é um bloco de código contendo um conjunto de instruções. Também pode ser chamada de Método.

//O uso de funções nos fornece inúmeros benefícios no desenvolvimento de um programa, tais como: 
// separação de responsabilidades, reuso de código e facilitação da manutenção.

class ProgramImc
{
  public double CalculateImc(int weigth, double heigth)
  {
    return weigth / (heigth * heigth);
  }

  //função sem retorno
  public void SendEmail() 
{
  // Bloco de código que vai conter tudo que for necessário para o envio de um e-mail
}

//função com retorno
public int CalculateAgeByYear(int yearOfBirth) 
{     
  return DateTime.Now.Year - yearOfBirth;
}

public bool ValidateComingOfAge(int age) 
{
  return age >= 18;
}
}