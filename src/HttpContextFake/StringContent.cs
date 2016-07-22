using System.IO;

namespace HttpContextFake
{
    public class StringContent : Body
    {
        private readonly string _content;

        public StringContent(string content)
        {
            _content = content;
            ContentType = "text/plain";
        }

        public override Stream GetContentStream()
        {
            return ToStream.FromText(_content);
        }
    }
}