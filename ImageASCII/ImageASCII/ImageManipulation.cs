using System;
using System.Drawing;

namespace ImageASCII
{
    internal class ImageManipulation
    {
        public static Bitmap Resize(Bitmap Image,Int16 SizeV,Int16 SizeH)
        {
            return (new Bitmap(Image, SizeV, SizeH));
        }
        
        public static void Save(String Text,String Location)
        {

        }

    }
}
