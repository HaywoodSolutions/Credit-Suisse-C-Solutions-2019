using System;
using System.Linq;

namespace Answers {
  public class Question3 {
    static int countOccurrences (int[] arr, int x) {
      int res = 0;
      for (int i = 0; i < arr.Length; i++)
        if (x == arr[i])
          res++;
      return res;
    }

    public static int Answer (int[] scores, int[] alice) {
      scores = scores.Distinct ().ToArray ();
      Array.Sort (scores);
      Array.Reverse (scores);
      int[] rank = new int[alice.Length];
      for (int i = 0; i < alice.Length; i++) {
        int r = 0;
        for (int j = 0; j < scores.Length; j++) {
          if (alice[i] >= scores[j]) {
            break;
          } else {
            r += 1;
          }
        }
        rank[i] = r + 1;
      }
      int[] rankset = rank.Distinct ().ToArray ();
      int[] c = new int[rankset.Length];
      for (int j = 0; j < rankset.Length; j++) {
        c[j] = countOccurrences (rank, rankset[j]);
      }
      int mc = c.Max ();
      if (countOccurrences (c, mc) == 1) {
        return rankset[Array.IndexOf (c, mc)];
      } else {
        int[] s = new int[c.Length];
        for (int i = 0; i < c.Length; i++) {
          if (c[i] == mc) {
            s[i] = rankset[i];
          }
        }
        return s.Max ();
      }
    }
  }
}