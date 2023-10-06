using Test_PO_MIET.Interfaces;
using Test_PO_MIET.Realization;

namespace CalculatorTests;

[TestFixture]
public class CalculatorTests
{
	public ICalculator calculator = new Calculator();

	[Test]
	public void Add_WhenGivenTwoNumbers_ReturnsCorrectSum()
	{
		double result = calculator.Sum(5, 3);
		Assert.AreEqual(8, result);
	}

	[Test]
	public void Subtract_WhenGivenTwoNumbers_ReturnsCorrectDifference()
	{
		double result = calculator.Subtract(10, 3);
		Assert.AreEqual(7, result);
	}

	[Test]
	public void Multiply_WhenGivenTwoNumbers_ReturnsCorrectProduct()
	{
		double result = calculator.Multiply(4, 6);
		Assert.AreEqual(24, result);
	}

	[Test]
	public void Divide_WhenGivenTwoNumbers_ReturnsCorrectQuotient()
	{
		double result = calculator.Divide(12, 4);
		Assert.AreEqual(3, result);
	}

	[Test]
	public void Divide_DividingByZero_ThrowsException()
	{
		Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
	}
}