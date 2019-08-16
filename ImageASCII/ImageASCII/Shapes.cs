using System;

namespace ImageASCII
{

    internal class Shapes
    {

        //----------------------------------------------------------------------------------------------------
        // These are multiple character strings. 
        // The reason is because if it was for one char only, ASCII text would be screteched vertically.
        //----------------------------------------------------------------------------------------------------

        // Very basic (W&B) colors
        public const string Transparent = "..";
        public const string Black = "%%";
        public const string White = "''";

        // Basic colors
        public const string Red = "@@";
        public const string Blue = "##";
        public const string Green = "==";
        public const string Yellow = "++";

        public const string Default = White;
    }
}
