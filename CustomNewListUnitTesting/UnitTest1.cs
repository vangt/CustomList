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
            int number = 3;
            int numberTwo = 7;
            int expectedResult = 7;

            //Act
            customList.Add(number);
            customList.Add(numberTwo);
            string result = customList[1];

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
            string name = "Tim";
            string nametwo = "Joe";
            string namethree = "Mark";
            string expectedResult = "Tim ,Joe, Mark";

            //Act
            customList.Add(name);
            customList.Add(nametwo);
            customList.Add(namethree);
            string result = customList.FindAll(string);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Check_List_ReturnSuperString()
        {
            //Arrange
            CustomNewList<int> customList = new CustomNewList<int>();
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            string expectedResult = "123";

            //Act
            string result = customList.String();

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Error_List_DataType()
        {
            //Arrange
            CustomNewList<bool> customList = new CustomNewList<bool>();
            customList.Add(false);
            customList.Add(true);

            //Act
            decimal result = customList[0];
        }

        [TestMethod]
        public void Add_List_OverloadPlus()
        {
            //Arrange
            CustomNewList<string> customList = new CustomNewList<string>();
            CustomNewList<string> customListTwo = new CustomNewList<string>();

            string name = "Tim";
            string nameTwo = "Joe";
            string nameThree = "Mark";
            string nameFour = "Peter";
            string expectedResult = "Mark";

            //Act
            customList.Add(name);
            customList.Add(nameTwo);
            customListTwo.Add(nameThree);
            customListTwo.Add(nameFour);

            CustomNewList<string> customListThree = customList + customListTwo;

            string result = customListThree[3];

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Subtract_List_OverloadMinus()
        {
            //Arrange
            CustomNewList<int> customList = new CustomNewList<int>();
            CustomNewList<int> customListTwo = new CustomNewList<int>();
            int firstNumber = 10;
            int secondNumber = 1;
            int thirdNumber = 1;
            int forthNumber = 9;
            int fifthNumber = 10;
            int expectedResult = 9;

            //Act
            customList.Add(firstNumber);
            customList.Add(secondNumber);
            customListTwo.Add(thirdNumber);
            customListTwo.Add(forthNumber);
            customListTwo.Add(fifthNumber);

            customListTwo = customListTwo - customList;

            int result = customListTwo[0];

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Zip_List_CombinedList()
        {
            //Arrange
            CustomNewList<int> customList = new CustomNewList<int>();
            CustomNewList<int> customListTwo = new CustomNewList<int>();
            CustomNewList<int> customListThree = new CustomNewList<int>();
            int firstNumber = 1;
            int secondNumber = 2;
            int thirstNumber = 3;
            int forthNumber = 4;
            int fifthNumber = 5;
            int sixthNumber = 6;

            //Act
            customList.Add(firstNumber);
            customList.Add(secondNumber);
            customList.Add(thirstNumber);
            customListTwo.Add(forthNumber);
            customListTwo.Add(fifthNumber);
            customListTwo.Add(sixthNumber);

            customListThree.Add(firstNumber);
            customListThree.Add(secondNumber);
            customListThree.Add(thirstNumber);
            customListThree.Add(forthNumber);
            customListThree.Add(fifthNumber);
            customListThree.Add(sixthNumber);

            int result = customList.Zip(customListTwo);

            //Assert
            Assert.AreEqual(customList, customListThree);
        }
    }
}
