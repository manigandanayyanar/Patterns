using FactoryPattern.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.FactoryClass
{
    public class GCPFileUploader : IFileUploader
    {
        public void UploadFile(string filePath)
        {
            // Google Cloud Storage upload logic
            Console.WriteLine("File uploaded to Google Cloud Storage.");
        }
    }

}
