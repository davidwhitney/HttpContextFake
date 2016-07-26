using System;
using NUnit.Framework;

namespace HttpContextFake.Tests
{
    [TestFixture]
    public class RequestTests
    {
        private HttpRequest _sut;

        [SetUp]
        public void SetUp()
        {
            _sut = new HttpRequest();
        }

        [Test]
        public void CanSetUrl()
        {
            _sut.FakeUrl = new Uri("http://www.google.com");
            Assert.That(_sut.Url, Is.EqualTo(_sut.FakeUrl));
        }

        [Test]
        public void CanSeFakeaders()
        {
            _sut.FakeHeaders.Add("header", "value");
            Assert.That(_sut.Headers["header"], Is.EqualTo("value"));
        }
    }
}