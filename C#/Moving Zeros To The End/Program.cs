public class Kata
{
  public static int[] MoveZeroes(int[] arr)
  {
    int col = arr.Length * 2;
    while (col != 0)
    {
      for (int i = 0; i < arr.Length - 1; i++)
      {
        if (arr[i] == 0)
        {
          var nextNumbre = arr[i+1];
          var nole = arr[i];
          arr[i+1] = nole;
          arr[i] = nextNumbre;
        }
      }
      col -= 1;
    }
    return arr;
  }
}