using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emulair.Common
{
    public class ImagesExtension
    {
        public List<byte[]> ConvertImages(List<IFormFile> images)
        {
            var imageBytesList = new List<byte[]>();

            foreach (var formFile in images)
            {
                if (formFile.Length > 0)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        formFile.CopyToAsync(memoryStream);
                        imageBytesList.Add(memoryStream.ToArray());
                    }
                }
            }
            return imageBytesList;
        }
    }
}
