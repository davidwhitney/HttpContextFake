using System.IO;
using System.Text;

namespace HttpContextFake
{
    public abstract class Body
    {
        public string ContentType { get; set; }
        public Encoding ContentEncoding { get; set; }
        public abstract Stream GetContentStream();
    }
}