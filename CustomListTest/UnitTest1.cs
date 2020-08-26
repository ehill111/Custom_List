using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;
using System.CodeDom;

namespace CustomListTest
{
    [TestClass]
    public class CustomListAddFunctionTest
    {                           //THE NEXT FIVE ARE THE ADD TESTS
        [TestMethod]
        public void Add_AddFiveValues_CountOfFive() //Check count of add.
        {
            //Arrange
            //Instantiate, create variables, include expected and actual
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int expected = 5;
            int actual;


            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);
            customList.Add(value5);
            actual = customList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddFourValues_CapacityOf4() //Check capacity of add.
        {
            //Arrange
            //Instantiate, create variables, include expected and actual
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int expectedValue = 4;
            int actualValue;

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);

            actualValue = customList.Capacity;//The four values make capacity go from 0 to 4, since the default of capacity is 0.

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void Add_AddFiveValues_CapacityDoubles4To8() //Check doubling function of capacity.
        {
            //Arrange
            //Instantiate, create variables, include expected and actual
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int expectedValue = 8;
            int actualValue;

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);
            customList.Add(value5);

            actualValue = customList.Capacity;//The fifth value should make capacity go from 4 to 8. This is assuming the system makes an array of 4 the moment the first item is added to the list irrespective of it being instanced yet. If instantiation is necessary prior to giving array size, then array size would go from the default of zero directly to eight once the default reaches its max (or perhaps when the fifth item is input?).

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void Add_String() //Check string of add.
        {
            //Arrange
            //Instantiate, create variables, include expected and actual
            CustomList<string> customList = new CustomList<string>();
            string value1 = ("Dog");
            string expectedValue = ("Dog");
            string actualValue;

            //Act
            customList.Add(value1);
            actualValue = customList[0];

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Add_CheckIndexOutOfRange_ExceptionThrown() //Wow. This opens a whole new area of testing.
        {   //Arrange
            //Instantiate, create variables, include expected and actual
            CustomList<string> customList = new CustomList<string>();
            string value1 = ("Dog");
            string value2 = ("Dog");
            string value3 = ("Dog");
            string expectedResult = ArgumentOutOfRange;//I thought null would produce true or false. MS documentation said it would produce a string.
            string actualResult;

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            actualResult = customList[3];

            //Assert
            Assert.ArgumentOutOfRange(expectedResult, actualResult);
        }
        //BELOW ARE THE REMOVE TESTS
        [TestMethod]
        public void Remove_SingleItemFromList_DecrementOfItem()
        {
            //Arrange
            //Instantiate, create variables, include expected and actual
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int expected = 4;
            int actual;

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);
            customList.Add(value5);
            customList.Remove(value1);
            actual = customList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_SingleValue_CountOf4()
        {
            //Arrange
            //Instantiate, create variables, include expected and actual
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int expected = 4;
            int actual;

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);
            customList.Add(value5);
            customList.Remove(value1);
            actual = customList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveOneValue_CountOf4()
        {
            //Arrange
            //Instantiate, create variables, include expected and actual
            CustomList<int> customList = new CustomList<int>();
            int value1;
            int value2;
            int value3;
            int value4;
            int value5;

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);
            customList.Add(value5);
            customList.Remove(value1);
            actual = customList.Count;

            //Assert
            int expected = 4;
            int actual;
        }

        [TestMethod]
        public void Remove_RemoveOneValue_CapacityOf8()
        {
            //Arrange
            //Instantiate, create variables, include expected and actual
            CustomList<int> customList = new CustomList<int>();
            int value1;
            int value2;
            int value3;
            int value4;
            int value5;
            int value6;
            int value7;
            int value8;
            int value9;

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);
            customList.Add(value5);
            customList.Add(value6);
            customList.Add(value7);
            customList.Add(value8);
            customList.Add(value9);
            customList.Remove(value1);
            actual = customList.Capacity;

            //Assert
            int expected = 8;
            int actual;//Capacity would have decreased from 16.
        }

        [TestMethod]
        public void Remove_RemoveFourValues_CountOf5()
        {
            //Arrange
            //Instantiate, create variables, include expected and actual
            CustomList<int> customList = new CustomList<int>();
            int value1;
            int value2;
            int value3;
            int value4;
            int value5;
            int value6;
            int value7;
            int value8;
            int value9;

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);
            customList.Add(value5);
            customList.Add(value6);
            customList.Add(value7);
            customList.Add(value8);
            customList.Add(value9);
            customList.Remove(value1);
            customList.Remove(value2);
            customList.Remove(value3);
            customList.Remove(value4);
            actual = customList.Count;

            //Assert
            int expected = 5;
            int actual;
        }

    }
}
