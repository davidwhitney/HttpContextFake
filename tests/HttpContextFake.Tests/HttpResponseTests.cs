using NUnit.Framework;

namespace HttpContextFake.Tests
{
    [TestFixture]
    public class HttpResponseTests
    {
        private HttpResponse _sut;

        [SetUp]
        public void SetUp()
        {
            _sut = new HttpResponse();
        }
        
        [Test]
        public void CanSetContent()
        {
            _sut.Body = new StringContent("Hi");

            Assert.That(_sut.OutputStream.ToStringContents(), Is.EqualTo("Hi"));
            Assert.That(_sut.ContentType, Is.EqualTo("text/plain"));
        }
    }
}