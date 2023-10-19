using Test_PO_MIET.Interfaces;

namespace Test_PO_MIET.Realization;

public class CalculatorPresenter : ICalculatorPresenter
{
	public ICalculator Calculator {  get; set; }

	public ICalculatorView View { get; set; }

	public double Result {  get; set; }	

	public CalculatorPresenter(
		ICalculator calculator,
		ICalculatorView view)
	{
		Calculator = calculator;
		View = view;
	}

	public void onDivideClicked()
	{
		Result = Calculator.Divide(Calculator.First, Calculator.Second);
		View.PrintResult(Result);
	}

	public void onMinusClicked()
	{
		Result = Calculator.Subtract(Calculator.First, Calculator.Second);
		View.PrintResult(Result);
	}

	public void onMultiplyClicked()
	{
		Result = Calculator.Multiply(Calculator.First, Calculator.Second);
		View.PrintResult(Result);
	}

	public void onPlusClicked()
	{
		Result = Calculator.Sum(Calculator.First, Calculator.Second);
		View.PrintResult(Result);
	}
}
