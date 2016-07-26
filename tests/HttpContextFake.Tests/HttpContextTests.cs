using System;
using System.Web.Caching;
using NUnit.Framework;

namespace HttpContextFake.Tests
{
    [TestFixture]
    public class HttpContextTests
    {
        private HttpContext _sut;

        [SetUp]
        public void SetUp()
        {
            _sut = new HttpContext();
        }

        [Test]
        public void CanSetRequest()
        {
            _sut.FakeRequest = new HttpRequest();
            Assert.That(_sut.Request, Is.EqualTo(_sut.FakeRequest));
        }

        [Test]
        public void CanSetResponse()
        {
            _sut.FakeResponse = new HttpResponse();
            Assert.That(_sut.Response, Is.EqualTo(_sut.FakeResponse));
        }

        [Test]
        public void CanSetItems()
        {
            _sut.FakeItems.Add("hi", "Fakere");
            Assert.That(_sut.Items["hi"], Is.EqualTo("Fakere"));
        }

        [Test]
        public void CanSetError()
        {
            _sut.FakeError = new Exception("abc");
            Assert.That(_sut.Error, Is.EqualTo(_sut.FakeError));
        }

        [Test]
        public void Cache_Works()
        {
            _sut.FakeCache = new Cache();
            Assert.That(_sut.Cache, Is.EqualTo(_sut.FakeCache));
        }
    }
}
