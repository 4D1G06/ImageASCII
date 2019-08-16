using System;
using System.Drawing;

using ImageASCII;

namespace ImageASCII
{
    internal class ShapeCalculator // Njësuesi i formave/ngjyrave
    {

        public static string GetShape(Color Color)
        {
            // E tejdukshme
            // Transparent            
            if (Color.A < 100) return Shapes.Transparent;
            
            // E verdhë
            // Yellow      
            if (Color.R > Color.B && Color.G > Color.B && Color.R - Color.G < 100) return Shapes.Yellow;
            
            // E zezë
            // Black  
            if (Color.R == Color.G && Color.G > Color.B || Color.R == 0 && Color.G == 0 && Color.B == 0) return Shapes.Black;

            // E bardhë
            // White
            if (Color.R - Color.G <= 10 || Color.G - Color.B <= 10 && Color.G - Color.B <= 10 || Color.B - Color.G <= 10) return Shapes.White;

            // E kuqe
            // Red
            if (Color.R > Color.G && Color.R > Color.B) return Shapes.Red;

            // E gjelbërt
            // Green
            if (Color.G > Color.R && Color.G > Color.B) return Shapes.Green;

            // E kaltër
            // Blue
            if (Color.B > Color.R && Color.B > Color.G) return Shapes.Blue;

            return Shapes.Default;
        }
    }
}
