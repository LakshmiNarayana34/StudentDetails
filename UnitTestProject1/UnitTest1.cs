using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;


namespace UnitTestProject1
{
    public class UnitTest1
    {
        
        [Fact]
        public void NewTest()
        {
            if (Sum(2, 2) != 4)
                throw new Exception();
        }

        int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
