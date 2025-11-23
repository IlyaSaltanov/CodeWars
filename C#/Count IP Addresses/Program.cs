using System;

public class CountIPAddresses
{
   public static long IpsBetween(string start, string end)
   {
      var spStart = start.Split('.');
      var spEnd = end.Split('.');
      
      int[] spIntStart = new int[spStart.Length];
      int[] spIntEnd = new int[spEnd.Length];
     
      for (int q = 0; q < spEnd.Length; q++)
      {
        spIntStart[q] = int.Parse(spStart[q]);
        spIntEnd[q] = int.Parse(spEnd[q]);
      }
      
      long s1 = 0;
      long s2 = 0;
      s1 = (spIntStart[0] * (long)Math.Pow(256, 3)) + ((spIntStart[1] * (long)Math.Pow(256, 2))) + ((spIntStart[2] * (long)Math.Pow(256, 1))) + spIntStart[3];
      s2 = (spIntEnd[0] * (long)Math.Pow(256, 3)) + ((spIntEnd[1] * (long)Math.Pow(256, 2))) + ((spIntEnd[2] * (long)Math.Pow(256, 1))) + spIntEnd[3];
     
      return s2 - s1;
   }
}