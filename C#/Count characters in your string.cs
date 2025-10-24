using System.Collections.Generic;
using System;
using System.Linq;

public class Kata
{
  public static Dictionary<char, int> Count(string str)
  {
    Dictionary<char, int> dict = new Dictionary<char, int>();
    HashSet<char> sp = new HashSet<char>(str);
    string st = new string(sp.ToArray());
    for (int i = 0; i < st.Length; i++)
      {
      int count = 0;
      foreach (char bukv in str)
        {
        if (bukv == st[i])
          {
          count++;
        }
      }
      dict.Add(st[i], count);
    }
    return dict;
  }
}
