using System.Collections.Generic;
using System.Collections.Specialized;
using System.Web;

namespace HttpContextFake
{
    public class HttpSessionState : HttpSessionStateBase
    {
        public Dictionary<string, object> Storage = new Dictionary<string, object>();
    }
}