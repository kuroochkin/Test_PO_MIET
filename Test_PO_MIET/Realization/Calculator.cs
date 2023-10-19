using Test_PO_MIET.Interfaces;

namespace Test_PO_MIET.Realization;

public class Calculator : ICalculator
{
	public double First { get; set; }
	public double Second { get; set; }
	public double Divide(double a, double b)
	{
		if (b == 0 || b < 0.00000001)
			throw new DivideByZeroException();
		else
			return a / b;
	}

	public double Multiply(double a, double b)
	{
		return a * b;
	}

	public double Subtract(double a, double b)
	{
		return a - b;
	}

	public double Sum(double a, double b)
	{
		return a + b;
	}
}
