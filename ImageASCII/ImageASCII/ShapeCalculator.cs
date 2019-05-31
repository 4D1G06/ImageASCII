using System;
using System.Drawing;

using ImageASCII;

namespace ImageASCII
{
    internal class ShapeCalculator
    {

        public static string GetShape(Color Color)
        {
            // Red scales
            if(Color.R > Color.G && Color.R > Color.B)
            {
                return Shapes.Red;
            }

            // Green scales
            if (Color.G > Color.R && Color.G > Color.B)
            {
                return Shapes.Green;
            }

            // Blue scales
            if (Color.B > Color.R && Color.B > Color.G)
            {
                return Shapes.Blue;
            }

            if(Color.R == 0 && Color.G == 0 && Color.B == 0)
            {
                return Shapes.Black;
            }
            else
            {
                return Shapes.White;
            }

            // White & Background
            if (Color.R >= 182 && Color.G >= 182 && Color.B >= 182 || Color == Color.Transparent)
            {
                return Shapes.White;
            }

            return Shapes.Black;
        }




    }
}
