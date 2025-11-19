using System;

public class Kata
{
  public static string ToCamelCase(string str)
  {
    string[] sp = str.Split(new char[] {'-', '_'});
    for (int i = 1; i < sp.Length; i++)
    {
       sp[i] = char.ToUpper(sp[i][0]) + sp[i].Substring(1);
    }
    return string.Join("",sp);
  }
}