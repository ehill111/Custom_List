using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace UnitTest_TestAddFunction
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
        public void Add_AddFiveValues_DoesCapacityDouble() //Check doubling function of capacity.
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

            actualValue = customList.Capacity;//The fifth value should make capacity go from 4 to 8.

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void Add_String() //Check string of add.
        {
            //Arrange
            //Instantiate, create variables, include expected and actual
            CustomList<string> customList = new CustomList<string>();
            string value1 = ("String Output");
            string expectedValue = ("String Output");
            string actualValue;

            //Act
            customList.Add(value1);
            actualValue = customList[0];

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void Add_CheckToSeeIfNull()//Check null value of add.
        {   //Arrange
            //Instantiate, create variables, include expected and actual
            CustomList<string> customList = new CustomList<string>();
            string value1 = ("Not Null Value");
            string value2 = ("Not Null Value");
            string value3 = ("Not Null Value");
            string expectedValue = null;
            string actualValue;

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            actualValue = customList[3];
            
            //Assert
            Assert.IsNull(expectedValue, actualValue);
        }
                                //BELOW ARE THE REMOVE TESTS
        [TestMethod]
        public void Remove_ItemFromList()
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
        public void Remove_ItemFromListByIndex()
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
            customList.RemoveAt(3);
            actual = customList.Count;
             
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_CheckCountAfterRemoval()
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
            string expected = 4;
            string actual;
        }

        [TestMethod]
        public void Remove_CheckCapacityAfterRemoval()
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
            string expected = 8;
            string actual;//Capacity would have decreased from 16.
        }

        [TestMethod]
        public void Remove_RemoveMultipleObjects()
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
            string expected = 5;
            string actual;
        }

    }






}

