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
            string X, Y;

            // Loops throught all arguments (Desired images)
            // Përsërit gjat gjitë argumenteve (Fotove)
            foreach(string arg in args)
            {
                ASCII = ""; // Rikthen rezultatin në asgjë

                try
                {
                    if (File.Exists(arg)) // Shikon se a egziston fotoja (nga argumenti)
                    {
                        Console.Write("Enter number of vertical pixels (leave 0 for default): ");
                        X = Console.ReadLine();
                        Console.Write("Enter number of horizontal pixels (leave 0 for default): ");
                        Y = Console.ReadLine();
                        Console.Write("\n");

                        // File does exist.
                        // Fotoja egzistoj.

                        Bitmap ImageLocator = new Bitmap(arg);

                        if(Convert.ToInt16(X) == 0) X = Convert.ToString(ImageLocator.Size.Height);
                        if(Convert.ToInt16(Y) == 0) Y = Convert.ToString(ImageLocator.Size.Width);

                        ImageLocator = ImageManipulation.Resize(ImageLocator, Convert.ToInt16(X), Convert.ToInt16(Y)); // Change this if you need please !

                        // Ngjyra
                        Color PixelColor;



                        // Loop throught pixels (V-H)
                        // Përsërit gjitha pikselat (V-H)
                        for (int vertical = 0, horizontal = 0; vertical < ImageLocator.Height; vertical++)
                        {
                            for (horizontal = 0; horizontal < ImageLocator.Width; horizontal++)
                            {
                                // Gets pixel color
                                // Gjen ngjyrën e pikselit
                                PixelColor = ImageLocator.GetPixel(horizontal, vertical);

                                // Adds result in text
                                // Shton rezultatin në tekst
                                ASCII += ShapeCalculator.GetShape(PixelColor);
                            }
                            // Adds a newline, end of horiontal pixels of a vertical line
                            // Shton një vij të re, fundi i pikselave horizontal i një vije vertikale
                            ASCII += '\n';
                        }

                        // Saves the text
                        // Ruan tekstin
                        ImageManipulation.Save(ASCII, arg);

                    }
                }
                catch (Exception ex)
                {
                    // An unexcepted error occured
                    // Një dështim i papritur ndodhi
                }
            }
        }
    }
}
