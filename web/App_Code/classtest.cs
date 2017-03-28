using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// classtest の概要の説明です
/// </summary>
public class Complex
{
  public double re; // 実部を記憶しておく(外部からの読み出し・書き換えも可能)
  public double im; // 虚部を記憶しておく(外部からの読み出し・書き換えも可能)

  // 絶対値を取り出す
  public double Abs()
  {
    return Math.Sqrt(re * re + im * im);// Math.Sqrt は平方根を求める関数
  }

  public override string ToString()
  {
    if(im > 0)
      return re.ToString() + "+i" + im.ToString();
    if(im < 0)
      return re.ToString() + "-i" + (-im).ToString();
    return re.ToString();
  }
}