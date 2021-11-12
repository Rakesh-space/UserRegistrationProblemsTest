using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationProblemsTest;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFirstName()
        {
            //AAA Methodology

            //Arrange
            string message = "Rak";
            string expected = "valid";

            //Act
            TestingClass testing = new TestingClass(message);
            string actual = testing.validFirstName();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestLastName()
        {
            //AAA Methodology

            //Arrange
            string message = "Mus";
            string expected = "valid";

            //Act
            TestingClass testing = new TestingClass(message);
            string actual = testing.validFirstName();

            //Assert
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void TestGmail()
        {
            //AAA Methodology

            //Arrange
            string message = "abc.xyz@bl.co.in";
            string expected = "valid";

            //Act
            TestingClass testing = new TestingClass(message);
            string actual = testing.validFirstName();

            //Assert
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void TestMobileNo()
        {
            //AAA Methodology

            //Arrange
            string message = "91 8007078569";
            string expected = "valid";

            //Act
            TestingClass testing = new TestingClass(message);
            string actual = testing.validFirstName();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestPassword()
        {
            //AAA Methodology

            //Arrange
            string message = "rakeSH95@";
            string expected = "valid";

            //Act
            TestingClass testing = new TestingClass(message);
            string actual = testing.validFirstName();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestUpperCase()
        {
            //AAA Methodology

            //Arrange
            string message = "RakeSH95";
            string expected = "valid";

            //Act
            TestingClass testing = new TestingClass(message);
            string actual = testing.validFirstName();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestOneNumeric()
        {
            //AAA Methodology

            //Arrange
            string message = "R@95sM99";
            string expected = "valid";

            //Act
            TestingClass testing = new TestingClass(message);
            string actual = testing.validFirstName();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestSpecialCharcter()
        {
            //AAA Methodology

            //Arrange
            string message = "#r&K*9@oV5";
            string expected = "valid";

            //Act
            TestingClass testing = new TestingClass(message);
            string actual = testing.validFirstName();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestAllGmailFormat()
        {
            //AAA Methodology

            //Arrange
            string message = "rakeshM111@";
            string expected = "valid";

            //Act
            TestingClass testing = new TestingClass(message);
            string actual = testing.validFirstName();

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}