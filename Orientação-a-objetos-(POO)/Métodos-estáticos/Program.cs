class Rocket
{
  int _fuel;
  int _maxFuel = 5000;

  public int FuelAsPercentage
  {
    get { return _fuel * 100 / _maxFuel; }
    set
    {
      if (value > 100 || value < 0)
        throw new ArgumentOutOfRangeException();

      _fuel = (value * _maxFuel) / 100;
    }
  }
}

class Bakery
{
    public Bread fabricateBread(int weight)
    {
        return new Bread
        {
            Weight = weight,
            Type = "White"
        };
    }

    public Cake fabricateChocolateCake(string size)
    {
        return new Cake
        {
            Size = size,
            Flavour = "Chocolate"
        };
    }
}

class Bread
{
    string _type = "";

    public int Weight { get; set; }
    public string Type
    {
        get { return _type; }
        set
        {
            if (value != "White" && value != "Wheat")
                throw new ArgumentException("Invalid bread type");

            _type = value;
        }
    }
}

class Cake
{
    public string Size { get; set; }
    public string Flavour { get; set; }
}