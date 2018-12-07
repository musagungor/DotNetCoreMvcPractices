using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace DotNetCoreMvcPractices.Helpers
{

    public interface IFormFileDownloader
    {
        void DonloadFormFile(IFormFile formFile,string filePath);
    }

    public class FormFileDownloader:IFormFileDownloader
    {
       
      
        public void DonloadFormFile(IFormFile formFile,string filePath)
        {
            var imageName = formFile.FileName;           
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            var imageUri = Path.Combine(filePath, imageName);

            using (var stream = new FileStream(imageUri, FileMode.Create))
            {
                formFile.CopyTo(stream);
            }
        }

    }
}