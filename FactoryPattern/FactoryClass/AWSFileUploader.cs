using FactoryPattern.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.FactoryClass
{
    public class AWSFileUploader : IFileUploader
    {
        public void UploadFile(string filePath)
        {
            // AWS S3 upload logic
            Console.WriteLine("File uploaded to AWS S3.");
        }
    }

}
