using System;
using System.IO;
using System.Drawing;

using ImageASCII;

namespace ImageASCII
{
    
    class Convertor
    {


        static void  Main(string[] args)
        {
            string ASCII;

            foreach(string arg in args)
            {
                ASCII = "";

                try
                {
                    if (File.Exists(arg))
                    {



                        // File does exist.
                        Bitmap ImageLocator = new Bitmap(arg);
                        ImageLocator = ImageManipulation.Resize(ImageLocator, 32, 32);

                        Color PixelColor;



                        // Loop throught pixels (V-H)
                        for (int vertical = 0, horizontal = 0; vertical < ImageLocator.Height; vertical++)
                        {
                            for (horizontal = 0; horizontal < ImageLocator.Width; horizontal++)
                            {
                                PixelColor = ImageLocator.GetPixel(horizontal, vertical);
                                ASCII += ShapeCalculator.GetShape(PixelColor);

                            }
                            ASCII += '\n';
                        }

                        FileInfo FileDetails = new FileInfo(arg);

                        string new_arg = arg.Remove(arg.Length-FileDetails.Extension.Length, FileDetails.Extension.Length);

                        StreamWriter FileWriter = new StreamWriter(new_arg + ".txt");

                        FileWriter.Write(ASCII);
                        FileWriter.Close();

                    }
                }
                catch (Exception ex)
                {
                }
            }
        }
    }
}
