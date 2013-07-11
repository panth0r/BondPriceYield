using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoodsPriceYieldCalc
{
  public partial class WoodsPYTMCalc : Form
  {
    public WoodsPYTMCalc()
    {
      InitializeComponent();
    }

    private void GetPrice_Click(object sender, EventArgs e)
    {
      int years = (int)Years.Value;
      double coupon = (double)Coupon.Value, face = (double)Face.Value, rate = (double)YTM.Value;
      double price = Calculators.CalcPrice(coupon, years, face, rate);
      Price.Value = (decimal)price;
      if (autoClipboard.Checked)
        Clipboard.SetText(price.ToString("f7"));
    }

    private void GetYTM_Click(object sender, EventArgs e)
    {
      int years = (int)Years.Value;
      double coupon = (double)Coupon.Value, face = (double)Face.Value, price = (double)Price.Value;
      double rate = Calculators.CalcYield(coupon, years, face, price);
      YTM.Value = (decimal)rate;
      if (autoClipboard.Checked)
        Clipboard.SetText(rate.ToString("f7"));
    }
  }
}
