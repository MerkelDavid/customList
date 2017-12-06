using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using customList;

namespace MyListTests
{

    [TestClass]
    public class MyListTests
    {
        //Get MyList Tests
        [TestMethod]

        public void GetMyList_IntegerN_IntegerN()
        {
            //arrange
            MyList<int> myListInstance = new MyList<int>();
            int n = 1;
            //act
            myListInstance[0]=1;
            //assert
            Assert.AreEqual(myListInstance[0], n);
       }

        [TestMethod]

        public void GetMyList_StringN_StringN()
        {
            //arrange
            MyList<string> myListInstance = new MyList<string>();
            string n = "hello";
            //act
            myListInstance[0]= "hello";
            //assert
            Assert.AreEqual(myListInstance[0], n);
        }
        [TestMethod]

        public void GetMyList_ObjectN_ObjectN()
        {
            //arrange
            MyList<TestClass> myListInstance = new MyList<TestClass>();
            TestClass n = new TestClass(40,"David Merkel");
            //act
            myListInstance[0]=n;
            //assert
            Assert.AreEqual(myListInstance[0], n);
        }

        [TestMethod]
        //assert
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void GetMyList_IndexOutsideOfCompacity_OutOfRangeException()
        {
            //arrange
            MyList<int> myListInstance = new MyList<int>();
            int n = 10000000;
            //act
            int test = myListInstance[n];
        }

        [TestMethod]
        //assert
        [ExpectedException(typeof(IndexOutOfRangeException))]

        public void GetMyList_NegitiveIndex_OutOfRangeException()
        {
            //arrange
            MyList<int> myListInstance = new MyList<int>();
            int n = -1;
            //act
            int test =  myListInstance[n];
        }

        //Set MyList Tests
        [TestMethod]

        public void SetMyList_IntegerN_IntegerN()
        {
            //arrange
            MyList<int> myListInstance = new MyList<int>();
            int n = 1;
            //act
            myListInstance[0] = n;
            //assert
            Assert.AreEqual(myListInstance[0], n);
        }

        [TestMethod]

        public void SetMyList_StringN_StringN()
        {
            //arrange
            MyList<string> myListInstance = new MyList<string>();
            string n = "hello";
            //act
            myListInstance[0] = n;
            //assert
            Assert.AreEqual(myListInstance[0], n);
        }
        [TestMethod]

        public void SetMyList_ObjectN_ObjectN()
        {
            //arrange
            MyList<TestClass> myListInstance = new MyList<TestClass>();
            TestClass n = new TestClass(40, "David Merkel");
            //act
            myListInstance[0] = n;
            //assert
            Assert.AreEqual(myListInstance[0], n);
        }

        [TestMethod]
        //assert
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void SetMyList_IndexOutsideOfCompacity_OutOfRangeException()
        {
            //arrange
            MyList<int> myListInstance = new MyList<int>();
            int n = 10000000;
            //act
            myListInstance[n] = 50;
        }

        [TestMethod]
        //assert
        [ExpectedException(typeof(IndexOutOfRangeException))]

        public void SetMyList_NegitiveIndex_OutOfRangeException()
        {
            //arrange
            MyList<int> myListInstance = new MyList<int>();
            int n = -1;
            //act
            myListInstance[n] = 50;
        }

        //Add MyList Tests
        [TestMethod]

        public void Add_AddAnIntegerToAnEmptyList_IntegerIsAtTheEndOfTheList()
        {
            //arrange
            MyList<int> myListInstance = new MyList<int>();
            //act
            myListInstance.Add(5);
            Assert.AreEqual(myListInstance[(myListInstance.Count-1)], 5);
        }

        [TestMethod]

        public void Add_AddAnObjectToAnEmptyList_ObjectIsAtTheEndOfTheList()
        {
            //arrange
            MyList<TestClass> myListInstance = new MyList<TestClass>();
            TestClass testInstance = new TestClass(45, "david");
            //act
            myListInstance.Add(testInstance);
            Assert.AreEqual(myListInstance[(myListInstance.Count-1)], testInstance);
        }

        [TestMethod]

        public void Add_UsingMultipleAdds_FinalAddedInteger()
        {
            //arrange
            MyList<int> myListInstance = new MyList<int>();
            //act
            myListInstance.Add(1);
            myListInstance.Add(2);
            myListInstance.Add(3);
            myListInstance.Add(4);
            myListInstance.Add(4);
            myListInstance.Add(7);
            myListInstance.Add(32);
            Assert.AreEqual(myListInstance[(myListInstance.Count -1)], 32);

            myListInstance.Add(51345);
            myListInstance.Add(512);
            myListInstance.Add(5234);
            myListInstance.Add(5987);
            myListInstance.Add(50);
            myListInstance.Add(10);
            //assert
            Assert.AreEqual(myListInstance[(myListInstance.Count -1)], 10);
        }

        //Remove MyList Tests
        [TestMethod]

        public void Remove_IntN_True()
        {
            //arrange
            MyList<int> myListInstance = new MyList<int>();
            myListInstance.Add(1);
            myListInstance.Add(2);
            myListInstance.Add(3);
            myListInstance.Add(4);
            myListInstance.Add(4);
            myListInstance.Add(7);
            myListInstance.Add(32);
            //assert
            Assert.AreEqual(myListInstance.Remove(4),true);

        }

        [TestMethod]

        public void Remove_IntN_False()
        {
            //arrange
            MyList<int> myListInstance = new MyList<int>();
            myListInstance.Add(1);
            myListInstance.Add(2);
            myListInstance.Add(3);
            myListInstance.Add(4);
            myListInstance.Add(4);
            myListInstance.Add(7);
            myListInstance.Add(32);
            //assert
            Assert.AreEqual(myListInstance.Remove(6), false);
        }

        [TestMethod]

        public void Remove_ObjectN_True()
        {
            //arrange
            MyList<TestClass> myListInstance = new MyList<TestClass>();
            TestClass TonyStark = new TestClass(54, "Tony Stark");
            myListInstance.Add(new TestClass(33,"Dude Guy"));
            myListInstance.Add(new TestClass(33, "Dude Guy"));
            myListInstance.Add(new TestClass(33, "Dude Guy"));
            myListInstance.Add(new TestClass(33, "Dude Guy"));
            myListInstance.Add(new TestClass(54, "Tony Stark"));
            myListInstance.Add(new TestClass(33, "Dude Guy"));
            myListInstance.Add(new TestClass(33, "Dude Guy"));
            //assert
            Assert.AreEqual(TonyStark, TonyStark);
        }

        [TestMethod]
        //assert
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Get_A_Value_Out_Of_Range_Because_Of_Remove_Return_Exception()
        {
            //arrange
            MyList<int> myListInstance = new MyList<int>();
            myListInstance.Add(1);
            myListInstance.Add(2);
            myListInstance.Add(3);
            myListInstance.Add(4);
            myListInstance.Add(4);
            myListInstance.Add(7);
            myListInstance.Add(32);
            //act
            myListInstance.Remove(4);
            int outOfRangeNumber = myListInstance[7];
            
        }

        [TestMethod]
        public void Testing_For_Index_Change_After_Removal_Index()
        {
            //arrange
            MyList<int> myListInstance = new MyList<int>();
            myListInstance.Add(1);
            myListInstance.Add(2);
            myListInstance.Add(3);
            myListInstance.Add(4);
            myListInstance.Add(4);
            myListInstance.Add(7);
            myListInstance.Add(32);
            myListInstance.Add(43);

            int valueBeforeRemoval = myListInstance[6];
            //act
            myListInstance.Remove(4);
            //assert
            int valueAfterRemoval = myListInstance[6];
            Assert.AreNotEqual(valueBeforeRemoval, valueAfterRemoval);

        }

        [TestMethod]
        public void Testing_For_No_Index_Change_After_Before_Index()
        {
            //arrange
            MyList<int> myListInstance = new MyList<int>();
            myListInstance.Add(1);
            myListInstance.Add(2);
            myListInstance.Add(3);
            myListInstance.Add(4);
            myListInstance.Add(4);
            myListInstance.Add(7);
            myListInstance.Add(32);
            myListInstance.Add(43);

            int valueBeforeRemoval = myListInstance[1];
            //act
            myListInstance.Remove(4);
            int valueAfterRemoval = myListInstance[1];
            //assert
            Assert.AreEqual(valueBeforeRemoval, valueAfterRemoval);

       }

        [TestMethod]
        public void Testing_For_Changed_Index_Upon_Successful_removal()
        {
            //arrange
            MyList<int> myListInstance = new MyList<int>();
            myListInstance.Add(1);
            myListInstance.Add(2);
            myListInstance.Add(3);
            myListInstance.Add(4);
            myListInstance.Add(4);
            myListInstance.Add(7);
            myListInstance.Add(32);
            myListInstance.Add(43);

            int countBeforeRemoval = myListInstance.Count;
            //act
            myListInstance.Remove(4);
            int countAfterRemoval = myListInstance.Count;
            //assert
            Assert.AreNotEqual(countBeforeRemoval, countAfterRemoval);

        }

        [TestMethod]
        public void Testing_For_Changed_Index_Upon_Unsuccessful_removal()
        {
            //arrange
            MyList<int> myListInstance = new MyList<int>();
            myListInstance.Add(1);
            myListInstance.Add(2);
            myListInstance.Add(3);
            myListInstance.Add(4);
            myListInstance.Add(4);
            myListInstance.Add(7);
            myListInstance.Add(32);
            myListInstance.Add(43);

            int countBeforeRemoval = myListInstance.Count;
            //act
            myListInstance.Remove(100);
            int countAfterRemoval = myListInstance.Count;
            //assert
            Assert.AreEqual(countBeforeRemoval, countAfterRemoval);

        }

        //enumerable Test
        [TestMethod]

        public void Enumeration_ListOfIntegers_True()
        {
            MyList<int> myListInstance = new MyList<int>();
            myListInstance.Add(1);
            myListInstance.Add(2);
            myListInstance.Add(3);
            myListInstance.Add(4);
            myListInstance.Add(4);
            myListInstance.Add(7);
            myListInstance.Add(32);
            myListInstance.Add(43);

            MyList<int> testList = new MyList<int>();

            foreach(int index in myListInstance)
            {
                testList.Add(index);
            }

            Assert.AreEqual(myListInstance[1], testList[1]);
            Assert.AreEqual(myListInstance[2], testList[2]);
        }

        [TestMethod]
        public void Enumeration_ListOfObject_True()
        {
            //arrange
            MyList<TestClass> myListInstance = new MyList<TestClass>();
            TestClass TonyStark = new TestClass(54, "Tony Stark");
            myListInstance.Add(new TestClass(33, "Dude Guy"));
            myListInstance.Add(new TestClass(33, "Dude Guy"));
            myListInstance.Add(new TestClass(33, "Dude Guy"));
            myListInstance.Add(new TestClass(33, "Dude Guy"));
            myListInstance.Add(new TestClass(54, "Tony Stark"));
            myListInstance.Add(new TestClass(33, "Dude Guy"));
            myListInstance.Add(new TestClass(33, "Dude Guy"));

            MyList<TestClass> testList = new MyList<TestClass>();

            foreach (TestClass index in myListInstance)
            {
                testList.Add(index);
            }

            Assert.AreEqual(myListInstance, testList);
        }



    }
}
