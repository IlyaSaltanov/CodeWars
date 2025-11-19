using System.Collections.Generic;
using System.Text;
public static class VowelCode
{
  static Dictionary<char, char> dict = new Dictionary<char, char>{
    {'a','1'},
    {'e','2'},
    {'i','3'},
    {'o','4'},
    {'u','5'}
    };
  static Dictionary<char, char> dictDecode = new Dictionary<char, char>{
    {'1','a'},
    {'2','e'},
    {'3','i'},
    {'4','o'},
    {'5','u'}
    };
  public static string Encode(string msg)
  {
    StringBuilder myStringBuilder = new StringBuilder(msg);
    for (int i = 0; i < msg.Length; i++)
    {
      if (dict.ContainsKey(msg[i]))
      {
        myStringBuilder.Replace(msg[i], dict[msg[i]]);
      }
    }
    return myStringBuilder.ToString();
  }
  
  public static string Decode(string msg)
  {
    StringBuilder myStringBuilder = new StringBuilder(msg);
    for (int i = 0; i < msg.Length; i++)
    {
      if (dictDecode.ContainsKey(msg[i]))
      {
        myStringBuilder.Replace(msg[i], dictDecode[msg[i]]);
      }
    }
    return myStringBuilder.ToString();
  }
}
