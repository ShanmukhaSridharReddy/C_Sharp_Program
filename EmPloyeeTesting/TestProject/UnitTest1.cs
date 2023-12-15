using EmPloyeeTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetNameTest()
        {
            Employee obj = new Employee();
            string firstName = "shanmuk"; 
            string lastName = "reddy";
            string expected = "shanmukreddy";
            string actual;
            actual = obj.GetName(firstName,lastName);
            Assert.AreEqual(expected, actual);
        }
    }
}
