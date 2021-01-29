using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeDemo.FunctionTest
{
    static class TestHelper
    {
        public static void DoesNotThrows<T>(Action expressionUnderTest, string exceptionMessage = "Expected exception was thrown by target of invocation.") where T : Exception
        {
            try
            {
                expressionUnderTest();
            }
            catch (T)
            {
                Assert.Fail(exceptionMessage);
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }

            Assert.IsTrue(true);
        }

    }
}
