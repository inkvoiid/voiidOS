using System;
using System.Collections.Generic;
using System.Text;

namespace voiidOS.Utils
{
    class Text
    {

        public static string Shrink(string input)
        {
            return input.ToLower().Replace(" ", "");
        }

    }
}
