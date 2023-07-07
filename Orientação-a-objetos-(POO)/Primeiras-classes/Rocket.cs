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
  string Name { get; set; }

  public Rocket1(string nome)
  {
    Name = nome;
  }
}
