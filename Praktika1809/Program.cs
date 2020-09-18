using System;
using System.Text.RegularExpressions;

namespace Praktika1809
{
  class Program
  {
    private const string V = "fffiohafiheihwfgeihwgehiwtehiwegj9wojhwge+79421447781dasdsadasda\n" +
            "+732598051701570275sad\n" +
            "kfjiogigji8(901)3654026\n";

    static void Main(string[] args)
    {
      string delimited = "([0-9]{11})|([+][0-9]{11})|([+][0-9][(][0-9]{3}[)][0-9]{7})|([0-9][(][0-9]{3}[)][0-9]{7})|([0-9]*[-][0-9]*[-][0-9]*[-][0-9]*[-][0-9]*)";
      string input = V;
      Console.WriteLine("Number");
      foreach (Match match in Regex.Matches(input, delimited))
        Console.WriteLine("{1,10}", match.Groups[1], match.Groups[2].Value, match.Groups[3].Value);
    }
  }
}
