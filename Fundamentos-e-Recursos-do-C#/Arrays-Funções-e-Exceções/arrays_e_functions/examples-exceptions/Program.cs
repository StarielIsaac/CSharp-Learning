//Em C#, as exceções podem ser geradas pelo CLR (Common Language Runtime) do .NET, 
//ou pelo código do próprio sistema

//sintaxe do try-catch
try
{
  // Código a ser executado
}
catch
{
  // Caso aconteça uma exceção no código dentro do bloco try, aqui vai ser requisitado!
}

//exemplo mais completo (IndexOutOfRangeException, Exception) 
string[] chemicalProduct = new string[3];

try
{
  chemicalProduct[0] = "Cálcio";
  chemicalProduct[1] = "Zinco";
  chemicalProduct[2] = "Hidrazina";
  chemicalProduct[3] = "Anilina";
}
catch (IndexOutOfRangeException ex)
{
  Console.WriteLine($"Erro Específico, sabemos o motivo do erro: {ex.Message}");
}
catch (Exception ex)
{
  Console.WriteLine("Temos a mensagem, porém é um pouco incerto o que ocorreu.");
}

class Verify
{
    public bool VerifyArray(string[] array)
    {
        try
        {
            if (array == null || array.Length < 5)
            {
                throw new ArgumentException("O array é nulo ou possui menos de 5 elementos.");
            }

            return true;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }
}

