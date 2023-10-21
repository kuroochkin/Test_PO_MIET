using Test_PO_MIET.Interfaces;
using Test_PO_MIET.Realization;

ICalculator calc = new Calculator();
ICalculatorView view = new CalculatorView();

ICalculatorPresenter presenter = new CalculatorPresenter(calc, view);

while (true)
{
	Console.Clear();
	Console.WriteLine("Выберите операцию:");
	Console.WriteLine("1. Сложение");
	Console.WriteLine("2. Вычитание");
	Console.WriteLine("3. Умножение");
	Console.WriteLine("4. Деление");
	Console.WriteLine("5. Выход");

	int choice = Convert.ToInt32(Console.ReadLine());

	if (choice == 5)
		break;

	double num1, num2;

	Console.Write("Введите первое число: ");
	num1 = Convert.ToDouble(Console.ReadLine());

	Console.Write("Введите второе число: ");
	num2 = Convert.ToDouble(Console.ReadLine());

	switch (choice)
	{
		case 1:
			presenter.Calculator.First = num1; 
			presenter.Calculator.Second = num2;
			presenter.onPlusClicked();
			break;
		case 2:
			presenter.Calculator.First = num1;
			presenter.Calculator.Second = num2;
			presenter.onMinusClicked();
			break;
		case 3:
			presenter.Calculator.First = num1;
			presenter.Calculator.Second = num2;
			presenter.onMultiplyClicked();
			break;
		case 4:
			if (num2 == 0)
				presenter.View.DisplayError("На ноль делить нельзя");
			presenter.Calculator.First = num1;
			presenter.Calculator.Second = num2;
			presenter.onDivideClicked();
			break;
		default:
			Console.WriteLine("Ошибка: Неверный выбор операции.");
			break;
	}

	Console.WriteLine("Нажмите любую клавишу для продолжения...");
	Console.ReadKey();
}