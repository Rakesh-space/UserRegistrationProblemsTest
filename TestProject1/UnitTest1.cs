using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationProblemsTest;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
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
    }
}
