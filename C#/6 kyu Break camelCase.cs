using System.Collections.Generic;

public class Kata
{
  public static string BreakCamelCase(string str)
  {
    // complete the function
    List<string> sp = new List<string>();
    int start = 0;
    int i = 0;
    for(; i < str.Length; i++)
      {
      if (str[i] == char.ToUpper(str[i]))
        {
        sp.Add(str.Substring(start, i - start));
        start = i;
      }
    }
    sp.Add(str.Substring(start));
    string st = "";
    foreach(string element in sp)
      {
      st = st + " " + element;
    }
    return st.Substring(1);
  }
}