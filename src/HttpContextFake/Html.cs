using System.IO;

namespace HttpContextFake
{
    public class Html : Body
    {
        private readonly string _html;

        public Html(string html)
        {
            _html = html;
            ContentType = "text/html";
        }

        public override Stream GetContentStream()
        {
            return ToStream.FromText(_html);
        }
    }
}