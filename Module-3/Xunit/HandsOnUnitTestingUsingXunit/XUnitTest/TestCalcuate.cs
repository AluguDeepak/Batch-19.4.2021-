using System;
using Xunit;
using CalculateService;
using System.Collections.Generic;

namespace XUnitTest
{
    public class TestCalcuate
    {
      
        
        [Fact]
        public void TestAdd()
        {
            //Act
            Calculate obj = new Calculate();
            int expected = 2;
            //Arrange
            int actual = obj.Add(1, 2);
           
            //Assessrt
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void TestDiv()
        {
            Calculate obj = new Calculate();
            int expected = 5;
            int actual = obj.Div(10,2);
            Assert.Equal(expected, actual);
            
        }
        [Fact]
        public void TestGetNo()
        {
            //Act
            Calculate obj = new Calculate();
            List<int> list = obj.GetNos();
            Assert.NotNull(list);
           // Assert.Equal(5, list.Count);
           
        }
    }
}
