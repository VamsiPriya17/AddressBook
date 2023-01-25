using RegEx;
namespace UserRegTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidFirstName()
        {
            string expected = "Pri";
            string message = "Valid";
            UserRegistration ur = new UserRegistration();

            string actual = ur.TakeFirstName(expected);

            Assert.AreEqual(message, actual);
        }
        [TestMethod]
        public void InvalidFirstName()
        {
            string expected = "priya";
            string message = "Invalid";
            UserRegistration ur = new UserRegistration();

            string actual = ur.TakeFirstName(expected);

            Assert.AreEqual(message, actual);
        }
        [TestMethod]
        public void ValidLastName()
        {
            string expected = "Nulu";
            string message = "Valid";
            UserRegistration ur = new UserRegistration();

            string actual = ur.TakeLastName(expected);

            Assert.AreEqual(message, actual);
        }
        [TestMethod]
        public void InvalidLastName()
        {
            string expected = "nulu";
            string message = "Invalid";
            UserRegistration ur = new UserRegistration();

            string actual = ur.TakeLastName(expected);

            Assert.AreEqual(message, actual);
        }
        [TestMethod]
        public void ValidEmail()
        {
            string expected = "abc.xyz@bl.co.in";
            string message = "Valid";
            UserRegistration ur = new UserRegistration();

            string actual = ur.TakeEmail(expected);

            Assert.AreEqual(message, actual);
        }
        [TestMethod]
        public void ValidPassword()
        {
            string expected = "P@1324ad";
            string message = "Valid";
            UserRegistration ur = new UserRegistration();

            string actual = ur.TakePassword(expected);

            Assert.AreEqual(message, actual);
        }
        [TestMethod]
        public void InvalidPassword()
        {
            string expected = "P1324ad";
            string message = "Invalid";
            UserRegistration ur = new UserRegistration();

            string actual = ur.TakePassword(expected);

            Assert.AreEqual(message, actual);
        }
        [TestMethod]
        public void ValidPhone()
        {
            string expected = "91 0987654321";
            string message = "Valid";
            UserRegistration ur = new UserRegistration();

            string actual = ur.TakePhoneNumber(expected);

            Assert.AreEqual(message, actual);
        }
        [TestMethod]
        public void InvalidPhone()
        {
            string expected = "91 0987654";
            string message = "Invalid";
            UserRegistration ur = new UserRegistration();

            string actual = ur.TakePhoneNumber(expected);

            Assert.AreEqual(message, actual);
        }
    }
}