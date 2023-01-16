using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemExplorer
{
    /// <summary>
    /// Converts objects that represent images
    /// </summary>
    public static class ImgConverter
    {
        /// <summary>
        /// Converts Image object to byte array
        /// </summary>
        /// <param name="img">Image to be converted</param>
        /// <returns>Image as byte array</returns>
        public static byte[] toByteArray(Image img)
        {
            //Null check
            if (img == null)
                return null;

            //Saving image to stream and returning stream as byte array
            using (var ms = new MemoryStream())
            {
                img.Save(ms, img.RawFormat);
                return ms.ToArray();
            }
        }

        /// <summary>
        /// Converts byte array to Image object
        /// </summary>
        /// <param name="img">Image to be converted</param>
        /// <returns>Image type object</returns>
        public static Image toImage(byte[] img)
        {
            //Null check
            if(img == null)
                return null;

            //Creatring stream with byte array and using Image class to return it as Image
            using (var ms = new MemoryStream(img))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
