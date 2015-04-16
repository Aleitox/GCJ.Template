using System.Collections.Generic;
using GoogleCodeJam.Interpreter;

namespace GoogleCodeJam.Case
{
    public class Problem
    {
        [Interpreter(Order = 1)]
        public int Credit { get; set; }

        [Interpreter(Order = 2)]
        public int ItemsCount { get; set; }

        [Interpreter(Order = 3, ItitializeAttibutes = new[] { "ItemsCount", "Length" })]
        public List<int> Items { get; set; }

        public string PrintSolution()
        {
            var solution = Solve();
            return solution.ToString();
        }
        
        public Solution Solve()
        {
            var posibleSolution = new Solution();
            return posibleSolution;
        }
    }
}
