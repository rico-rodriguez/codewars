using System.Collections.Generic;

public class Kata
{
  public static List<int> ReverseList(List<int> list)
  {
    var reverse = new List<int>(list);
    reverse.Reverse();
    return reverse;      
  }
}
