public class Program
{
  public static void Main()
  {
    int intResult = 5 / 2;

    Console.WriteLine(intResult);
  }
}

public class Program1
{
  public static void Main()
  {
    int someIntNumber = 51;
    long longNumberCast = someIntNumber;

    Console.WriteLine(longNumberCast);
  }
}

public class Program2
{
  public static void Main()
  {
    long someLongNumber = 516144564564654;
    int intNumber = Convert.ToInt32(someLongNumber);
    Console.WriteLine(intNumber);
  }
}

// Conversão de string para números
public class Program3
{
  public static void Main()
  {
    string someString = "42";
    int convertInt = Convert.ToInt32(someString);

    Console.WriteLine(convertInt);
  }
}

public class Program4
{
  public static void Main()
  {
    int? number = 0;

    if (number > 0)
      Console.WriteLine("maior que zero");
    else if (number < 0)
      Console.WriteLine("menor que zero");
    else
      Console.WriteLine("igual a zero");
  }
}

public class Program5
{
  public static void Main()
  {
    int? number = 0;

    switch (number)
    {
      case > 0:
        Console.WriteLine("maior que 0");
        break;
      case 0:
        Console.WriteLine("igual a zero");
        break;
      default:
        Console.WriteLine("menor que zero");
        break;
    }
  }
}