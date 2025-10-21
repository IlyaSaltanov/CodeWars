using System;
using System.Globalization;
public static class JadenCase
{
  public static string ToJadenCase(this string phrase)
  {
    return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);
  }
}