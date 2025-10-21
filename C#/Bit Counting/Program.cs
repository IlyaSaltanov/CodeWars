using System;

public class Kata
{
    public static int CountBits(int n)
    {
      int count = 0;
      string str = Convert.ToString(n, 2);
      foreach (char a in str)
        {
        if (a == '1')
          {
          count++;
        }
      }
    return count;
    }
}