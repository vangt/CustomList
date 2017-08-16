using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList.Classes;

namespace CustomNewListUnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Get_Array_Size()
        {
            //Arrange
            CustomNewList<string> customList = new CustomNewList<string>();
            int expectedResult = 0;

            //Act
            int result = customList.Count;

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Add_Array_IncreaseSize()
        {
            //Arrange
            CustomNewList<string> customList = new CustomNewList<string>();
            int increaseBy = 1;
            int expectedResult = 1;

            //Act
            customList.Capcity(1);
            int result = customList.Count;

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Add_Array_ObjectAdd()
        {
            //Arrange
            CustomNewList<string> customList = new CustomNewList<string>();
            string name = "Tim";
            string expectedResult = "Tim";

            //Act
            string result = customList[0];

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
