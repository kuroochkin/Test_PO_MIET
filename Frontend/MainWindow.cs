using System.Windows;
using System.Windows.Controls;
using Test_PO_MIET.Interfaces;
using Test_PO_MIET.Realization;

namespace Frontend;

public partial class MainWindow : Window
{
	public ICalculatorPresenter Presenter = new CalculatorPresenter(new Calculator(), new CalculatorView());

	private string currentInput = string.Empty;
	public string currentOperator = string.Empty;

	private void Number_Click(object sender, RoutedEventArgs e)
	{
		Button button = (Button)sender;
		currentInput += button.Content.ToString();
		resultTextBox.Text = currentInput;
	}

	private void Clear(object sender, RoutedEventArgs e)
	{
		resultTextBox.Text = string.Empty;
	}

	private void Operator_Click(object sender, RoutedEventArgs e)
	{
		Button button = (Button)sender;
		currentOperator = button.Content.ToString();
		Presenter.Calculator.First = double.Parse(currentInput);
		currentInput = string.Empty;
    }

	private void Equals_Click(object sender, RoutedEventArgs e)
	{
		Presenter.Calculator.Second = double.Parse(currentInput);
		
		switch (currentOperator)
		{
			case "+":
				Presenter.onPlusClicked();
				break;
			case "-":
				Presenter.onMinusClicked();
				break;
			case "x":
				Presenter.onMultiplyClicked();
				break;
			case "/":
				if (Presenter.Calculator.Second != 0)
					Presenter.onDivideClicked();
				else
					resultTextBox.Text = "Ошибка деления на ноль!";
				break;
		}

		resultTextBox.Text = Presenter.Result.ToString();
		currentInput = Presenter.Result.ToString();
	}
}
