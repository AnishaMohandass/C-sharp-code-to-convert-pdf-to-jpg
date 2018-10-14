using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupDocs.Conversion.Config;
using GroupDocs.Conversion.Handler;
using GroupDocs.Conversion.Converter.Option;
using System.IO;

namespace pdftoimage
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "sample.pdf";
            ConvertPdfToImage(fileName, ImageSaveOptions.ImageFileType.Jpg);
        }

        public static void ConvertPdfToImage(string fileName, ImageSaveOptions.ImageFileType outputFileType)
        {
            string sourcePath = @"C:\Users\Admin\source\repos\pdftoimage\Data\SampleFiles\";
            string targetPath = @"C:\Users\Admin\source\repos\pdftoimage\Data\ConvertedFiles\";

            var conversionConfig = new ConversionConfig { StoragePath = sourcePath, OutputPath = targetPath };

            var conversionHandler = new ConversionHandler(conversionConfig);

            var saveOptions = new ImageSaveOptions { ConvertFileType = outputFileType };

            var convertedDocumentPath = conversionHandler.Convert(sourcePath + fileName, saveOptions);

            for (int pageNum = 1; pageNum <= convertedDocumentPath.PageCount; pageNum++)
            {
                convertedDocumentPath.Save("Output-" + Path.GetFileNameWithoutExtension(fileName) + pageNum.ToString() + "." + outputFileType, pageNum);
            }
        }

    }
}
