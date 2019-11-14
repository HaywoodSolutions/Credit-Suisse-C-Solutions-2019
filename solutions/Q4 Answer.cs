using System;

namespace Answers {
  public class Question4 {
    public static int Answer (int[] rank, int[] complexity, int capacity) {
      int[] matrix = new int[capacity+1];
      for (int i=0; i < rank.Length; i++) {
        for (int j=capacity; j > complexity[i]-1; j--) {
          matrix[j] = Math.Max(matrix[j], rank[i] + matrix[j - complexity[i]]);
        }
      }
      return matrix[capacity];
    }
  }
}