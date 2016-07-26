using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Principal;
using System.Web;
using System.Web.Caching;

namespace HttpContextFake
{
    public class HttpContext : HttpContextBase
    {
        public HttpRequest FakeRequest { get; set; } = new HttpRequest();
        public override HttpRequestBase Request => FakeRequest;

        public HttpResponse FakeResponse { get; set; } = new HttpResponse();
        public override HttpResponseBase Response => FakeResponse;

        public Exception FakeError { get; set; }
        public override Exception Error => FakeError;

        public Dictionary<string, string> FakeItems { get; set; } = new Dictionary<string,string>();
        public override IDictionary Items => FakeItems;

        public Cache FakeCache { get; set; } = new Cache();
        public override Cache Cache => FakeCache;

        public HttpServerUtility FakeServer { get; set; } = new HttpServerUtility();
        public override HttpServerUtilityBase Server => FakeServer;

        public HttpSessionState FakeSession { get; set; } = new HttpSessionState();
        public override HttpSessionStateBase Session => FakeSession;
        
        public override IPrincipal User { get; set; }
    }
}
