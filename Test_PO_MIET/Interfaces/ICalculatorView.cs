namespace Test_PO_MIET.Interfaces;

public interface ICalculatorView
{
	void PrintResult(double result);
	void DisplayError(string message);
	string getFirstArgumentAsString();
	string getSecondArgumentAsString();
}
