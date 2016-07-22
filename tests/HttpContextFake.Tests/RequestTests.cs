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
            _sut.TheUrl = new Uri("http://www.google.com");
            Assert.That(_sut.Url, Is.EqualTo(_sut.TheUrl));
        }

        [Test]
        public void CanSetHeaders()
        {
            _sut.TheHeaders.Add("header", "value");
            Assert.That(_sut.Headers["header"], Is.EqualTo("value"));
        }
    }
}