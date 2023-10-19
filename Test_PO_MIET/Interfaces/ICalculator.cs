namespace Test_PO_MIET.Interfaces;

public interface ICalculator
{
	public double First { get; set; }
	public double Second { get; set; }

	double Sum(double a, double b);

	double Subtract(double a, double b);

	double Multiply(double a, double b);

	double Divide(double a, double b);
}
