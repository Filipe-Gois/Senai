using System.Text.RegularExpressions;

namespace Exe2.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("f@f.com")]
        [InlineData("f@.com")]
        [InlineData("@f.com")]
        [InlineData("f@f")]
        [InlineData("")]
        [InlineData("f")]
        public void Test1(string email)
        {
            bool emailENullOuVazio = string.IsNullOrWhiteSpace(email);

            bool temArrobaECom = email.Contains('@') && email.Contains(".com");

            Regex regex = new(@"^[^@\s]+@[^@\s]+\.[a-zA-Z]{2,}$");


            bool estaFormatado = regex.IsMatch(email);




            Assert.True(estaFormatado);

        }


    }
}