using System.Collections;
using System;
using Xunit;
using Xunit.Abstractions;
using MyProject;
using System.Collections.Generic;

namespace MyProjectTest
{
    public class Example2
    {
        private readonly ITestOutputHelper _output;
        public Example2(ITestOutputHelper output)
        {
            _output = output ?? throw new ArgumentNullException(nameof(output));
        }

        [Theory(DisplayName = "User fields are filled")]
        [MemberData(nameof(UserList))]
        public void UserFieldsHasContent(User user)
        {
            Assert.NotEmpty(user.UserName);
            Assert.NotEmpty(user.Email);
            Assert.IsType<User>(user);
        }

        public static IEnumerable<object[]> UserList => new[]
        {
            new [] {new User { Id = 1, UserName = "admin", Email = "admin@example.com"}},
            new [] {new User { Id = 1, UserName = "admin", Email = "admin@example.com"}},
            new [] {new User { Id = 1, UserName = "admin", Email = "admin@example.com"}},
            new [] {new User { Id = 1, UserName = "admin", Email = "admin@example.com"}},
        };

        [Theory(DisplayName = "user fieldsare filled from class")]
        [ClassData(typeof(UserListData))]
        public void UserFieldHasContentClass(User user)
        {
            Assert.NotEmpty(user.UserName);
            Assert.NotEmpty(user.Email);
            Assert.IsType<User>(user);
        }

        private class UserListData : IEnumerable<object[]>
        {
            private readonly List<object[]> _data = new List<object[]>
            {
                new [] {new User { Id = 1, UserName = "admin", Email = "admin@example.com"}},
                new [] {new User { Id = 1, UserName = "admin", Email = "admin@example.com"}},
                new [] {new User { Id = 1, UserName = "admin", Email = "admin@example.com"}},
                new [] {new User { Id = 1, UserName = "admin", Email = "admin@example.com"}},
            };

            public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
    }
}