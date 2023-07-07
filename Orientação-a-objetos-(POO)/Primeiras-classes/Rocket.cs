class Rocket
{
  public string Name { get; set; }
} 

// var rocket1 = new Rocket();
// var rocket2 = rocket1;

// rocket1.Name = "Apollo 11";
// rocket2.Name = "Falcon 9";

// Console.WriteLine(rocket1.Name);


//construtores -> métodos chamados toda vez que uma instância de uma classe é criada
class Rocket1
{
  private string _Nome;
  private int _Fuel { get; set; } = 0;
  private decimal _Price { get; set; }

  public Rocket1(string nome, decimal price)
  {
    _Nome = nome;
    _Price = price;
  }

  public string ShowName()
  {
    return this._Nome;
  }
// Para intanciar essa classe -> Rocket1 firstRocket = new Rocket1("Apollo 11", 23234,3)
}

