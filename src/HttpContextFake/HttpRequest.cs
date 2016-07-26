using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Web;

namespace HttpContextFake
{
    public class HttpRequest : HttpRequestBase
    {
        public Uri FakeUrl { get; set; }
        public override Uri Url => FakeUrl;

        public Dictionary<string, string> FakeHeaders { get; set; } = new Dictionary<string, string>();

        public override NameValueCollection Headers
        {
            get
            {
                var nvc = new NameValueCollection();
                foreach (var h in FakeHeaders)
                {
                    nvc.Add(h.Key, h.Value);
                }
                return nvc;
            }
        }
    }
}