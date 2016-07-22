using System.IO;

namespace HttpContextFake
{
    public static class ToStream
    {
        public static Stream FromText(string text)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(text);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
    }
}