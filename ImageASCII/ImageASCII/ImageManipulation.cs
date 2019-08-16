using System;
using System.IO;
using System.Drawing;

namespace ImageASCII
{
    internal class ImageManipulation
    {
        // Resizes the image
        // Zmadhon/Zvoglon foton
        public static Bitmap Resize(Bitmap Image,Int16 SizeV,Int16 SizeH)
        {
            return (new Bitmap(Image, SizeV, SizeH));
        }
        
        // Saves the text
        // Ruan tekstin
        public static void Save(String Text,String File)
        {
            string arg = File;

            FileInfo FileDetails = new FileInfo(arg);

            string new_arg = arg.Remove(arg.Length - FileDetails.Extension.Length, FileDetails.Extension.Length);

            StreamWriter FileWriter = new StreamWriter(new_arg + ".txt");

            FileWriter.Write(Text);
            FileWriter.Close();
        }

    }
}
