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
    }
}
