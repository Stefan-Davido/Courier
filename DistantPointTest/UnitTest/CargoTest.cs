using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Assert = Xunit.Assert;

namespace UnitTest
{
    [TestClass]
    public class CargoTest
    {
        [Theory]
        [InlineData(8,4,2)]
        public void Price_Check(double x, double y, double expected)
        {
            // arrange
            // act
            double actual = x / y;
            // assert
           Assert.Equal(expected, actual);
        }
        
        [Theory]
        [InlineData(4.5,6)]
        public void Testing(double x, double y)
        {
            // arrange
            List<double> list = new List<double>();
            list.Add(y);
            list.Add(x);
            list.Sort();
            // act
            double actual = list[0];
            // assert
           Assert.Equal(4.5, actual);
        }
        
        [Fact]
        public void NewTest()
        {
            // arrange
            double expect = 2*2*2*2*3*3 ;
            // act
            double actual = 144;
            // assert
           Assert.Equal(expect, actual);
        }


    }
}
