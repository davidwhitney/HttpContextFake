using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Web;

namespace HttpContextFake
{
    public class HttpRequest : HttpRequestBase
    {
        public Uri TheUrl { get; set; }
        public override Uri Url => TheUrl;

        public Dictionary<string, string> TheHeaders { get; set; } = new Dictionary<string, string>();

        public override NameValueCollection Headers
        {
            get
            {
                var nvc = new NameValueCollection();
                foreach (var h in TheHeaders)
                {
                    nvc.Add(h.Key, h.Value);
                }
                return nvc;
            }
        }
    }
}