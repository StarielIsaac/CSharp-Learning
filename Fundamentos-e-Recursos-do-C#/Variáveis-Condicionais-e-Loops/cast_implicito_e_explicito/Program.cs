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
