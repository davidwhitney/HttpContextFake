using System.IO;
using System.Text;

namespace HttpContextFake.Tests
{
    public static class StreamExtensions
    {
        public static string ToStringContents(this Stream stream)
        {
            stream.Position = 0;
            using (var reader = new StreamReader(stream, Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }

        public static Stream ToStream(this string src)
        {
            byte[] byteArray = Encoding.UTF8.GetBytes(src);
            return new MemoryStream(byteArray);
        }
    }
}