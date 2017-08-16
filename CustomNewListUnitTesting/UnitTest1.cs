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
            string stringOne = "Tim";
            int expectedResult = 1;

            //Act
            customList[0] = stringOne;
            int result = customList.Count;

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
