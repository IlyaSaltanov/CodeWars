﻿public static class Kata
{
  public static int Solution(int value)
  {
    int count = 0;
    for (int i = 0; i < value; i++)
      {
      if (i % 3 == 0 || i % 5 == 0)
        {
        count = count + i;
      }
    }
    return count;
  }
}