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
            _sut.TheRequest = new HttpRequest();
            Assert.That(_sut.Request, Is.EqualTo(_sut.TheRequest));
        }

        [Test]
        public void CanSetResponse()
        {
            _sut.TheResponse = new HttpResponse();
            Assert.That(_sut.Response, Is.EqualTo(_sut.TheResponse));
        }

        [Test]
        public void CanSetItems()
        {
            _sut.TheItems.Add("hi", "there");
            Assert.That(_sut.Items["hi"], Is.EqualTo("there"));
        }

        [Test]
        public void CanSetError()
        {
            _sut.TheError = new Exception("abc");
            Assert.That(_sut.Error, Is.EqualTo(_sut.TheError));
        }

        [Test]
        public void Cache_Works()
        {
            _sut.TheCache = new Cache();
            Assert.That(_sut.Cache, Is.EqualTo(_sut.TheCache));
        }
    }
}
