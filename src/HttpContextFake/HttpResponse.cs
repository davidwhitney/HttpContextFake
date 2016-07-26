using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Text;
using System.Web;

namespace HttpContextFake
{
    public class HttpResponse : HttpResponseBase
    {
        public Body Body { get; set; } = new StringContent("");
        
        public override string ContentType => Body.ContentType;
        public override Encoding ContentEncoding => Body.ContentEncoding;
        public override Stream OutputStream => Body.GetContentStream();

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