using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// PartialClassStudy の概要の説明です
/// </summary>
partial class Program
{
  static void Main(string[] arts)
  {
    OnBeginProgram();

    Console.Write("program body\n");

    OnEndProgram();
  }

  static partial void OnBeginProgram();
  static partial void OnEndProgram();
}
