namespace WoodsPriceYieldCalc
{
  partial class WoodsPYTMCalc
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WoodsPYTMCalc));
      this.autoClipboard = new System.Windows.Forms.CheckBox();
      this.YearsLabel = new System.Windows.Forms.Label();
      this.CouponLabel = new System.Windows.Forms.Label();
      this.FaceLabel = new System.Windows.Forms.Label();
      this.GetPrice = new System.Windows.Forms.Button();
      this.GetYTM = new System.Windows.Forms.Button();
      this.Years = new System.Windows.Forms.NumericUpDown();
      this.Coupon = new System.Windows.Forms.NumericUpDown();
      this.Face = new System.Windows.Forms.NumericUpDown();
      this.Price = new System.Windows.Forms.NumericUpDown();
      this.YTM = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.Years)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Coupon)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Face)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Price)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.YTM)).BeginInit();
      this.SuspendLayout();
      // 
      // autoClipboard
      // 
      resources.ApplyResources(this.autoClipboard, "autoClipboard");
      this.autoClipboard.Checked = true;
      this.autoClipboard.CheckState = System.Windows.Forms.CheckState.Checked;
      this.autoClipboard.Name = "autoClipboard";
      this.autoClipboard.UseVisualStyleBackColor = true;
      // 
      // YearsLabel
      // 
      resources.ApplyResources(this.YearsLabel, "YearsLabel");
      this.YearsLabel.Name = "YearsLabel";
      // 
      // CouponLabel
      // 
      resources.ApplyResources(this.CouponLabel, "CouponLabel");
      this.CouponLabel.Name = "CouponLabel";
      // 
      // FaceLabel
      // 
      resources.ApplyResources(this.FaceLabel, "FaceLabel");
      this.FaceLabel.Name = "FaceLabel";
      // 
      // GetPrice
      // 
      resources.ApplyResources(this.GetPrice, "GetPrice");
      this.GetPrice.Name = "GetPrice";
      this.GetPrice.UseVisualStyleBackColor = true;
      this.GetPrice.Click += new System.EventHandler(this.GetPrice_Click);
      // 
      // GetYTM
      // 
      resources.ApplyResources(this.GetYTM, "GetYTM");
      this.GetYTM.Name = "GetYTM";
      this.GetYTM.UseVisualStyleBackColor = true;
      this.GetYTM.Click += new System.EventHandler(this.GetYTM_Click);
      // 
      // Years
      // 
      resources.ApplyResources(this.Years, "Years");
      this.Years.Name = "Years";
      this.Years.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
      // 
      // Coupon
      // 
      this.Coupon.DecimalPlaces = 10;
      this.Coupon.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
      resources.ApplyResources(this.Coupon, "Coupon");
      this.Coupon.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.Coupon.Name = "Coupon";
      this.Coupon.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
      // 
      // Face
      // 
      this.Face.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
      resources.ApplyResources(this.Face, "Face");
      this.Face.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
      this.Face.Name = "Face";
      this.Face.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      // 
      // Price
      // 
      this.Price.DecimalPlaces = 7;
      resources.ApplyResources(this.Price, "Price");
      this.Price.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
      this.Price.Name = "Price";
      this.Price.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      // 
      // YTM
      // 
      this.YTM.DecimalPlaces = 10;
      this.YTM.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
      resources.ApplyResources(this.YTM, "YTM");
      this.YTM.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.YTM.Name = "YTM";
      this.YTM.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
      // 
      // WoodsPYTMCalc
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.YTM);
      this.Controls.Add(this.Price);
      this.Controls.Add(this.Face);
      this.Controls.Add(this.Coupon);
      this.Controls.Add(this.Years);
      this.Controls.Add(this.GetYTM);
      this.Controls.Add(this.GetPrice);
      this.Controls.Add(this.FaceLabel);
      this.Controls.Add(this.CouponLabel);
      this.Controls.Add(this.YearsLabel);
      this.Controls.Add(this.autoClipboard);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.Name = "WoodsPYTMCalc";
      this.Opacity = 0.85D;
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.TopMost = true;
      ((System.ComponentModel.ISupportInitialize)(this.Years)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Coupon)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Face)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Price)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.YTM)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.CheckBox autoClipboard;
    private System.Windows.Forms.Label YearsLabel;
    private System.Windows.Forms.Label CouponLabel;
    private System.Windows.Forms.Label FaceLabel;
    private System.Windows.Forms.Button GetPrice;
    private System.Windows.Forms.Button GetYTM;
    private System.Windows.Forms.NumericUpDown Years;
    private System.Windows.Forms.NumericUpDown Coupon;
    private System.Windows.Forms.NumericUpDown Face;
    private System.Windows.Forms.NumericUpDown Price;
    private System.Windows.Forms.NumericUpDown YTM;
  }
}

