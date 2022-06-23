using SocialNetwork.BLL.Models;
using SocialNetwork.DAL.Entity;
using SocialNetwork.DAL.Repositories;
using NUnit.Framework;
using SocialNetwork;
using System;
using SocialNetwork.BLL.Services;

namespace SocialNetwork.Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void TestForCreatingUser()
        {
            UserRepository testUser = new UserRepository();

            var TestUserData = new UserEntity()
            {
                firstname = "a",
                lastname = "a",
                email = "a@gmil.com",
                password = "00000000",
            };
            Assert.True(testUser.Create(TestUserData) != 0);

        }


    }
}
