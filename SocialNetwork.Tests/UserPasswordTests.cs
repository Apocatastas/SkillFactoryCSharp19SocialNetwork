using SocialNetwork.DAL.Entities;

namespace SocialNetwork.Tests
{
    [TestFixture]
    public class UserPasswordTests
    {
        [Test]
        public void PasswordLengthIsMoreThan8Symbols()
        {
            var user = new UserEntity()
            {
                firstname = "Yegor",
                lastname = "Letov",
                email = "ooo@moya-oboro.na",
                password = "vintovka"
            };

            Assert.That(user.password.Length >= 8);
        }
    }
}