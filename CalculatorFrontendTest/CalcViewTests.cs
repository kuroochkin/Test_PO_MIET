using Frontend;
using TestStack.White;
using TestStack.White.UIItems;

namespace CalculatorFrontendTest;

[TestFixture]
public class CalcViewTests
{

	[Test]
	public void AdditionButton_Click_ShouldSetOperationToPlus()
	{
		MainWindow mainWindow = new MainWindow();
		
		   
		Assert.AreEqual("+", mainWindow.currentOperator);
	}
}