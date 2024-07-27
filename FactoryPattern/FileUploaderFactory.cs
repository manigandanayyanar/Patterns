using FactoryPattern.FactoryClass;
using FactoryPattern.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class FileUploaderFactory
    {
        public IFileUploader CreateFileUploader(string provider)
        {
            switch (provider)
            {
                case "AWS":
                    return new AWSFileUploader();

                case "Azure":
                    return new AzureFileUploader();

                case "GCP":
                    return new GCPFileUploader();

                default:
                    throw new ArgumentException("Invalid provider specified.");
            }
        }
    }
}
