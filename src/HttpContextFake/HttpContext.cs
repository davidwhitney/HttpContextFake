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
        public HttpRequest TheRequest { get; set; } = new HttpRequest();
        public override HttpRequestBase Request => TheRequest;

        public HttpResponse TheResponse { get; set; } = new HttpResponse();
        public override HttpResponseBase Response => TheResponse;

        public Exception TheError { get; set; }
        public override Exception Error => TheError;

        public Dictionary<string, string> TheItems { get; set; } = new Dictionary<string,string>();
        public override IDictionary Items => TheItems;

        public Cache TheCache { get; set; } = new Cache();
        public override Cache Cache => TheCache;

        public HttpServerUtility TheServer { get; set; } = new HttpServerUtility();
        public override HttpServerUtilityBase Server => TheServer;

        public HttpSessionState TheSession { get; set; } = new HttpSessionState();
        public override HttpSessionStateBase Session => TheSession;
        
        public override IPrincipal User { get; set; }
    }
}
