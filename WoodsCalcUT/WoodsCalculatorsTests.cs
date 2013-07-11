using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WoodsPriceYieldCalc;

namespace WoodsCalcUT
{
  [TestClass]
  public class WoodsCalculatorsTests
  {
    [TestMethod]
    public void TestProvidedExamples()
    {
      double tolerance = 0.0000001;
      Assert.AreEqual(Calculators.CalcPrice(0.10, 5, 1000, 0.15), 832.3922451, tolerance);
      Assert.AreEqual(Calculators.CalcYield(0.10, 5, 1000, 832.4), 0.149997376, tolerance);
      Assert.AreEqual(Calculators.CalcPrice(0.15, 5, 1000, 0.15), 1000.0000000, tolerance);
      Assert.AreEqual(Calculators.CalcPrice(0.10, 5, 1000, 1000), 0.100000000, tolerance);
      Assert.AreEqual(Calculators.CalcPrice(0.10, 5, 1000, 0.08), 1079.8542007, tolerance);
      Assert.AreEqual(Calculators.CalcYield(0.10, 5, 1000, 1079.85), 0.080000999, tolerance);
      Assert.AreEqual(Calculators.CalcPrice(0.10, 30, 1000, 0.19), 528.8807463, tolerance);
      Assert.AreEqual(Calculators.CalcYield(0.10, 30, 1000, 528.8807463), 0.190000000, tolerance);
    }
  }
}
