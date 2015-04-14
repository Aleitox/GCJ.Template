using System;
using System.Collections.Generic;
using GoogleCodeJam.FileIO;
using GoogleCodeJam.Interpreter;

namespace GoogleCodeJam
{
    class Program
    {
        static void Main(string[] args)
        {
            var aProblem = new Case.Problem();
            var fileManger = new FileManager();
            var input = fileManger.ReadFile();
            var initializer = new ObjectInitializer(aProblem);

            var inputProblems = initializer.InitializeObject(input);

            var printSolutions = new List<string>();
            for (var index = 0; index < inputProblems.Cases; index++)
            {
                printSolutions.Add(string.Format("Case #{0}: {1}", (index + 1), inputProblems.Problems[index].PrintSolution()));
                Console.WriteLine("Case {0} completed.", index + 1);
            }

            fileManger.WriteFile(printSolutions);
        }
    }
}
