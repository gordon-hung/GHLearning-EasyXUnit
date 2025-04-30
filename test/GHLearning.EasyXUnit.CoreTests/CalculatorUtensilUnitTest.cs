using GHLearning.EasyXUnit.Core;

namespace GHLearning.EasyXUnit.CoreTests;

public class CalculatorUtensilUnitTest
{
	[Theory]
	[InlineData(1, 1, 2)]
	[InlineData(1, 2, 3)]
	public void Plus_Int_When_One_Plus_One_Result_Two(int numberOne, int numberTwo, int expected)
	{
		var actual = CalculatorUtensil.Plus(numberOne, numberTwo);

		Assert.Equal(expected, actual);
	}

	[Theory]
	[InlineData(1, 1, 2)]
	[InlineData(1, 2, 3)]
	public void Plus_Decimal_When_One_Plus_One_Result_Two(decimal numberOne, decimal numberTwo, decimal expected)
	{
		var actual = CalculatorUtensil.Plus(numberOne, numberTwo);

		Assert.Equal(expected, actual);
	}

	[Theory]
	[InlineData(1, 1, 0)]
	[InlineData(1, 2, -1)]
	public void Minus_Int_When_One_Minus_One_Result_Zero(int numberOne, int numberTwo, int expected)
	{
		var actual = CalculatorUtensil.Minus(numberOne, numberTwo);

		Assert.Equal(expected, actual);
	}

	[Theory]
	[InlineData(1, 1, 0)]
	[InlineData(1, 2, -1)]
	public void Minus_Decimal_When_One_Minus_One_Result_Zero(decimal numberOne, decimal numberTwo, decimal expected)
	{
		var actual = CalculatorUtensil.Minus(numberOne, numberTwo);

		Assert.Equal(expected, actual);
	}
}
