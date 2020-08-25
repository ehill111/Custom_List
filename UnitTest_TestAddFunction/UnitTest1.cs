using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace UnitTest_TestAddFunction
{
    [TestClass]
    public class CustomListAddFunctionTest
    {
        [TestMethod]
        public void Add_AddFiveValues_CountOfFive() //Check count of add.
        {
            //Arrange
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
        public void Add_AddThreeValues_CapacityOf8() //Check capacity of add.
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int expectedValue = 8;
            int actualValue;

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);

            //Assert
            Assert.AreEqual(expectedValue, actualValue);

        }
        
        [TestMethod]
        public void Add_String() //Check string of add.
        {
            //Arrange
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
            CustomList<string> customList = new CustomList<string>();
            string value1 = ("Not Null Value");
            string value2 = ("Not Null Value");
            string value3 = ("Not Null Value");
            string expectedValue = ("Not Null Value");
            string actualValue;

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);

            //Assert
            Assert.IsNotNull(expectedValue, actualValue);
        }
        [TestMethod]
        public void Remove_ItemFromList()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value1;
            int value2;
            int value3;
            int value4;
            int value5;
            int expected = Create;
            int actual;

            //



        }






    }

}