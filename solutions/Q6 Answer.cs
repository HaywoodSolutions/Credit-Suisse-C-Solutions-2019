namespace Answers {
  public class Question6 {
    public static int Answer (string[] input) {
      string f = input[0];
      char s = f[0];
      char e = f[f.Length - 1];
      for (int i = input.Length - 1; i >= 0; i--) {
        if (input[i][0] == s && input[i][input[i].Length - 1] == e) {
          return i;
        }
      }
      return -1;
    }
  }
}