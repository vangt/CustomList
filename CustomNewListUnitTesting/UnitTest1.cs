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
        public void Prevent_List_SizeOfNegative()
        {
            //Arrange
            CustomNewList<string> customList = new CustomNewList<string>();

            //Act

            //Assert
        }

        [TestMethod]
        public void Add_List_IncreaseSize()
        {
            //Arrange
            CustomNewList<string> customList = new CustomNewList<string>();
            int increaseBy = 1;
            int expectedResult = 1;

            //Act
            customList.Capcity;
            int result = customList.Count;

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Find_Item_ListItem()
        {
            //Arrange
            CustomNewList<int> customList = new CustomNewList<int>();
            int indexNumber = 0;
            int expectedResult = 0;

            //Act
            customList.Capcity;
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
            customList.Capacity;
            customList.Add(name);
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
            customList.Capacity;
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
