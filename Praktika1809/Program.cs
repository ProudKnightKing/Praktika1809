using System;
using System.Text.RegularExpressions;

namespace Praktika1809
{
  class Program
  {
    private const string V = "89013654026g" +
    "adf+79013654026agad" +
    "fadf+7(901)3654026sadg" +
    "faafda8(901)3654026agadg" +
    "dda8-901-365-40-26gs" +
    "ddsadasad8(901)3654026sgg" +
    "oih[fgwjio +790136540263155" +
    "ddddvsa8-901-365-40-26" +
    "d79013654026";

    static void Main(string[] args)
    {
      string delimited = "([0-9]{11})|([+][0-9]{11})|([+][0-9][(][0-9]{3}[)][0-9]{7})|([0-9][(][0-9]{3}[)][0-9]{7})|([0-9]*[-][0-9]*[-][0-9]*[-][0-9]*[-][0-9]*)";
      string input = V;
      Console.WriteLine("Number");
      foreach (Match match in Regex.Matches(input, delimited))
        Console.WriteLine("{0}", match.Groups[1].Value);
    }
  }
}
