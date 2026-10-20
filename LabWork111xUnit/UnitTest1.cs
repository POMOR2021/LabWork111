using LabWork111;

namespace LabWork111xUnit
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Abbcdef12")]
        [InlineData("ValidPass1")]
        [InlineData("1234567aA")]
        public void Validate_ReturnTrue(string password)
        {
            bool result = ValidationPassword.ValidPassword(password);
            Assert.True(result);
        }

        [Theory]
        [InlineData("short1A")]
        [InlineData("abcdefg")]
        [InlineData("12345678")]
        [InlineData("")]
        [InlineData(null)]
        public void Validate_ReturnFalse(string password)
        {
            bool result = ValidationPassword.ValidPassword(password);
            Assert.False(result);
        }
    }
}
