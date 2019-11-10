namespace POC.Delivery.Api.Helpers
{
    using System.IO;

    public class FileReaderHelper
    {
        public static string ReadFile(string fileSource)
        {
            return File.ReadAllText(Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), fileSource));
        }
    }
}
