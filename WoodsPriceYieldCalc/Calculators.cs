using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodsPriceYieldCalc
{
  public class Calculators
  {
    public static double CalcPrice(double coupon, int years, double face, double rate)
    {
      double price = 0, payment = face*coupon;
      for (int year = 1; year <= years; year++)
      {
        price += payment / (Math.Pow(1 + rate, year));
      }
      price += face / (Math.Pow(1 + rate, years));
      return price;
    }
    public static double CalcYield(double coupon, int years, double face, double price)
    {
      double rate = 0, payment = coupon * face, epsilon = 1;
      rate = (payment + ((face - price) / years)) / ((face + price) / 2);
      double estPrice = CalcPrice(coupon, years, face, rate);
      while (Math.Abs(estPrice - price) > 0.0000001)
      {
        if (estPrice > price)
        {
          rate += epsilon;
          estPrice = CalcPrice(coupon, years, face, rate);
        }
        else
        {
          rate -= epsilon;
          estPrice = CalcPrice(coupon, years, face, rate);
        }
        epsilon = epsilon / 2;
      }
      return rate;
    }
  }
}
