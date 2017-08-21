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
            customList.Add("Tim");

            //Act
            customList.Remove("Tim");
            customList.Remove("Tim");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Prevent_List_NoObject()
        {
            //Arrange
            CustomNewList<string> customList = new CustomNewList<string>();

            //Act
            customList.Remove(customList[0]);
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
            int result = customList[1];

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
            customList.Remove("Tim");
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
            string expectedResult = "Tim, Joe, Mark";

            //Act
            customList.Add(name);
            customList.Add(nametwo);
            customList.Add(namethree);

            //Assert
            Assert.AreEqual(expectedResult, customList);
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
            string result = customList.ToString();

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Check_ListWithNull_ReturnString()
        {
            //Arrange
            CustomNewList<string> customList = new CustomNewList<string>();
            string name = "Tim";
            string nameTwo = null;
            string nameThree = "Joe";
            string expectedResult = "TimJoe";

            //Act
            customList.Add(name);
            customList.Add(nameTwo);
            customList.Add(nameThree);
            string result = customList.ToString();

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Error_List_DataType()
        {
            //Arrange
            CustomNewList<bool> customList = new CustomNewList<bool>();
            customList.Add(false);
            customList.Add(true);
            bool expectedResult = false;

            //Act
            bool result = customList[0];

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Add_List_OverloadPlus()
        {
            //Arrange
            CustomNewList<string> customList = new CustomNewList<string>();
            CustomNewList<string> customListTwo = new CustomNewList<string>();
            CustomNewList<string> customListThree = new CustomNewList<string>();
            string name = "Tim";
            string nameTwo = "Joe";
            string nameThree = "Mark";
            string nameFour = "Peter";

            //Act
            customList.Add(name);
            customList.Add(nameTwo);
            customListTwo.Add(nameThree);
            customListTwo.Add(nameFour);

            customListThree.Add(name);
            customListThree.Add(nameTwo);
            customListThree.Add(nameThree);
            customListThree.Add(nameFour);

            customList = customList + customListTwo;

            //Assert
            Assert.AreEqual(customListThree, customList);
        }

        [TestMethod]
        public void Subtract_List_OverloadMinus()
        {
            //Arrange
            CustomNewList<int> customList = new CustomNewList<int>();
            CustomNewList<int> customListTwo = new CustomNewList<int>();
            CustomNewList<int> customListThree;
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

            customListThree = customListTwo - customList;

            int result = customListThree[0];

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Subtract_Two_ListOne()
        {
            //Arrange
            CustomNewList<string> name = new CustomNewList<string>();
            CustomNewList<string> names = new CustomNewList<string>();            
            string firstName = "Mark";
            string secondname = "Peter";
            string thirdName = "Tim";
            string fourthName = "Joe";
            string fifthName = "Mark";
            string expectedResult = "Peter";

            //Act
            name.Add(firstName);
            name.Add(secondname);
            names.Add(thirdName);
            names.Add(fourthName);
            names.Add(fifthName);

            CustomNewList<string> results = name - names;

            //Assert
            Assert.AreEqual(expectedResult, results[0]);
        }

        [TestMethod]
        public void Add_TwoList_DifferentData()
        {
            //Arrange
            CustomNewList<string> names = new CustomNewList<string>();
            CustomNewList<string> namesTwo = new CustomNewList<string>();
            CustomNewList<string> newNames = new CustomNewList<string>();
            string name = "Tim";
            string nametwo = "Joe";
            string namethree = "Peter";
            string expecetedResult = "Peter";

            //Act
            names.Add(name);
            names.Add(nametwo);
            namesTwo.Add(namethree);
            
            newNames = names + namesTwo;

            //Assert
            Assert.AreEqual(expecetedResult, newNames[2]);

        }

        [TestMethod]
        public void Zip_List_CombinedList()
        {
            //Arrange
            CustomNewList<int> customList = new CustomNewList<int>();
            CustomNewList<int> customListTwo = new CustomNewList<int>();
            CustomNewList<int> customListThree = new CustomNewList<int>();
            int firstNumber = 1;
            int secondNumber = 3;
            int thirstNumber = 5;
            int forthNumber = 2;
            int fifthNumber = 4;
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

            CustomNewList<int> result = customList.Zip(customListTwo);

            //Assert
            Assert.AreEqual(customList, customListThree);
        }

        [TestMethod]
        public void Zip_TwoList_Strings()
        {
            //Arrange
            CustomNewList<string> customList = new CustomNewList<string>();
            CustomNewList<string> customListTwo = new CustomNewList<string>();
            CustomNewList< string> customListThree = new CustomNewList<string>();
            string nameOne = "Tim";
            string nameTwo = "Joe";
            string wordyOne = " is cool ";
            string wordyTwo = " is not cool";

            //Act
            customList.Add(nameOne);
            customList.Add(nameTwo);
            customListTwo.Add(wordyOne);
            customListTwo.Add(wordyTwo);

            customListThree.Add(nameOne);
            customListThree.Add(nameTwo);
            customListThree.Add(wordyOne);
            customListThree.Add(wordyTwo);

            customList = customList.Zip(customListTwo);

            //Assert
            Assert.AreEqual(customList, customListThree);
        }

        [TestMethod]
        public void Check_TwoList_ZipTrue()
        {
            //Arrange
            CustomNewList<string> customList = new CustomNewList<string>();
            CustomNewList<string> customListTwo = new CustomNewList<string>();
            CustomNewList<string> customListThree = new CustomNewList<string>();
            string nameOne = "Tim";
            string nameTwo = "Joe";
            string nameThree = "Peter";
            string nameFour = "Mark";
            string expectedResult = "Peter";

            //Act
            customList.Add(nameOne);
            customList.Add(nameTwo);
            customListTwo.Add(nameThree);
            customListTwo.Add(nameFour);

            customListThree = customList.Zip(customListTwo);

            //Assert
            Assert.AreEqual(expectedResult, customListThree[1]);
        }
    }
}
