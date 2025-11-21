using System.Linq;
using System.Collections.Generic;
class WhichAreIn
{
    public static string[] inArray(string[] array1, string[] array2)
    {
        //       string[] r = new string[array1.Length];
        List<string> r = new List<string>();
        for (int i = 0; i < array1.Length; i++)
        {
            string word = array1[i];
            for (int q = 0; q < array2.Length; q++)
            {
                string fullWord = array2[q];
                if (fullWord.Contains(word))
                {
                    //             r[i] = word;
                    r.Add(word);
                    break;
                }
            }
        }
        //     r = r.OrderBy(w => w).ToArray();
        //     return r;
        return r.OrderBy(w => w).ToArray();
    }
}


