﻿using System.IO;
namespace Sample_App.client
{
    public class FileInterface
    {
        public FileInterface()
        {
        }

        public Stream OpenLocalFile(string filename)
        {
            return File.Open("../../../resources/" + filename, FileMode.Open);
        }
    }
}
