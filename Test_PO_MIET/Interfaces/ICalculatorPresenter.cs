namespace Test_PO_MIET.Interfaces;

public interface ICalculatorPresenter
{
	ICalculator Calculator { get; set; }
	ICalculatorView View { get; set; }
	double Result {  get; set; }

	void onPlusClicked();

	void onMinusClicked();

	void onDivideClicked();

	void onMultiplyClicked();
}

