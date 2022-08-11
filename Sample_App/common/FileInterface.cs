using System.IO;
namespace Sample_App.client
{
    public class FileInterface
    {
        private FileInterface()
        {
        }

        public static Stream OpenLocalFile(string filename)
        {
            return File.Open("../../../resources/" + filename, FileMode.Open);
        }
    }
}
