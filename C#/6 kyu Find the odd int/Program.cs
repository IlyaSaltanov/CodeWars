namespace Solution
{
  class Kata
    {
    public static int find_it(int[] seq) 
      {
      for (int i = 0; i < seq.Length; i++)
        {
          int k = 0;
          var variable = seq[i];
          for (int q = 0; q < seq.Length; q++)
          {
            if (variable == seq[q])
            {
              k++;
            }
          }
          if (k % 2 == 1)
          {
            return variable;
          }
        }
      return 0;
      }  
    }
}