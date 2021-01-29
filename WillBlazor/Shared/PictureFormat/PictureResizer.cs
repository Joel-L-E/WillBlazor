using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillBlazor.Shared.PictureFormat
{
    public class PictureResizer
    {
        // return a string to use as the css inline style element
        public static string GetStyledSize(int length, int width)
        {
            if (length == width)
            {
                // scale down both sides to be the same rem each time
                return "";
            }
            if(length > width)
            {
                // Landscape photos
                // figure out the difference in ratio
                // Size it to the correct length in rem
                // Factor the height by the same ratio into rem

                return "";
            }
            else
            {
                // this means this is a portrait photo
                // scale the height to be within range
                // factor the width by the same ratio
                // return css string
                return "";
            }

        }

    }
}
