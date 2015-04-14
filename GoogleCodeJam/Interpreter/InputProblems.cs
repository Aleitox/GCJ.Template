using System.Collections.Generic;

namespace GoogleCodeJam.Interpreter
{
    public class InputProblems
    {
        public InputProblems() 
        {
            Problems = new List<Case.Problem>();
        }

        public int Cases { get; set; }

        public List<Case.Problem> Problems { get; set; }
    }
}
