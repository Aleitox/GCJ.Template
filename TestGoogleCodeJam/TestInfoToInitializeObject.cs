using GoogleCodeJam.Case;
using GoogleCodeJam.Interpreter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestGoogleCodeJam
{
    [TestClass]
    public class TestInfoToInitializeObject
    {
        [TestMethod]
        public void TestConstructor()
        {
            var problem = new Problem();
            var hola = new ObjectInitializer(problem);
        }
    }
}
