using System;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace NUnit_Homework
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //Testing Replace

        [Test]
        public void TestReplace1()
        {
            // arrange
            string str = "Hello, I am String!";
            string expected = "Hi, I am String!";
            // act
            string actual = str.Replace("Hello", "Hi");
            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestReplace2()
        {
            // arrange
            string str = "Hello, I am String!";
            string expected = "Herro, I am String!";
            // act
            string actual = str.Replace('l', 'r');
            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestReplace3()
        {
            // arrange
            string str = "Hello, I am String!";
            // act
            string actual = str.Replace('f', 'r');
            // assert
            Assert.AreSame(str,str);
        }

        [Test]
        public void TestReplace4()
        {
            // arrange
            string str = "";
            // act
            string actual = str.Replace('f', 'r');
            // assert
            Assert.AreSame(str, str);
        }

        [Test]
        public void TestReplace5()
        {
            // arrange
            string str = "Hello, I am String!";
            // act
            ActualValueDelegate<object> actual = () => str.Replace(null, "Hi");
            // assert
            Assert.That(actual, Throws.TypeOf<ArgumentNullException>());
        }

        //Testing Split

        [Test]
        public void TestSplit1()
        {
            // arrange
            string str = "Hello, I am String!";
            string[] expected = {"Hello", " I am String!"};
            // act
            string[] actual = str.Split(',');
            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestSplit2()
        {
            // arrange
            string str = "Hello, I am String!";
            string[] expected = { "He", "", "o, I am String!" };
            // act
            string[] actual = str.Split('l', 3);
            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestSplit3()
        {
            // arrange
            string str = "Hello, I am String!";
            // act
            string[] actual = str.Split('f');
            // assert
            Assert.AreNotSame(str, actual);
        }

        [Test]
        public void TestSplit4()
        {
            // arrange
            string str = "Hello, I am String!";
            // act
            string[] actual = str.Split('f');
            // assert
            Assert.AreSame(str, actual[0]);
        }

        [Test]
        public void TestSplit5()
        {
            // arrange
            string str = "Hello, I am String!";
            // act
            string[] actual = str.Split(',', 0);
            // assert
            Assert.IsEmpty(actual);
        }

        [Test]
        public void TestSplit6()
        {
            // arrange
            string str = "Hello, I am String!";
            // act
            ActualValueDelegate<object> actual = () => str.Split(',', -1);
            // assert
            Assert.That(actual, Throws.TypeOf<ArgumentOutOfRangeException>());
        }


        //Testing Substring

        [Test]
        public void TestSubstring1()
        {
            // arrange
            string str = "Hello, I am String!";
            string expected = "Hello";
            // act
            string actual = str.Substring(0,5);
            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestSubstring2()
        {
            // arrange
            string str = "Hello, I am String!";
            int expected = 6;
            // act
            int actual = str.Substring(2, 6).Length;
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Hello, I am String!", -1, 2)]
        [TestCase("Hello, I am String!", 20, 1)]
        [TestCase("Hello, I am String!", 1, -1)]
        [TestCase("Hello, I am String!", 19, 2)]
        public void TestSubstring3(string str, int startIndex, int length)
        {
            // act
            ActualValueDelegate<object> actual = () => str.Substring(startIndex, length);
            // assert
            Assert.That(actual, Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void TestSubstring4()
        {
            // arrange
            string str = "Hello, I am String!";
            string expected = String.Empty;
            // act
            string actual = str.Substring(2, 0);
            // assert
            Assert.AreSame(expected, actual);
        }

        [Test]
        public void TestSubstring5()
        {
            // arrange
            string str = "Hello, I am String!";
            // act
            string actual = str.Substring(0, 19);
            // assert
            Assert.AreSame(str, actual);
        }
    }
}