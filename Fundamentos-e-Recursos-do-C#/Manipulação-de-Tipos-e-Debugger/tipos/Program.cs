// Funções da Classe String

// Concat() - Concatenação de strings
string textOne = "Você está aprendendo sobre ";
string textTwo = "Strings em C#, ";
string textThree = "e agora sabe concatenar textos utilizando a função Concat()!";
string result = string.Concat(textOne, textTwo, textThree);

// Split() - Para separarmos uma string em várias
// A função Split() retorna um array de strings
string emails = "email1@trybe.com;email2@trybe.com;email3@trybe.com";
string[] arrayEmails = emails.Split(";");


// IndexOf() - Procurando um index na string
string trybe = "Trybe";
int index = trybe.IndexOf("y"); //2

string indexNull = "Trybe";
int index1 = indexNull.IndexOf("s"); //-1 pois não existe 's' na palavra


//Estamos dizendo para a função IndexOf() encontrar o caracter e a partir do index 6.
string indexNull1 = "I love Trybe";
int index2 = indexNull1.IndexOf("e", 6); //11


// Contains() - Verificar se uma string está contida em outra string, ou em um array.
List<string> languages = new List<string>
{
 "c#",
 "java",
 "javascript",
 "python"
};

bool languageExists = languages.Contains("c#"); //retorno um booleano, ou seja, true ou false.


// Join() - Concatena uma coleção de valores em uma string.
IEnumerable<int> listNumbers = Enumerable.Range(1, 10);
string numbersText = string.Join(',', listNumbers); // concatenando cada numero do array, separando-os por vírgula.


//interpolação -> processo de inserir o valor de uma variável em parte de uma string.
string textString = "string";
string text = $"Isso é uma {textString}";


//Datas - No C# podemos tratar os momentos de tempo com a biblioteca 'DateTime'.

// Data, composta por:
//   - Dia
//   - Mês
//   - Ano
// Horário, composto por:
//   - Horas
//   - Minutos
//   - Segundos
//   - Milissegundos

//Instância com os parâmetros de ano, dia, mês, hora, minuto e segundo definidos respectivamente; 
//além disso, usamos o ToString() para imprimir essa data.
public class DataUtil
{
  public static void Main(string[] args)
  {
    var date = new DateTime(2022, 10, 2, 8, 35, 0);
    Console.WriteLine(date.ToString()); // 02/10/2022 08:35:00
  }
}


//Principais propriedades da DateTime


//DateTime.Now
public class DataUtilNow
{
  public string GetTimeNow()
  {
    var dataType = DateTime.Now;
    return "O momento de tempo atual é " + dataType;
  }
}

// DateTime.Date - acessa o componente da data em uma instância da DateTime
  public class DataUtilDate
  {
      public static void Main(string[] args)
      {
          var day = new DateTime(2022, 10, 2, 8, 35, 0);
          var dateOnly = day.Date;
          Console.WriteLine(dateOnly.ToString()); //02/10/2022.
      }
  }

// DateTime.Day -  representa um momento de tempo e retorna um valor inteiro entre 1 e 31.
  public class DataUtilDay
  {
      public static void Main(string[] args)
      {
          var example = new DateTime(2022, 10, 2, 8, 35, 0);
          var dayOnly = example.Day;
          Console.WriteLine(dayOnly.ToString());
      }
  }

  

