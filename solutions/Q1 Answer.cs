using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;


namespace Answers {
  public class Question1 {
    public static int Answer (double initialLevelOfDebt, double interestPercentage, double repaymentPercentage) {
      double monthly_payment = initialLevelOfDebt * repaymentPercentage / 100.0;
      double currentDept = initialLevelOfDebt;
      interestPercentage = 1 + interestPercentage / 100;
      int months = 0;
      while (currentDept > monthly_payment) {
        currentDept = currentDept * interestPercentage - monthly_payment;
        months += 1;
      }
      return (int) Math.Round (months * monthly_payment + currentDept + 0.1 * initialLevelOfDebt, MidpointRounding.AwayFromZero);
    }
  }
}
© 2019 GitHub, Inc.