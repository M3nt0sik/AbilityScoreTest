using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbilityScoreTest
{
    internal class Class_AbilityScoreCalculator
    {
        public int RollResult = 14;
        public double DividedBy = 1.75;
        public int AddAmount = 2;
        public int Minimum = 3;
        public int Score;

        public void CalculateAbilityScore()
        {
            //Results divided by variable DividedBy
            double divided = RollResult / DividedBy;
            // Add AddAmount to results of divided
            int added = AddAmount += (int)divided;

            //if results ism too low use Minimum
            if (added < Minimum) { Score = Minimum; }
            else Score = added;
        }
    }
}
