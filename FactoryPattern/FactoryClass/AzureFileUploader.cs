using FactoryPattern.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.FactoryClass
{
    public class AzureFileUploader : IFileUploader
    {
        public void UploadFile(string filePath)
        {
            // Azure Blob Storage upload logic
            Console.WriteLine("File uploaded to Azure Blob Storage.");
        }
    }

}
