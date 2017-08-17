using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList.Classes;

namespace CustomNewListUnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Get_List_Size()
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
        public void Get_List_SizeOfOne()
        {
            //Arrange
            CustomNewList<string> customList = new CustomNewList<string>();
            string addString = "Tim";
            int expectedResult = 1;

            //Act
            customList.Add(addString);
            int result = customList.Count;

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Prevent_List_SizeOfNegative()
        {
            //Arrange
            CustomNewList<string> customList = new CustomNewList<string>();
            int index = 0;

            //Act
            customList.RemoveAt(index);            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Prevent_List_NoObject()
        {
            //Arrange
            CustomNewList<string> customList = new CustomNewList<string>();
            int index = 3;

            //Act
            customList.RemoveAt(index);
        }

        [TestMethod]
        public void Add_List_IncreaseSize()
        {
            //Arrange
            CustomNewList<string> customList = new CustomNewList<string>();
            string name = "Tim";
            int expectedResult = 1;

            //Act
            customList.Add(name);
            int result = customList.Count;

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Find_Item_ListItem()
        {
            //Arrange
            CustomNewList<int> customList = new CustomNewList<int>();
            int number = 7;
            int expectedResult = 7;

            //Act
            customList.Add(number)
            string result = customList[0];

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Add_List_ObjectAdd()
        {
            //Arrange
            CustomNewList<string> customList = new CustomNewList<string>();
            string name = "Tim";
            string expectedResult = "Tim";

            //Act
            customList.Add(name);
            string result = customList[0];

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Check_List_ZeroIndex()
        {
            //Arrange
            CustomNewList<string> customList = new CustomNewList<string>();
            string name = "Tim";
            string nametwo = "Joe";
            string expectedResult = "Joe";

            //Act
            customList.Add(name);
            customList.Add(nametwo);
            customList.Remove(0);
            string result = customList[0];

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Remove_List_ObjectRemove()
        {
            //Arrange
            CustomNewList<string> customList = new CustomNewList<string>();
            string name = "Tim";
            int expectedResult = 0;

            //Act
            customList.Add(name);
            customList.Remove("Tim");
            int result = customList.Count;

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Iterate_List_Objects()
        {
            //Arrange
            CustomNewList<string> customList = new CustomNewList<string>();
            //TODO: Add code that iterates through list?

            //Act

            //Assert
        }

        [TestMethod]
        public void Override_ToString_NewReturn()
        {
            //Arrange
            CustomNewList<string> customList = new CustomNewList<string>();
            
            //Act

            //Assert
        }
    }
}
