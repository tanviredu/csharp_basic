using System;
using Xunit;

namespace gradebook.test
{
    public class UnitTest1
    {

        // test method should have the attribute
        // [Fact] the xunit will only invoke the 
        // [Fact] method for testing
        // other function will be considered as 
        // a helper function
        [Fact]
        public void Test1()
        {
            // there are a number of assert static
            // method in unit test assret class
            // lets test with a  2 number
            // with expected value and predicted value

            var x = 5;
            var y = 2;
            var actual = x+y;
            var expected = 7;
            Assert.Equal(expected,actual);



            // now basically unit test function divided into three
            //section

            // arrange [all the data arrange here]


            // act [all the function will be there]


            // assert [the main test is doing here] 


        }
    }
}
