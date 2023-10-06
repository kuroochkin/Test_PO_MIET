using Test_PO_MIET.Interfaces;

namespace Test_PO_MIET.Realization;

public class CalculatorView : ICalculatorView
{
	public void PrintResult(double result)
	{
        Console.WriteLine($"Результат вычисления: {result}");
    }

	public void DisplayError(string message)
	{
        Console.WriteLine(message);
    }

	public string getFirstArgumentAsString()

	{
		return "Успешно введен первый аргумент";
	}
	public string getSecondArgumentAsString()
	{
		return "Успешно введен второй аргумент";
	}
}
